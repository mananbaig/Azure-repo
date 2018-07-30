// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The key verify parameters.
    /// </summary>
    public partial class KeyVerifyParameters
    {
        /// <summary>
        /// Initializes a new instance of the KeyVerifyParameters class.
        /// </summary>
        public KeyVerifyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVerifyParameters class.
        /// </summary>
        /// <param name="algorithm">The signing/verification algorithm. For
        /// more information on possible algorithm types, see
        /// Microsoft.Azure.KeyVault.WebKey.JsonWebKeySignatureAlgorithm. Possible values include: 'PS256',
        /// 'PS384', 'PS512', 'RS256', 'RS384', 'RS512', 'RSNULL', 'ES256',
        /// 'ES384', 'ES512', 'ES256K'</param>
        /// <param name="digest">The digest used for signing.</param>
        /// <param name="signature">The signature to be verified.</param>
        public KeyVerifyParameters(string algorithm, byte[] digest, byte[] signature)
        {
            Algorithm = algorithm;
            Digest = digest;
            Signature = signature;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the signing/verification algorithm. For more
        /// information on possible algorithm types, see
        /// Microsoft.Azure.KeyVault.WebKey.JsonWebKeySignatureAlgorithm. Possible values include: 'PS256',
        /// 'PS384', 'PS512', 'RS256', 'RS384', 'RS512', 'RSNULL', 'ES256',
        /// 'ES384', 'ES512', 'ES256K'
        /// </summary>
        [JsonProperty(PropertyName = "alg")]
        public string Algorithm { get; set; }

        /// <summary>
        /// Gets or sets the digest used for signing.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "digest")]
        public byte[] Digest { get; set; }

        /// <summary>
        /// Gets or sets the signature to be verified.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "value")]
        public byte[] Signature { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Algorithm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Algorithm");
            }
            if (Digest == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Digest");
            }
            if (Signature == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Signature");
            }
            if (Algorithm != null)
            {
                if (Algorithm.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Algorithm", 1);
                }
            }
        }
    }
}
