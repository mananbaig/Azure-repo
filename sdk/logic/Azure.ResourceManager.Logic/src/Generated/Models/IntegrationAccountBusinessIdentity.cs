// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration account partner&apos;s business identity. </summary>
    public partial class IntegrationAccountBusinessIdentity
    {
        /// <summary> Initializes a new instance of IntegrationAccountBusinessIdentity. </summary>
        /// <param name="qualifier"> The business identity qualifier e.g. as2identity, ZZ, ZZZ, 31, 32. </param>
        /// <param name="value"> The user defined business identity value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="qualifier"/> or <paramref name="value"/> is null. </exception>
        public IntegrationAccountBusinessIdentity(string qualifier, string value)
        {
            if (qualifier == null)
            {
                throw new ArgumentNullException(nameof(qualifier));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Qualifier = qualifier;
            Value = value;
        }

        /// <summary> The business identity qualifier e.g. as2identity, ZZ, ZZZ, 31, 32. </summary>
        public string Qualifier { get; set; }
        /// <summary> The user defined business identity value. </summary>
        public string Value { get; set; }
    }
}
