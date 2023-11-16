// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> Looking glass output model. </summary>
    public partial class LookingGlassOutput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LookingGlassOutput"/>. </summary>
        internal LookingGlassOutput()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LookingGlassOutput"/>. </summary>
        /// <param name="command"> Invoked command. </param>
        /// <param name="output"> Output of the command. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LookingGlassOutput(LookingGlassCommand? command, string output, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Command = command;
            Output = output;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Invoked command. </summary>
        public LookingGlassCommand? Command { get; }
        /// <summary> Output of the command. </summary>
        public string Output { get; }
    }
}
