// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections;
using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> Contains a document found by a search query, plus associated metadata. </summary>
    public partial class SearchResult : IDictionary<string, object>
    {
        /// <summary> The relevance score of the document compared to other documents returned by the query. </summary>
        public double? Score { get; internal set; }
        /// <summary> Text fragments from the document that indicate the matching search terms, organized by each applicable field; null if hit highlighting was not enabled for the query. </summary>
        public IDictionary<string, ICollection<string>> Highlights { get; internal set; }
        private readonly IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _additionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => _additionalProperties.GetEnumerator();
        /// <inheritdoc />
        public ICollection<string> Keys => _additionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => _additionalProperties.Values;
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => _additionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public void Add(string key, object value) => _additionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => _additionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public bool Remove(string key) => _additionalProperties.Remove(key);
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => _additionalProperties.Count;
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => _additionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => _additionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => _additionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => _additionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => _additionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => _additionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => _additionalProperties[key];
            set => _additionalProperties[key] = value;
        }
    }
}
