// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> You can use Job Preparation to prepare a Node to run Tasks for the Job. Activities commonly performed in Job Preparation include: Downloading common resource files used by all the Tasks in the Job. The Job Preparation Task can download these common resource files to the shared location on the Node. (AZ_BATCH_NODE_ROOT_DIR\shared), or starting a local service on the Node so that all Tasks of that Job can communicate with it. If the Job Preparation Task fails (that is, exhausts its retry count before exiting with exit code 0), Batch will not run Tasks of this Job on the Node. The Compute Node remains ineligible to run Tasks of this Job until it is reimaged. The Compute Node remains active and can be used for other Jobs. The Job Preparation Task can run multiple times on the same Node. Therefore, you should write the Job Preparation Task to handle re-execution. If the Node is rebooted, the Job Preparation Task is run again on the Compute Node before scheduling any other Task of the Job, if rerunOnNodeRebootAfterSuccess is true or if the Job Preparation Task did not previously complete. If the Node is reimaged, the Job Preparation Task is run again before scheduling any Task of the Job. Batch will retry Tasks when a recovery operation is triggered on a Node. Examples of recovery operations include (but are not limited to) when an unhealthy Node is rebooted or a Compute Node disappeared due to host failure. Retries due to recovery operations are independent of and are not counted against the maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal retry due to a recovery operation may occur. Because of this, all Tasks should be idempotent. This means Tasks need to tolerate being interrupted and restarted without causing any corruption or duplicate data. The best practice for long running Tasks is to use some form of checkpointing. </summary>
    public partial class JobPreparationTask
    {
        /// <summary> Initializes a new instance of JobPreparationTask. </summary>
        /// <param name="commandLine"> The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commandLine"/> is null. </exception>
        public JobPreparationTask(string commandLine)
        {
            Argument.AssertNotNull(commandLine, nameof(commandLine));

            CommandLine = commandLine;
            ResourceFiles = new ChangeTrackingList<ResourceFile>();
            EnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
        }

        /// <summary> Initializes a new instance of JobPreparationTask. </summary>
        /// <param name="id"> The ID can contain any combination of alphanumeric characters including hyphens and underscores and cannot contain more than 64 characters. If you do not specify this property, the Batch service assigns a default value of 'jobpreparation'. No other Task in the Job can have the same ID as the Job Preparation Task. If you try to submit a Task with the same id, the Batch service rejects the request with error code TaskIdSameAsJobPreparationTask; if you are calling the REST API directly, the HTTP status code is 409 (Conflict). </param>
        /// <param name="commandLine"> The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <param name="containerSettings"> When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </param>
        /// <param name="resourceFiles"> Files listed under this element are located in the Task's working directory.  There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. </param>
        /// <param name="environmentSettings"> A list of environment variable settings for the Job Preparation Task. </param>
        /// <param name="constraints"> Execution constraints to apply to a Task. </param>
        /// <param name="waitForSuccess"> If true and the Job Preparation Task fails on a Node, the Batch service retries the Job Preparation Task up to its maximum retry count (as specified in the constraints element). If the Task has still not completed successfully after all retries, then the Batch service will not schedule Tasks of the Job to the Node. The Node remains active and eligible to run Tasks of other Jobs. If false, the Batch service will not wait for the Job Preparation Task to complete. In this case, other Tasks of the Job can start executing on the Compute Node while the Job Preparation Task is still running; and even if the Job Preparation Task fails, new Tasks will continue to be scheduled on the Compute Node. The default value is true. </param>
        /// <param name="userIdentity"> If omitted, the Task runs as a non-administrative user unique to the Task on Windows Compute Nodes, or a non-administrative user unique to the Pool on Linux Compute Nodes. </param>
        /// <param name="rerunOnNodeRebootAfterSuccess"> The Job Preparation Task is always rerun if a Compute Node is reimaged, or if the Job Preparation Task did not complete (e.g. because the reboot occurred while the Task was running). Therefore, you should always write a Job Preparation Task to be idempotent and to behave correctly if run multiple times. The default value is true. </param>
        internal JobPreparationTask(string id, string commandLine, TaskContainerSettings containerSettings, IList<ResourceFile> resourceFiles, IList<EnvironmentSetting> environmentSettings, TaskConstraints constraints, bool? waitForSuccess, UserIdentity userIdentity, bool? rerunOnNodeRebootAfterSuccess)
        {
            Id = id;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            Constraints = constraints;
            WaitForSuccess = waitForSuccess;
            UserIdentity = userIdentity;
            RerunOnNodeRebootAfterSuccess = rerunOnNodeRebootAfterSuccess;
        }

        /// <summary> The ID can contain any combination of alphanumeric characters including hyphens and underscores and cannot contain more than 64 characters. If you do not specify this property, the Batch service assigns a default value of 'jobpreparation'. No other Task in the Job can have the same ID as the Job Preparation Task. If you try to submit a Task with the same id, the Batch service rejects the request with error code TaskIdSameAsJobPreparationTask; if you are calling the REST API directly, the HTTP status code is 409 (Conflict). </summary>
        public string Id { get; set; }
        /// <summary> The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </summary>
        public string CommandLine { get; set; }
        /// <summary> When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </summary>
        public TaskContainerSettings ContainerSettings { get; set; }
        /// <summary> Files listed under this element are located in the Task's working directory.  There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. </summary>
        public IList<ResourceFile> ResourceFiles { get; }
        /// <summary> A list of environment variable settings for the Job Preparation Task. </summary>
        public IList<EnvironmentSetting> EnvironmentSettings { get; }
        /// <summary> Execution constraints to apply to a Task. </summary>
        public TaskConstraints Constraints { get; set; }
        /// <summary> If true and the Job Preparation Task fails on a Node, the Batch service retries the Job Preparation Task up to its maximum retry count (as specified in the constraints element). If the Task has still not completed successfully after all retries, then the Batch service will not schedule Tasks of the Job to the Node. The Node remains active and eligible to run Tasks of other Jobs. If false, the Batch service will not wait for the Job Preparation Task to complete. In this case, other Tasks of the Job can start executing on the Compute Node while the Job Preparation Task is still running; and even if the Job Preparation Task fails, new Tasks will continue to be scheduled on the Compute Node. The default value is true. </summary>
        public bool? WaitForSuccess { get; set; }
        /// <summary> If omitted, the Task runs as a non-administrative user unique to the Task on Windows Compute Nodes, or a non-administrative user unique to the Pool on Linux Compute Nodes. </summary>
        public UserIdentity UserIdentity { get; set; }
        /// <summary> The Job Preparation Task is always rerun if a Compute Node is reimaged, or if the Job Preparation Task did not complete (e.g. because the reboot occurred while the Task was running). Therefore, you should always write a Job Preparation Task to be idempotent and to behave correctly if run multiple times. The default value is true. </summary>
        public bool? RerunOnNodeRebootAfterSuccess { get; set; }
    }
}
