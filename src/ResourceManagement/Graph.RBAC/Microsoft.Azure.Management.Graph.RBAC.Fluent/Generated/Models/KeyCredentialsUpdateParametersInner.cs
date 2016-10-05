// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Request parameters for  KeyCredentials update operation
    /// </summary>
    public partial class KeyCredentialsUpdateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// KeyCredentialsUpdateParametersInner class.
        /// </summary>
        public KeyCredentialsUpdateParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// KeyCredentialsUpdateParametersInner class.
        /// </summary>
        /// <param name="value">KeyCredential list.</param>
        public KeyCredentialsUpdateParametersInner(System.Collections.Generic.IList<KeyCredential> value = default(System.Collections.Generic.IList<KeyCredential>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets keyCredential list.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<KeyCredential> Value { get; set; }

    }
}
