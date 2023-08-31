// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineRunCommandUpdate : IUtf8JsonSerializable, IModelJsonSerializable<VirtualMachineRunCommandUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualMachineRunCommandUpdate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualMachineRunCommandUpdate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualMachineRunCommandUpdate>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                if (Source is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VirtualMachineRunCommandScriptSource>)Source).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RunCommandInputParameter>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProtectedParameters))
            {
                writer.WritePropertyName("protectedParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedParameters)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RunCommandInputParameter>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AsyncExecution))
            {
                writer.WritePropertyName("asyncExecution"u8);
                writer.WriteBooleanValue(AsyncExecution.Value);
            }
            if (Optional.IsDefined(RunAsUser))
            {
                writer.WritePropertyName("runAsUser"u8);
                writer.WriteStringValue(RunAsUser);
            }
            if (Optional.IsDefined(RunAsPassword))
            {
                writer.WritePropertyName("runAsPassword"u8);
                writer.WriteStringValue(RunAsPassword);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeoutInSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(OutputBlobUri))
            {
                writer.WritePropertyName("outputBlobUri"u8);
                writer.WriteStringValue(OutputBlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ErrorBlobUri))
            {
                writer.WritePropertyName("errorBlobUri"u8);
                writer.WriteStringValue(ErrorBlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(OutputBlobManagedIdentity))
            {
                writer.WritePropertyName("outputBlobManagedIdentity"u8);
                if (OutputBlobManagedIdentity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RunCommandManagedIdentity>)OutputBlobManagedIdentity).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ErrorBlobManagedIdentity))
            {
                writer.WritePropertyName("errorBlobManagedIdentity"u8);
                if (ErrorBlobManagedIdentity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RunCommandManagedIdentity>)ErrorBlobManagedIdentity).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TreatFailureAsDeploymentFailure))
            {
                writer.WritePropertyName("treatFailureAsDeploymentFailure"u8);
                writer.WriteBooleanValue(TreatFailureAsDeploymentFailure.Value);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineRunCommandUpdate DeserializeVirtualMachineRunCommandUpdate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<VirtualMachineRunCommandScriptSource> source = default;
            Optional<IList<RunCommandInputParameter>> parameters = default;
            Optional<IList<RunCommandInputParameter>> protectedParameters = default;
            Optional<bool> asyncExecution = default;
            Optional<string> runAsUser = default;
            Optional<string> runAsPassword = default;
            Optional<int> timeoutInSeconds = default;
            Optional<Uri> outputBlobUri = default;
            Optional<Uri> errorBlobUri = default;
            Optional<RunCommandManagedIdentity> outputBlobManagedIdentity = default;
            Optional<RunCommandManagedIdentity> errorBlobManagedIdentity = default;
            Optional<string> provisioningState = default;
            Optional<VirtualMachineRunCommandInstanceView> instanceView = default;
            Optional<bool> treatFailureAsDeploymentFailure = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = VirtualMachineRunCommandScriptSource.DeserializeVirtualMachineRunCommandScriptSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item));
                            }
                            parameters = array;
                            continue;
                        }
                        if (property0.NameEquals("protectedParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item));
                            }
                            protectedParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("asyncExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asyncExecution = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("runAsUser"u8))
                        {
                            runAsUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("runAsPassword"u8))
                        {
                            runAsPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeoutInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeoutInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("outputBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("errorBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = VirtualMachineRunCommandInstanceView.DeserializeVirtualMachineRunCommandInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("treatFailureAsDeploymentFailure"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            treatFailureAsDeploymentFailure = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualMachineRunCommandUpdate(Optional.ToDictionary(tags), source.Value, Optional.ToList(parameters), Optional.ToList(protectedParameters), Optional.ToNullable(asyncExecution), runAsUser.Value, runAsPassword.Value, Optional.ToNullable(timeoutInSeconds), outputBlobUri.Value, errorBlobUri.Value, outputBlobManagedIdentity.Value, errorBlobManagedIdentity.Value, provisioningState.Value, instanceView.Value, Optional.ToNullable(treatFailureAsDeploymentFailure), rawData);
        }

        VirtualMachineRunCommandUpdate IModelJsonSerializable<VirtualMachineRunCommandUpdate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualMachineRunCommandUpdate>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineRunCommandUpdate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualMachineRunCommandUpdate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualMachineRunCommandUpdate>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualMachineRunCommandUpdate IModelSerializable<VirtualMachineRunCommandUpdate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualMachineRunCommandUpdate>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualMachineRunCommandUpdate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualMachineRunCommandUpdate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualMachineRunCommandUpdate"/> to convert. </param>
        public static implicit operator RequestContent(VirtualMachineRunCommandUpdate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualMachineRunCommandUpdate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualMachineRunCommandUpdate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualMachineRunCommandUpdate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
