// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The participant property reference. </summary>
    public partial class ParticipantPropertyReference
    {
        /// <summary> Initializes a new instance of ParticipantPropertyReference. </summary>
        /// <param name="sourcePropertyName"> The source property that maps to the target property. </param>
        /// <param name="targetPropertyName"> The target property that maps to the source property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourcePropertyName"/> or <paramref name="targetPropertyName"/> is null. </exception>
        public ParticipantPropertyReference(string sourcePropertyName, string targetPropertyName)
        {
            if (sourcePropertyName == null)
            {
                throw new ArgumentNullException(nameof(sourcePropertyName));
            }
            if (targetPropertyName == null)
            {
                throw new ArgumentNullException(nameof(targetPropertyName));
            }

            SourcePropertyName = sourcePropertyName;
            TargetPropertyName = targetPropertyName;
        }

        /// <summary> The source property that maps to the target property. </summary>
        public string SourcePropertyName { get; set; }
        /// <summary> The target property that maps to the source property. </summary>
        public string TargetPropertyName { get; set; }
    }
}
