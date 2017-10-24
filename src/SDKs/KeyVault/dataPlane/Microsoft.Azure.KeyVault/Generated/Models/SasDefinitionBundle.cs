// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.KeyVault;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A SAS definition bundle consists of key vault SAS definition details
    /// plus its attributes.
    /// </summary>
    public partial class SasDefinitionBundle
    {
        /// <summary>
        /// Initializes a new instance of the SasDefinitionBundle class.
        /// </summary>
        public SasDefinitionBundle()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SasDefinitionBundle class.
        /// </summary>
        /// <param name="id">The SAS definition id.</param>
        /// <param name="secretId">Storage account SAS definition secret
        /// id.</param>
        /// <param name="parameters">The SAS definition metadata in the form of
        /// key-value pairs.</param>
        /// <param name="attributes">The SAS definition attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs</param>
        public SasDefinitionBundle(string id = default(string), string secretId = default(string), IDictionary<string, string> parameters = default(IDictionary<string, string>), SasDefinitionAttributes attributes = default(SasDefinitionAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            SecretId = secretId;
            Parameters = parameters;
            Attributes = attributes;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the SAS definition id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets storage account SAS definition secret id.
        /// </summary>
        [JsonProperty(PropertyName = "sid")]
        public string SecretId { get; private set; }

        /// <summary>
        /// Gets the SAS definition metadata in the form of key-value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, string> Parameters { get; private set; }

        /// <summary>
        /// Gets the SAS definition attributes.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public SasDefinitionAttributes Attributes { get; private set; }

        /// <summary>
        /// Gets application specific metadata in the form of key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; private set; }

    }
}
