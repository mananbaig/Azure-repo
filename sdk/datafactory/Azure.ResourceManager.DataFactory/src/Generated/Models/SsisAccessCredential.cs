// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SSIS access credential. </summary>
    public partial class SsisAccessCredential
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SsisAccessCredential"/>. </summary>
        /// <param name="domain"> Domain for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> UseName for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public SsisAccessCredential(DataFactoryElement<string> domain, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password)
        {
            Argument.AssertNotNull(domain, nameof(domain));
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));

            Domain = domain;
            UserName = userName;
            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="SsisAccessCredential"/>. </summary>
        /// <param name="domain"> Domain for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> UseName for windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for windows authentication. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisAccessCredential(DataFactoryElement<string> domain, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, Dictionary<string, BinaryData> rawData)
        {
            Domain = domain;
            UserName = userName;
            Password = password;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SsisAccessCredential"/> for deserialization. </summary>
        internal SsisAccessCredential()
        {
        }

        /// <summary> Domain for windows authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Domain { get; set; }
        /// <summary> UseName for windows authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password for windows authentication. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
    }
}
