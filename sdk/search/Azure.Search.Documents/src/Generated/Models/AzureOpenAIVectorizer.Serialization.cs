// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class AzureOpenAIVectorizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("azureOpenAIParameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(VectorizerName);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static AzureOpenAIVectorizer DeserializeAzureOpenAIVectorizer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureOpenAIVectorizerParameters azureOpenAIParameters = default;
            string name = default;
            VectorSearchVectorizerKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureOpenAIParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureOpenAIParameters = AzureOpenAIVectorizerParameters.DeserializeAzureOpenAIVectorizerParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new VectorSearchVectorizerKind(property.Value.GetString());
                    continue;
                }
            }
            return new AzureOpenAIVectorizer(name, kind, azureOpenAIParameters);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AzureOpenAIVectorizer FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureOpenAIVectorizer(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
