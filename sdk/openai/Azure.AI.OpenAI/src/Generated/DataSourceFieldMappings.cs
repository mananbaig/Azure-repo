// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary> The AzureSearchChatDataSourceParametersFieldsMapping. </summary>
    public partial class DataSourceFieldMappings
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
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

        /// <summary> Initializes a new instance of <see cref="DataSourceFieldMappings"/>. </summary>
        /// <param name="titleFieldName"> The name of the index field to use as a title. </param>
        /// <param name="urlFieldName"> The name of the index field to use as a URL. </param>
        /// <param name="filepathFieldName"> The name of the index field to use as a filepath. </param>
        /// <param name="contentFieldNames"> The names of index fields that should be treated as content. </param>
        /// <param name="contentFieldSeparator"> The separator pattern that content fields should use. </param>
        /// <param name="vectorFieldNames"> The names of fields that represent vector data. </param>
        /// <param name="imageVectorFieldNames"> The names of fields that represent image vector data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataSourceFieldMappings(string titleFieldName, string urlFieldName, string filepathFieldName, IList<string> contentFieldNames, string contentFieldSeparator, IList<string> vectorFieldNames, IList<string> imageVectorFieldNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TitleFieldName = titleFieldName;
            UrlFieldName = urlFieldName;
            FilepathFieldName = filepathFieldName;
            ContentFieldNames = contentFieldNames;
            ContentFieldSeparator = contentFieldSeparator;
            VectorFieldNames = vectorFieldNames;
            ImageVectorFieldNames = imageVectorFieldNames;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
