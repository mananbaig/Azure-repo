// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure SQL Database server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Server : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The Azure Active Directory identity of the
        /// server.</param>
        /// <param name="kind">Kind of sql server. This is metadata used for
        /// the Azure portal experience.</param>
        /// <param name="administratorLogin">Administrator username for the
        /// server. Once created it cannot be changed.</param>
        /// <param name="administratorLoginPassword">The administrator login
        /// password (required for server creation).</param>
        /// <param name="version">The version of the server.</param>
        /// <param name="state">The state of the server.</param>
        /// <param name="fullyQualifiedDomainName">The fully qualified domain
        /// name of the server.</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connections on a server</param>
        /// <param name="minimalTlsVersion">Minimal TLS version. Allowed
        /// values: '1.0', '1.1', '1.2'</param>
        /// <param name="publicNetworkAccess">Whether or not public endpoint
        /// access is allowed for this server.  Value is optional but if passed
        /// in, must be 'Enabled' or 'Disabled'. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="workspaceFeature">Whether or not existing server has a
        /// workspace created and if it allows connection from workspace.
        /// Possible values include: 'Connected', 'Disconnected'</param>
        /// <param name="primaryUserAssignedIdentityId">The resource id of a
        /// user assigned identity to be used by default.</param>
        /// <param name="federatedClientId">The Client id used for cross tenant
        /// CMK scenario</param>
        /// <param name="keyId">A CMK URI of the key to use for
        /// encryption.</param>
        /// <param name="administrators">The Azure Active Directory
        /// administrator of the server.</param>
        /// <param name="restrictOutboundNetworkAccess">Whether or not to
        /// restrict outbound network access for this server.  Value is
        /// optional but if passed in, must be 'Enabled' or 'Disabled'.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        public Server(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceIdentity identity = default(ResourceIdentity), string kind = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string), string version = default(string), string state = default(string), string fullyQualifiedDomainName = default(string), IList<ServerPrivateEndpointConnection> privateEndpointConnections = default(IList<ServerPrivateEndpointConnection>), string minimalTlsVersion = default(string), string publicNetworkAccess = default(string), string workspaceFeature = default(string), string primaryUserAssignedIdentityId = default(string), System.Guid? federatedClientId = default(System.Guid?), string keyId = default(string), ServerExternalAdministrator administrators = default(ServerExternalAdministrator), string restrictOutboundNetworkAccess = default(string))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            Kind = kind;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            State = state;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            PrivateEndpointConnections = privateEndpointConnections;
            MinimalTlsVersion = minimalTlsVersion;
            PublicNetworkAccess = publicNetworkAccess;
            WorkspaceFeature = workspaceFeature;
            PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
            FederatedClientId = federatedClientId;
            KeyId = keyId;
            Administrators = administrators;
            RestrictOutboundNetworkAccess = restrictOutboundNetworkAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory identity of the server.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets kind of sql server. This is metadata used for the Azure portal
        /// experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets or sets administrator username for the server. Once created it
        /// cannot be changed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the administrator login password (required for server
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets the version of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets the state of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain name of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets list of private endpoint connections on a server
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<ServerPrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets minimal TLS version. Allowed values: '1.0', '1.1',
        /// '1.2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimalTlsVersion")]
        public string MinimalTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets whether or not public endpoint access is allowed for
        /// this server.  Value is optional but if passed in, must be 'Enabled'
        /// or 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets whether or not existing server has a workspace created and if
        /// it allows connection from workspace. Possible values include:
        /// 'Connected', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceFeature")]
        public string WorkspaceFeature { get; private set; }

        /// <summary>
        /// Gets or sets the resource id of a user assigned identity to be used
        /// by default.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryUserAssignedIdentityId")]
        public string PrimaryUserAssignedIdentityId { get; set; }

        /// <summary>
        /// Gets or sets the Client id used for cross tenant CMK scenario
        /// </summary>
        [JsonProperty(PropertyName = "properties.federatedClientId")]
        public System.Guid? FederatedClientId { get; set; }

        /// <summary>
        /// Gets or sets a CMK URI of the key to use for encryption.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets the Azure Active Directory administrator of the
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.administrators")]
        public ServerExternalAdministrator Administrators { get; set; }

        /// <summary>
        /// Gets or sets whether or not to restrict outbound network access for
        /// this server.  Value is optional but if passed in, must be 'Enabled'
        /// or 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.restrictOutboundNetworkAccess")]
        public string RestrictOutboundNetworkAccess { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PrivateEndpointConnections != null)
            {
                foreach (var element in PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
