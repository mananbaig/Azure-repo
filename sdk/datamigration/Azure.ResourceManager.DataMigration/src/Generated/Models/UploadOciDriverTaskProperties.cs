// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that uploads an OCI driver. </summary>
    public partial class UploadOciDriverTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of UploadOciDriverTaskProperties. </summary>
        public UploadOciDriverTaskProperties()
        {
            Output = new ChangeTrackingList<UploadOciDriverTaskOutput>();
            TaskType = TaskType.ServiceUploadOci;
        }

        /// <summary> Initializes a new instance of UploadOciDriverTaskProperties. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Input for the service task to upload an OCI driver. </param>
        /// <param name="output"> Task output. This is ignored if submitted. </param>
        internal UploadOciDriverTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, UploadOciDriverTaskInput input, IReadOnlyList<UploadOciDriverTaskOutput> output) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Input for the service task to upload an OCI driver. </summary>
        internal UploadOciDriverTaskInput Input { get; set; }
        /// <summary> File share information for the OCI driver archive. </summary>
        public FileShare InputDriverShare
        {
            get => Input is null ? default : Input.DriverShare;
            set
            {
                if (Input is null)
                    Input = new UploadOciDriverTaskInput();
                Input.DriverShare = value;
            }
        }

        /// <summary> Task output. This is ignored if submitted. </summary>
        public IReadOnlyList<UploadOciDriverTaskOutput> Output { get; }
    }
}
