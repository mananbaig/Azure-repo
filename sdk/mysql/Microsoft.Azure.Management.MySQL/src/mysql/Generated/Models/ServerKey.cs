// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A MySQL Server key.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerKey : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerKey class.
        /// </summary>
        public ServerKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerKey class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="kind">Kind of encryption protector used to protect the
        /// key.</param>
        /// <param name="uri">The URI of the key.</param>
        /// <param name="creationDate">The key creation date.</param>
        public ServerKey(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string uri = default(string), System.DateTime? creationDate = default(System.DateTime?))
            : base(id, name, type)
        {
            Kind = kind;
            Uri = uri;
            CreationDate = creationDate;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ServerKey class.
        /// </summary>
        static ServerKey()
        {
            ServerKeyType = "AzureKeyVault";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets kind of encryption protector used to protect the key.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets or sets the URI of the key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets the key creation date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// The key type like 'AzureKeyVault'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverKeyType")]
        public static string ServerKeyType { get; private set; }

    }
}
