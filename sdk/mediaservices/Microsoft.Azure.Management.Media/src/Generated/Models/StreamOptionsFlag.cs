// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for StreamOptionsFlag.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(StreamOptionsFlagConverter))]
    public struct StreamOptionsFlag : System.IEquatable<StreamOptionsFlag>
    {
        private StreamOptionsFlag(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Live streaming with no special latency optimizations.
        /// </summary>
        public static readonly StreamOptionsFlag Default = "Default";

        /// <summary>
        /// The live event provides lower end to end latency by reducing its
        /// internal buffers.
        /// </summary>
        public static readonly StreamOptionsFlag LowLatency = "LowLatency";

        /// <summary>
        /// The live event is optimized for end to end latency. This option is
        /// only available for encoding live events with RTMP input. The
        /// outputs can be streamed using HLS or DASH formats. The outputs'
        /// archive or DVR rewind length is limited to 6 hours. Use
        /// "LowLatency" stream option for all other scenarios.
        /// </summary>
        public static readonly StreamOptionsFlag LowLatencyV2 = "LowLatencyV2";


        /// <summary>
        /// Underlying value of enum StreamOptionsFlag
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for StreamOptionsFlag
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type StreamOptionsFlag
        /// </summary>
        public bool Equals(StreamOptionsFlag e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to StreamOptionsFlag
        /// </summary>
        public static implicit operator StreamOptionsFlag(string value)
        {
            return new StreamOptionsFlag(value);
        }

        /// <summary>
        /// Implicit operator to convert StreamOptionsFlag to string
        /// </summary>
        public static implicit operator string(StreamOptionsFlag e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum StreamOptionsFlag
        /// </summary>
        public static bool operator == (StreamOptionsFlag e1, StreamOptionsFlag e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum StreamOptionsFlag
        /// </summary>
        public static bool operator != (StreamOptionsFlag e1, StreamOptionsFlag e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for StreamOptionsFlag
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is StreamOptionsFlag && Equals((StreamOptionsFlag)obj);
        }

        /// <summary>
        /// Returns for hashCode StreamOptionsFlag
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
