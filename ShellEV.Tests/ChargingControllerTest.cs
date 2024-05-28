// <copyright file="ChargingControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellEV.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using ShellEV.Standard;
    using ShellEV.Standard.Controllers;
    using ShellEV.Standard.Exceptions;
    using ShellEV.Standard.Http.Client;
    using ShellEV.Standard.Http.Response;
    using ShellEV.Standard.Models.Containers;
    using ShellEV.Standard.Utilities;

    /// <summary>
    /// ChargingControllerTest.
    /// </summary>
    [TestFixture]
    public class ChargingControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ChargingController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ChargingController;
        }

        /// <summary>
        /// This API initiates to start a session on a EVSE (Electric Vehicle Supply Equipement). When the EV Charge Card number and the unique EVSE ID on the location is provided, the session is initiated. 
        ///
        ///Please note that this is an asynchronous request, the request will be passed on to the operator/platform to be processed further. 
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestStartChargeSession()
        {
            // Parameters for the API call
            Guid requestId = Guid.Parse("eb621f45-a543-4d9a-a934-2f223b263c42");
            Standard.Models.ChargesessionStartBody body = null;

            // Perform API call
            Standard.Models.InlineResponse202 result = null;
            try
            {
                result = await this.controller.StartChargeSessionAsync(requestId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"RequestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"Status\":\"SUCCESS\",\"Data\":[{\"SessionId\":\"c3e332f0-1bb2-4f50-a96b-e075bbb71e68\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This API retrieves the list of active sessions for a given set of EMAIds.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestActive()
        {
            // Parameters for the API call
            string emaId = "NL-TNM-C0216599X-A";
            Guid requestId = Guid.Parse("eb621f45-a543-4d9a-a934-2f223b263c42");

            // Perform API call
            Standard.Models.ActiveResponse200Json result = null;
            try
            {
                result = await this.controller.ActiveAsync(emaId, requestId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"RequestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"Status\":\"SUCCESS\",\"Data\":[{\"EmaId\":\"NL-TNM-C0216599X-A\",\"EvseId\":\"NL*TNM*EVIRTUALCP0002*0\",\"Id\":\"260f17a9-52d4-4b40-ae74-83832b538975\",\"StartedAt\":\"2022-10-21T09:11:23.455Z\",\"SessionState\":\"started\",\"SessionCode\":null,\"SessionMessage\":null,\"UserId\":\"96f69b3b-8ad4-487a-baaa-f1d3db741e88\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}