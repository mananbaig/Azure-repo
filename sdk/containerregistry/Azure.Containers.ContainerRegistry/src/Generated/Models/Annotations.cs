// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Additional information provided through arbitrary metadata. </summary>
    public partial class Annotations : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of Annotations. </summary>
        public Annotations()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Annotations. </summary>
        /// <param name="created"> Date and time on which the image was built (string, date-time as defined by https://tools.ietf.org/html/rfc3339#section-5.6). </param>
        /// <param name="authors"> Contact details of the people or organization responsible for the image. </param>
        /// <param name="url"> URL to find more information on the image. </param>
        /// <param name="documentation"> URL to get documentation on the image. </param>
        /// <param name="source"> URL to get source code for building the image. </param>
        /// <param name="version"> Version of the packaged software. The version MAY match a label or tag in the source code repository, may also be Semantic versioning-compatible. </param>
        /// <param name="revision"> Source control revision identifier for the packaged software. </param>
        /// <param name="vendor"> Name of the distributing entity, organization or individual. </param>
        /// <param name="licenses"> License(s) under which contained software is distributed as an SPDX License Expression. </param>
        /// <param name="name"> Name of the reference for a target. </param>
        /// <param name="title"> Human-readable title of the image. </param>
        /// <param name="description"> Human-readable description of the software packaged in the image. </param>
        /// <param name="additionalProperties"> . </param>
        internal Annotations(DateTimeOffset? created, string authors, string url, string documentation, string source, string version, string revision, string vendor, string licenses, string name, string title, string description, IDictionary<string, object> additionalProperties)
        {
            Created = created;
            Authors = authors;
            Url = url;
            Documentation = documentation;
            Source = source;
            Version = version;
            Revision = revision;
            Vendor = vendor;
            Licenses = licenses;
            Name = name;
            Title = title;
            Description = description;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Date and time on which the image was built (string, date-time as defined by https://tools.ietf.org/html/rfc3339#section-5.6). </summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary> Contact details of the people or organization responsible for the image. </summary>
        public string Authors { get; set; }
        /// <summary> URL to find more information on the image. </summary>
        public string Url { get; set; }
        /// <summary> URL to get documentation on the image. </summary>
        public string Documentation { get; set; }
        /// <summary> URL to get source code for building the image. </summary>
        public string Source { get; set; }
        /// <summary> Version of the packaged software. The version MAY match a label or tag in the source code repository, may also be Semantic versioning-compatible. </summary>
        public string Version { get; set; }
        /// <summary> Source control revision identifier for the packaged software. </summary>
        public string Revision { get; set; }
        /// <summary> Name of the distributing entity, organization or individual. </summary>
        public string Vendor { get; set; }
        /// <summary> License(s) under which contained software is distributed as an SPDX License Expression. </summary>
        public string Licenses { get; set; }
        /// <summary> Name of the reference for a target. </summary>
        public string Name { get; set; }
        /// <summary> Human-readable title of the image. </summary>
        public string Title { get; set; }
        /// <summary> Human-readable description of the software packaged in the image. </summary>
        public string Description { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="ICollection{T}.Count"/>
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc cref="ICollection{T}.Add"/>
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc cref="ICollection{T}.Remove"/>
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc cref="ICollection{T}.Contains"/>
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc cref="ICollection{T}.CopyTo"/>
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc cref="ICollection{T}.Clear"/>
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
