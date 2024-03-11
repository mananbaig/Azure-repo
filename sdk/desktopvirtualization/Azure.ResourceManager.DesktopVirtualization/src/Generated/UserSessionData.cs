// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the UserSession data model.
    /// Represents a UserSession definition.
    /// </summary>
    public partial class UserSessionData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UserSessionData"/>. </summary>
        public UserSessionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserSessionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="objectId"> ObjectId of user session. (internal use). </param>
        /// <param name="userPrincipalName"> The user principal name. </param>
        /// <param name="applicationType"> Application type of application. </param>
        /// <param name="sessionState"> State of user session. </param>
        /// <param name="activeDirectoryUserName"> The active directory user name. </param>
        /// <param name="createOn"> The timestamp of the user session create. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserSessionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string objectId, string userPrincipalName, VirtualApplicationType? applicationType, UserSessionState? sessionState, string activeDirectoryUserName, DateTimeOffset? createOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ObjectId = objectId;
            UserPrincipalName = userPrincipalName;
            ApplicationType = applicationType;
            SessionState = sessionState;
            ActiveDirectoryUserName = activeDirectoryUserName;
            CreateOn = createOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ObjectId of user session. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> The user principal name. </summary>
        public string UserPrincipalName { get; set; }
        /// <summary> Application type of application. </summary>
        public VirtualApplicationType? ApplicationType { get; set; }
        /// <summary> State of user session. </summary>
        public UserSessionState? SessionState { get; set; }
        /// <summary> The active directory user name. </summary>
        public string ActiveDirectoryUserName { get; set; }
        /// <summary> The timestamp of the user session create. </summary>
        public DateTimeOffset? CreateOn { get; set; }
    }
}
