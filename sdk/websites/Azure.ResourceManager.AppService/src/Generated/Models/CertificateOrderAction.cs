// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Certificate order action. </summary>
    public partial class CertificateOrderAction : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="CertificateOrderAction"/>. </summary>
        public CertificateOrderAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CertificateOrderAction"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="actionType"> Action type. </param>
        /// <param name="createdOn"> Time at which the certificate action was performed. </param>
        internal CertificateOrderAction(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, CertificateOrderActionType? actionType, DateTimeOffset? createdOn) : base(id, name, resourceType, systemData, kind)
        {
            ActionType = actionType;
            CreatedOn = createdOn;
        }

        /// <summary> Action type. </summary>
        public CertificateOrderActionType? ActionType { get; }
        /// <summary> Time at which the certificate action was performed. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
