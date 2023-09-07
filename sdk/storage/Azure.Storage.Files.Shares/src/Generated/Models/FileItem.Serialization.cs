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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FileItem : IXmlSerializable, IModelSerializable<FileItem>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "File");
            writer.WriteObjectValue(Name, "Name");
            if (Optional.IsDefined(FileId))
            {
                writer.WriteStartElement("FileId");
                writer.WriteValue(FileId);
                writer.WriteEndElement();
            }
            writer.WriteObjectValue(Properties, "Properties");
            if (Optional.IsDefined(Attributes))
            {
                writer.WriteStartElement("Attributes");
                writer.WriteValue(Attributes);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(PermissionKey))
            {
                writer.WriteStartElement("PermissionKey");
                writer.WriteValue(PermissionKey);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static FileItem DeserializeFileItem(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            StringEncoded name = default;
            string fileId = default;
            FileProperty properties = default;
            string attributes = default;
            string permissionKey = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = StringEncoded.DeserializeStringEncoded(nameElement);
            }
            if (element.Element("FileId") is XElement fileIdElement)
            {
                fileId = (string)fileIdElement;
            }
            if (element.Element("Properties") is XElement propertiesElement)
            {
                properties = FileProperty.DeserializeFileProperty(propertiesElement);
            }
            if (element.Element("Attributes") is XElement attributesElement)
            {
                attributes = (string)attributesElement;
            }
            if (element.Element("PermissionKey") is XElement permissionKeyElement)
            {
                permissionKey = (string)permissionKeyElement;
            }
            return new FileItem(name, fileId, properties, attributes, permissionKey, default);
        }

        BinaryData IModelSerializable<FileItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FileItem>(this, options.Format);

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

        FileItem IModelSerializable<FileItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FileItem>(this, options.Format);

            return DeserializeFileItem(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="FileItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FileItem"/> to convert. </param>
        public static implicit operator RequestContent(FileItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FileItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FileItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeFileItem(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
