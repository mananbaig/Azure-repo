// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Azure Active Directory only authentication. </summary>
    public partial class ManagedInstanceAzureADOnlyAuthentication : ProxyResource
    {
        /// <summary> Initializes a new instance of ManagedInstanceAzureADOnlyAuthentication. </summary>
        public ManagedInstanceAzureADOnlyAuthentication()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceAzureADOnlyAuthentication. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="azureADOnlyAuthentication"> Azure Active Directory only Authentication enabled. </param>
        internal ManagedInstanceAzureADOnlyAuthentication(string id, string name, string type, bool? azureADOnlyAuthentication) : base(id, name, type)
        {
            AzureADOnlyAuthentication = azureADOnlyAuthentication;
        }

        /// <summary> Azure Active Directory only Authentication enabled. </summary>
        public bool? AzureADOnlyAuthentication { get; set; }
    }
}
