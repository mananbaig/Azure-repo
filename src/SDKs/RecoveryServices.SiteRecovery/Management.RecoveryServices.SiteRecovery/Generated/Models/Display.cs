// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the localized display information for this particular
    /// operation / action. These value will be used by several clients for (1)
    /// custom role definitions for RBAC; (2) complex query filters for the
    /// event service; and (3) audit history / records for management
    /// operations.
    /// </summary>
    public partial class Display
    {
        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        public Display()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        /// <param name="provider">The provider. The localized friendly form of
        /// the resource provider name – it is expected to also include the
        /// publisher/company responsible. It should use Title Casing and begin
        /// with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring
        /// Insights" or "Microsoft Compute."</param>
        /// <param name="resource">The resource. The localized friendly form of
        /// the resource related to this action/operation – it should match the
        /// public documentation for the resource provider. It should use Title
        /// Casing. This value should be unique for a particular URL type (e.g.
        /// nested types should *not* reuse their parent’s display.resource
        /// field). e.g. "Virtual Machines" or "Scheduler Job Collections", or
        /// "Virtual Machine VM Sizes" or "Scheduler Jobs"</param>
        /// <param name="operation">The operation. The localized friendly name
        /// for the operation, as it should be shown to the user. It should be
        /// concise (to fit in drop downs) but clear (i.e. self-documenting).
        /// It should use Title Casing. Prescriptive guidance: Read Create or
        /// Update Delete 'ActionName'</param>
        /// <param name="description">The description. The localized friendly
        /// description for the operation, as it should be shown to the user.
        /// It should be thorough, yet concise – it will be used in tool tips
        /// and detailed views. Prescriptive guidance for namespaces: Read any
        /// 'display.provider' resource Create or Update any 'display.provider'
        /// resource Delete any 'display.provider' resource Perform any other
        /// action on any 'display.provider' resource Prescriptive guidance for
        /// namespaces: Read any 'display.resource' Create or Update any
        /// 'display.resource' Delete any 'display.resource' 'ActionName' any
        /// 'display.resources'</param>
        public Display(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provider. The localized friendly form of the
        /// resource provider name – it is expected to also include the
        /// publisher/company responsible. It should use Title Casing and begin
        /// with "Microsoft" for 1st party services. e.g. "Microsoft Monitoring
        /// Insights" or "Microsoft Compute."
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the resource. The localized friendly form of the
        /// resource related to this action/operation – it should match the
        /// public documentation for the resource provider. It should use Title
        /// Casing. This value should be unique for a particular URL type (e.g.
        /// nested types should *not* reuse their parent’s display.resource
        /// field). e.g. "Virtual Machines" or "Scheduler Job Collections", or
        /// "Virtual Machine VM Sizes" or "Scheduler Jobs"
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the operation. The localized friendly name for the
        /// operation, as it should be shown to the user. It should be concise
        /// (to fit in drop downs) but clear (i.e. self-documenting). It should
        /// use Title Casing. Prescriptive guidance: Read Create or Update
        /// Delete 'ActionName'
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the description. The localized friendly description
        /// for the operation, as it should be shown to the user. It should be
        /// thorough, yet concise – it will be used in tool tips and detailed
        /// views. Prescriptive guidance for namespaces: Read any
        /// 'display.provider' resource Create or Update any 'display.provider'
        /// resource Delete any 'display.provider' resource Perform any other
        /// action on any 'display.provider' resource Prescriptive guidance for
        /// namespaces: Read any 'display.resource' Create or Update any
        /// 'display.resource' Delete any 'display.resource' 'ActionName' any
        /// 'display.resources'
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
