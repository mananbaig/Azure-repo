﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.GuestConfiguration.Models;
using Azure.ResourceManager.GuestConfiguration.Tests.Utilities;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.ResourceManager.GuestConfiguration.Tests
{
    public class GuestConfigurationManagementTestBase : ManagementRecordedTestBase<GuestConfigurationManagementTestEnvironment>
    {
        public string SubscriptionId { get; set; }
        public ArmClient ArmClient { get; private set; }
        public ResourceGroupCollection ResourceGroupsOperations { get; set; }
        public SubscriptionResource Subscription { get; set; }

        protected GuestConfigurationManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected GuestConfigurationManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public void CreateCommonClient()
        {
            ArmClient = GetArmClient();
        }

        protected async Task InitializeClients()
        {
            ArmClient = GetArmClient();
            Subscription = await ArmClient.GetDefaultSubscriptionAsync();
            ResourceGroupsOperations = Subscription.GetResourceGroups();
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(ResourceGroupCollection resourceGroupsOperations, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new(location);
            ArmOperation<ResourceGroupResource> lro = await resourceGroupsOperations.CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected async Task<GuestConfigurationAssignmentCollection> GetGuestConfigurationAssignmentCollectionAsync(string resourceGroupName, string vmName)
        {
            ResourceGroupResource rg = await GetResourceGroupAsync(resourceGroupName);
            return rg.GetGuestConfigurationAssignments(vmName);
        }
        public async Task<ResourceGroupResource> GetResourceGroupAsync(string name)
        {
            return await Subscription.GetResourceGroups().GetAsync(name);
        }
        protected static GuestConfigurationAssignmentProperties GetDefaultGuestConfigurationAssignmentProperties()
        {
            //var configurationParameter = new ConfigurationParameter("[InstalledApplication]bwhitelistedapp;Name", "NotePad,sql");
            var configurationParameter = new ConfigurationParameter();
            var configurationParameterList = new List<ConfigurationParameter>() { configurationParameter };

            //var configurationSetting = new ConfigurationSetting(GuestConfigurationManagementUtilities.DefaultConfigurationMode, true, new ActionAfterReboot("ContinueConfiguration"), 25, true, 10);
            GuestConfigurationNavigation guestConfigurationNavigation = new GuestConfigurationNavigation(GuestConfigurationManagementUtilities.DefaultKind, GuestConfigurationManagementUtilities.DefaultAssignmentName,
            GuestConfigurationManagementUtilities.DefaultAssignmentVersion, null, null, GuestConfigurationManagementUtilities.DefaultAssignmentType,
            null, "Builtin", configurationParameterList, configurationParameterList, null);

            return new GuestConfigurationAssignmentProperties()
            {
                Context = GuestConfigurationManagementUtilities.DefaultContext,
                GuestConfiguration = guestConfigurationNavigation,
            };
          }

        protected static GuestConfigurationAssignmentData GetDefaultContactGuestConfigurationAssignmentData(string id)
        {
            GuestConfigurationAssignmentProperties properties = GetDefaultGuestConfigurationAssignmentProperties();

            return new GuestConfigurationAssignmentData(
                id,
                GuestConfigurationManagementUtilities.DefaultAssignmentName,
                GuestConfigurationManagementUtilities.DefaultResourceLocation,
                GuestConfigurationManagementUtilities.DefaultResourceType,
                properties,
                new SystemData()
                );
        }
    }
}
