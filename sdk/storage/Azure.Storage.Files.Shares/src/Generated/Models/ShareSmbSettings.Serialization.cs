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
    public partial class ShareSmbSettings : IXmlSerializable, IModelSerializable<ShareSmbSettings>
    {
        private void Serialize(XmlWriter writer, string nameHint, ModelSerializerOptions options)
        {
            writer.WriteStartElement(nameHint ?? "SMB");
            if (Optional.IsDefined(Multichannel))
            {
                writer.WriteObjectValue(Multichannel, "Multichannel");
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => Serialize(writer, nameHint, ModelSerializerOptions.DefaultWireOptions);

        internal static ShareSmbSettings DeserializeShareSmbSettings(XElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;
            SmbMultichannel multichannel = default;
            if (element.Element("Multichannel") is XElement multichannelElement)
            {
                multichannel = SmbMultichannel.DeserializeSmbMultichannel(multichannelElement);
            }
            return new ShareSmbSettings(multichannel, default);
        }

        BinaryData IModelSerializable<ShareSmbSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareSmbSettings>(this, options.Format);

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

        ShareSmbSettings IModelSerializable<ShareSmbSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ShareSmbSettings>(this, options.Format);

            return DeserializeShareSmbSettings(XElement.Load(data.ToStream()), options);
        }

        /// <summary> Converts a <see cref="ShareSmbSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ShareSmbSettings"/> to convert. </param>
        public static implicit operator RequestContent(ShareSmbSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ShareSmbSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ShareSmbSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            return DeserializeShareSmbSettings(XElement.Load(response.ContentStream), ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
