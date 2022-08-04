// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Event Grid Partner Topic.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PartnerTopic : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the PartnerTopic class.
        /// </summary>
        public PartnerTopic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerTopic class.
        /// </summary>
        /// <param name="location">Location of the resource.</param>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="tags">Tags of the resource.</param>
        /// <param name="partnerRegistrationImmutableId">The immutableId of the
        /// corresponding partner registration.</param>
        /// <param name="source">Source associated with this partner topic.
        /// This represents a unique partner resource.</param>
        /// <param name="eventTypeInfo">Event Type information from the
        /// corresponding event channel.</param>
        /// <param name="expirationTimeIfNotActivatedUtc">Expiration time of
        /// the partner topic. If this timer expires while the partner topic is
        /// still never activated,
        /// the partner topic and corresponding event channel are
        /// deleted.</param>
        /// <param name="provisioningState">Provisioning state of the partner
        /// topic. Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Canceled', 'Failed',
        /// 'IdleDueToMirroredChannelResourceDeletion'</param>
        /// <param name="activationState">Activation state of the partner
        /// topic. Possible values include: 'NeverActivated', 'Activated',
        /// 'Deactivated'</param>
        /// <param name="partnerTopicFriendlyDescription">Friendly description
        /// about the topic. This can be set by the publisher/partner to show
        /// custom description for the customer partner topic.
        /// This will be helpful to remove any ambiguity of the origin of
        /// creation of the partner topic for the customer.</param>
        /// <param name="messageForActivation">Context or helpful message that
        /// can be used during the approval process by the subscriber.</param>
        /// <param name="systemData">The system metadata relating to Partner
        /// Topic resource.</param>
        /// <param name="identity">Identity information for the Partner Topic
        /// resource.</param>
        public PartnerTopic(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.Guid? partnerRegistrationImmutableId = default(System.Guid?), string source = default(string), EventTypeInfo eventTypeInfo = default(EventTypeInfo), System.DateTime? expirationTimeIfNotActivatedUtc = default(System.DateTime?), string provisioningState = default(string), string activationState = default(string), string partnerTopicFriendlyDescription = default(string), string messageForActivation = default(string), SystemData systemData = default(SystemData), IdentityInfo identity = default(IdentityInfo))
            : base(location, id, name, type, tags)
        {
            PartnerRegistrationImmutableId = partnerRegistrationImmutableId;
            Source = source;
            EventTypeInfo = eventTypeInfo;
            ExpirationTimeIfNotActivatedUtc = expirationTimeIfNotActivatedUtc;
            ProvisioningState = provisioningState;
            ActivationState = activationState;
            PartnerTopicFriendlyDescription = partnerTopicFriendlyDescription;
            MessageForActivation = messageForActivation;
            SystemData = systemData;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the immutableId of the corresponding partner
        /// registration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerRegistrationImmutableId")]
        public System.Guid? PartnerRegistrationImmutableId { get; set; }

        /// <summary>
        /// Gets or sets source associated with this partner topic. This
        /// represents a unique partner resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets event Type information from the corresponding event
        /// channel.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventTypeInfo")]
        public EventTypeInfo EventTypeInfo { get; set; }

        /// <summary>
        /// Gets or sets expiration time of the partner topic. If this timer
        /// expires while the partner topic is still never activated,
        /// the partner topic and corresponding event channel are deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTimeIfNotActivatedUtc")]
        public System.DateTime? ExpirationTimeIfNotActivatedUtc { get; set; }

        /// <summary>
        /// Gets provisioning state of the partner topic. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed', 'IdleDueToMirroredChannelResourceDeletion'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets activation state of the partner topic. Possible values
        /// include: 'NeverActivated', 'Activated', 'Deactivated'
        /// </summary>
        [JsonProperty(PropertyName = "properties.activationState")]
        public string ActivationState { get; set; }

        /// <summary>
        /// Gets or sets friendly description about the topic. This can be set
        /// by the publisher/partner to show custom description for the
        /// customer partner topic.
        /// This will be helpful to remove any ambiguity of the origin of
        /// creation of the partner topic for the customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerTopicFriendlyDescription")]
        public string PartnerTopicFriendlyDescription { get; set; }

        /// <summary>
        /// Gets or sets context or helpful message that can be used during the
        /// approval process by the subscriber.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageForActivation")]
        public string MessageForActivation { get; set; }

        /// <summary>
        /// Gets the system metadata relating to Partner Topic resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets identity information for the Partner Topic resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public IdentityInfo Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
