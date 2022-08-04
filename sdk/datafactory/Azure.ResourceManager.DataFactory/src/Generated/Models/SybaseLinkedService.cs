// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for Sybase data source. </summary>
    public partial class SybaseLinkedService : FactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of SybaseLinkedService. </summary>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="database"/> is null. </exception>
        public SybaseLinkedService(BinaryData server, BinaryData database)
        {
            if (server == null)
            {
                throw new ArgumentNullException(nameof(server));
            }
            if (database == null)
            {
                throw new ArgumentNullException(nameof(database));
            }

            Server = server;
            Database = database;
            LinkedServiceType = "Sybase";
        }

        /// <summary> Initializes a new instance of SybaseLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="schema"> Schema name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for authentication.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SybaseLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData server, BinaryData database, BinaryData schema, SybaseAuthenticationType? authenticationType, BinaryData username, FactorySecretBaseDefinition password, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Database = database;
            Schema = schema;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Sybase";
        }

        /// <summary> Server name for connection. Type: string (or Expression with resultType string). </summary>
        public BinaryData Server { get; set; }
        /// <summary> Database name for connection. Type: string (or Expression with resultType string). </summary>
        public BinaryData Database { get; set; }
        /// <summary> Schema name for connection. Type: string (or Expression with resultType string). </summary>
        public BinaryData Schema { get; set; }
        /// <summary> AuthenticationType to be used for connection. </summary>
        public SybaseAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public BinaryData Username { get; set; }
        /// <summary>
        /// Password for authentication.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
