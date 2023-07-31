// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> The result of listing the subtasks of a Task. </summary>
    public partial class CloudTaskListSubtasksResult
    {
        /// <summary> Initializes a new instance of CloudTaskListSubtasksResult. </summary>
        internal CloudTaskListSubtasksResult()
        {
            Value = new ChangeTrackingList<SubtaskInformation>();
        }

        /// <summary> Initializes a new instance of CloudTaskListSubtasksResult. </summary>
        /// <param name="value"> The list of subtasks. </param>
        internal CloudTaskListSubtasksResult(IReadOnlyList<SubtaskInformation> value)
        {
            Value = value;
        }

        /// <summary> The list of subtasks. </summary>
        public IReadOnlyList<SubtaskInformation> Value { get; }
    }
}
