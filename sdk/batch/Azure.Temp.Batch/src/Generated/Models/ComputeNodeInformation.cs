// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Temp.Batch.Models
{
    /// <summary> Information about the Compute Node on which a Task ran. </summary>
    public partial class ComputeNodeInformation
    {
        /// <summary> Initializes a new instance of ComputeNodeInformation. </summary>
        internal ComputeNodeInformation()
        {
        }

        /// <summary> Initializes a new instance of ComputeNodeInformation. </summary>
        /// <param name="affinityId"> An identifier for the Node on which the Task ran, which can be passed when adding a Task to request that the Task be scheduled on this Compute Node. </param>
        /// <param name="nodeUrl"> The URL of the Compute Node on which the Task ran. </param>
        /// <param name="poolId"> The ID of the Pool on which the Task ran. </param>
        /// <param name="nodeId"> The ID of the Compute Node on which the Task ran. </param>
        /// <param name="taskRootDirectory"> The root directory of the Task on the Compute Node. </param>
        /// <param name="taskRootDirectoryUrl"> The URL to the root directory of the Task on the Compute Node. </param>
        internal ComputeNodeInformation(string affinityId, string nodeUrl, string poolId, string nodeId, string taskRootDirectory, string taskRootDirectoryUrl)
        {
            AffinityId = affinityId;
            NodeUrl = nodeUrl;
            PoolId = poolId;
            NodeId = nodeId;
            TaskRootDirectory = taskRootDirectory;
            TaskRootDirectoryUrl = taskRootDirectoryUrl;
        }

        /// <summary> An identifier for the Node on which the Task ran, which can be passed when adding a Task to request that the Task be scheduled on this Compute Node. </summary>
        public string AffinityId { get; }
        /// <summary> The URL of the Compute Node on which the Task ran. </summary>
        public string NodeUrl { get; }
        /// <summary> The ID of the Pool on which the Task ran. </summary>
        public string PoolId { get; }
        /// <summary> The ID of the Compute Node on which the Task ran. </summary>
        public string NodeId { get; }
        /// <summary> The root directory of the Task on the Compute Node. </summary>
        public string TaskRootDirectory { get; }
        /// <summary> The URL to the root directory of the Task on the Compute Node. </summary>
        public string TaskRootDirectoryUrl { get; }
    }
}
