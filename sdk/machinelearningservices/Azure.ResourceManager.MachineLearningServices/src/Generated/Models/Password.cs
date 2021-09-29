// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The Password. </summary>
    public partial class Password
    {
        /// <summary> Initializes a new instance of Password. </summary>
        internal Password()
        {
        }

        /// <summary> Initializes a new instance of Password. </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        internal Password(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
    }
}
