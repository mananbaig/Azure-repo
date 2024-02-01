// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Fleet;
using Azure.ResourceManager.Fleet.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Fleet.Samples
{
    public partial class Sample_FleetResource
    {
        // Fleets_ListBySubscription_MaximumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFleets_FleetsListBySubscriptionMaximumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_ListBySubscription_MaximumSet.json
            // this example is just showing the usage of "Fleets_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (FleetResource item in subscriptionResource.GetFleetsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FleetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Fleets_ListBySubscription_MinimumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFleets_FleetsListBySubscriptionMinimumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_ListBySubscription_MinimumSet.json
            // this example is just showing the usage of "Fleets_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (FleetResource item in subscriptionResource.GetFleetsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FleetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Fleets_Get_MaximumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FleetsGetMaximumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_Get_MaximumSet.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetResource result = await fleet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_Get_MinimumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FleetsGetMinimumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_Get_MinimumSet.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetResource result = await fleet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_Update_MaximumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_FleetsUpdateMaximumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_Update_MaximumSet.json
            // this example is just showing the usage of "Fleets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetPatch patch = new FleetPatch()
            {
                Zones =
{
"zone1","zone2"
},
                Tags =
{
},
                SpotPriorityProfile = new SpotPriorityProfile()
                {
                    Capacity = 20,
                    MinCapacity = 10,
                    MaxPricePerVm = 0.00865,
                    EvictionPolicy = EvictionPolicy.Delete,
                    AllocationStrategy = SpotAllocationStrategy.PriceCapacityOptimized,
                },
                RegularPriorityProfile = new RegularPriorityProfile()
                {
                    Capacity = 20,
                    MinCapacity = 10,
                    AllocationStrategy = RegularPriorityAllocationStrategy.LowestPrice,
                },
                VmSizesProfile =
{
new VmSizeProfile("Standard_d1_v2")
},
                ComputeProfile = new ComputeProfileUpdate()
                {
                    BaseVirtualMachineProfile = new VirtualMachineScaleSetVmProfile()
                    {
                        OSProfile = new VirtualMachineScaleSetOSProfile()
                        {
                            ComputerNamePrefix = "svdrokuuojba",
                            AdminUsername = "offgcmltnjkbiakzjhosetqeslifah",
                            AdminPassword = "wntdnosdvucijisma",
                            CustomData = "konjpsuyijb",
                            WindowsConfiguration = new WindowsConfiguration()
                            {
                                ProvisionVmAgent = true,
                                EnableAutomaticUpdates = true,
                                TimeZone = "kpfs",
                                AdditionalUnattendContent =
{
new AdditionalUnattendContent()
{
PassName = PassName.OobeSystem,
ComponentName = ComponentName.MicrosoftWindowsShellSetup,
SettingName = SettingName.AutoLogon,
Content = "kstwdekvloggaypeiqgzlcfsm",
}
},
                                PatchSettings = new PatchSettings()
                                {
                                    PatchMode = WindowsVmGuestPatchMode.Manual,
                                    EnableHotpatching = true,
                                    AssessmentMode = WindowsPatchAssessmentMode.ImageDefault,
                                    AutomaticByPlatformSettings = new WindowsVmGuestPatchAutomaticByPlatformSettings()
                                    {
                                        RebootSetting = WindowsVmGuestPatchAutomaticByPlatformRebootSetting.Unknown,
                                        BypassPlatformSafetyChecksOnUserSchedule = true,
                                    },
                                },
                                WinRMListeners =
{
new WinRMListener()
{
Protocol = ProtocolType.Http,
CertificateUri = new Uri("rpbe"),
}
},
                                EnableVmAgentPlatformUpdates = true,
                            },
                            LinuxConfiguration = new LinuxConfiguration()
                            {
                                DisablePasswordAuthentication = true,
                                SshPublicKeys =
{
new SshPublicKey()
{
Path = "pxxnbbcyekgdq",
KeyData = "lfxabidjysvtlm",
}
},
                                ProvisionVmAgent = true,
                                PatchSettings = new LinuxPatchSettings()
                                {
                                    PatchMode = LinuxVmGuestPatchMode.ImageDefault,
                                    AssessmentMode = LinuxPatchAssessmentMode.ImageDefault,
                                    AutomaticByPlatformSettings = new LinuxVmGuestPatchAutomaticByPlatformSettings()
                                    {
                                        RebootSetting = LinuxVmGuestPatchAutomaticByPlatformRebootSetting.Unknown,
                                        BypassPlatformSafetyChecksOnUserSchedule = true,
                                    },
                                },
                                EnableVmAgentPlatformUpdates = true,
                            },
                            Secrets =
{
new VaultSecretGroup()
{
SourceVaultId = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
VaultCertificates =
{
new VaultCertificate()
{
CertificateUri = new Uri("niigcnvodpcyiatng"),
CertificateStore = "ofo",
}
},
}
},
                            AllowExtensionOperations = true,
                            RequireGuestProvisionSignal = true,
                        },
                        StorageProfile = new VirtualMachineScaleSetStorageProfile()
                        {
                            ImageReference = new ImageReference()
                            {
                                Publisher = "skk",
                                Offer = "ruhnsiankpaqh",
                                Sku = "bcwgmoqrsftfxshebubz",
                                Version = "nhzyxfc",
                                SharedGalleryImageId = "mkfpnxoxmkyrwpab",
                                CommunityGalleryImageId = "ujhxcd",
                                Id = "eouuvblwiuykzebjh",
                            },
                            OSDisk = new VirtualMachineScaleSetOSDisk(DiskCreateOptionType.FromImage)
                            {
                                Name = "qzchzeaaxupl",
                                Caching = CachingType.None,
                                WriteAcceleratorEnabled = true,
                                DiffDiskSettings = new DiffDiskSettings()
                                {
                                    Option = DiffDiskOption.Local,
                                    Placement = DiffDiskPlacement.CacheDisk,
                                },
                                DiskSizeGB = 18,
                                OSType = OperatingSystemType.Windows,
                                ImageUri = new Uri("zfpzrbpchhrehnfmh"),
                                VhdContainers =
{
"ibogdijam"
},
                                ManagedDisk = new VirtualMachineScaleSetManagedDiskParameters()
                                {
                                    StorageAccountType = StorageAccountType.StandardLRS,
                                    DiskEncryptionSetId = new ResourceIdentifier("hinhonboozgfbrfwyy"),
                                    SecurityProfile = new VmDiskSecurityProfile()
                                    {
                                        SecurityEncryptionType = SecurityEncryptionType.VmGuestStateOnly,
                                        DiskEncryptionSetId = new ResourceIdentifier("hinhonboozgfbrfwyy"),
                                    },
                                },
                                DeleteOption = DiskDeleteOptionType.Delete,
                            },
                            DataDisks =
{
new VirtualMachineScaleSetDataDisk(17,DiskCreateOptionType.FromImage)
{
Name = "lxrutjmjctse",
Caching = CachingType.None,
WriteAcceleratorEnabled = true,
DiskSizeGB = 24,
ManagedDisk = new VirtualMachineScaleSetManagedDiskParameters()
{
StorageAccountType = StorageAccountType.StandardLRS,
DiskEncryptionSetId = new ResourceIdentifier("hinhonboozgfbrfwyy"),
SecurityProfile = new VmDiskSecurityProfile()
{
SecurityEncryptionType = SecurityEncryptionType.VmGuestStateOnly,
DiskEncryptionSetId = new ResourceIdentifier("hinhonboozgfbrfwyy"),
},
},
DiskIopsReadWrite = 9,
DiskMBpsReadWrite = 17,
DeleteOption = DiskDeleteOptionType.Delete,
}
},
                            DiskControllerType = "yjhloknohphvezhkawonpaeyvkxed",
                        },
                        NetworkProfile = new VirtualMachineScaleSetNetworkProfile()
                        {
                            HealthProbeId = new ResourceIdentifier("puulsdoecyaooqmhz"),
                            NetworkInterfaceConfigurations =
{
new VirtualMachineScaleSetNetworkConfiguration("akgykxfyokjdwhjztro")
{
Primary = true,
EnableAcceleratedNetworking = true,
DisableTcpStateTracking = true,
EnableFpga = true,
NetworkSecurityGroupId = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
DnsServers =
{
"uptkfxtujkp"
},
IPConfigurations =
{
new VirtualMachineScaleSetIPConfiguration("et")
{
SubnetId = new ResourceIdentifier("puulsdoecyaooqmhz"),
Primary = true,
PublicIPAddressConfiguration = new VirtualMachineScaleSetPublicIPAddressConfiguration("vphqhgnqqsbnafztnoq")
{
Sku = new PublicIPAddressSku()
{
Name = PublicIPAddressSkuName.Basic,
Tier = PublicIPAddressSkuTier.Regional,
},
IdleTimeoutInMinutes = 8,
DnsSettings = new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings("fdwomemghickvduupceilj")
{
DomainNameLabelScope = DomainNameLabelScopeType.TenantReuse,
},
IPTags =
{
new VirtualMachineScaleSetIPTag()
{
IPTagType = "odacxovypuippcmak",
Tag = "bbwjxnpervnfkaxvblftzfypky",
}
},
PublicIPPrefixId = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
PublicIPAddressVersion = IPVersion.IPv4,
DeleteOption = DeleteOption.Delete,
},
PrivateIPAddressVersion = IPVersion.IPv4,
ApplicationGatewayBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
}
},
ApplicationSecurityGroups =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
}
},
LoadBalancerBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
}
},
LoadBalancerInboundNatPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
}
},
}
},
EnableIPForwarding = true,
DeleteOption = DeleteOption.Delete,
AuxiliaryMode = NetworkInterfaceAuxiliaryMode.None,
AuxiliarySku = NetworkInterfaceAuxiliarySku.None,
}
},
                            NetworkApiVersion = NetworkApiVersion.TwoThousandTwenty1101,
                        },
                        SecurityProfile = new SecurityProfile()
                        {
                            UefiSettings = new UefiSettings()
                            {
                                SecureBootEnabled = true,
                                VTpmEnabled = true,
                            },
                            EncryptionAtHost = true,
                            SecurityType = SecurityType.TrustedLaunch,
                            UserAssignedIdentityResourceId = "ymhqsov",
                            ProxyAgentSettings = new ProxyAgentSettings()
                            {
                                Enabled = true,
                                Mode = Mode.Audit,
                                KeyIncarnationId = 8,
                            },
                        },
                        BootDiagnostics = new BootDiagnostics()
                        {
                            Enabled = true,
                            StorageUri = new Uri("lqthuokqcyyccvfxut"),
                        },
                        ExtensionProfile = new VirtualMachineScaleSetExtensionProfile()
                        {
                            Extensions =
{
new VirtualMachineScaleSetExtension()
{
Name = "gioliweczgjegdfqyaqkdgwrmc",
ForceUpdateTag = "bfapfyqglqyiy",
Publisher = "vmgltumwyjrsvlwcbgexcovgwyex",
TypePropertiesType = "jrewfymdqgrlcudogunfog",
TypeHandlerVersion = "vqrkrrankheuqbcopc",
AutoUpgradeMinorVersion = true,
EnableAutomaticUpgrade = true,
Settings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
}),
ProtectedSettings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
}),
ProvisionAfterExtensions =
{
"babgtjyllusylxsnfvepitrkmkcx"
},
SuppressFailures = true,
ProtectedSettingsFromKeyVault = new KeyVaultSecretReference(new Uri("qmjoynsytvnjzutetnkog"),new WritableSubResource()
{
Id = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
}),
}
},
                            ExtensionsTimeBudget = "srvemetinivyy",
                        },
                        LicenseType = "pbnasge",
                        Priority = VirtualMachinePriorityType.Regular,
                        EvictionPolicy = VirtualMachineEvictionPolicyType.Deallocate,
                        BillingMaxPrice = 8,
                        ScheduledEventsProfile = new ScheduledEventsProfile()
                        {
                            TerminateNotificationProfile = new TerminateNotificationProfile()
                            {
                                NotBeforeTimeout = "yczcvhbnxumqmilfufwatqupjrniie",
                                Enable = true,
                            },
                            OSImageNotificationProfile = new OSImageNotificationProfile()
                            {
                                NotBeforeTimeout = "wletnpoxpngmbtrup",
                                Enable = true,
                            },
                        },
                        UserData = "jgdmsclzzknsevdsh",
                        CapacityReservationGroupId = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
                        GalleryApplications =
{
new VmGalleryApplication("aabkcborasmyowocjceldewmkci")
{
Tags = "bevijlsuchspoihzlfjczuqttaqz",
Order = 4,
ConfigurationReference = "auikpeahpgodbqdih",
TreatFailureAsDeploymentFailure = true,
EnableAutomaticUpgrade = true,
}
},
                        HardwareVmSizeProperties = new VmSizeProperties()
                        {
                            VCPUsAvailable = 14,
                            VCPUsPerCore = 24,
                        },
                        ServiceArtifactReferenceId = new ResourceIdentifier("qqqxnjehbgcepcfldzifjkwlzusn"),
                        SecurityPostureReference = new SecurityPostureReference()
                        {
                            Id = "zwtxjdjwedxmhpcoii",
                            ExcludeExtensions =
{
new VirtualMachineExtension(new AzureLocation("jzecxhirbtegqxpyk"))
{
ForceUpdateTag = "eleagpulycjgvscuulb",
Publisher = "rwaucnzfffywlsaoqltkmsynni",
TypePropertiesType = "rgnq",
TypeHandlerVersion = "hyyj",
AutoUpgradeMinorVersion = true,
EnableAutomaticUpgrade = true,
Settings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
}),
ProtectedSettings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
}),
InstanceView = new VirtualMachineExtensionInstanceView()
{
Name = "xxnjefzqotctmujsqpmyleaie",
VirtualMachineExtensionInstanceViewType = "cycepellfcdujniys",
TypeHandlerVersion = "jefntwzzgxsbzncchhefqiqbs",
Substatuses =
{
new InstanceViewStatus()
{
Code = "cbzjpwcbfodkqjnd",
Level = StatusLevelType.Info,
DisplayStatus = "oxhrtqv",
Message = "uldcsnhprfe",
Time = DateTimeOffset.Parse("2024-01-28T09:08:15.992Z"),
}
},
Statuses =
{
new InstanceViewStatus()
{
Code = "cbzjpwcbfodkqjnd",
Level = StatusLevelType.Info,
DisplayStatus = "oxhrtqv",
Message = "uldcsnhprfe",
Time = DateTimeOffset.Parse("2024-01-28T09:08:15.992Z"),
}
},
},
SuppressFailures = true,
ProtectedSettingsFromKeyVault = new KeyVaultSecretReference(new Uri("qmjoynsytvnjzutetnkog"),new WritableSubResource()
{
Id = new ResourceIdentifier("ihxrocoahkxxjrbmbhmaahzi"),
}),
ProvisionAfterExtensions =
{
"aysdon"
},
Tags =
{
["key4849"] = "hqnzzgyumfzflmyjxklwslb",
},
}
},
                        },
                    },
                    ComputeApiVersion = "2023-07-01",
                },
            };
            ArmOperation<FleetResource> lro = await fleet.UpdateAsync(WaitUntil.Completed, patch);
            FleetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_Update_MinimumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_FleetsUpdateMinimumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_Update_MinimumSet.json
            // this example is just showing the usage of "Fleets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetPatch patch = new FleetPatch();
            ArmOperation<FleetResource> lro = await fleet.UpdateAsync(WaitUntil.Completed, patch);
            FleetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Fleets_Delete_MaximumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_FleetsDeleteMaximumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_Delete_MaximumSet.json
            // this example is just showing the usage of "Fleets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            await fleet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Fleets_Delete_MinimumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_FleetsDeleteMinimumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/Fleets_Delete_MinimumSet.json
            // this example is just showing the usage of "Fleets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            await fleet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineScaleSets_ListByFleet_MaximumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineScaleSets_VirtualMachineScaleSetsListByFleetMaximumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/VirtualMachineScaleSets_ListByFleet_MaximumSet.json
            // this example is just showing the usage of "VirtualMachineScaleSets_ListByFleet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "myFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualMachineScaleSet item in fleet.GetVirtualMachineScaleSetsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineScaleSets_ListByFleet_MinimumSet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineScaleSets_VirtualMachineScaleSetsListByFleetMinimumSet()
        {
            // Generated from example definition: specification/azurefleet/resource-manager/Microsoft.AzureFleet/preview/2023-11-01-preview/examples/VirtualMachineScaleSets_ListByFleet_MinimumSet.json
            // this example is just showing the usage of "VirtualMachineScaleSets_ListByFleet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "7B0CD4DB-3381-4013-9B31-FB6E6FD0FF1C";
            string resourceGroupName = "rgazurefleet";
            string fleetName = "testFleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualMachineScaleSet item in fleet.GetVirtualMachineScaleSetsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
