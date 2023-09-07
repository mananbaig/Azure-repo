// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 specific provider input. </summary>
    public partial class InMageAzureV2ReprotectContent : ReverseReplicationProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ReprotectContent"/>. </summary>
        public InMageAzureV2ReprotectContent()
        {
            DisksToInclude = new ChangeTrackingList<string>();
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ReprotectContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="masterTargetId"> The Master target Id. </param>
        /// <param name="processServerId"> The Process Server Id. </param>
        /// <param name="storageAccountId"> The storage account id. </param>
        /// <param name="runAsAccountId"> The CS account Id. </param>
        /// <param name="policyId"> The Policy Id. </param>
        /// <param name="logStorageAccountId"> The storage account to be used for logging during replication. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2ReprotectContent(string instanceType, string masterTargetId, Guid? processServerId, ResourceIdentifier storageAccountId, string runAsAccountId, ResourceIdentifier policyId, ResourceIdentifier logStorageAccountId, IList<string> disksToInclude, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            StorageAccountId = storageAccountId;
            RunAsAccountId = runAsAccountId;
            PolicyId = policyId;
            LogStorageAccountId = logStorageAccountId;
            DisksToInclude = disksToInclude;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> The Master target Id. </summary>
        public string MasterTargetId { get; set; }
        /// <summary> The Process Server Id. </summary>
        public Guid? ProcessServerId { get; set; }
        /// <summary> The storage account id. </summary>
        public ResourceIdentifier StorageAccountId { get; set; }
        /// <summary> The CS account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> The Policy Id. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary> The storage account to be used for logging during replication. </summary>
        public ResourceIdentifier LogStorageAccountId { get; set; }
        /// <summary> The disks to include list. </summary>
        public IList<string> DisksToInclude { get; }
    }
}
