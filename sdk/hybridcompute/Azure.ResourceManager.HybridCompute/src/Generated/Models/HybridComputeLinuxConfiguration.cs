// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Specifies the linux configuration for update management. </summary>
    public partial class HybridComputeLinuxConfiguration
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

        /// <summary> Initializes a new instance of <see cref="HybridComputeLinuxConfiguration"/>. </summary>
        public HybridComputeLinuxConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeLinuxConfiguration"/>. </summary>
        /// <param name="assessmentMode"> Specifies the assessment mode. </param>
        /// <param name="patchMode"> Specifies the patch mode. </param>
        /// <param name="isHotpatchingEnabled"> Captures the hotpatch capability enrollment intent of the customers, which enables customers to patch their Windows machines without requiring a reboot. </param>
        /// <param name="status"> Status of the hotpatch capability enrollment or disenrollment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridComputeLinuxConfiguration(AssessmentModeType? assessmentMode, PatchModeType? patchMode, bool? isHotpatchingEnabled, HybridComputePatchSettingsStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssessmentMode = assessmentMode;
            PatchMode = patchMode;
            IsHotpatchingEnabled = isHotpatchingEnabled;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the assessment mode. </summary>
        [WirePath("patchSettings.assessmentMode")]
        public AssessmentModeType? AssessmentMode { get; set; }
        /// <summary> Specifies the patch mode. </summary>
        [WirePath("patchSettings.patchMode")]
        public PatchModeType? PatchMode { get; set; }
        /// <summary> Captures the hotpatch capability enrollment intent of the customers, which enables customers to patch their Windows machines without requiring a reboot. </summary>
        [WirePath("patchSettings.enableHotpatching")]
        public bool? IsHotpatchingEnabled { get; set; }
        /// <summary> Status of the hotpatch capability enrollment or disenrollment. </summary>
        [WirePath("patchSettings.status")]
        public HybridComputePatchSettingsStatus Status { get; }
    }
}
