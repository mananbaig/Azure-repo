// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Square Serivce linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Square")]
    [Rest.Serialization.JsonTransformation]
    public partial class SquareLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the SquareLinkedService class.
        /// </summary>
        public SquareLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SquareLinkedService class.
        /// </summary>
        /// <param name="host">The URL of the Square instance. (i.e.
        /// mystore.mysquare.com)</param>
        /// <param name="clientId">The client ID associated with your Square
        /// application.</param>
        /// <param name="redirectUri">The redirect URL assigned in the Square
        /// application dashboard. (i.e. http://localhost:2500)</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="clientSecret">The client secret associated with your
        /// Square application.</param>
        /// <param name="useEncryptedEndpoints">Specifies whether the data
        /// source endpoints are encrypted using HTTPS. The default value is
        /// true.</param>
        /// <param name="useHostVerification">Specifies whether to require the
        /// host name in the server's certificate to match the host name of the
        /// server when connecting over SSL. The default value is true.</param>
        /// <param name="usePeerVerification">Specifies whether to verify the
        /// identity of the server when connecting over SSL. The default value
        /// is true.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public SquareLinkedService(object host, object clientId, object redirectUri, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), SecretBase clientSecret = default(SecretBase), object useEncryptedEndpoints = default(object), object useHostVerification = default(object), object usePeerVerification = default(object), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            Host = host;
            ClientId = clientId;
            ClientSecret = clientSecret;
            RedirectUri = redirectUri;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the Square instance. (i.e.
        /// mystore.mysquare.com)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the client ID associated with your Square application.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientId")]
        public object ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret associated with your Square
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientSecret")]
        public SecretBase ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the redirect URL assigned in the Square application
        /// dashboard. (i.e. http://localhost:2500)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.redirectUri")]
        public object RedirectUri { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the
        /// server's certificate to match the host name of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useHostVerification")]
        public object UseHostVerification { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server
        /// when connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.usePeerVerification")]
        public object UsePeerVerification { get; set; }

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
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (RedirectUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RedirectUri");
            }
        }
    }
}
