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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSIS properties for managed integration runtime.
    /// </summary>
    public partial class IntegrationRuntimeSsisProperties
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeSsisProperties
        /// class.
        /// </summary>
        public IntegrationRuntimeSsisProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeSsisProperties
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="catalogInfo">Catalog information for managed dedicated
        /// integration runtime.</param>
        /// <param name="licenseType">License type for bringing your own
        /// license scenario. Possible values include: 'BasePrice',
        /// 'LicenseIncluded'</param>
        /// <param name="customSetupScriptProperties">Custom setup script
        /// properties for a managed dedicated integration runtime.</param>
        /// <param name="dataProxyProperties">Data proxy properties for a
        /// managed dedicated integration runtime.</param>
        /// <param name="edition">The edition for the SSIS Integration Runtime.
        /// Possible values include: 'Standard', 'Enterprise'</param>
        public IntegrationRuntimeSsisProperties(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeSsisCatalogInfo catalogInfo = default(IntegrationRuntimeSsisCatalogInfo), string licenseType = default(string), IntegrationRuntimeCustomSetupScriptProperties customSetupScriptProperties = default(IntegrationRuntimeCustomSetupScriptProperties), IntegrationRuntimeDataProxyProperties dataProxyProperties = default(IntegrationRuntimeDataProxyProperties), string edition = default(string))
        {
            AdditionalProperties = additionalProperties;
            CatalogInfo = catalogInfo;
            LicenseType = licenseType;
            CustomSetupScriptProperties = customSetupScriptProperties;
            DataProxyProperties = dataProxyProperties;
            Edition = edition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets catalog information for managed dedicated integration
        /// runtime.
        /// </summary>
        [JsonProperty(PropertyName = "catalogInfo")]
        public IntegrationRuntimeSsisCatalogInfo CatalogInfo { get; set; }

        /// <summary>
        /// Gets or sets license type for bringing your own license scenario.
        /// Possible values include: 'BasePrice', 'LicenseIncluded'
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets custom setup script properties for a managed dedicated
        /// integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "customSetupScriptProperties")]
        public IntegrationRuntimeCustomSetupScriptProperties CustomSetupScriptProperties { get; set; }

        /// <summary>
        /// Gets or sets data proxy properties for a managed dedicated
        /// integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "dataProxyProperties")]
        public IntegrationRuntimeDataProxyProperties DataProxyProperties { get; set; }

        /// <summary>
        /// Gets or sets the edition for the SSIS Integration Runtime. Possible
        /// values include: 'Standard', 'Enterprise'
        /// </summary>
        [JsonProperty(PropertyName = "edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CatalogInfo != null)
            {
                CatalogInfo.Validate();
            }
            if (CustomSetupScriptProperties != null)
            {
                CustomSetupScriptProperties.Validate();
            }
        }
    }
}
