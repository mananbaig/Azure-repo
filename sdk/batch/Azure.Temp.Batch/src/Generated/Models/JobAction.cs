// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Temp.Batch.Models
{
    /// <summary> The default is none for exit code 0 and terminate for all other exit conditions. If the Job's onTaskFailed property is noaction, then specifying this property returns an error and the add Task request fails with an invalid property value error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
    public enum JobAction
    {
        /// <summary> Take no action. </summary>
        None,
        /// <summary> Disable the Job. This is equivalent to calling the disable Job API, with a disableTasks value of requeue. </summary>
        Disable,
        /// <summary> Terminate the Job. The terminateReason in the Job's executionInfo is set to "TaskFailed". </summary>
        Terminate
    }
}
