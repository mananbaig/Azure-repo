// ------------------------------------------------------------------------------------------------
// <copyright file="DnsResolverScenarioTests.cs" company="Microsoft Corporation">
//   Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace DnsResolver.Tests.ScenarioTests
{
    using FluentAssertions;
    using Microsoft.Azure.Management.DnsResolver;
    using Microsoft.Azure.Management.DnsResolver.Models;
    using Microsoft.Azure.Management.Resources;
    using Microsoft.Rest.Azure;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using Xunit;
    using Xunit.Abstractions;

    public class DnsResolverScenarioTests : BaseScenarioTests
    {
        public DnsResolverScenarioTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void PutDnsResolver_ResolverNotExists_ExpectResolverCreated()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);

            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            createdDnsResolver.Should().NotBeNull();
            createdDnsResolver.Name.Should().Be(dnsResolverName);
            createdDnsResolver.Tags.Should().BeNull();
            createdDnsResolver.Location.Should().Be(Constants.DnsResolverLocation);
            createdDnsResolver.Etag.Should().NotBeNullOrEmpty();
            createdDnsResolver.VirtualNetwork.Id.Should().Be(dnsResolver.VirtualNetwork.Id);
            createdDnsResolver.NumberOfInboundEndpoints.Should().Be(0);
            createdDnsResolver.ProvisioningState.Should().Be(Constants.ProvisioningStateSucceeded);
        }

        [Fact]
        public void PutDnsResolver_ResolverNotExistsWithTags_ExpectResolverCreated()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolverTags = TestDataGenerator.GenerateTags();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName, tags: dnsResolverTags);

            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            createdDnsResolver.Should().NotBeNull();
            createdDnsResolver.Tags.Should().NotBeNull().And.BeEquivalentTo(dnsResolverTags);
        }

        [Fact]
        public void PutDnsResolver_ResolverNotExistsWithMalformedVirtualNetworkArmId_ExpectError()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            dnsResolver.VirtualNetwork.Id = TestDataGenerator.GetRandomString(15);

            Action createdDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            createdDnsResolverAction.Should().NotBeNull();
            createdDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }


        [Fact]
        public void PutDnsResolver_VirtualNetworkAttachedToAnotherVirtualNetwork_ResolvereNotExists_ExpectConflict()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);

            var firstCreatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);
            firstCreatedDnsResolver.Should().NotBeNull();

            var conflictDnsResolver = TestDataGenerator.GenerateDnsResolverWithoutVirtualNetwork(location: Constants.DnsResolverLocation);
            conflictDnsResolver.VirtualNetwork.Id = dnsResolver.VirtualNetwork.Id;

            Action createConflictDnsResolverAction = () =>  this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: TestDataGenerator.GenerateDnsResolverName(),
                parameters: dnsResolver);

           createConflictDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.Conflict);
        }

        [Fact]
        public void PutDnsResolver_ResolverNotExistsVirtualNetworkNotExists_ExpectFailure()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = TestDataGenerator.GenerateDnsResolverWithoutVirtualNetwork(location: Constants.DnsResolverLocation);
            dnsResolver.VirtualNetwork = TestDataGenerator.GenerateNonExistentVirtualNetwork(subscriptionId: this.SubscriptionId, resourceGroupName: resourceGroupName);

            Action createDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            createDnsResolverAction.Should().NotBeNull();
            createDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsUpdateWithNewVirtualNetwork_ExpectConflict()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);

            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            createdDnsResolver.Should().NotBeNull();
            createdDnsResolver.ProvisioningState.Should().Be(Constants.ProvisioningStateSucceeded);

            dnsResolver.VirtualNetwork = CreateVirtualNetwork(resourceGroupName: resourceGroupName);

            Action updateDnsResolverAction = () =>  this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            updateDnsResolverAction.Should().NotBeNull();
            updateDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.Conflict);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsUpdateWithVirtualNetworkUsedByAnotherResolver_ExpectConflict()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var firstdnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);

            var createdFirstdnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: firstdnsResolver);
            var secondDnsResolver = TestDataGenerator.GenerateDnsResolverWithoutVirtualNetwork(location: Constants.DnsResolverLocation);
            secondDnsResolver.VirtualNetwork = firstdnsResolver.VirtualNetwork;

            Action createSecondDnsResolver = () => this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: secondDnsResolver);

            createSecondDnsResolver.Should().NotBeNull();
            createSecondDnsResolver.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.Conflict);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsIfMatchWildCardSuccess_ExpectResolverUpdated()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            var ifMatch = "*";
            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);
            var tagsForUpdate = TestDataGenerator.GenerateTags();
            dnsResolver.Tags = tagsForUpdate;

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: dnsResolver,
                ifMatch: ifMatch);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.Tags.Should().BeEquivalentTo(tagsForUpdate);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsIfMatchSuccessAddTags_ExpectResolverUpdated()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                 resourceGroupName: resourceGroupName,
                 dnsResolverName: dnsResolverName,
                 parameters: dnsResolver);

            var addedTags = TestDataGenerator.GenerateTags();
            dnsResolver.Tags = addedTags;
            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: dnsResolver,
                ifMatch: createdDnsResolver.Etag);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.ProvisioningState.Should().Be(Constants.ProvisioningStateSucceeded);
            updatedDnsResolver.Tags.Should().BeEquivalentTo(addedTags);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsIfMatchFailure_ExpectFailure()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var createdDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName);

            Action updateDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: createdDnsResolver, 
                ifMatch: TestDataGenerator.GetRandomString(10));

            updateDnsResolverAction.Should().NotBeNull();
            updateDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.PreconditionFailed);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsWithoutTagsToResolverWithTags_ExpectSuccess()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                 resourceGroupName: resourceGroupName,
                 dnsResolverName: dnsResolverName,
                 parameters: dnsResolver);
            var addedTags = TestDataGenerator.GenerateTags();
            dnsResolver.Tags = addedTags;

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: dnsResolver);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.Tags.Should().NotBeNull().And.BeEquivalentTo(addedTags);
        }

        [Fact]
        public void PutDnsResolver_ResolverExistsWithTagsToResolverWithTags_ExpectSuccess()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                 resourceGroupName: resourceGroupName,
                 dnsResolverName: dnsResolverName,
                 parameters: dnsResolver);
            var updatedDnsResolverTags = TestDataGenerator.GenerateTags(startFrom: dnsResolver.Tags.Count);
            dnsResolver.Tags = updatedDnsResolverTags;

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: dnsResolver);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.Tags.Should().NotBeNull().And.BeEquivalentTo(updatedDnsResolverTags);
        }


        [Fact]
        public void PutDnsResolver_ResolverExists_ExpectConflicts()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var existingDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName);
            var dnsResolverForCreation = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);

            Action createDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: existingDnsResolver.Name,
                parameters: dnsResolverForCreation);

            createDnsResolverAction.Should().NotBeNull();
            createDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.Conflict);
        }
 
        [Fact]
        public void PutDnsResolver_ResolverNotExistsIfNoneMatchSuccess_ExpectResolvereCreated()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolverForCreation = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            var ifNoneMatch = "*";

            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolverForCreation,
                ifNoneMatch: ifNoneMatch);

            createdDnsResolver.Should().NotBeNull();
            createdDnsResolver.ProvisioningState.Should().BeEquivalentTo(Constants.ProvisioningStateSucceeded.ToString());
        }

        [Fact]
        public void GetDnsResolver_ResolverExists_ExpectResolverRetrieved() 
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var createdDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName);

            var retrievedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.Get(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name);

            retrievedDnsResolver.Should().NotBeNull();
            retrievedDnsResolver.ProvisioningState.Should().Be(Constants.ProvisioningStateSucceeded);
        }

        [Fact]
        public void GetDnsResolver_ResolverNotExists_ExpectFailure()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();

            Action retrieveDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.Get(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName);

            retrieveDnsResolverAction.Should().NotBeNull();
            retrieveDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public void ListDnsResolversByVirtualNetwork_ValidVirtualNetworkAttachedToResolver_ExpectResolverRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);
            var createdDnsResolver = this.DnsResolverManagementClient.DnsResolvers.CreateOrUpdate(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver);

            var virtualNetworkName = ExtractArmResourceName(dnsResolver.VirtualNetwork.Id);
            var listResult = this.DnsResolverManagementClient.DnsResolvers.ListByVirtualNetwork(
                resourceGroupName: resourceGroupName,
                virtualNetworkName: virtualNetworkName);

            listResult.Should().NotBeNull();
            listResult.NextPageLink.Should().BeNull();

            var listedDnsResolvers = listResult.ToArray();
            listedDnsResolvers.Count().Should().Be(1);
        }

        [Fact]
        public void ListDnsResolversInSubscription_MultipleResolversPresent_ExpectResolverRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = 2;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName, numDnsResolvers: numDnsResolvers);

            var listResult = this.DnsResolverManagementClient.DnsResolvers.List();

            listResult.Should().NotBeNull();
            var listedDnsResolvers = listResult.ToArray();
            listedDnsResolvers.All(resolver => ValidateListedResolverIsExpected(resolver, createdDnsResolvers));
        }

        [Fact]
        public void ListDnsResolversInSubscription_MultipleResolversPresentWithTop_ExpectResolverRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = TestDataGenerator.GenerateInteger(2, 10);
            var topValue = numDnsResolvers - 1;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName, numDnsResolvers: numDnsResolvers);

            var listResult = this.DnsResolverManagementClient.DnsResolvers.List(
                top: topValue);

            listResult.Should().NotBeNull();
            listResult.NextPageLink.Should().NotBeNullOrEmpty();
            var listedDnsResolvers = listResult.ToArray();
            listedDnsResolvers.Count().Should().Be(topValue);
        }

        [Fact]
        public void ListDnsResolversInSubscription_MultipleResolversPresentWithNextLink_ExpectResolverRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = 2;
            var topValue = numDnsResolvers - 1;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName, numDnsResolvers: numDnsResolvers);
            var expectedResolver = createdDnsResolvers.OrderBy(x => x.Name).Skip(topValue);
            var initialListResult = this.DnsResolverManagementClient.DnsResolvers.List(top: topValue);

            var nextListResult = this.DnsResolverManagementClient.DnsResolvers.ListNext(initialListResult.NextPageLink);

            var nextListedResolvers = nextListResult.ToArray();
            nextListedResolvers.Count().Should().Be(numDnsResolvers - topValue);
            nextListedResolvers.All(resolver => ValidateListedResolverIsExpected(resolver, expectedResolver));
        }

        [Fact]
        public void ListDnsResolversInResourceGroup_NoResolverPresents_ExpectEmptyListRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;

            var listResult = this.DnsResolverManagementClient.DnsResolvers.ListByResourceGroup(resourceGroupName: resourceGroupName);

            listResult.Should().NotBeNull();
            var listedResolvers = listResult.ToArray();
            listedResolvers.Count().Should().Be(0);
        }

        [Fact]
        public void ListDnsResolversInResourceGroup_MultipleResolversPresent_ExpectResolversRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = 2;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName: resourceGroupName, numDnsResolvers: numDnsResolvers);

            var listResult = this.DnsResolverManagementClient.DnsResolvers.ListByResourceGroup(resourceGroupName: resourceGroupName);

            listResult.Should().NotBeNull();
            var listedResolvers = listResult.ToArray();
            listedResolvers.Count().Should().Be(numDnsResolvers);
            listedResolvers.All(resolver => ValidateListedResolverIsExpected(resolver, createdDnsResolvers));
        }

        [Fact]
        public void ListDnsResolversInResourceGroup_MultipleResolversPresentWithTop_ExpectResolversRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = 2;
            var topValue = numDnsResolvers - 1;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName: resourceGroupName, numDnsResolvers: numDnsResolvers);
            var expectedResolver = createdDnsResolvers.OrderBy(x => x.Name).Take(topValue);

            var listResult = this.DnsResolverManagementClient.DnsResolvers.ListByResourceGroup(
                resourceGroupName: resourceGroupName, 
                top: topValue);

            listResult.Should().NotBeNull();
            var listedResolvers = listResult.ToArray();
            listedResolvers.Count().Should().Be(topValue);
            listedResolvers.All(resolver => ValidateListedResolverIsExpected(resolver, expectedResolver));
        }

        [Fact]
        public void ListDnsResolversInResourceGroup_MultipleResolversPresentNextLink_ExpectResolversRetrieved()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = 2;
            var topValue = numDnsResolvers - 1;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName: resourceGroupName, numDnsResolvers: numDnsResolvers);
            var expectedResolver = createdDnsResolvers.OrderBy(x => x.Name).Skip(topValue);
            var initialListResult = this.DnsResolverManagementClient.DnsResolvers.ListByResourceGroup(
                resourceGroupName: resourceGroupName,
                top: topValue);

            var nextListResult = this.DnsResolverManagementClient.DnsResolvers.ListNext(
                initialListResult.NextPageLink);

            var nextListedResolvers = nextListResult.ToArray();
            nextListedResolvers.Count().Should().Be(numDnsResolvers - topValue);
            nextListedResolvers.All(resolver => ValidateListedResolverIsExpected(resolver, expectedResolver));
        }

        [Fact]
        public void ListDnsResolversInResourceGroup_MultipleResolversPresentWithTopZero_ExpectError()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var numDnsResolvers = 2;
            var topValue = 0;
            var createdDnsResolvers = this.CreateDnsResolvers(resourceGroupName: resourceGroupName, numDnsResolvers: numDnsResolvers);

            Action listDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.ListByResourceGroup(
                resourceGroupName: resourceGroupName,
                top: topValue);

            listDnsResolverAction.Should().NotBeNull();
            listDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

        }

        [Fact]
        public void PatchDnsResolver_ResolverNotExists_ExpectError()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = GenerateDnsResolverWithNewlyCreatedVirtualNetwork(location: Constants.DnsResolverLocation, resourceGroupName: resourceGroupName);

            Action patchDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.Update(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName,
                parameters: dnsResolver
                );

            patchDnsResolverAction.Should().Throw<CloudException>().Which.Response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public void PatchDnsResolver_ResolverExistsEmptyRequest_ExpectSuccess()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();
            var dnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName);

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.Update(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolver.Name,
                parameters: dnsResolver
                );

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.ProvisioningState.Should().BeEquivalentTo(Constants.ProvisioningStateSucceeded);
        }

        [Fact]
        public void PatchDnsResolver_ResolveExistsAddTags_ExpectSuccess()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var createdDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName, tags: null);
            var tagsForUpdate = TestDataGenerator.GenerateTags();
            createdDnsResolver.Tags = tagsForUpdate;

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.Update(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: createdDnsResolver);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.ProvisioningState.Should().BeEquivalentTo(Constants.ProvisioningStateSucceeded);
            updatedDnsResolver.Tags.Should().BeEquivalentTo(tagsForUpdate);
        }

        [Fact]
        public void PatchDnsResolver_ResolverExistsChangeTags_ExpectSuccess()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var createdDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName, tags: TestDataGenerator.GenerateTags());
            var tagsForUpdate = TestDataGenerator.GenerateTags();
            createdDnsResolver.Tags = tagsForUpdate;

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.Update(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: createdDnsResolver);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.ProvisioningState.Should().BeEquivalentTo(Constants.ProvisioningStateSucceeded);
            updatedDnsResolver.Tags.Should().BeEquivalentTo(tagsForUpdate);
        }

        [Fact]
        public void PatchDnsResolver_ResolverExistsRemoveTags_ExpectSuccess()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var createdDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName, tags: TestDataGenerator.GenerateTags());
            createdDnsResolver.Tags = null;

            var updatedDnsResolver = this.DnsResolverManagementClient.DnsResolvers.Update(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name,
                parameters: createdDnsResolver);

            updatedDnsResolver.Should().NotBeNull();
            updatedDnsResolver.ProvisioningState.Should().BeEquivalentTo(Constants.ProvisioningStateSucceeded);
            updatedDnsResolver.Tags.Should().BeEmpty();
        }

        [Fact]
        public void DeleteDnsResolver_ResolverNotExists_ExpectNoError()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var dnsResolverName = TestDataGenerator.GenerateDnsResolverName();

            Action deleteDnsResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.Delete(
                resourceGroupName: resourceGroupName,
                dnsResolverName: dnsResolverName);

            deleteDnsResolverAction.Should().NotThrow();
        }

        [Fact]
        public void DeleteDnsResolver_ResolverExists_ExpectDeleted()
        {
            var resourceGroupName = this.CreateResourceGroup().Name;
            var createdDnsResolver = this.CreateDnsResolver(resourceGroupName: resourceGroupName);

            Action deleteResolverAction = () => this.DnsResolverManagementClient.DnsResolvers.Delete(
                resourceGroupName: resourceGroupName,
                dnsResolverName: createdDnsResolver.Name);

            deleteResolverAction.Should().NotThrow();
        }

        private static bool ValidateListedResolverIsExpected(DnsResolverModel listedResolver, IEnumerable<DnsResolverModel> expectedResolvers)
        {
            return expectedResolvers.Any(expectedResolver => string.Equals(expectedResolver.Id, listedResolver.Id, StringComparison.OrdinalIgnoreCase));
        }
    }
}
