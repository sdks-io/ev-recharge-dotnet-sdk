// <copyright file="LocationsControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace ShellEV.Tests
{
    /// <summary>
    /// LocationsControllerTest.
    /// </summary>
    [TestFixture]
    public class LocationsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private LocationsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.LocationsController;
        }

        /// <summary>
        /// This API provides the list of all Shell Recharge locations. The list includes all Shell Recharge network and all locations available through our roaming partners. The end point provides flexible search criteria in order to get the list of Shell Recharge Network. The end point provides the details such as the exact location/address of the site along with the up-to-date status information of all the charging units in the site. 
        ///
        ///Supported Search Options
        ///
        ///* Based on status of the Charging units. Eg : Available or Occupied
        ///* Based on available connector types.
        ///* Based on minimum Power output (in kW) available
        ///* Based on a specific charging unit ID (EVSE ID).
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetEVLocations()
        {
            // Parameters for the API call
            Guid requestId = Guid.Parse("123e4567-e89b-12d3-a456-426614174000");
            Standard.Models.GetEVLocationsEvseStatusEnum? evseStatus = null;
            Standard.Models.GetEVLocationsConnectorTypesEnum? connectorTypes = null;
            double? connectorMinPower = null;
            Standard.Models.GetEVLocationsAuthorizationMethodsEnum? authorizationMethods = null;
            bool? withOperatorName = null;
            string evseId = "NL*TNM*E01000401*0";
            string locationExternalId = null;
            string evseExternalId = null;
            int? pageNumber = null;
            int? perPage = null;
            string updatedSince = null;
            List<string> country = ApiHelper.JsonDeserialize<List<string>>("[\"NED\"]");
            List<string> excludeCountry = ApiHelper.JsonDeserialize<List<string>>("[\"NED\"]");

            // Perform API call
            Standard.Models.Response result = null;
            try
            {
                result = await this.controller.GetEVLocationsAsync(requestId, evseStatus, connectorTypes, connectorMinPower, authorizationMethods, withOperatorName, evseId, locationExternalId, evseExternalId, pageNumber, perPage, updatedSince, country, excludeCountry);
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
        }
    }
}