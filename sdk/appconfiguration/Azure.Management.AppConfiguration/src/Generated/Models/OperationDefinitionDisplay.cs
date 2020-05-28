// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.AppConfiguration.Models
{
    /// <summary> The display information for a configuration store operation. </summary>
    public partial class OperationDefinitionDisplay
    {
        /// <summary> Initializes a new instance of OperationDefinitionDisplay. </summary>
        internal OperationDefinitionDisplay()
        {
        }

        /// <summary> Initializes a new instance of OperationDefinitionDisplay. </summary>
        /// <param name="provider"> The resource provider name: Microsoft App Configuration.&quot;. </param>
        /// <param name="resource"> The resource on which the operation is performed. </param>
        /// <param name="operation"> The operation that users can perform. </param>
        /// <param name="description"> The description for the operation. </param>
        internal OperationDefinitionDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> The resource provider name: Microsoft App Configuration.&quot;. </summary>
        public string Provider { get; }
        /// <summary> The resource on which the operation is performed. </summary>
        public string Resource { get; }
        /// <summary> The operation that users can perform. </summary>
        public string Operation { get; }
        /// <summary> The description for the operation. </summary>
        public string Description { get; }
    }
}
