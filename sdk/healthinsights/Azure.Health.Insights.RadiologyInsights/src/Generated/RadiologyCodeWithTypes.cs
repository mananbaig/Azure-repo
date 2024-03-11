// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Radiology code with types : used in imaging procedure recommendation for contrast and view. </summary>
    public partial class RadiologyCodeWithTypes
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

        /// <summary> Initializes a new instance of <see cref="RadiologyCodeWithTypes"/>. </summary>
        /// <param name="code"> The SNOMED CT code indicates whether imaging was conducted with or without contrast in the case of contrast, and in the case of views, it denotes the number of views. </param>
        /// <param name="types"> The collection of types will indicate the contrast substance used in the case of contrast and, in the case of views, it will specify the types of views, such as lateral and frontal, etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="types"/> is null. </exception>
        internal RadiologyCodeWithTypes(FhirR4CodeableConcept code, IEnumerable<FhirR4CodeableConcept> types)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(types, nameof(types));

            Code = code;
            Types = types.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyCodeWithTypes"/>. </summary>
        /// <param name="code"> The SNOMED CT code indicates whether imaging was conducted with or without contrast in the case of contrast, and in the case of views, it denotes the number of views. </param>
        /// <param name="types"> The collection of types will indicate the contrast substance used in the case of contrast and, in the case of views, it will specify the types of views, such as lateral and frontal, etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RadiologyCodeWithTypes(FhirR4CodeableConcept code, IReadOnlyList<FhirR4CodeableConcept> types, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Types = types;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyCodeWithTypes"/> for deserialization. </summary>
        internal RadiologyCodeWithTypes()
        {
        }

        /// <summary> The SNOMED CT code indicates whether imaging was conducted with or without contrast in the case of contrast, and in the case of views, it denotes the number of views. </summary>
        public FhirR4CodeableConcept Code { get; }
        /// <summary> The collection of types will indicate the contrast substance used in the case of contrast and, in the case of views, it will specify the types of views, such as lateral and frontal, etc. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> Types { get; }
    }
}
