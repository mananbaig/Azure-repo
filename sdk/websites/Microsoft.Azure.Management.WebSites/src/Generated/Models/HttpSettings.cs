// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the HTTP requests for authentication and
    /// authorization requests made against App Service
    /// Authentication/Authorization.
    /// </summary>
    public partial class HttpSettings
    {
        /// <summary>
        /// Initializes a new instance of the HttpSettings class.
        /// </summary>
        public HttpSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpSettings class.
        /// </summary>
        /// <param name="requireHttps">&lt;code&gt;false&lt;/code&gt; if the
        /// authentication/authorization responses not having the HTTPS scheme
        /// are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;.</param>
        /// <param name="routes">The configuration settings of the paths HTTP
        /// requests.</param>
        /// <param name="forwardProxy">The configuration settings of a forward
        /// proxy used to make the requests.</param>
        public HttpSettings(bool? requireHttps = default(bool?), HttpSettingsRoutes routes = default(HttpSettingsRoutes), ForwardProxy forwardProxy = default(ForwardProxy))
        {
            RequireHttps = requireHttps;
            Routes = routes;
            ForwardProxy = forwardProxy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt; if the
        /// authentication/authorization responses not having the HTTPS scheme
        /// are permissible; otherwise,
        /// &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "requireHttps")]
        public bool? RequireHttps { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the paths HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public HttpSettingsRoutes Routes { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of a forward proxy used to
        /// make the requests.
        /// </summary>
        [JsonProperty(PropertyName = "forwardProxy")]
        public ForwardProxy ForwardProxy { get; set; }

    }
}
