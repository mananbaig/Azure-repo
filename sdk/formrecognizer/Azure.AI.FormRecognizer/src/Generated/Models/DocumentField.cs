// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object representing the content and location of a field value. </summary>
    public partial class DocumentField
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

        /// <summary> Initializes a new instance of <see cref="DocumentField"/>. </summary>
        /// <param name="expectedFieldType"> Data type of the field value. </param>
        /// <param name="valueString"> String value. </param>
        /// <param name="valueDate"> Date value in YYYY-MM-DD format (ISO 8601). </param>
        /// <param name="valueTime"> Time value in hh:mm:ss format (ISO 8601). </param>
        /// <param name="valuePhoneNumber"> Phone number value in E.164 format (ex. +19876543210). </param>
        /// <param name="valueNumber"> Floating point value. </param>
        /// <param name="valueInteger"> Integer value. </param>
        /// <param name="valueSelectionMark"> Selection mark value. </param>
        /// <param name="valueSignature"> Presence of signature. </param>
        /// <param name="valueCountryRegion"> 3-letter country code value (ISO 3166-1 alpha-3). </param>
        /// <param name="valueArray"> Array of field values. </param>
        /// <param name="valueObject"> Dictionary of named field values. </param>
        /// <param name="valueCurrency"> Currency value. </param>
        /// <param name="valueAddress"> Address value. </param>
        /// <param name="valueBoolean"> Boolean value. </param>
        /// <param name="content"> Field content. </param>
        /// <param name="boundingRegions"> Bounding regions covering the field. </param>
        /// <param name="spans"> Location of the field in the reading order concatenated content. </param>
        /// <param name="confidence"> Confidence of correctly extracting the field. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentField(DocumentFieldType expectedFieldType, string valueString, DateTimeOffset? valueDate, TimeSpan? valueTime, string valuePhoneNumber, double? valueNumber, long? valueInteger, V3SelectionMarkState? valueSelectionMark, DocumentSignatureType? valueSignature, string valueCountryRegion, IReadOnlyList<DocumentField> valueArray, IReadOnlyDictionary<string, DocumentField> valueObject, CurrencyValue? valueCurrency, AddressValue valueAddress, bool? valueBoolean, string content, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, float? confidence, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpectedFieldType = expectedFieldType;
            ValueString = valueString;
            ValueDate = valueDate;
            ValueTime = valueTime;
            ValuePhoneNumber = valuePhoneNumber;
            ValueNumber = valueNumber;
            ValueInteger = valueInteger;
            ValueSelectionMark = valueSelectionMark;
            ValueSignature = valueSignature;
            ValueCountryRegion = valueCountryRegion;
            ValueArray = valueArray;
            ValueObject = valueObject;
            ValueCurrency = valueCurrency;
            ValueAddress = valueAddress;
            ValueBoolean = valueBoolean;
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Confidence = confidence;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentField"/> for deserialization. </summary>
        internal DocumentField()
        {
        }
        /// <summary> Field content. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the field. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the field in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Confidence of correctly extracting the field. </summary>
        public float? Confidence { get; }
    }
}
