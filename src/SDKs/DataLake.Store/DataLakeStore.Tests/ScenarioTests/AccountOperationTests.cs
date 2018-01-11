﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.Store;
using Microsoft.Azure.Management.DataLake.Store.Models;
using Microsoft.Azure.Test;
using Microsoft.Rest.Azure;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xunit;
namespace DataLakeStore.Tests
{
    public class AccountOperationTests : TestBase
    {   
        private CommonTestFixture commonData;

        [Fact]
        public void CreateGetUpdateDeleteTest()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                commonData = new CommonTestFixture(context);
                var clientToUse = this.GetDataLakeStoreAccountManagementClient(context);

                // Ensure that the account name is available
                var checkNameParam = new CheckNameAvailabilityParameters
                {
                    Name = commonData.DataLakeStoreAccountName
                };

                var responseNameCheck = clientToUse.Account.CheckNameAvailability("EastUS2", checkNameParam);

                Assert.True(responseNameCheck.NameAvailable);

                // Create a test account
                var responseCreate =
                    clientToUse.Account.Create(resourceGroupName: commonData.ResourceGroupName, name: commonData.DataLakeStoreAccountName,
                        parameters: new DataLakeStoreAccount
                        {
                            Location = commonData.Location,
                            Tags = new Dictionary<string, string>
                            {
                            { "testkey","testvalue" }
                            },
                            Identity = new EncryptionIdentity(),
                            EncryptionConfig = new EncryptionConfig
                            {
                                Type = EncryptionConfigType.ServiceManaged
                            },
                            EncryptionState = EncryptionState.Enabled,
                            NewTier = TierType.Commitment1TB
                        });

                Assert.Equal(DataLakeStoreAccountStatus.Succeeded, responseCreate.ProvisioningState);

                // Verify that the account name is no longer available
                responseNameCheck = clientToUse.Account.CheckNameAvailability("EastUS2", checkNameParam);

                Assert.False(responseNameCheck.NameAvailable);

                // Get the account and ensure that all the values are properly set.
                var responseGet = clientToUse.Account.Get(commonData.ResourceGroupName, commonData.DataLakeStoreAccountName);

                // Validate the account creation process
                Assert.Equal(DataLakeStoreAccountStatus.Succeeded, responseGet.ProvisioningState);
                Assert.NotNull(responseCreate.Id);
                Assert.NotNull(responseGet.Id);
                Assert.Contains(commonData.DataLakeStoreAccountName, responseGet.Id);
                Assert.Contains(commonData.DataLakeStoreAccountName, responseGet.Endpoint);
                Assert.Equal(commonData.Location, responseGet.Location);
                Assert.Equal(commonData.DataLakeStoreAccountName, responseGet.Name);
                Assert.Equal("Microsoft.DataLakeStore/accounts", responseGet.Type);
                Assert.Equal(TierType.Commitment1TB, responseGet.CurrentTier);
                Assert.Equal(TierType.Commitment1TB, responseGet.NewTier);

                // Wait for provisioning state to be Succeeded
                // We will wait a maximum of 15 minutes for this to happen and then report failures
                int timeToWaitInMinutes = 15;
                int minutesWaited = 0;
                while (responseGet.ProvisioningState != DataLakeStoreAccountStatus.Succeeded && responseGet.ProvisioningState != DataLakeStoreAccountStatus.Failed && minutesWaited <= timeToWaitInMinutes)
                {
                    TestUtilities.Wait(60000); // Wait for one minute and then go again.
                    minutesWaited++;
                    responseGet = clientToUse.Account.Get(commonData.ResourceGroupName, commonData.DataLakeStoreAccountName);
                }

                // Confirm that the account creation did succeed
                Assert.True(responseGet.ProvisioningState == DataLakeStoreAccountStatus.Succeeded);

                // Validate the encryption state is set
                Assert.Equal(EncryptionState.Enabled, responseGet.EncryptionState.GetValueOrDefault());
                Assert.True(responseGet.Identity.PrincipalId.HasValue);
                Assert.True(responseGet.Identity.TenantId.HasValue);
                Assert.Equal(EncryptionConfigType.ServiceManaged, responseGet.EncryptionConfig.Type);

                // Update the account and confirm the updates make it in.
                var newAccount = responseGet;
                newAccount.Tags = new Dictionary<string, string>
                {
                    { "updatedKey", "updatedValue" }
                };

                var updateResponse = clientToUse.Account.Update(commonData.ResourceGroupName, commonData.DataLakeStoreAccountName,
                new DataLakeStoreAccountUpdateParameters
                {
                    Tags = new Dictionary<string, string>
                    {
                        { "updatedKey", "updatedValue" }
                    },
                    NewTier = TierType.Consumption
                });

                Assert.Equal(DataLakeStoreAccountStatus.Succeeded, updateResponse.ProvisioningState);

                var updateResponseGet = clientToUse.Account.Get(commonData.ResourceGroupName, commonData.DataLakeStoreAccountName);

                Assert.NotNull(updateResponse.Id);
                Assert.Contains(responseGet.Id, updateResponseGet.Id);
                Assert.Equal(responseGet.Location, updateResponseGet.Location);
                Assert.Equal(newAccount.Name, updateResponseGet.Name);
                Assert.Equal(responseGet.Type, updateResponseGet.Type);

                // Verify the new tags. NOTE: sequence equal is not ideal if we have more than 1 tag, since the ordering can change.
                Assert.True(updateResponseGet.Tags.SequenceEqual(newAccount.Tags));

                Assert.Equal(TierType.Commitment1TB, updateResponseGet.CurrentTier);
                Assert.Equal(TierType.Consumption, updateResponseGet.NewTier);

                // Create another account and ensure that list account returns both
                var accountToChange = updateResponseGet;
                var newAcctName = accountToChange.Name + "acct2";
                clientToUse.Account.Create(commonData.ResourceGroupName, newAcctName, new DataLakeStoreAccount
                {
                    Location = accountToChange.Location
                });

                var listResponse = clientToUse.Account.List();

                // Assert that there are at least two accounts in the list
                Assert.True(listResponse.Count() > 1);

                // Now list by resource group:
                listResponse = clientToUse.Account.ListByResourceGroup(commonData.ResourceGroupName);

                // Assert that there are at least two accounts in the list
                Assert.True(listResponse.Count() > 1);

                // Test that the account exists
                Assert.True(clientToUse.Account.Exists(commonData.ResourceGroupName, newAccount.Name));

                // Check that Locations_GetCapability and Operations_List are functional
                var responseGetCapability = clientToUse.Locations.GetCapability("EastUS2");

                Assert.NotNull(responseGetCapability);

                var responseListOps = clientToUse.Operations.List();

                Assert.NotNull(responseListOps);

                // Delete the account and confirm that it is deleted.
                clientToUse.Account.Delete(commonData.ResourceGroupName, newAccount.Name);

                // Delete the account again and make sure it continues to result in a succesful code.
                clientToUse.Account.Delete(commonData.ResourceGroupName, newAccount.Name);

                // Delete the account with its old name, which should also succeed.
                clientToUse.Account.Delete(commonData.ResourceGroupName, commonData.DataLakeStoreAccountName);

                // Test that the account is gone
                Assert.False(clientToUse.Account.Exists(commonData.ResourceGroupName, newAccount.Name));
            }
        }
        [Fact]
        public void FirewallAndTrustedProviderTest()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                commonData = new CommonTestFixture(context);
                var clientToUse = this.GetDataLakeStoreAccountManagementClient(context);

                // Create a an account with trusted ID provider and firewall rules.
                var adlsAccountName = TestUtilities.GenerateName("adlsacct");

                var firewallStart = "127.0.0.1";
                var firewallEnd = "127.0.0.2";
                var firewallRuleName1 = TestUtilities.GenerateName("firerule1");

                var trustedId = TestUtilities.GenerateGuid();
                var trustedUrl = string.Format("https://sts.windows.net/{0}", trustedId.ToString());
                var trustedIdName = TestUtilities.GenerateName("trustedrule1");

                var responseCreate =
                    clientToUse.Account.Create(resourceGroupName: commonData.ResourceGroupName, name: adlsAccountName,
                        parameters: new DataLakeStoreAccount
                        {
                            Location = commonData.Location,
                            FirewallRules = new List<FirewallRule>
                            {
                                new FirewallRule(firewallStart, firewallEnd, name: firewallRuleName1)
                            },
                            TrustedIdProviders = new List<TrustedIdProvider>
                            {
                                new TrustedIdProvider(trustedUrl, name: trustedIdName)
                            },
                            FirewallState = FirewallState.Enabled,
                            TrustedIdProviderState = TrustedIdProviderState.Enabled,
                            FirewallAllowAzureIps = FirewallAllowAzureIpsState.Enabled
                            
                        });

                Assert.Equal(DataLakeStoreAccountStatus.Succeeded, responseCreate.ProvisioningState);

                // Get the account and ensure that all the values are properly set.
                var responseGet = clientToUse.Account.Get(commonData.ResourceGroupName, adlsAccountName);

                // Validate the account creation process
                Assert.Equal(DataLakeStoreAccountStatus.Succeeded, responseGet.ProvisioningState);
                Assert.NotNull(responseCreate.Id);
                Assert.NotNull(responseGet.Id);
                Assert.Contains(adlsAccountName, responseGet.Id);
                Assert.Contains(adlsAccountName, responseGet.Endpoint);
                Assert.Equal(commonData.Location, responseGet.Location);
                Assert.Equal(adlsAccountName, responseGet.Name);
                Assert.Equal("Microsoft.DataLakeStore/accounts", responseGet.Type);

                // Validate firewall state
                Assert.Equal(FirewallState.Enabled, responseGet.FirewallState);
                Assert.Equal(1, responseGet.FirewallRules.Count());
                Assert.Equal(firewallStart, responseGet.FirewallRules[0].StartIpAddress);
                Assert.Equal(firewallEnd, responseGet.FirewallRules[0].EndIpAddress);
                Assert.Equal(firewallRuleName1, responseGet.FirewallRules[0].Name);
                Assert.Equal(FirewallAllowAzureIpsState.Enabled, responseGet.FirewallAllowAzureIps);

                // Validate trusted identity provider state
                Assert.Equal(TrustedIdProviderState.Enabled, responseGet.TrustedIdProviderState);
                Assert.Equal(1, responseGet.TrustedIdProviders.Count());
                Assert.Equal(trustedUrl, responseGet.TrustedIdProviders[0].IdProvider);
                Assert.Equal(trustedIdName, responseGet.TrustedIdProviders[0].Name);

                // Test getting the specific firewall rules
                var firewallRule = clientToUse.FirewallRules.Get(commonData.ResourceGroupName, adlsAccountName, firewallRuleName1);

                Assert.Equal(firewallStart, firewallRule.StartIpAddress);
                Assert.Equal(firewallEnd, firewallRule.EndIpAddress);
                Assert.Equal(firewallRuleName1, firewallRule.Name);

                var updatedFirewallStart = "192.168.0.0";
                var updatedFirewallEnd = "192.168.0.1";
                firewallRule.StartIpAddress = updatedFirewallStart;
                firewallRule.EndIpAddress = updatedFirewallEnd;

                // Update the firewall rule to change the start/end ip addresses
                firewallRule = clientToUse.FirewallRules.CreateOrUpdate(commonData.ResourceGroupName, adlsAccountName,firewallRuleName1, firewallRule);

                Assert.Equal(updatedFirewallStart, firewallRule.StartIpAddress);
                Assert.Equal(updatedFirewallEnd, firewallRule.EndIpAddress);
                Assert.Equal(firewallRuleName1, firewallRule.Name);

                // Just update the firewall rule start IP
                firewallRule = clientToUse.FirewallRules.Update(
                    commonData.ResourceGroupName,
                    adlsAccountName,
                    firewallRuleName1,
                    new UpdateFirewallRuleParameters
                    {
                        StartIpAddress = firewallStart
                    });

                Assert.Equal(firewallStart, firewallRule.StartIpAddress);
                Assert.Equal(updatedFirewallEnd, firewallRule.EndIpAddress);
                Assert.Equal(firewallRuleName1, firewallRule.Name);

                // Remove the firewall rule and verify it is gone.
                clientToUse.FirewallRules.Delete(commonData.ResourceGroupName, adlsAccountName, firewallRuleName1);

                try
                {
                    firewallRule = clientToUse.FirewallRules.Get(commonData.ResourceGroupName, adlsAccountName, firewallRuleName1);
                    Assert.True(false, "Attempting to retrieve a deleted firewall rule did not throw.");
                }
                catch (CloudException e)
                {
                    Assert.Equal(HttpStatusCode.NotFound, e.Response.StatusCode);
                }

                // Test getting the specific trusted identity provider
                var trustedIdProvider = clientToUse.TrustedIdProviders.Get(commonData.ResourceGroupName, adlsAccountName, trustedIdName);

                Assert.Equal(trustedUrl, trustedIdProvider.IdProvider);
                Assert.Equal(trustedIdName, trustedIdProvider.Name);

                var updatedIdUrl = string.Format("https://sts.windows.net/{0}", TestUtilities.GenerateGuid().ToString());
                trustedIdProvider.IdProvider = updatedIdUrl;

                // Update the trusted id provider
                trustedIdProvider = clientToUse.TrustedIdProviders.CreateOrUpdate(commonData.ResourceGroupName, adlsAccountName, trustedIdName, trustedIdProvider);

                Assert.Equal(updatedIdUrl, trustedIdProvider.IdProvider);
                Assert.Equal(trustedIdName, trustedIdProvider.Name);

                // Update it with a patch
                trustedIdProvider = clientToUse.TrustedIdProviders.Update(
                    commonData.ResourceGroupName,
                    adlsAccountName,
                    trustedIdName,
                    new UpdateTrustedIdProviderParameters
                    {
                        IdProvider = trustedUrl
                    });

                Assert.Equal(trustedUrl, trustedIdProvider.IdProvider);
                Assert.Equal(trustedIdName, trustedIdProvider.Name);

                // Remove the firewall rule and verify it is gone.
                clientToUse.TrustedIdProviders.Delete(commonData.ResourceGroupName, adlsAccountName, trustedIdName);

                try
                {
                    trustedIdProvider = clientToUse.TrustedIdProviders.Get(commonData.ResourceGroupName, adlsAccountName, trustedIdName);
                    Assert.True(false, "Attempting to retrieve a deleted trusted identity provider did not throw.");
                }
                catch (CloudException e)
                {
                    Assert.Equal(HttpStatusCode.NotFound, e.Response.StatusCode);
                }
            }
        }
    }
}
