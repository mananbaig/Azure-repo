// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Specifies an OAuth 2.0 permission scope or an app role that an application requires. The resourceAccess property of the RequiredResourceAccess type is a collection of ResourceAccess. </summary>
    public partial class ResourceAccess : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of ResourceAccess. </summary>
        /// <param name="id"> The unique identifier for one of the OAuth2Permission or AppRole instances that the resource application exposes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public ResourceAccess(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ResourceAccess. </summary>
        /// <param name="id"> The unique identifier for one of the OAuth2Permission or AppRole instances that the resource application exposes. </param>
        /// <param name="type"> Specifies whether the id property references an OAuth2Permission or an AppRole. Possible values are &quot;scope&quot; or &quot;role&quot;. </param>
        /// <param name="additionalProperties"> . </param>
        internal ResourceAccess(string id, string type, IDictionary<string, object> additionalProperties)
        {
            Id = id;
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The unique identifier for one of the OAuth2Permission or AppRole instances that the resource application exposes. </summary>
        public string Id { get; set; }
        /// <summary> Specifies whether the id property references an OAuth2Permission or an AppRole. Possible values are &quot;scope&quot; or &quot;role&quot;. </summary>
        public string Type { get; set; }
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
