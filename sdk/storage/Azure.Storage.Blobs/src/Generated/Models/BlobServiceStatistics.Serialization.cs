// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Storage.Blobs.Models
{
    public partial class BlobServiceStatistics : IXmlSerializable, IModelSerializable<BlobServiceStatistics>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "StorageServiceStats");
            if (Optional.IsDefined(GeoReplication))
            {
                writer.WriteObjectValue(GeoReplication, "GeoReplication");
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static BlobServiceStatistics DeserializeBlobServiceStatistics(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            BlobGeoReplication geoReplication = default;
            if (element.Element("GeoReplication") is XElement geoReplicationElement)
            {
                geoReplication = BlobGeoReplication.DeserializeBlobGeoReplication(geoReplicationElement);
            }
            return new BlobServiceStatistics(geoReplication, default);
        }

        BinaryData IModelSerializable<BlobServiceStatistics>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobServiceStatistics>(this, options.Format);

            options ??= ModelSerializerOptions.DefaultWireOptions;
            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            Serialize(writer, null, options);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        BlobServiceStatistics IModelSerializable<BlobServiceStatistics>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobServiceStatistics>(this, options.Format);

            return DeserializeBlobServiceStatistics(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="BlobServiceStatistics"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BlobServiceStatistics"/> to convert. </param>
        public static implicit operator RequestContent(BlobServiceStatistics model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BlobServiceStatistics"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BlobServiceStatistics(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeBlobServiceStatistics(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
