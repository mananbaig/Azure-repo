// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Scale Set Extension.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetExtensionInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionInner class.
        /// </summary>
        public VirtualMachineScaleSetExtensionInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetExtensionInner class.
        /// </summary>
        /// <param name="name">the name of the extension.</param>
        /// <param name="publisher">the name of the extension handler
        /// publisher.</param>
        /// <param name="type">the type of the extension handler.</param>
        /// <param name="typeHandlerVersion">the type version of the extension
        /// handler.</param>
        /// <param name="autoUpgradeMinorVersion">whether the extension
        /// handler should be automatically upgraded across minor
        /// versions.</param>
        /// <param name="settings">Json formatted public settings for the
        /// extension.</param>
        /// <param name="protectedSettings">Json formatted protected settings
        /// for the extension.</param>
        /// <param name="provisioningState">the provisioning state, which only
        /// appears in the response.</param>
        public VirtualMachineScaleSetExtensionInner(string id = default(string), string name = default(string), string publisher = default(string), string type = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string))
            : base(id)
        {
            Name = name;
            Publisher = publisher;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the name of the extension.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the type of the extension handler.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets whether the extension handler should be automatically
        /// upgraded across minor versions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets json formatted public settings for the extension.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets json formatted protected settings for the extension.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
