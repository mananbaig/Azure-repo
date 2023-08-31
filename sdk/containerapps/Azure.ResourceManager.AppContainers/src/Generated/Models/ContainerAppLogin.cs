// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the login flow of users using ContainerApp Service Authentication/Authorization. </summary>
    public partial class ContainerAppLogin
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppLogin"/>. </summary>
        public ContainerAppLogin()
        {
            AllowedExternalRedirectUrls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppLogin"/>. </summary>
        /// <param name="routes"> The routes that specify the endpoints used for login and logout requests. </param>
        /// <param name="preserveUrlFragmentsForLogins"> &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="allowedExternalRedirectUrls">
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </param>
        /// <param name="cookieExpiration"> The configuration settings of the session cookie's expiration. </param>
        /// <param name="nonce"> The configuration settings of the nonce used in the login flow. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppLogin(LoginRoutes routes, bool? preserveUrlFragmentsForLogins, IList<string> allowedExternalRedirectUrls, ContainerAppCookieExpiration cookieExpiration, ContainerAppLoginNonce nonce, Dictionary<string, BinaryData> rawData)
        {
            Routes = routes;
            PreserveUrlFragmentsForLogins = preserveUrlFragmentsForLogins;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            CookieExpiration = cookieExpiration;
            Nonce = nonce;
            _rawData = rawData;
        }

        /// <summary> The routes that specify the endpoints used for login and logout requests. </summary>
        internal LoginRoutes Routes { get; set; }
        /// <summary> The endpoint at which a logout request should be made. </summary>
        public string RoutesLogoutEndpoint
        {
            get => Routes is null ? default : Routes.LogoutEndpoint;
            set
            {
                if (Routes is null)
                    Routes = new LoginRoutes();
                Routes.LogoutEndpoint = value;
            }
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? PreserveUrlFragmentsForLogins { get; set; }
        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// </summary>
        public IList<string> AllowedExternalRedirectUrls { get; }
        /// <summary> The configuration settings of the session cookie's expiration. </summary>
        public ContainerAppCookieExpiration CookieExpiration { get; set; }
        /// <summary> The configuration settings of the nonce used in the login flow. </summary>
        public ContainerAppLoginNonce Nonce { get; set; }
    }
}
