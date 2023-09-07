// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary>
    /// Contains the localized display information for this particular operation / action. These
    /// value will be used by several clients for
    /// (1) custom role definitions for RBAC;
    /// (2) complex query filters for the event service; and
    /// (3) audit history / records for management operations.
    /// </summary>
    public partial class MoverDisplayInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MoverDisplayInfo"/>. </summary>
        internal MoverDisplayInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MoverDisplayInfo"/>. </summary>
        /// <param name="provider">
        /// Gets or sets the provider.
        /// The localized friendly form of the resource provider name – it is expected to also
        /// include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services.
        /// e.g. "Microsoft Monitoring Insights" or "Microsoft Compute.".
        /// </param>
        /// <param name="resource">
        /// Gets or sets the resource.
        /// The localized friendly form of the resource related to this action/operation – it
        /// should match the public documentation for the resource provider.
        /// It should use Title Casing.
        /// This value should be unique for a particular URL type (e.g. nested types should *not*
        /// reuse their parent’s display.resource field)
        /// e.g. "Virtual Machines" or "Scheduler Job Collections", or "Virtual Machine VM Sizes"
        /// or "Scheduler Jobs".
        /// </param>
        /// <param name="operation">
        /// Gets or sets the operation.
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// It should be concise (to fit in drop downs) but clear (i.e. self-documenting).
        /// It should use Title Casing.
        /// Prescriptive guidance: Read Create or Update Delete 'ActionName'.
        /// </param>
        /// <param name="description">
        /// Gets or sets the description.
        /// The localized friendly description for the operation, as it should be shown to the
        /// user.
        /// It should be thorough, yet concise – it will be used in tool tips and detailed views.
        /// Prescriptive guidance for namespace:
        /// Read any 'display.provider'  resource
        /// Create or Update any  'display.provider'  resource
        /// Delete any  'display.provider'  resource
        /// Perform any other action on any  'display.provider'  resource
        /// Prescriptive guidance for namespace:
        /// Read any 'display.resource' Create or Update any  'display.resource' Delete any
        ///  'display.resource' 'ActionName' any 'display.resources'.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverDisplayInfo(string provider, string resource, string operation, string description, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Gets or sets the provider.
        /// The localized friendly form of the resource provider name – it is expected to also
        /// include the publisher/company responsible.
        /// It should use Title Casing and begin with "Microsoft" for 1st party services.
        /// e.g. "Microsoft Monitoring Insights" or "Microsoft Compute.".
        /// </summary>
        public string Provider { get; }
        /// <summary>
        /// Gets or sets the resource.
        /// The localized friendly form of the resource related to this action/operation – it
        /// should match the public documentation for the resource provider.
        /// It should use Title Casing.
        /// This value should be unique for a particular URL type (e.g. nested types should *not*
        /// reuse their parent’s display.resource field)
        /// e.g. "Virtual Machines" or "Scheduler Job Collections", or "Virtual Machine VM Sizes"
        /// or "Scheduler Jobs".
        /// </summary>
        public string Resource { get; }
        /// <summary>
        /// Gets or sets the operation.
        /// The localized friendly name for the operation, as it should be shown to the user.
        /// It should be concise (to fit in drop downs) but clear (i.e. self-documenting).
        /// It should use Title Casing.
        /// Prescriptive guidance: Read Create or Update Delete 'ActionName'.
        /// </summary>
        public string Operation { get; }
        /// <summary>
        /// Gets or sets the description.
        /// The localized friendly description for the operation, as it should be shown to the
        /// user.
        /// It should be thorough, yet concise – it will be used in tool tips and detailed views.
        /// Prescriptive guidance for namespace:
        /// Read any 'display.provider'  resource
        /// Create or Update any  'display.provider'  resource
        /// Delete any  'display.provider'  resource
        /// Perform any other action on any  'display.provider'  resource
        /// Prescriptive guidance for namespace:
        /// Read any 'display.resource' Create or Update any  'display.resource' Delete any
        ///  'display.resource' 'ActionName' any 'display.resources'.
        /// </summary>
        public string Description { get; }
    }
}
