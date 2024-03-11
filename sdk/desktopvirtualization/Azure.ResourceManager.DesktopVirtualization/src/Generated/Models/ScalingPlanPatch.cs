// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Scaling plan properties that can be patched. </summary>
    public partial class ScalingPlanPatch
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

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPatch"/>. </summary>
        public ScalingPlanPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Schedules = new ChangeTrackingList<ScalingSchedule>();
            HostPoolReferences = new ChangeTrackingList<ScalingHostPoolReference>();
        }

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPatch"/>. </summary>
        /// <param name="tags"> tags to be updated. </param>
        /// <param name="description"> Description of scaling plan. </param>
        /// <param name="friendlyName"> User friendly name of scaling plan. </param>
        /// <param name="timeZone"> Timezone of the scaling plan. </param>
        /// <param name="exclusionTag"> Exclusion tag for scaling plan. </param>
        /// <param name="schedules"> List of ScalingSchedule definitions. </param>
        /// <param name="hostPoolReferences"> List of ScalingHostPoolReference definitions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScalingPlanPatch(IDictionary<string, string> tags, string description, string friendlyName, string timeZone, string exclusionTag, IList<ScalingSchedule> schedules, IList<ScalingHostPoolReference> hostPoolReferences, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Description = description;
            FriendlyName = friendlyName;
            TimeZone = timeZone;
            ExclusionTag = exclusionTag;
            Schedules = schedules;
            HostPoolReferences = hostPoolReferences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Description of scaling plan. </summary>
        public string Description { get; set; }
        /// <summary> User friendly name of scaling plan. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Timezone of the scaling plan. </summary>
        public string TimeZone { get; set; }
        /// <summary> Exclusion tag for scaling plan. </summary>
        public string ExclusionTag { get; set; }
        /// <summary> List of ScalingSchedule definitions. </summary>
        public IList<ScalingSchedule> Schedules { get; }
        /// <summary> List of ScalingHostPoolReference definitions. </summary>
        public IList<ScalingHostPoolReference> HostPoolReferences { get; }
    }
}
