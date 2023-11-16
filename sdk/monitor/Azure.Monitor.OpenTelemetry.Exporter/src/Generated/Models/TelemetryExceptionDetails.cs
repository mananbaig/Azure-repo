// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Exception details of the exception in a chain. </summary>
    internal partial class TelemetryExceptionDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TelemetryExceptionDetails"/>. </summary>
        /// <param name="message"> Exception message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public TelemetryExceptionDetails(string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
            ParsedStack = new ChangeTrackingList<StackFrame>();
        }

        /// <summary> Initializes a new instance of <see cref="TelemetryExceptionDetails"/>. </summary>
        /// <param name="id"> In case exception is nested (outer exception contains inner one), the id and outerId properties are used to represent the nesting. </param>
        /// <param name="outerId"> The value of outerId is a reference to an element in ExceptionDetails that represents the outer exception. </param>
        /// <param name="typeName"> Exception type name. </param>
        /// <param name="message"> Exception message. </param>
        /// <param name="hasFullStack"> Indicates if full exception stack is provided in the exception. The stack may be trimmed, such as in the case of a StackOverflow exception. </param>
        /// <param name="stack"> Text describing the stack. Either stack or parsedStack should have a value. </param>
        /// <param name="parsedStack"> List of stack frames. Either stack or parsedStack should have a value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TelemetryExceptionDetails(int? id, int? outerId, string typeName, string message, bool? hasFullStack, string stack, IList<StackFrame> parsedStack, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            OuterId = outerId;
            TypeName = typeName;
            Message = message;
            HasFullStack = hasFullStack;
            Stack = stack;
            ParsedStack = parsedStack;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TelemetryExceptionDetails"/> for deserialization. </summary>
        internal TelemetryExceptionDetails()
        {
        }

        /// <summary> In case exception is nested (outer exception contains inner one), the id and outerId properties are used to represent the nesting. </summary>
        public int? Id { get; set; }
        /// <summary> The value of outerId is a reference to an element in ExceptionDetails that represents the outer exception. </summary>
        public int? OuterId { get; set; }
        /// <summary> Exception type name. </summary>
        public string TypeName { get; set; }
        /// <summary> Exception message. </summary>
        public string Message { get; }
        /// <summary> Indicates if full exception stack is provided in the exception. The stack may be trimmed, such as in the case of a StackOverflow exception. </summary>
        public bool? HasFullStack { get; set; }
        /// <summary> Text describing the stack. Either stack or parsedStack should have a value. </summary>
        public string Stack { get; set; }
        /// <summary> List of stack frames. Either stack or parsedStack should have a value. </summary>
        public IList<StackFrame> ParsedStack { get; }
    }
}
