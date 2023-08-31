// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that migrates MySQL databases to Azure Database for MySQL for offline migrations. </summary>
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskProperties"/>. </summary>
        public MigrateMySqlAzureDBForMySqlOfflineTaskProperties()
        {
            Output = new ChangeTrackingList<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>();
            TaskType = TaskType.MigrateMySqlAzureDBForMySql;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskProperties"/>. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Task input. </param>
        /// <param name="output">
        /// Task output. This is ignored if submitted.
        /// Please note <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputError"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel"/> and <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel"/>.
        /// </param>
        /// <param name="isCloneable"> whether the task can be cloned or not. </param>
        /// <param name="taskId"> Task id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateMySqlAzureDBForMySqlOfflineTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, MigrateMySqlAzureDBForMySqlOfflineTaskInput input, IReadOnlyList<MigrateMySqlAzureDBForMySqlOfflineTaskOutput> output, bool? isCloneable, string taskId, Dictionary<string, BinaryData> rawData) : base(taskType, errors, state, commands, clientData, rawData)
        {
            Input = input;
            Output = output;
            IsCloneable = isCloneable;
            TaskId = taskId;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public MigrateMySqlAzureDBForMySqlOfflineTaskInput Input { get; set; }
        /// <summary>
        /// Task output. This is ignored if submitted.
        /// Please note <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputError"/>, <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel"/> and <see cref="MigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel"/>.
        /// </summary>
        public IReadOnlyList<MigrateMySqlAzureDBForMySqlOfflineTaskOutput> Output { get; }
        /// <summary> whether the task can be cloned or not. </summary>
        public bool? IsCloneable { get; set; }
        /// <summary> Task id. </summary>
        public string TaskId { get; set; }
    }
}
