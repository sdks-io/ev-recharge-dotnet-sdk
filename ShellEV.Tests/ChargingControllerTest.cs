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
        /// This endpoint start the charging session for the user..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestStart()
        {
            // Parameters for the API call
            Guid requestId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000");
            Standard.Models.ChargesessionStartBody body = null;

            // Perform API call
            Standard.Models.InlineResponse202 result = null;
            try
            {
                result = await this.controller.StartAsync(requestId, body);
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
                    "{\"requestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"status\":\"SUCCESS\",\"data\":[{\"sessionId\":\"c3e332f0-1bb2-4f50-a96b-e075bbb71e68\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Accepts a request to stop an active session when a valid session id is provided..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestStop()
        {
            // Parameters for the API call
            Guid requestId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000");
            string sessionId = "c3e332f0-1bb2-4f50-a96b-e075bbb71e68";

            // Perform API call
            Standard.Models.InlineResponse2021 result = null;
            try
            {
                result = await this.controller.StopAsync(requestId, sessionId);
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
                    "{\"requestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"status\":\"SUCCESS\"}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This endpoint returns the details of the session if the session is found..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetChargeSessionRetrieve()
        {
            // Parameters for the API call
            Guid requestId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000");
            string sessionId = "c3e332f0-1bb2-4f50-a96b-e075bbb71e68";

            // Perform API call
            Standard.Models.GetChargeSessionRetrieveResponse200Json result = null;
            try
            {
                result = await this.controller.GetChargeSessionRetrieveAsync(requestId, sessionId);
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
                    "{\"requestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"status\":\"SUCCESS\",\"data\":[{\"id\":\"78b5d7a3-bdba-43d7-9851-1c84fcddb782\",\"userId\":\"281482b6-2c9a-4fd1-b3ea-1928edb40ef9\",\"emaId\":\"NL-TNM-C00122045-K\",\"evseId\":\"NL*TNM*E02003451*0\",\"lastUpdated\":\"2024-06-19T07:36:57.985998Z\",\"startedAt\":\"2024-06-19T11:20:27Z\",\"stoppedAt\":\"2014-06-19T12:20:27Z\",\"sessionState\":{\"status\":\"Started\"}}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// Fetrches the active sessions for user..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestActive()
        {
            // Parameters for the API call
            Guid requestId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000");
            string emaId = "NL-TNM-C0216599X-A";

            // Perform API call
            Standard.Models.ActiveResponse200Json result = null;
            try
            {
                result = await this.controller.ActiveAsync(requestId, emaId);
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
                    "{\"requestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"status\":\"SUCCESS\",\"data\":[{\"id\":\"78b5d7a3-bdba-43d7-9851-1c84fcddb782\",\"userId\":\"281482b6-2c9a-4fd1-b3ea-1928edb40ef9\",\"emaId\":\"NL-TNM-C00122045-K\",\"evseId\":\"NL*TNM*E02003451*0\",\"startedAt\":\"2015-08-19T11:20:27Z\",\"stoppedAt\":\"2015-08-19T11:20:27Z\",\"SessionState\":{\"status\":\"Started\"},\"lastUpdated\":\"2024-07-17T07:36:57.985998Z\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}