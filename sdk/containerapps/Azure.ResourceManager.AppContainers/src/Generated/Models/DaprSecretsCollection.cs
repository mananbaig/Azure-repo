// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Dapr component Secrets Collection for ListSecrets Action. </summary>
    internal partial class DaprSecretsCollection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DaprSecretsCollection"/>. </summary>
        /// <param name="value"> Collection of secrets used by a Dapr component. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DaprSecretsCollection(IEnumerable<ContainerAppDaprSecret> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DaprSecretsCollection"/>. </summary>
        /// <param name="value"> Collection of secrets used by a Dapr component. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DaprSecretsCollection(IReadOnlyList<ContainerAppDaprSecret> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DaprSecretsCollection"/> for deserialization. </summary>
        internal DaprSecretsCollection()
        {
        }

        /// <summary> Collection of secrets used by a Dapr component. </summary>
        public IReadOnlyList<ContainerAppDaprSecret> Value { get; }
    }
}
