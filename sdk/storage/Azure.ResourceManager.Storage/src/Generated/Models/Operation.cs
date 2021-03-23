// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Storage REST API operation definition. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        internal Operation()
        {
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="name"> Operation name: {provider}/{resource}/{operation}. </param>
        /// <param name="display"> Display metadata associated with the operation. </param>
        /// <param name="origin"> The origin of operations. </param>
        /// <param name="serviceSpecification"> One property of operation, include metric specifications. </param>
        internal Operation(string name, OperationDisplay display, string origin, ServiceSpecification serviceSpecification)
        {
            Name = name;
            Display = display;
            Origin = origin;
            ServiceSpecification = serviceSpecification;
        }

        /// <summary> Operation name: {provider}/{resource}/{operation}. </summary>
        public string Name { get; }
        /// <summary> Display metadata associated with the operation. </summary>
        public OperationDisplay Display { get; }
        /// <summary> The origin of operations. </summary>
        public string Origin { get; }
        /// <summary> One property of operation, include metric specifications. </summary>
        public ServiceSpecification ServiceSpecification { get; }
    }
}
