// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Software update configuration machine run job navigation properties. </summary>
    internal partial class JobNavigation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="JobNavigation"/>. </summary>
        internal JobNavigation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="JobNavigation"/>. </summary>
        /// <param name="id"> Id of the job associated with the software update configuration run. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal JobNavigation(Guid? id, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            _rawData = rawData;
        }

        /// <summary> Id of the job associated with the software update configuration run. </summary>
        public Guid? Id { get; }
    }
}
