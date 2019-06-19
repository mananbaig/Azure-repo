// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TaskExecutionResult.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskExecutionResult
    {
        /// <summary>
        /// The task ran successfully.
        /// </summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>
        /// There was an error during processing of the task. The failure may
        /// have occurred before the task process was launched, while the task
        /// process was executing, or after the task process exited.
        /// </summary>
        [EnumMember(Value = "failure")]
        Failure
    }
    internal static class TaskExecutionResultEnumExtension
    {
        internal static string ToSerializedValue(this TaskExecutionResult? value)
        {
            return value == null ? null : ((TaskExecutionResult)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskExecutionResult value)
        {
            switch( value )
            {
                case TaskExecutionResult.Success:
                    return "success";
                case TaskExecutionResult.Failure:
                    return "failure";
            }
            return null;
        }

        internal static TaskExecutionResult? ParseTaskExecutionResult(this string value)
        {
            switch( value )
            {
                case "success":
                    return TaskExecutionResult.Success;
                case "failure":
                    return TaskExecutionResult.Failure;
            }
            return null;
        }
    }
}
