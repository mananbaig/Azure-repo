// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Api Entity Properties
    /// </summary>
    public partial class ApiContractProperties : ApiEntityBaseContract
    {
        /// <summary>
        /// Initializes a new instance of the ApiContractProperties class.
        /// </summary>
        public ApiContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiContractProperties class.
        /// </summary>
        /// <param name="path">Relative URL uniquely identifying this API and
        /// all of its resource paths within the API Management service
        /// instance. It is appended to the API endpoint base URL specified
        /// during the service instance creation to form a public URL for this
        /// API.</param>
        /// <param name="description">Description of the API. May include HTML
        /// formatting tags.</param>
        /// <param name="authenticationSettings">Collection of authentication
        /// settings included into this API.</param>
        /// <param name="subscriptionKeyParameterNames">Protocols over which
        /// API is made available.</param>
        /// <param name="apiType">Type of API. Possible values include: 'http',
        /// 'soap'</param>
        /// <param name="apiRevision">Describes the Revision of the Api. If no
        /// value is provided, default revision 1 is created</param>
        /// <param name="apiVersion">Indicates the Version identifier of the
        /// API if the API is versioned</param>
        /// <param name="isCurrent">Indicates if API revision is current api
        /// revision.</param>
        /// <param name="isOnline">Indicates if API revision is accessible via
        /// the gateway.</param>
        /// <param name="apiVersionSetId">A resource identifier for the related
        /// ApiVersionSet.</param>
        /// <param name="displayName">API name.</param>
        /// <param name="serviceUrl">Absolute URL of the backend service
        /// implementing this API.</param>
        /// <param name="protocols">Describes on which protocols the operations
        /// in this API can be invoked.</param>
        public ApiContractProperties(string path, string description = default(string), AuthenticationSettingsContract authenticationSettings = default(AuthenticationSettingsContract), SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default(SubscriptionKeyParameterNamesContract), string apiType = default(string), string apiRevision = default(string), string apiVersion = default(string), bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiVersionSetId = default(string), string displayName = default(string), string serviceUrl = default(string), IList<Protocol?> protocols = default(IList<Protocol?>), ApiVersionSetContractDetails apiVersionSet = default(ApiVersionSetContractDetails))
            : base(description, authenticationSettings, subscriptionKeyParameterNames, apiType, apiRevision, apiVersion, isCurrent, isOnline, apiVersionSetId)
        {
            DisplayName = displayName;
            ServiceUrl = serviceUrl;
            Path = path;
            Protocols = protocols;
            ApiVersionSet = apiVersionSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets API name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets absolute URL of the backend service implementing this
        /// API.
        /// </summary>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets relative URL uniquely identifying this API and all of
        /// its resource paths within the API Management service instance. It
        /// is appended to the API endpoint base URL specified during the
        /// service instance creation to form a public URL for this API.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets describes on which protocols the operations in this
        /// API can be invoked.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<Protocol?> Protocols { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiVersionSet")]
        public ApiVersionSetContractDetails ApiVersionSet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 300);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
            }
            if (ServiceUrl != null)
            {
                if (ServiceUrl.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ServiceUrl", 2000);
                }
                if (ServiceUrl.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ServiceUrl", 0);
                }
            }
            if (Path != null)
            {
                if (Path.Length > 400)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Path", 400);
                }
                if (Path.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Path", 0);
                }
            }
        }
    }
}
