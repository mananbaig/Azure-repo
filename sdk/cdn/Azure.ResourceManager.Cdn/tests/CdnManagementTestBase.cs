﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Cdn.Tests.Helper;
using NUnit.Framework;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Tests
{
    public class CdnManagementTestBase : ManagementRecordedTestBase<CdnManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }

        protected CdnManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected CdnManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public void CreateCommonClient()
        {
            Client = GetArmClient();
        }

        protected async Task<ResourceGroup> CreateResourceGroup(Subscription subscription, string rgNamePrefix)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(AzureLocation.WestUS);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected async Task<ProfileResource> CreateCdnProfile(ResourceGroup rg, string profileName, CdnSkuName skuName)
        {
            ProfileData input = ResourceDataHelper.CreateProfileData(skuName);
            var lro = await rg.GetProfiles().CreateOrUpdateAsync(WaitUntil.Completed, profileName, input);
            return lro.Value;
        }

        protected async Task<ProfileResource> CreateAfdProfile(ResourceGroup rg, string profileName, CdnSkuName skuName)
        {
            ProfileData input = ResourceDataHelper.CreateAfdProfileData(skuName);
            var lro = await rg.GetProfiles().CreateOrUpdateAsync(WaitUntil.Completed, profileName, input);
            return lro.Value;
        }

        protected async Task<CdnEndpointResource> CreateCdnEndpoint(ProfileResource profile, string endpointName)
        {
            CdnEndpointData input = ResourceDataHelper.CreateEndpointData();
            DeepCreatedOrigin deepCreatedOrigin = ResourceDataHelper.CreateDeepCreatedOrigin();
            input.Origins.Add(deepCreatedOrigin);
            var lro = await profile.GetCdnEndpoints().CreateOrUpdateAsync(WaitUntil.Completed, endpointName, input);
            return lro.Value;
        }

        protected async Task<CdnEndpointResource> CreateCdnEndpointWithOriginGroup(ProfileResource profile, string endpointName)
        {
            CdnEndpointData input = ResourceDataHelper.CreateEndpointData();
            DeepCreatedOrigin deepCreatedOrigin = ResourceDataHelper.CreateDeepCreatedOrigin();
            DeepCreatedOriginGroup deepCreatedOriginGroup = ResourceDataHelper.CreateDeepCreatedOriginGroup();
            deepCreatedOriginGroup.Origins.Add(new WritableSubResource
            {
                Id = new ResourceIdentifier($"{profile.Id}/endpoints/{endpointName}/origins/{deepCreatedOrigin.Name}")
            });
            input.Origins.Add(deepCreatedOrigin);
            input.OriginGroups.Add(deepCreatedOriginGroup);
            input.DefaultOriginGroup = new EndpointPropertiesUpdateParametersDefaultOriginGroup
            {
                Id = new ResourceIdentifier($"{profile.Id}/endpoints/{endpointName}/originGroups/{deepCreatedOriginGroup.Name}")
            };
            var lro = await profile.GetCdnEndpoints().CreateOrUpdateAsync(WaitUntil.Completed, endpointName, input);
            return lro.Value;
        }

        //protected async Task<AfdEndpoint> CreateAfdEndpoint(ProfileResource profile, string endpointName)
        //{
        //    AfdEndpointData input = ResourceDataHelper.CreateAfdEndpointData();
        //    var lro = await profile.GetAfdEndpoints().CreateOrUpdateAsync(true, endpointName, input);
        //    return lro.Value;
        //}

        protected async Task<CdnOriginResource> CreateCdnOrigin(CdnEndpointResource endpoint, string originName)
        {
            CdnOriginData input = ResourceDataHelper.CreateOriginData();
            var lro = await endpoint.GetCdnOrigins().CreateOrUpdateAsync(WaitUntil.Completed, originName, input);
            return lro.Value;
        }

        //protected async Task<AfdOrigin> CreateAfdOrigin(AfdOriginGroup originGroup, string originName)
        //{
        //    AfdOriginData input = ResourceDataHelper.CreateAfdOriginData();
        //    var lro = await originGroup.GetAfdOrigins().CreateOrUpdateAsync(true, originName, input);
        //    return lro.Value;
        //}

        protected async Task<CdnOriginGroupResource> CreateCdnOriginGroup(CdnEndpointResource endpoint, string originGroupName, string originName)
        {
            CdnOriginGroupData input = ResourceDataHelper.CreateOriginGroupData();
            input.Origins.Add(new WritableSubResource
            {
                Id = new ResourceIdentifier($"{endpoint.Id}/origins/{originName}")
            });
            var lro = await endpoint.GetCdnOriginGroups().CreateOrUpdateAsync(WaitUntil.Completed, originGroupName, input);
            return lro.Value;
        }

        //protected async Task<AfdOriginGroup> CreateAfdOriginGroup(ProfileResource profile, string originGroupName)
        //{
        //    AfdOriginGroupData input = ResourceDataHelper.CreateAfdOriginGroupData();
        //    var lro = await profile.GetAfdOriginGroups().CreateOrUpdateAsync(true, originGroupName, input);
        //    return lro.Value;
        //}

        protected async Task<CdnCustomDomainResource> CreateCdnCustomDomain(CdnEndpointResource endpoint, string customDomainName, string hostName)
        {
            CustomDomainOptions input = ResourceDataHelper.CreateCdnCustomDomainData(hostName);
            var lro = await endpoint.GetCdnCustomDomains().CreateOrUpdateAsync(WaitUntil.Completed, customDomainName, input);
            return lro.Value;
        }

        //protected async Task<AfdCustomDomain> CreateAfdCustomDomain(ProfileResource profile, string customDomainName, string hostName)
        //{
        //    AfdCustomDomainData input = ResourceDataHelper.CreateAfdCustomDomainData(hostName);
        //    var lro = await profile.GetAfdCustomDomains().CreateOrUpdateAsync(true, customDomainName, input);
        //    return lro.Value;
        //}

        //protected async Task<AfdRuleSet> CreateAfdRuleSet(ProfileResource profile, string ruleSetName)
        //{
        //    var lro = await profile.GetAfdRuleSets().CreateOrUpdateAsync(true, ruleSetName);
        //    return lro.Value;
        //}

        //protected async Task<AfdRule> CreateAfdRule(AfdRuleSet ruleSet, string ruleName)
        //{
        //    AfdRuleData input = ResourceDataHelper.CreateAfdRuleData();
        //    DeliveryRuleCondition deliveryRuleCondition = ResourceDataHelper.CreateDeliveryRuleCondition();
        //    DeliveryRuleActionAutoGenerated deliveryRuleAction = ResourceDataHelper.CreateDeliveryRuleOperation();
        //    input.Conditions.Add(deliveryRuleCondition);
        //    input.Actions.Add(deliveryRuleAction);
        //    var lro = await ruleSet.GetAfdRules().CreateOrUpdateAsync(true, ruleName, input);
        //    return lro.Value;
        //}

        //protected async Task<AfdRoute> CreateAfdRoute(AfdEndpoint endpoint, string routeName, AfdOriginGroup originGroup, AfdRuleSet ruleSet)
        //{
        //    AfdRouteData input = ResourceDataHelper.CreateAfdRouteData(originGroup);
        //    input.RuleSets.Add(new WritableSubResource
        //    {
        //        Id = ruleSet.Id
        //    });
        //    input.PatternsToMatch.Add("/*");
        //    var lro = await endpoint.GetAfdRoutes().CreateOrUpdateAsync(true, routeName, input);
        //    return lro.Value;
        //}

        //protected async Task<AfdSecurityPolicy> CreateAfdSecurityPolicy(ProfileResource profile, AfdEndpoint endpoint, string securityPolicyName)
        //{
        //    AfdSecurityPolicyData input = ResourceDataHelper.CreateAfdSecurityPolicyData(endpoint);
        //    SecurityPolicyWebApplicationFirewallAssociation securityPolicyWebApplicationFirewallAssociation = new SecurityPolicyWebApplicationFirewallAssociation();
        //    securityPolicyWebApplicationFirewallAssociation.Domains.Add(new WritableSubResource
        //    {
        //        Id = endpoint.Id
        //    });
        //    securityPolicyWebApplicationFirewallAssociation.PatternsToMatch.Add("/*");
        //    ((SecurityPolicyWebApplicationFirewallParameters)input.Parameters).Associations.Add(securityPolicyWebApplicationFirewallAssociation);
        //    var lro = await profile.GetAfdSecurityPolicies().CreateOrUpdateAsync(true, securityPolicyName, input);
        //    return lro.Value;
        //}

        //protected async Task<AfdSecret> CreateAfdSecret(ProfileResource profile, string secretName)
        //{
        //    AfdSecretData input = ResourceDataHelper.CreateAfdSecretData();
        //    var lro = await profile.GetAfdSecrets().CreateOrUpdateAsync(true, secretName, input);
        //    return lro.Value;
        //}

        protected async Task<CdnWebApplicationFirewallPolicyResource> CreatePolicy(ResourceGroup rg, string policyName)
        {
            CdnWebApplicationFirewallPolicyData input = ResourceDataHelper.CreateCdnWebApplicationFirewallPolicyData();
            var lro = await rg.GetCdnWebApplicationFirewallPolicies().CreateOrUpdateAsync(WaitUntil.Completed, policyName, input);
            return lro.Value;
        }
    }
}
