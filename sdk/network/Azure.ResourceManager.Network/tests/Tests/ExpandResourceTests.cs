﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network.Tests.Helpers;
using NUnit.Framework;
using SubResource = Azure.ResourceManager.Network.Models.SubResource;

namespace Azure.ResourceManager.Network.Tests
{
    [Ignore("https://github.com/Azure/azure-sdk-for-net/issues/24577")]
    public class ExpandResourceTests : NetworkServiceClientTestBase
    {
        public ExpandResourceTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        public void ClearChallengeCacheforRecord()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                Initialize();
            }
        }

        [Test]
        [RecordedTest]
        public async Task ExpandResourceTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = TestEnvironment.Location;
            var resourceGroup = await CreateResourceGroup(resourceGroupName);

            // Create lbPublicIP
            string lbPublicIpName = Recording.GenerateAssetName("azsmnet");
            string lbDomaingNameLabel = Recording.GenerateAssetName("azsmnet");

            PublicIPAddress lbPublicIp = await CreateDefaultPublicIpAddress(
                lbPublicIpName,
                lbDomaingNameLabel,
                location,
                resourceGroup.GetPublicIPAddresses());

            // Create Vnet
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");
            VirtualNetwork vnet = await CreateVirtualNetwork(vnetName, subnetName, location, resourceGroup.GetVirtualNetworks());

            // Create Nics
            string nic1name = Recording.GenerateAssetName("azsmnet");
            string nic2name = Recording.GenerateAssetName("azsmnet");
            string nic3name = Recording.GenerateAssetName("azsmnet");

            NetworkInterface nic1 = await CreateNetworkInterface(
                nic1name,
                null,
                vnet.Data.Subnets[0].Id,
                location,
                "ipconfig",
                resourceGroup.GetNetworkInterfaces());

            NetworkInterface nic2 = await CreateNetworkInterface(
                nic2name,
                null,
                vnet.Data.Subnets[0].Id,
                location,
                "ipconfig",
                resourceGroup.GetNetworkInterfaces());

            NetworkInterface nic3 = await CreateNetworkInterface(
                nic3name,
                null,
                vnet.Data.Subnets[0].Id,
                location,
                "ipconfig",
                resourceGroup.GetNetworkInterfaces());

            // Create the LoadBalancer
            var lbName = Recording.GenerateAssetName("azsmnet");
            var frontendIpConfigName = Recording.GenerateAssetName("azsmnet");
            var backEndAddressPoolName = Recording.GenerateAssetName("azsmnet");
            var loadBalancingRuleName = Recording.GenerateAssetName("azsmnet");
            var probeName = Recording.GenerateAssetName("azsmnet");
            var inboundNatRule1Name = Recording.GenerateAssetName("azsmnet");
            var inboundNatRule2Name = Recording.GenerateAssetName("azsmnet");

            // Populate the loadBalancerCreateOrUpdateParameter
            var loadBalancerData = new LoadBalancerData()
            {
                Location = location,
                FrontendIPConfigurations = {
                    new FrontendIPConfiguration()
                    {
                        Name = frontendIpConfigName,
                        PublicIPAddress = new PublicIPAddressData()
                        {
                            Id = lbPublicIp.Id
                        }
                    }
                },
                BackendAddressPools = {
                    new BackendAddressPoolData()
                    {
                        Name = backEndAddressPoolName,
                    }
                },
                LoadBalancingRules = {
                    new LoadBalancingRule()
                    {
                        Name = loadBalancingRuleName,
                        FrontendIPConfiguration = new WritableSubResource()
                        {
                            Id = GetChildLbResourceId(TestEnvironment.SubscriptionId,
                            resourceGroupName, lbName, "FrontendIPConfigurations", frontendIpConfigName)
                        },
                        Protocol = TransportProtocol.Tcp,
                        FrontendPort = 80,
                        BackendPort = 80,
                        EnableFloatingIP = false,
                        IdleTimeoutInMinutes = 15,
                        BackendAddressPool = new WritableSubResource()
                        {
                            Id = GetChildLbResourceId(TestEnvironment.SubscriptionId,
                                resourceGroupName, lbName, "backendAddressPools", backEndAddressPoolName)
                        },
                        Probe = new WritableSubResource()
                        {
                            Id = GetChildLbResourceId(TestEnvironment.SubscriptionId,
                            resourceGroupName, lbName, "probes", probeName)
                        }
                    }
                },
                Probes = {
                    new Probe()
                    {
                        Name = probeName,
                        Protocol = ProbeProtocol.Http,
                        Port = 80,
                        RequestPath = "healthcheck.aspx",
                        IntervalInSeconds = 10,
                        NumberOfProbes = 2
                    }
                },
                InboundNatRules = {
                    new InboundNatRuleData()
                    {
                        Name = inboundNatRule1Name,
                        FrontendIPConfiguration = new WritableSubResource()
                        {
                            Id = GetChildLbResourceId(TestEnvironment.SubscriptionId,
                            resourceGroupName, lbName, "FrontendIPConfigurations", frontendIpConfigName)
                        },
                        Protocol = TransportProtocol.Tcp,
                        FrontendPort = 3389,
                        BackendPort = 3389,
                        IdleTimeoutInMinutes = 15,
                        EnableFloatingIP = false
                    },
                    new InboundNatRuleData()
                    {
                        Name = inboundNatRule2Name,
                        FrontendIPConfiguration = new WritableSubResource()
                        {
                            Id = GetChildLbResourceId(TestEnvironment.SubscriptionId,
                            resourceGroupName, lbName, "FrontendIPConfigurations", frontendIpConfigName)
                        },
                        Protocol = TransportProtocol.Tcp,
                        FrontendPort = 3390,
                        BackendPort = 3389,
                        IdleTimeoutInMinutes = 15,
                        EnableFloatingIP = false,
                    }
                }
            };

            // Create the loadBalancer
            var loadBalancerContainer = resourceGroup.GetLoadBalancers();
            LoadBalancer loadBalancer  = (await loadBalancerContainer.CreateOrUpdateAsync(lbName, loadBalancerData)).Value;

            // Associate the nic with LB
            //nic1.GetNetworkInterfaceIPConfigurations().List().First().`
            // TODO: where do we have the following?
            //nic1.IpConfigurations.First().LoadBalancerBackendAddressPools.Add(getLoadBalancer.Value.BackendAddressPools.First());
            //nic1.IpConfigurations.First().LoadBalancerInboundNatRules.Add(getLoadBalancer.Value.InboundNatRules.First());
            //nic2.IpConfigurations.First().LoadBalancerBackendAddressPools.Add(getLoadBalancer.Value.BackendAddressPools.First());
            //nic3.IpConfigurations.First().LoadBalancerInboundNatRules.Add(getLoadBalancer.Value.InboundNatRules[1]);
            nic1.Data.IpConfigurations.First().LoadBalancerBackendAddressPools.Add(loadBalancer.Data.BackendAddressPools.First());
            nic1.Data.IpConfigurations.First().LoadBalancerInboundNatRules.Add(loadBalancer.Data.InboundNatRules[0]);
            nic2.Data.IpConfigurations.First().LoadBalancerBackendAddressPools.Add(loadBalancer.Data.BackendAddressPools.First());
            nic2.Data.IpConfigurations.First().LoadBalancerInboundNatRules.Add(loadBalancer.Data.InboundNatRules[1]);
            nic3.Data.IpConfigurations.First().LoadBalancerBackendAddressPools.Add(loadBalancer.Data.BackendAddressPools.First());

            // Put Nics
            var networkInterfaceContainer = resourceGroup.GetNetworkInterfaces();
            var createOrUpdateOperation1 = await networkInterfaceContainer.CreateOrUpdateAsync(nic1name, nic1.Data);
            await createOrUpdateOperation1.WaitForCompletionAsync();

            var createOrUpdateOperation2 = await networkInterfaceContainer.CreateOrUpdateAsync(nic2name, nic2.Data);
            await createOrUpdateOperation2.WaitForCompletionAsync();

            var createOrUpdateOperation3 = await networkInterfaceContainer.CreateOrUpdateAsync(nic3name, nic3.Data);
            await createOrUpdateOperation3.WaitForCompletionAsync();

            // Get Nics
            await networkInterfaceContainer.GetAsync(nic1name);
            await networkInterfaceContainer.GetAsync(nic2name);
            await networkInterfaceContainer.GetAsync(nic3name);

            // Get lb with expanded nics from nat rules
            loadBalancer = await loadBalancerContainer.GetAsync(lbName, "InboundNatRules/backendIPConfiguration");

            foreach (InboundNatRule natRule in loadBalancer.GetInboundNatRules().GetAll())
            {
                Assert.NotNull(natRule.Data.BackendIPConfiguration);
                Assert.NotNull(natRule.Data.BackendIPConfiguration.Id);
                //Assert.NotNull(natRule.Data.BackendIPConfiguration.Name);
                //Assert.NotNull(natRule.Data.BackendIPConfiguration.Etag);
                //Assert.AreEqual(natRule.Id, natRule.Data.BackendIPConfiguration.LoadBalancerInboundNatRules[0].Id);
            }

            // Get lb with expanded nics from pools
            loadBalancer = await loadBalancerContainer.GetAsync(lbName, "BackendAddressPools/backendIPConfigurations");

            foreach (BackendAddressPool pool in loadBalancer.GetBackendAddressPools().GetAll())
            {
                foreach (NetworkInterfaceIPConfiguration ipconfig in loadBalancer.GetBackendAddressPools().GetAll().First().Data.BackendIPConfigurations)
                {
                    Assert.NotNull(ipconfig.Id);
                    //Assert.NotNull(ipconfig.Name);
                    //Assert.NotNull(ipconfig.Etag);
                    //Assert.AreEqual(pool.Id, ipconfig.LoadBalancerBackendAddressPools[0].Id);
                }
            }

            // Get lb with expanded publicip
            loadBalancer = await loadBalancerContainer.GetAsync(lbName, "FrontendIPConfigurations/PublicIPAddress");
            foreach (FrontendIPConfiguration ipconfig in loadBalancer.Data.FrontendIPConfigurations)
            {
                Assert.NotNull(ipconfig.PublicIPAddress);
                Assert.NotNull(ipconfig.PublicIPAddress.Id);
                Assert.NotNull(ipconfig.PublicIPAddress.Name);
                Assert.NotNull(ipconfig.PublicIPAddress.Etag);
                Assert.AreEqual(ipconfig.Id, ipconfig.PublicIPAddress.IpConfiguration.Id);
            }

            // Get NIC with expanded subnet
            nic1 = await networkInterfaceContainer.GetAsync(nic1name, "IPConfigurations/Subnet");
            foreach (NetworkInterfaceIPConfiguration ipconfig in nic1.GetNetworkInterfaceIPConfigurations())
            {
                Assert.NotNull(ipconfig.Subnet);
                Assert.NotNull(ipconfig.Subnet.Id);
                //Assert.NotNull(ipconfig.Subnet.Name);
                //Assert.NotNull(ipconfig.Subnet.Etag);
                //Assert.IsNotEmpty(ipconfig.Subnet.IpConfigurations);
            }

            // Get subnet with expanded ipconfigurations
            Response<Subnet> subnet = await resourceGroup.GetVirtualNetworks().Get(vnetName).Value.GetSubnets().GetAsync(
                subnetName,
                "IPConfigurations");

            foreach (IPConfiguration ipconfig in subnet.Value.Data.IpConfigurations)
            {
                Assert.NotNull(ipconfig.Id);
                //Assert.NotNull(ipconfig.Name);
                //Assert.NotNull(ipconfig.Etag);
                Assert.NotNull(ipconfig.PrivateIPAddress);
            }

            // Get publicIPAddress with expanded ipconfigurations
            Response<PublicIPAddress> publicip = await resourceGroup.GetPublicIPAddresses().GetAsync(
                lbPublicIpName,
                "IPConfiguration");

            Assert.NotNull(publicip.Value.Data.IpConfiguration);
            Assert.NotNull(publicip.Value.Data.IpConfiguration.Id);
            //Assert.NotNull(publicip.Value.Data.IpConfiguration.Name);
            //Assert.NotNull(publicip.Value.Data.IpConfiguration.Etag);

            // Delete LoadBalancer
            Operation deleteOperation = await loadBalancerContainer.Get(lbName).Value.DeleteAsync();
            await deleteOperation.WaitForCompletionResponseAsync();

            // Verify Delete
            AsyncPageable<LoadBalancer> listLoadBalancerAP = loadBalancerContainer.GetAllAsync();
            List<LoadBalancer> listLoadBalancer = await listLoadBalancerAP.ToEnumerableAsync();
            Assert.IsEmpty(listLoadBalancer);

            // Delete all NetworkInterfaces
            await networkInterfaceContainer.Get(nic1name).Value.DeleteAsync();
            await networkInterfaceContainer.Get(nic2name).Value.DeleteAsync();
            await networkInterfaceContainer.Get(nic3name).Value.DeleteAsync();

            // Delete all PublicIPAddresses
            await resourceGroup.GetPublicIPAddresses().Get(lbPublicIpName).Value.DeleteAsync();
        }
    }
}
