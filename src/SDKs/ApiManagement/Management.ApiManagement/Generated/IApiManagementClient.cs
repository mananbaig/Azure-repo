// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// ApiManagement Client
    /// </summary>
    public partial interface IApiManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Version of the API to be used with the client request.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IPolicyOperations.
        /// </summary>
        IPolicyOperations Policy { get; }

        /// <summary>
        /// Gets the IPolicySnippetsOperations.
        /// </summary>
        IPolicySnippetsOperations PolicySnippets { get; }

        /// <summary>
        /// Gets the IRegionsOperations.
        /// </summary>
        IRegionsOperations Regions { get; }

        /// <summary>
        /// Gets the IApiOperations.
        /// </summary>
        IApiOperations Api { get; }

        /// <summary>
        /// Gets the IApiRevisionsOperations.
        /// </summary>
        IApiRevisionsOperations ApiRevisions { get; }

        /// <summary>
        /// Gets the IApiReleaseOperations.
        /// </summary>
        IApiReleaseOperations ApiRelease { get; }

        /// <summary>
        /// Gets the IApiOperationOperations.
        /// </summary>
        IApiOperationOperations ApiOperation { get; }

        /// <summary>
        /// Gets the IApiOperationPolicyOperations.
        /// </summary>
        IApiOperationPolicyOperations ApiOperationPolicy { get; }

        /// <summary>
        /// Gets the IApiProductOperations.
        /// </summary>
        IApiProductOperations ApiProduct { get; }

        /// <summary>
        /// Gets the IApiPolicyOperations.
        /// </summary>
        IApiPolicyOperations ApiPolicy { get; }

        /// <summary>
        /// Gets the IApiSchemaOperations.
        /// </summary>
        IApiSchemaOperations ApiSchema { get; }

        /// <summary>
        /// Gets the IApiDiagnosticOperations.
        /// </summary>
        IApiDiagnosticOperations ApiDiagnostic { get; }

        /// <summary>
        /// Gets the IApiDiagnosticLoggerOperations.
        /// </summary>
        IApiDiagnosticLoggerOperations ApiDiagnosticLogger { get; }

        /// <summary>
        /// Gets the IAuthorizationServerOperations.
        /// </summary>
        IAuthorizationServerOperations AuthorizationServer { get; }

        /// <summary>
        /// Gets the IBackendOperations.
        /// </summary>
        IBackendOperations Backend { get; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        ICertificateOperations Certificate { get; }

        /// <summary>
        /// Gets the IApiManagementOperations.
        /// </summary>
        IApiManagementOperations ApiManagementOperations { get; }

        /// <summary>
        /// Gets the IApiManagementServiceOperations.
        /// </summary>
        IApiManagementServiceOperations ApiManagementService { get; }

        /// <summary>
        /// Gets the IDiagnosticOperations.
        /// </summary>
        IDiagnosticOperations Diagnostic { get; }

        /// <summary>
        /// Gets the IDiagnosticLoggerOperations.
        /// </summary>
        IDiagnosticLoggerOperations DiagnosticLogger { get; }

        /// <summary>
        /// Gets the IEmailTemplateOperations.
        /// </summary>
        IEmailTemplateOperations EmailTemplate { get; }

        /// <summary>
        /// Gets the IGroupOperations.
        /// </summary>
        IGroupOperations Group { get; }

        /// <summary>
        /// Gets the IGroupUserOperations.
        /// </summary>
        IGroupUserOperations GroupUser { get; }

        /// <summary>
        /// Gets the IIdentityProviderOperations.
        /// </summary>
        IIdentityProviderOperations IdentityProvider { get; }

        /// <summary>
        /// Gets the ILoggerOperations.
        /// </summary>
        ILoggerOperations Logger { get; }

        /// <summary>
        /// Gets the INotificationOperations.
        /// </summary>
        INotificationOperations Notification { get; }

        /// <summary>
        /// Gets the INotificationRecipientUserOperations.
        /// </summary>
        INotificationRecipientUserOperations NotificationRecipientUser { get; }

        /// <summary>
        /// Gets the INotificationRecipientEmailOperations.
        /// </summary>
        INotificationRecipientEmailOperations NotificationRecipientEmail { get; }

        /// <summary>
        /// Gets the INetworkStatusOperations.
        /// </summary>
        INetworkStatusOperations NetworkStatus { get; }

        /// <summary>
        /// Gets the IOpenIdConnectProviderOperations.
        /// </summary>
        IOpenIdConnectProviderOperations OpenIdConnectProvider { get; }

        /// <summary>
        /// Gets the ISignInSettingsOperations.
        /// </summary>
        ISignInSettingsOperations SignInSettings { get; }

        /// <summary>
        /// Gets the ISignUpSettingsOperations.
        /// </summary>
        ISignUpSettingsOperations SignUpSettings { get; }

        /// <summary>
        /// Gets the IDelegationSettingsOperations.
        /// </summary>
        IDelegationSettingsOperations DelegationSettings { get; }

        /// <summary>
        /// Gets the IProductOperations.
        /// </summary>
        IProductOperations Product { get; }

        /// <summary>
        /// Gets the IProductApiOperations.
        /// </summary>
        IProductApiOperations ProductApi { get; }

        /// <summary>
        /// Gets the IProductGroupOperations.
        /// </summary>
        IProductGroupOperations ProductGroup { get; }

        /// <summary>
        /// Gets the IProductSubscriptionsOperations.
        /// </summary>
        IProductSubscriptionsOperations ProductSubscriptions { get; }

        /// <summary>
        /// Gets the IProductPolicyOperations.
        /// </summary>
        IProductPolicyOperations ProductPolicy { get; }

        /// <summary>
        /// Gets the IPropertyOperations.
        /// </summary>
        IPropertyOperations Property { get; }

        /// <summary>
        /// Gets the IQuotaByCounterKeysOperations.
        /// </summary>
        IQuotaByCounterKeysOperations QuotaByCounterKeys { get; }

        /// <summary>
        /// Gets the IQuotaByPeriodKeysOperations.
        /// </summary>
        IQuotaByPeriodKeysOperations QuotaByPeriodKeys { get; }

        /// <summary>
        /// Gets the IReportsOperations.
        /// </summary>
        IReportsOperations Reports { get; }

        /// <summary>
        /// Gets the ISubscriptionOperations.
        /// </summary>
        ISubscriptionOperations Subscription { get; }

        /// <summary>
        /// Gets the ITagResourceOperations.
        /// </summary>
        ITagResourceOperations TagResource { get; }

        /// <summary>
        /// Gets the ITagOperations.
        /// </summary>
        ITagOperations Tag { get; }

        /// <summary>
        /// Gets the ITagDescriptionOperations.
        /// </summary>
        ITagDescriptionOperations TagDescription { get; }

        /// <summary>
        /// Gets the IOperationOperations.
        /// </summary>
        IOperationOperations Operation { get; }

        /// <summary>
        /// Gets the ITenantAccessOperations.
        /// </summary>
        ITenantAccessOperations TenantAccess { get; }

        /// <summary>
        /// Gets the ITenantAccessGitOperations.
        /// </summary>
        ITenantAccessGitOperations TenantAccessGit { get; }

        /// <summary>
        /// Gets the ITenantConfigurationOperations.
        /// </summary>
        ITenantConfigurationOperations TenantConfiguration { get; }

        /// <summary>
        /// Gets the IUserOperations.
        /// </summary>
        IUserOperations User { get; }

        /// <summary>
        /// Gets the IUserGroupOperations.
        /// </summary>
        IUserGroupOperations UserGroup { get; }

        /// <summary>
        /// Gets the IUserSubscriptionOperations.
        /// </summary>
        IUserSubscriptionOperations UserSubscription { get; }

        /// <summary>
        /// Gets the IUserIdentitiesOperations.
        /// </summary>
        IUserIdentitiesOperations UserIdentities { get; }

        /// <summary>
        /// Gets the IApiVersionSetOperations.
        /// </summary>
        IApiVersionSetOperations ApiVersionSet { get; }

        /// <summary>
        /// Gets the IApiExportOperations.
        /// </summary>
        IApiExportOperations ApiExport { get; }

    }
}
