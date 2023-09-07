// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Settings for Extended Groups username and group download. </summary>
    public partial class StorageCacheUsernameDownloadSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheUsernameDownloadSettings"/>. </summary>
        public StorageCacheUsernameDownloadSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheUsernameDownloadSettings"/>. </summary>
        /// <param name="enableExtendedGroups"> Whether or not Extended Groups is enabled. </param>
        /// <param name="usernameSource"> This setting determines how the cache gets username and group names for clients. </param>
        /// <param name="groupFileUri"> The URI of the file containing group information (in /etc/group file format). This field must be populated when 'usernameSource' is set to 'File'. </param>
        /// <param name="userFileUri"> The URI of the file containing user information (in /etc/passwd file format). This field must be populated when 'usernameSource' is set to 'File'. </param>
        /// <param name="ldapServer"> The fully qualified domain name or IP address of the LDAP server to use. </param>
        /// <param name="ldapBaseDN"> The base distinguished name for the LDAP domain. </param>
        /// <param name="encryptLdapConnection"> Whether or not the LDAP connection should be encrypted. </param>
        /// <param name="requireValidCertificate"> Determines if the certificates must be validated by a certificate authority. When true, caCertificateURI must be provided. </param>
        /// <param name="autoDownloadCertificate"> Determines if the certificate should be automatically downloaded. This applies to 'caCertificateURI' only if 'requireValidCertificate' is true. </param>
        /// <param name="caCertificateUri"> The URI of the CA certificate to validate the LDAP secure connection. This field must be populated when 'requireValidCertificate' is set to true. </param>
        /// <param name="usernameDownloaded"> Indicates whether or not the HPC Cache has performed the username download successfully. </param>
        /// <param name="credentials"> When present, these are the credentials for the secure LDAP connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheUsernameDownloadSettings(bool? enableExtendedGroups, StorageCacheUsernameSourceType? usernameSource, Uri groupFileUri, Uri userFileUri, string ldapServer, string ldapBaseDN, bool? encryptLdapConnection, bool? requireValidCertificate, bool? autoDownloadCertificate, Uri caCertificateUri, StorageCacheUsernameDownloadedType? usernameDownloaded, StorageCacheUsernameDownloadCredential credentials, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnableExtendedGroups = enableExtendedGroups;
            UsernameSource = usernameSource;
            GroupFileUri = groupFileUri;
            UserFileUri = userFileUri;
            LdapServer = ldapServer;
            LdapBaseDN = ldapBaseDN;
            EncryptLdapConnection = encryptLdapConnection;
            RequireValidCertificate = requireValidCertificate;
            AutoDownloadCertificate = autoDownloadCertificate;
            CaCertificateUri = caCertificateUri;
            UsernameDownloaded = usernameDownloaded;
            Credentials = credentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether or not Extended Groups is enabled. </summary>
        public bool? EnableExtendedGroups { get; set; }
        /// <summary> This setting determines how the cache gets username and group names for clients. </summary>
        public StorageCacheUsernameSourceType? UsernameSource { get; set; }
        /// <summary> The URI of the file containing group information (in /etc/group file format). This field must be populated when 'usernameSource' is set to 'File'. </summary>
        public Uri GroupFileUri { get; set; }
        /// <summary> The URI of the file containing user information (in /etc/passwd file format). This field must be populated when 'usernameSource' is set to 'File'. </summary>
        public Uri UserFileUri { get; set; }
        /// <summary> The fully qualified domain name or IP address of the LDAP server to use. </summary>
        public string LdapServer { get; set; }
        /// <summary> The base distinguished name for the LDAP domain. </summary>
        public string LdapBaseDN { get; set; }
        /// <summary> Whether or not the LDAP connection should be encrypted. </summary>
        public bool? EncryptLdapConnection { get; set; }
        /// <summary> Determines if the certificates must be validated by a certificate authority. When true, caCertificateURI must be provided. </summary>
        public bool? RequireValidCertificate { get; set; }
        /// <summary> Determines if the certificate should be automatically downloaded. This applies to 'caCertificateURI' only if 'requireValidCertificate' is true. </summary>
        public bool? AutoDownloadCertificate { get; set; }
        /// <summary> The URI of the CA certificate to validate the LDAP secure connection. This field must be populated when 'requireValidCertificate' is set to true. </summary>
        public Uri CaCertificateUri { get; set; }
        /// <summary> Indicates whether or not the HPC Cache has performed the username download successfully. </summary>
        public StorageCacheUsernameDownloadedType? UsernameDownloaded { get; }
        /// <summary> When present, these are the credentials for the secure LDAP connection. </summary>
        public StorageCacheUsernameDownloadCredential Credentials { get; set; }
    }
}
