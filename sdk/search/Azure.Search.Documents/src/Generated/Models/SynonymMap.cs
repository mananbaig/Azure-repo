// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Represents a synonym map definition. </summary>
    public partial class SynonymMap
    {

        /// <summary> Initializes a new instance of SynonymMap. </summary>
        /// <param name="name"> The name of the synonym map. </param>
        /// <param name="format"> The format of the synonym map. Only the &apos;solr&apos; format is currently supported. </param>
        /// <param name="synonyms"> A series of synonym rules in the specified synonym map format. The rules must be separated by newlines. </param>
        /// <param name="encryptionKey"> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your data when you want full assurance that no one, not even Microsoft, can decrypt your data in Azure Cognitive Search. Once you have encrypted your data, it will always remain encrypted. Azure Cognitive Search will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your data will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </param>
        /// <param name="Etag"> The ETag of the synonym map. </param>
        internal SynonymMap(string name, string format, string synonyms, SearchResourceEncryptionKey encryptionKey, string Etag)
        {
            Name = name;
            Format = format;
            Synonyms = synonyms;
            EncryptionKey = encryptionKey;
            _etag = Etag;
        }

        /// <summary> The name of the synonym map. </summary>
        public string Name { get; set; }
        /// <summary> The format of the synonym map. Only the &apos;solr&apos; format is currently supported. </summary>
        public string Format { get; set; }
        /// <summary> A series of synonym rules in the specified synonym map format. The rules must be separated by newlines. </summary>
        public string Synonyms { get; set; }
        /// <summary> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your data when you want full assurance that no one, not even Microsoft, can decrypt your data in Azure Cognitive Search. Once you have encrypted your data, it will always remain encrypted. Azure Cognitive Search will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your data will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </summary>
        public SearchResourceEncryptionKey EncryptionKey { get; set; }
    }
}
