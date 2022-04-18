// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery image definition that you want
    /// to update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryImageUpdate : UpdateResourceDefinition
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageUpdate class.
        /// </summary>
        public GalleryImageUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageUpdate class.
        /// </summary>
        /// <param name="osType">This property allows you to specify the type
        /// of the OS that is included in the disk when creating a VM from a
        /// managed image. &lt;br&gt;&lt;br&gt; Possible values are:
        /// &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**.
        /// Possible values include: 'Windows', 'Linux'</param>
        /// <param name="osState">This property allows the user to specify
        /// whether the virtual machines created under this image are
        /// 'Generalized' or 'Specialized'. Possible values include:
        /// 'Generalized', 'Specialized'</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="description">The description of this gallery image
        /// definition resource. This property is updatable.</param>
        /// <param name="eula">The Eula agreement for the gallery image
        /// definition.</param>
        /// <param name="privacyStatementUri">The privacy statement
        /// uri.</param>
        /// <param name="releaseNoteUri">The release note uri.</param>
        /// <param name="hyperVGeneration">The hypervisor generation of the
        /// Virtual Machine. Applicable to OS disks only. Possible valuesp
        /// include: 'V1', 'V2'</param>
        /// <param name="endOfLifeDate">The end of life date of the gallery
        /// image definition. This property can be used for decommissioning
        /// purposes. This property is updatable.</param>
        /// <param name="provisioningState">The current state of the gallery
        /// image definition.</param>
        /// <param name="features">A list of gallery image features.</param>
        /// <param name="architecture">The architecture of the image.
        /// Applicable to OS disks only. Possible values include: 'x64',
        /// 'Arm64'</param>
        public GalleryImageUpdate(OperatingSystemTypes osType, OperatingSystemStateTypes osState, GalleryImageIdentifier identifier, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), string eula = default(string), string privacyStatementUri = default(string), string releaseNoteUri = default(string), string hyperVGeneration = default(string), System.DateTime? endOfLifeDate = default(System.DateTime?), RecommendedMachineConfiguration recommended = default(RecommendedMachineConfiguration), Disallowed disallowed = default(Disallowed), ImagePurchasePlan purchasePlan = default(ImagePurchasePlan), string provisioningState = default(string), IList<GalleryImageFeature> features = default(IList<GalleryImageFeature>), string architecture = default(string))
            : base(id, name, type, tags)
        {
            Description = description;
            Eula = eula;
            PrivacyStatementUri = privacyStatementUri;
            ReleaseNoteUri = releaseNoteUri;
            OsType = osType;
            OsState = osState;
            HyperVGeneration = hyperVGeneration;
            EndOfLifeDate = endOfLifeDate;
            Identifier = identifier;
            Recommended = recommended;
            Disallowed = disallowed;
            PurchasePlan = purchasePlan;
            ProvisioningState = provisioningState;
            Features = features;
            Architecture = architecture;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of this gallery image definition
        /// resource. This property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Eula agreement for the gallery image definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eula")]
        public string Eula { get; set; }

        /// <summary>
        /// Gets or sets the privacy statement uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacyStatementUri")]
        public string PrivacyStatementUri { get; set; }

        /// <summary>
        /// Gets or sets the release note uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.releaseNoteUri")]
        public string ReleaseNoteUri { get; set; }

        /// <summary>
        /// Gets or sets this property allows you to specify the type of the OS
        /// that is included in the disk when creating a VM from a managed
        /// image. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Windows**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Linux**. Possible values
        /// include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes OsType { get; set; }

        /// <summary>
        /// Gets or sets this property allows the user to specify whether the
        /// virtual machines created under this image are 'Generalized' or
        /// 'Specialized'. Possible values include: 'Generalized',
        /// 'Specialized'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osState")]
        public OperatingSystemStateTypes OsState { get; set; }

        /// <summary>
        /// Gets or sets the hypervisor generation of the Virtual Machine.
        /// Applicable to OS disks only. Possible values include: 'V1', 'V2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// Gets or sets the end of life date of the gallery image definition.
        /// This property can be used for decommissioning purposes. This
        /// property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endOfLifeDate")]
        public System.DateTime? EndOfLifeDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.identifier")]
        public GalleryImageIdentifier Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommended")]
        public RecommendedMachineConfiguration Recommended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.disallowed")]
        public Disallowed Disallowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchasePlan")]
        public ImagePurchasePlan PurchasePlan { get; set; }

        /// <summary>
        /// Gets the current state of the gallery image definition.
        /// </summary>
        /// <remarks>
        /// The provisioning state, which only appears in the response.
        /// Possible values include: 'Creating', 'Updating', 'Failed',
        /// 'Succeeded', 'Deleting', 'Migrating'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets a list of gallery image features.
        /// </summary>
        [JsonProperty(PropertyName = "properties.features")]
        public IList<GalleryImageFeature> Features { get; set; }

        /// <summary>
        /// Gets or sets the architecture of the image. Applicable to OS disks
        /// only. Possible values include: 'x64', 'Arm64'
        /// </summary>
        [JsonProperty(PropertyName = "properties.architecture")]
        public string Architecture { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identifier");
            }
            if (Identifier != null)
            {
                Identifier.Validate();
            }
        }
    }
}
