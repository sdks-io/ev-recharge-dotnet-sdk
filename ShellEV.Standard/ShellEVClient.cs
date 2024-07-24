// <copyright file="ShellEVClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellEV.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using ShellEV.Standard.Authentication;
    using ShellEV.Standard.Controllers;
    using ShellEV.Standard.Http.Client;
    using ShellEV.Standard.Utilities;

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
                    { Server.Default, "https://api.shell.com" },
                }
            },
            {
                Environment.Environment2, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api-test.shell.com" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallBack httpCallBack;
        private readonly Lazy<LocationsController> locations;
        private readonly Lazy<ChargingController> charging;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private ShellEVClient(
            Environment environment,
            ClientCredentialsAuthModel clientCredentialsAuthModel,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            ClientCredentialsAuthModel = clientCredentialsAuthModel;
            var clientCredentialsAuthManager = new ClientCredentialsAuthManager(clientCredentialsAuthModel);
            clientCredentialsAuthManager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"BearerAuth", clientCredentialsAuthManager},
                })
                .ApiCallback(httpCallBack)
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
        internal HttpCallBack HttpCallBack => this.httpCallBack;

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
                .HttpCallBack(httpCallBack)
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
            private HttpCallBack httpCallBack;

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
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
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
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}
