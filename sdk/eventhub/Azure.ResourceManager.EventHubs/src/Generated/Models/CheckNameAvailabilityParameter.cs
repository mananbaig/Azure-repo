// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Parameter supplied to check Namespace name availability operation. </summary>
    public partial class CheckNameAvailabilityParameter
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilityParameter. </summary>
        /// <param name="name"> Name to check the namespace name availability. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CheckNameAvailabilityParameter(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Name to check the namespace name availability. </summary>
        public string Name { get; }
    }
}
