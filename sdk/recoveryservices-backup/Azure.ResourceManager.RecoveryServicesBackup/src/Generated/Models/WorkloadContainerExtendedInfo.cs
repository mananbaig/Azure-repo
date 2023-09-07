// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Extended information of the container. </summary>
    public partial class WorkloadContainerExtendedInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadContainerExtendedInfo"/>. </summary>
        public WorkloadContainerExtendedInfo()
        {
            NodesList = new ChangeTrackingList<DistributedNodesInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadContainerExtendedInfo"/>. </summary>
        /// <param name="hostServerName"> Host Os Name in case of Stand Alone and Cluster Name in case of distributed container. </param>
        /// <param name="inquiryInfo"> Inquiry Status for the container. </param>
        /// <param name="nodesList"> List of the nodes in case of distributed container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadContainerExtendedInfo(string hostServerName, WorkloadContainerInquiryInfo inquiryInfo, IList<DistributedNodesInfo> nodesList, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HostServerName = hostServerName;
            InquiryInfo = inquiryInfo;
            NodesList = nodesList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Host Os Name in case of Stand Alone and Cluster Name in case of distributed container. </summary>
        public string HostServerName { get; set; }
        /// <summary> Inquiry Status for the container. </summary>
        public WorkloadContainerInquiryInfo InquiryInfo { get; set; }
        /// <summary> List of the nodes in case of distributed container. </summary>
        public IList<DistributedNodesInfo> NodesList { get; }
    }
}
