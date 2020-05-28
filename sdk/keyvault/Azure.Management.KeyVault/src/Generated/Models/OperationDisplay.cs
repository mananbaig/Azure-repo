// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.KeyVault.Models
{
    /// <summary> Display metadata associated with the operation. </summary>
    public partial class OperationDisplay
    {
        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        internal OperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        /// <param name="provider"> Service provider: Microsoft Key Vault. </param>
        /// <param name="resource"> Resource on which the operation is performed etc. </param>
        /// <param name="operation"> Type of operation: get, read, delete, etc. </param>
        /// <param name="description"> Description of operation. </param>
        internal OperationDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> Service provider: Microsoft Key Vault. </summary>
        public string Provider { get; }
        /// <summary> Resource on which the operation is performed etc. </summary>
        public string Resource { get; }
        /// <summary> Type of operation: get, read, delete, etc. </summary>
        public string Operation { get; }
        /// <summary> Description of operation. </summary>
        public string Description { get; }
    }
}
