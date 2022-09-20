﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity.Tests.Mock;
using NUnit.Framework;

namespace Azure.Identity.Tests
{
    public class VisualStudioCodeCredentialTests : CredentialTestBase
    {
        public VisualStudioCodeCredentialTests(bool isAsync) : base(isAsync)
        { }

        public override TokenCredential GetTokenCredential(TokenCredentialOptions options)
        {
            using var env = new TestEnvVar(new Dictionary<string, string> { { "TENANT_ID", TenantId } });
            var environment = new IdentityTestEnvironment();
            var vscOptions = new VisualStudioCodeCredentialOptions
            {
                Diagnostics = { IsAccountIdentifierLoggingEnabled = options.Diagnostics.IsAccountIdentifierLoggingEnabled },
                TenantId = environment.TenantId,
                Transport = new MockTransport()
            };

            return InstrumentClient(
                new VisualStudioCodeCredential(
                    vscOptions,
                    null,
                    mockPublicMsalClient,
                    CredentialTestHelpers.CreateFileSystemForVisualStudioCode(environment),
                    new TestVscAdapter("VS Code Azure", "AzureCloud", expectedToken)));
        }

        [SetUp]
        public void Setup()
        {
            TestSetup();
        }

        [Test]
        [NonParallelizable]
        public async Task AuthenticateWithVsCodeCredential([Values(null, TenantIdHint)] string tenantId, [Values(true)] bool allowMultiTenantAuthentication)
        {
            using var env = new TestEnvVar(new Dictionary<string, string> { { "TENANT_ID", TenantId } });
            var environment = new IdentityTestEnvironment();
            var options = new VisualStudioCodeCredentialOptions { TenantId = environment.TenantId, AdditionallyAllowedTenants = { TenantIdHint }, Transport = new MockTransport() };
            var context = new TokenRequestContext(new[] { Scope }, tenantId: tenantId);
            expectedTenantId = TenantIdResolver.Resolve(environment.TenantId, context, TenantIdResolver.AllTenants);

            VisualStudioCodeCredential credential = InstrumentClient(
                new VisualStudioCodeCredential(
                    options,
                    null,
                    mockPublicMsalClient,
                    CredentialTestHelpers.CreateFileSystemForVisualStudioCode(environment),
                    new TestVscAdapter("VS Code Azure", "AzureCloud", expectedToken)));

            var actualToken = await credential.GetTokenAsync(context, CancellationToken.None);

            Assert.AreEqual(expectedToken, actualToken.Token, "Token should match");
            Assert.AreEqual(expiresOn, actualToken.ExpiresOn, "expiresOn should match");
        }

        public override async Task VerifyAllowedTenantEnforcement(AllowedTenantsTestParameters parameters)
        {
            Console.WriteLine(parameters.ToDebugString());

            using var env = new TestEnvVar(new Dictionary<string, string> { { "TENANT_ID", TenantId } });
            var environment = new IdentityTestEnvironment();
            var options = new VisualStudioCodeCredentialOptions
            {
                TenantId = parameters.TenantId,
                Transport = new MockTransport()
            };

            foreach (var addlTenant in parameters.AdditionallyAllowedTenants)
            {
                options.AdditionallyAllowedTenants.Add(addlTenant);
            }

            var msalClientMock = new MockMsalPublicClient(AuthenticationResultFactory.Create());

            var cred =  InstrumentClient(
                new VisualStudioCodeCredential(
                    options,
                    null,
                    msalClientMock,
                    CredentialTestHelpers.CreateFileSystemForVisualStudioCode(environment),
                    new TestVscAdapter("VS Code Azure", "AzureCloud", expectedToken)));

            await AssertAllowedTenantIdsEnforcedAsync(parameters, cred);
        }

        [Test]
        public void RespectsIsPIILoggingEnabled([Values(true, false)] bool isLoggingPIIEnabled)
        {
            var credential = new VisualStudioCodeCredential(new VisualStudioCodeCredentialOptions { IsLoggingPIIEnabled = isLoggingPIIEnabled });

            Assert.NotNull(credential.Client);
            Assert.AreEqual(isLoggingPIIEnabled, credential.Client.IsPiiLoggingEnabled);
        }

        [Test]
        public void AdfsTenantThrowsCredentialUnavailable()
        {
            var options = new VisualStudioCodeCredentialOptions { TenantId = "adfs", Transport = new MockTransport() };
            var context = new TokenRequestContext(new[] { Scope });
            string expectedTenantId = TenantIdResolver.Resolve(null, context, TenantIdResolver.AllTenants);

            VisualStudioCodeCredential credential = InstrumentClient(new VisualStudioCodeCredential(options));

            Assert.ThrowsAsync<CredentialUnavailableException>(
                async () => await credential.GetTokenAsync(new TokenRequestContext(new[] { "https://vault.azure.net/.default" }), CancellationToken.None));
        }
    }
}
