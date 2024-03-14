// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The predicted change to the resource property. </summary>
    public partial class WhatIfPropertyChange
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WhatIfPropertyChange"/>. </summary>
        /// <param name="path"> The path of the property. </param>
        /// <param name="propertyChangeType"> The type of property change. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        internal WhatIfPropertyChange(string path, WhatIfPropertyChangeType propertyChangeType)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
            PropertyChangeType = propertyChangeType;
            Children = new ChangeTrackingList<WhatIfPropertyChange>();
        }

        /// <summary> Initializes a new instance of <see cref="WhatIfPropertyChange"/>. </summary>
        /// <param name="path"> The path of the property. </param>
        /// <param name="propertyChangeType"> The type of property change. </param>
        /// <param name="before"> The value of the property before the deployment is executed. </param>
        /// <param name="after"> The value of the property after the deployment is executed. </param>
        /// <param name="children"> Nested property changes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WhatIfPropertyChange(string path, WhatIfPropertyChangeType propertyChangeType, BinaryData before, BinaryData after, IReadOnlyList<WhatIfPropertyChange> children, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Path = path;
            PropertyChangeType = propertyChangeType;
            Before = before;
            After = after;
            Children = children;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WhatIfPropertyChange"/> for deserialization. </summary>
        internal WhatIfPropertyChange()
        {
        }

        /// <summary> The path of the property. </summary>
        public string Path { get; }
        /// <summary> The type of property change. </summary>
        public WhatIfPropertyChangeType PropertyChangeType { get; }
        /// <summary>
        /// The value of the property before the deployment is executed.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Before { get; }
        /// <summary>
        /// The value of the property after the deployment is executed.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData After { get; }
        /// <summary> Nested property changes. </summary>
        public IReadOnlyList<WhatIfPropertyChange> Children { get; }
    }
}
