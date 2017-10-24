// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure ML Web Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureML")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMLLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureMLLinkedService class.
        /// </summary>
        public AzureMLLinkedService()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMLLinkedService class.
        /// </summary>
        /// <param name="mlEndpoint">The Batch Execution REST URL for an Azure
        /// ML Web Service endpoint. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="apiKey">The API key for accessing the Azure ML model
        /// endpoint.</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="updateResourceEndpoint">The Update Resource REST URL
        /// for an Azure ML Web Service endpoint. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="servicePrincipalId">The ID of the service principal
        /// used to authenticate against the ARM-based updateResourceEndpoint
        /// of an Azure ML web service. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="servicePrincipalKey">The key of the service principal
        /// used to authenticate against the ARM-based updateResourceEndpoint
        /// of an Azure ML web service.</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureMLLinkedService(object mlEndpoint, SecureString apiKey, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object updateResourceEndpoint = default(object), object servicePrincipalId = default(object), SecureString servicePrincipalKey = default(SecureString), object tenant = default(object), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            MlEndpoint = mlEndpoint;
            ApiKey = apiKey;
            UpdateResourceEndpoint = updateResourceEndpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Batch Execution REST URL for an Azure ML Web
        /// Service endpoint. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlEndpoint")]
        public object MlEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the API key for accessing the Azure ML model endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.apiKey")]
        public SecureString ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the Update Resource REST URL for an Azure ML Web
        /// Service endpoint. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.updateResourceEndpoint")]
        public object UpdateResourceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against the ARM-based updateResourceEndpoint of an Azure ML web
        /// service. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against the ARM-based updateResourceEndpoint of an Azure ML web
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecureString ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MlEndpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MlEndpoint");
            }
            if (ApiKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiKey");
            }
            if (ApiKey != null)
            {
                ApiKey.Validate();
            }
            if (ServicePrincipalKey != null)
            {
                ServicePrincipalKey.Validate();
            }
        }
    }
}
