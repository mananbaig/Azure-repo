// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Media.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_StreamingPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAStreamingPolicyByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policy-get-by-name.json
            // this example is just showing the usage of "StreamingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "clearStreamingPolicy";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyResource result = await streamingPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithClearKeyEncryptionInCommonEncryptionCbcs()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-commonEncryptionCbcs-clearKeyEncryption.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "UserCreatedSecureStreamingPolicyWithCommonEncryptionCbcsOnly";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                DefaultContentKeyPolicyName = "PolicyWithMultipleOptions",
                CommonEncryptionCbcs = new CommonEncryptionCbcs()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, false, true, false),
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "cbcsDefaultKey",
                        },
                    },
                    ClearKeyEncryptionCustomKeysAcquisitionUriTemplate = "https://contoso.com/{AlternativeMediaId}/clearkey/",
                },
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithClearKeyEncryptionInCommonEncryptionCenc()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-commonEncryptionCenc-clearKeyEncryption.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "UserCreatedSecureStreamingPolicyWithCommonEncryptionCencOnly";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                DefaultContentKeyPolicyName = "PolicyWithPlayReadyOptionAndOpenRestriction",
                CommonEncryptionCenc = new CommonEncryptionCenc()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, true, false, true),
                    ClearTracks =
{
new MediaTrackSelection()
{
TrackSelections =
{
new TrackPropertyCondition(TrackPropertyType.FourCC,TrackPropertyCompareOperation.Equal)
{
Value = "hev1",
}
},
}
},
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "cencDefaultKey",
                        },
                    },
                    ClearKeyEncryptionCustomKeysAcquisitionUriTemplate = "https://contoso.com/{AlternativeMediaId}/clearkey/",
                },
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithClearStreaming()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-clear.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "clearStreamingPolicy";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                NoEncryptionEnabledProtocols = new MediaEnabledProtocols(true, true, true, true),
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithCommonEncryptionCbcsOnly()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-commonEncryptionCbcs-only.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "UserCreatedSecureStreamingPolicyWithCommonEncryptionCbcsOnly";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                DefaultContentKeyPolicyName = "PolicyWithMultipleOptions",
                CommonEncryptionCbcs = new CommonEncryptionCbcs()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, false, true, false),
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "cbcsDefaultKey",
                        },
                    },
                    Drm = new CbcsDrmConfiguration()
                    {
                        FairPlay = new StreamingPolicyFairPlayConfiguration(true)
                        {
                            CustomLicenseAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/fairplay/{ContentKeyId}",
                        },
                    },
                },
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithCommonEncryptionCencOnly()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-commonEncryptionCenc-only.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "UserCreatedSecureStreamingPolicyWithCommonEncryptionCencOnly";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                DefaultContentKeyPolicyName = "PolicyWithPlayReadyOptionAndOpenRestriction",
                CommonEncryptionCenc = new CommonEncryptionCenc()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, true, false, true),
                    ClearTracks =
{
new MediaTrackSelection()
{
TrackSelections =
{
new TrackPropertyCondition(TrackPropertyType.FourCC,TrackPropertyCompareOperation.Equal)
{
Value = "hev1",
}
},
}
},
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "cencDefaultKey",
                        },
                    },
                    Drm = new CencDrmConfiguration()
                    {
                        PlayReady = new StreamingPolicyPlayReadyConfiguration()
                        {
                            CustomLicenseAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/playready/{ContentKeyId}",
                            PlayReadyCustomAttributes = "PlayReady CustomAttributes",
                        },
                        WidevineCustomLicenseAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/widevine/{ContentKeyId",
                    },
                },
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithEnvelopeEncryptionOnly()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-envelopeEncryption-only.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "UserCreatedSecureStreamingPolicyWithEnvelopeEncryptionOnly";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                DefaultContentKeyPolicyName = "PolicyWithClearKeyOptionAndTokenRestriction",
                EnvelopeEncryption = new EnvelopeEncryption()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, true, true, true),
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "aesDefaultKey",
                        },
                    },
                    CustomKeyAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/envelope/{ContentKeyId}",
                },
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreatesAStreamingPolicyWithSecureStreaming()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-create-secure-streaming.json
            // this example is just showing the usage of "StreamingPolicies_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "UserCreatedSecureStreamingPolicy";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            StreamingPolicyData data = new StreamingPolicyData()
            {
                DefaultContentKeyPolicyName = "PolicyWithMultipleOptions",
                EnvelopeEncryption = new EnvelopeEncryption()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, true, true, true),
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "aesDefaultKey",
                        },
                    },
                    CustomKeyAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/envelope/{ContentKeyId}",
                },
                CommonEncryptionCenc = new CommonEncryptionCenc()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, true, false, true),
                    ClearTracks =
{
new MediaTrackSelection()
{
TrackSelections =
{
new TrackPropertyCondition(TrackPropertyType.FourCC,TrackPropertyCompareOperation.Equal)
{
Value = "hev1",
}
},
}
},
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "cencDefaultKey",
                        },
                    },
                    Drm = new CencDrmConfiguration()
                    {
                        PlayReady = new StreamingPolicyPlayReadyConfiguration()
                        {
                            CustomLicenseAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/playready/{ContentKeyId}",
                            PlayReadyCustomAttributes = "PlayReady CustomAttributes",
                        },
                        WidevineCustomLicenseAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/widevine/{ContentKeyId",
                    },
                },
                CommonEncryptionCbcs = new CommonEncryptionCbcs()
                {
                    EnabledProtocols = new MediaEnabledProtocols(false, false, true, false),
                    ContentKeys = new StreamingPolicyContentKeys()
                    {
                        DefaultKey = new EncryptionSchemeDefaultKey()
                        {
                            Label = "cbcsDefaultKey",
                        },
                    },
                    Drm = new CbcsDrmConfiguration()
                    {
                        FairPlay = new StreamingPolicyFairPlayConfiguration(true)
                        {
                            CustomLicenseAcquisitionUriTemplate = "https://contoso.com/{AssetAlternativeId}/fairplay/{ContentKeyId}",
                        },
                    },
                },
            };
            ArmOperation<StreamingPolicyResource> lro = await streamingPolicy.UpdateAsync(WaitUntil.Completed, data);
            StreamingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAStreamingPolicy()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2023-01-01/examples/streaming-policies-delete.json
            // this example is just showing the usage of "StreamingPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingPolicyResource created on azure
            // for more information of creating StreamingPolicyResource, please refer to the document of StreamingPolicyResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosorg";
            string accountName = "contosomedia";
            string streamingPolicyName = "secureStreamingPolicyWithCommonEncryptionCbcsOnly";
            ResourceIdentifier streamingPolicyResourceId = StreamingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, streamingPolicyName);
            StreamingPolicyResource streamingPolicy = client.GetStreamingPolicyResource(streamingPolicyResourceId);

            // invoke the operation
            await streamingPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
