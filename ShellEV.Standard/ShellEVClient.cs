// <copyright file="ShellEVClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using ShellEV.Standard.Authentication;
using ShellEV.Standard.Controllers;
using ShellEV.Standard.Http.Client;
using ShellEV.Standard.Utilities;

namespace ShellEV.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class ShellEVClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.shell.com/ev/v1" },
                    { Server.AccessTokenServer, "https://api.shell.com/v2/oauth" },
                }
            },
            {
                Environment.Environment2, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api-test.shell.com/ev/v1" },
                    { Server.AccessTokenServer, "https://api.shell.com/v2/oauth" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<LocationsController> locations;
        private readonly Lazy<ChargingController> charging;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private ShellEVClient(
            Environment environment,
            ClientCredentialsAuthModel clientCredentialsAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            ClientCredentialsAuthModel = clientCredentialsAuthModel;
            var clientCredentialsAuthManager = new ClientCredentialsAuthManager(clientCredentialsAuthModel);
            clientCredentialsAuthManager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"BearerAuth", clientCredentialsAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            ClientCredentialsAuth = clientCredentialsAuthManager;

            this.locations = new Lazy<LocationsController>(
                () => new LocationsController(globalConfiguration));
            this.charging = new Lazy<ChargingController>(
                () => new ChargingController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets LocationsController controller.
        /// </summary>
        public LocationsController LocationsController => this.locations.Value;

        /// <summary>
        /// Gets ChargingController controller.
        /// </summary>
        public ChargingController ChargingController => this.charging.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with ClientCredentialsAuth.
        /// </summary>
        public IClientCredentialsAuth ClientCredentialsAuth { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with ClientCredentialsAuth.
        /// </summary>
        public ClientCredentialsAuthModel ClientCredentialsAuthModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the ShellEVClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .HttpClientConfig(config => config.Build());

            if (ClientCredentialsAuthModel != null)
            {
                builder.ClientCredentialsAuth(ClientCredentialsAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> ShellEVClient.</returns>
        internal static ShellEVClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("SHELL_EV_STANDARD_ENVIRONMENT");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("SHELL_EV_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("SHELL_EV_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.ClientCredentialsAuth(new ClientCredentialsAuthModel
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = ShellEV.Standard.Environment.Production;
            private ClientCredentialsAuthModel clientCredentialsAuthModel = new ClientCredentialsAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

            /// <summary>
            /// Sets credentials for ClientCredentialsAuth.
            /// </summary>
            /// <param name="oAuthClientId">OAuthClientId.</param>
            /// <param name="oAuthClientSecret">OAuthClientSecret.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use ClientCredentialsAuth(clientCredentialsAuthModel) instead.")]
            public Builder ClientCredentialsAuth(string oAuthClientId, string oAuthClientSecret)
            {
                clientCredentialsAuthModel = clientCredentialsAuthModel.ToBuilder()
                    .OAuthClientId(oAuthClientId)
                    .OAuthClientSecret(oAuthClientSecret)
                    .Build();
                return this;
            }

            /// <summary>
            /// Sets OAuthToken.
            /// </summary>
            /// <param name="oAuthToken">OAuthToken.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use ClientCredentialsAuth(clientCredentialsAuthModel) instead.")]
            public Builder OAuthToken(Models.OAuthToken oAuthToken)
            {
                clientCredentialsAuthModel = clientCredentialsAuthModel.ToBuilder()
                    .OAuthToken(oAuthToken)
                    .Build();
                return this;
            }

            /// <summary>
            /// Sets credentials for ClientCredentialsAuth.
            /// </summary>
            /// <param name="clientCredentialsAuthModel">ClientCredentialsAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder ClientCredentialsAuth(ClientCredentialsAuthModel clientCredentialsAuthModel)
            {
                if (clientCredentialsAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(clientCredentialsAuthModel));
                }

                this.clientCredentialsAuthModel = clientCredentialsAuthModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the ShellEVClient using the values provided for the builder.
            /// </summary>
            /// <returns>ShellEVClient.</returns>
            public ShellEVClient Build()
            {
                if (clientCredentialsAuthModel.OAuthClientId == null || clientCredentialsAuthModel.OAuthClientSecret == null)
                {
                    clientCredentialsAuthModel = null;
                }
                return new ShellEVClient(
                    environment,
                    clientCredentialsAuthModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}
