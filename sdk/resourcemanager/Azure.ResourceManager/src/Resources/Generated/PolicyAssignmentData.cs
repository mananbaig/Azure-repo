// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the PolicyAssignment data model.
    /// The policy assignment.
    /// </summary>
    public partial class PolicyAssignmentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolicyAssignmentData"/>. </summary>
        public PolicyAssignmentData()
        {
            ExcludedScopes = new ChangeTrackingList<string>();
            Parameters = new ChangeTrackingDictionary<string, ArmPolicyParameterValue>();
            NonComplianceMessages = new ChangeTrackingList<NonComplianceMessage>();
            ResourceSelectors = new ChangeTrackingList<ResourceSelector>();
            Overrides = new ChangeTrackingList<PolicyOverride>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicyAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the policy assignment. Only required when utilizing managed identity. </param>
        /// <param name="managedIdentity"> The managed identity associated with the policy assignment. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="displayName"> The display name of the policy assignment. </param>
        /// <param name="policyDefinitionId"> The ID of the policy definition or policy set definition being assigned. </param>
        /// <param name="scope"> The scope for the policy assignment. </param>
        /// <param name="excludedScopes"> The policy's excluded scopes. </param>
        /// <param name="parameters"> The parameter values for the assigned policy rule. The keys are the parameter names. </param>
        /// <param name="description"> This message will be part of response in case of policy violation. </param>
        /// <param name="metadata"> The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs. </param>
        /// <param name="enforcementMode"> The policy assignment enforcement mode. Possible values are Default and DoNotEnforce. </param>
        /// <param name="nonComplianceMessages"> The messages that describe why a resource is non-compliant with the policy. </param>
        /// <param name="resourceSelectors"> The resource selector list to filter policies by resource properties. </param>
        /// <param name="overrides"> The policy property value override. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ManagedServiceIdentity managedIdentity, string displayName, string policyDefinitionId, string scope, IList<string> excludedScopes, IDictionary<string, ArmPolicyParameterValue> parameters, string description, BinaryData metadata, EnforcementMode? enforcementMode, IList<NonComplianceMessage> nonComplianceMessages, IList<ResourceSelector> resourceSelectors, IList<PolicyOverride> overrides, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            ManagedIdentity = managedIdentity;
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
            ExcludedScopes = excludedScopes;
            Parameters = parameters;
            Description = description;
            Metadata = metadata;
            EnforcementMode = enforcementMode;
            NonComplianceMessages = nonComplianceMessages;
            ResourceSelectors = resourceSelectors;
            Overrides = overrides;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the policy assignment. Only required when utilizing managed identity. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The managed identity associated with the policy assignment. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity ManagedIdentity { get; set; }
        /// <summary> The display name of the policy assignment. </summary>
        public string DisplayName { get; set; }
        /// <summary> The ID of the policy definition or policy set definition being assigned. </summary>
        public string PolicyDefinitionId { get; set; }
        /// <summary> The scope for the policy assignment. </summary>
        public string Scope { get; }
        /// <summary> The policy's excluded scopes. </summary>
        public IList<string> ExcludedScopes { get; }
        /// <summary> The parameter values for the assigned policy rule. The keys are the parameter names. </summary>
        public IDictionary<string, ArmPolicyParameterValue> Parameters { get; }
        /// <summary> This message will be part of response in case of policy violation. </summary>
        public string Description { get; set; }
        /// <summary>
        /// The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Metadata { get; set; }
        /// <summary> The policy assignment enforcement mode. Possible values are Default and DoNotEnforce. </summary>
        public EnforcementMode? EnforcementMode { get; set; }
        /// <summary> The messages that describe why a resource is non-compliant with the policy. </summary>
        public IList<NonComplianceMessage> NonComplianceMessages { get; }
        /// <summary> The resource selector list to filter policies by resource properties. </summary>
        public IList<ResourceSelector> ResourceSelectors { get; }
        /// <summary> The policy property value override. </summary>
        public IList<PolicyOverride> Overrides { get; }
    }
}
