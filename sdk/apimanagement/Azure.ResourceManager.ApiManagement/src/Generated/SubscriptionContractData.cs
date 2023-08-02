// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the SubscriptionContract data model.
    /// Subscription details.
    /// </summary>
    public partial class SubscriptionContractData : ResourceData
    {
        /// <summary> Initializes a new instance of SubscriptionContractData. </summary>
        public SubscriptionContractData()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="ownerId"> The user resource identifier of the subscription owner. The value is a valid relative URL in the format of /users/{userId} where {userId} is a user identifier. </param>
        /// <param name="scope"> Scope like /products/{productId} or /apis or /apis/{apiId}. </param>
        /// <param name="displayName"> The name of the subscription, or null if the subscription has no name. </param>
        /// <param name="state"> Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. </param>
        /// <param name="createdOn">
        /// Subscription creation date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="startOn">
        /// Subscription activation date. The setting is for audit purposes only and the subscription is not automatically activated. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="expireOn">
        /// Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="endOn">
        /// Date when subscription was cancelled or expired. The setting is for audit purposes only and the subscription is not automatically cancelled. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="notifiesOn">
        /// Upcoming subscription expiration notification date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="primaryKey"> Subscription primary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </param>
        /// <param name="secondaryKey"> Subscription secondary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </param>
        /// <param name="stateComment"> Optional subscription comment added by an administrator when the state is changed to the 'rejected'. </param>
        /// <param name="allowTracing"> Determines whether tracing is enabled. </param>
        internal SubscriptionContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string ownerId, string scope, string displayName, SubscriptionState? state, DateTimeOffset? createdOn, DateTimeOffset? startOn, DateTimeOffset? expireOn, DateTimeOffset? endOn, DateTimeOffset? notifiesOn, string primaryKey, string secondaryKey, string stateComment, bool? allowTracing) : base(id, name, resourceType, systemData)
        {
            OwnerId = ownerId;
            Scope = scope;
            DisplayName = displayName;
            State = state;
            CreatedOn = createdOn;
            StartOn = startOn;
            ExpireOn = expireOn;
            EndOn = endOn;
            NotifiesOn = notifiesOn;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            StateComment = stateComment;
            AllowTracing = allowTracing;
        }

        /// <summary> The user resource identifier of the subscription owner. The value is a valid relative URL in the format of /users/{userId} where {userId} is a user identifier. </summary>
        public string OwnerId { get; set; }
        /// <summary> Scope like /products/{productId} or /apis or /apis/{apiId}. </summary>
        public string Scope { get; set; }
        /// <summary> The name of the subscription, or null if the subscription has no name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated. </summary>
        public SubscriptionState? State { get; set; }
        /// <summary>
        /// Subscription creation date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// Subscription activation date. The setting is for audit purposes only and the subscription is not automatically activated. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary>
        /// Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary>
        /// Date when subscription was cancelled or expired. The setting is for audit purposes only and the subscription is not automatically cancelled. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary>
        /// Upcoming subscription expiration notification date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset? NotifiesOn { get; set; }
        /// <summary> Subscription primary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </summary>
        public string PrimaryKey { get; set; }
        /// <summary> Subscription secondary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </summary>
        public string SecondaryKey { get; set; }
        /// <summary> Optional subscription comment added by an administrator when the state is changed to the 'rejected'. </summary>
        public string StateComment { get; set; }
        /// <summary> Determines whether tracing is enabled. </summary>
        public bool? AllowTracing { get; set; }
    }
}
