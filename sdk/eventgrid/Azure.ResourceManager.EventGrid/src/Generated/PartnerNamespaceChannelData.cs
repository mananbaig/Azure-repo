// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the PartnerNamespaceChannel data model.
    /// Channel info.
    /// </summary>
    public partial class PartnerNamespaceChannelData : ResourceData
    {
        /// <summary> Initializes a new instance of PartnerNamespaceChannelData. </summary>
        public PartnerNamespaceChannelData()
        {
        }

        /// <summary> Initializes a new instance of PartnerNamespaceChannelData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="channelType"> The type of the event channel which represents the direction flow of events. </param>
        /// <param name="partnerTopicInfo"> This property should be populated when channelType is PartnerTopic and represents information about the partner topic resource corresponding to the channel. </param>
        /// <param name="partnerDestinationInfo">
        /// This property should be populated when channelType is PartnerDestination and represents information about the partner destination resource corresponding to the channel.
        /// Please note <see cref="Models.PartnerDestinationInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebhookPartnerDestinationInfo"/>.
        /// </param>
        /// <param name="messageForActivation"> Context or helpful message that can be used during the approval process by the subscriber. </param>
        /// <param name="provisioningState"> Provisioning state of the channel. </param>
        /// <param name="readinessState"> The readiness state of the corresponding partner topic. </param>
        /// <param name="expireOnIfNotActivated">
        /// Expiration time of the channel. If this timer expires while the corresponding partner topic is never activated,
        /// the channel and corresponding partner topic are deleted.
        /// </param>
        internal PartnerNamespaceChannelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PartnerNamespaceChannelType? channelType, PartnerTopicInfo partnerTopicInfo, PartnerDestinationInfo partnerDestinationInfo, string messageForActivation, PartnerNamespaceChannelProvisioningState? provisioningState, PartnerTopicReadinessState? readinessState, DateTimeOffset? expireOnIfNotActivated) : base(id, name, resourceType, systemData)
        {
            ChannelType = channelType;
            PartnerTopicInfo = partnerTopicInfo;
            PartnerDestinationInfo = partnerDestinationInfo;
            MessageForActivation = messageForActivation;
            ProvisioningState = provisioningState;
            ReadinessState = readinessState;
            ExpireOnIfNotActivated = expireOnIfNotActivated;
        }

        /// <summary> The type of the event channel which represents the direction flow of events. </summary>
        public PartnerNamespaceChannelType? ChannelType { get; set; }
        /// <summary> This property should be populated when channelType is PartnerTopic and represents information about the partner topic resource corresponding to the channel. </summary>
        public PartnerTopicInfo PartnerTopicInfo { get; set; }
        /// <summary>
        /// This property should be populated when channelType is PartnerDestination and represents information about the partner destination resource corresponding to the channel.
        /// Please note <see cref="Models.PartnerDestinationInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WebhookPartnerDestinationInfo"/>.
        /// </summary>
        public PartnerDestinationInfo PartnerDestinationInfo { get; set; }
        /// <summary> Context or helpful message that can be used during the approval process by the subscriber. </summary>
        public string MessageForActivation { get; set; }
        /// <summary> Provisioning state of the channel. </summary>
        public PartnerNamespaceChannelProvisioningState? ProvisioningState { get; set; }
        /// <summary> The readiness state of the corresponding partner topic. </summary>
        public PartnerTopicReadinessState? ReadinessState { get; set; }
        /// <summary>
        /// Expiration time of the channel. If this timer expires while the corresponding partner topic is never activated,
        /// the channel and corresponding partner topic are deleted.
        /// </summary>
        public DateTimeOffset? ExpireOnIfNotActivated { get; set; }
    }
}
