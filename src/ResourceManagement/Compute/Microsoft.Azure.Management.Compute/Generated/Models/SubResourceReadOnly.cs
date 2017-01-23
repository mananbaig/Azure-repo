// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    public partial class SubResourceReadOnly : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the SubResourceReadOnly class.
        /// </summary>
        public SubResourceReadOnly() { }

        /// <summary>
        /// Initializes a new instance of the SubResourceReadOnly class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        public SubResourceReadOnly(string id = default(string))
        {
            Id = id;
        }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
