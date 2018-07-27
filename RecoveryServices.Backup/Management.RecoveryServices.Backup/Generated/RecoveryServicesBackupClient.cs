// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Open API 2.0 Specs for Azure RecoveryServices Backup service
    /// </summary>
    public partial class RecoveryServicesBackupClient : ServiceClient<RecoveryServicesBackupClient>, IRecoveryServicesBackupClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// The subscription Id.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IProtectionIntentOperations.
        /// </summary>
        public virtual IProtectionIntentOperations ProtectionIntent { get; private set; }

        /// <summary>
        /// Gets the IBackupStatusOperations.
        /// </summary>
        public virtual IBackupStatusOperations BackupStatus { get; private set; }

        /// <summary>
        /// Gets the IFeatureSupportOperations.
        /// </summary>
        public virtual IFeatureSupportOperations FeatureSupport { get; private set; }

        /// <summary>
        /// Gets the IBackupJobsOperations.
        /// </summary>
        public virtual IBackupJobsOperations BackupJobs { get; private set; }

        /// <summary>
        /// Gets the IJobDetailsOperations.
        /// </summary>
        public virtual IJobDetailsOperations JobDetails { get; private set; }

        /// <summary>
        /// Gets the IExportJobsOperationResultsOperations.
        /// </summary>
        public virtual IExportJobsOperationResultsOperations ExportJobsOperationResults { get; private set; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        public virtual IJobsOperations Jobs { get; private set; }

        /// <summary>
        /// Gets the IBackupPoliciesOperations.
        /// </summary>
        public virtual IBackupPoliciesOperations BackupPolicies { get; private set; }

        /// <summary>
        /// Gets the IBackupProtectedItemsOperations.
        /// </summary>
        public virtual IBackupProtectedItemsOperations BackupProtectedItems { get; private set; }

        /// <summary>
        /// Gets the IBackupUsageSummariesOperations.
        /// </summary>
        public virtual IBackupUsageSummariesOperations BackupUsageSummaries { get; private set; }

        /// <summary>
        /// Gets the IOperationOperations.
        /// </summary>
        public virtual IOperationOperations Operation { get; private set; }

        /// <summary>
        /// Gets the IBackupResourceVaultConfigsOperations.
        /// </summary>
        public virtual IBackupResourceVaultConfigsOperations BackupResourceVaultConfigs { get; private set; }

        /// <summary>
        /// Gets the IBackupEnginesOperations.
        /// </summary>
        public virtual IBackupEnginesOperations BackupEngines { get; private set; }

        /// <summary>
        /// Gets the IProtectionContainerRefreshOperationResultsOperations.
        /// </summary>
        public virtual IProtectionContainerRefreshOperationResultsOperations ProtectionContainerRefreshOperationResults { get; private set; }

        /// <summary>
        /// Gets the IProtectableContainersOperations.
        /// </summary>
        public virtual IProtectableContainersOperations ProtectableContainers { get; private set; }

        /// <summary>
        /// Gets the IProtectionContainersOperations.
        /// </summary>
        public virtual IProtectionContainersOperations ProtectionContainers { get; private set; }

        /// <summary>
        /// Gets the IBackupWorkloadItemsOperations.
        /// </summary>
        public virtual IBackupWorkloadItemsOperations BackupWorkloadItems { get; private set; }

        /// <summary>
        /// Gets the IProtectionContainerOperationResultsOperations.
        /// </summary>
        public virtual IProtectionContainerOperationResultsOperations ProtectionContainerOperationResults { get; private set; }

        /// <summary>
        /// Gets the IProtectedItemsOperations.
        /// </summary>
        public virtual IProtectedItemsOperations ProtectedItems { get; private set; }

        /// <summary>
        /// Gets the IBackupsOperations.
        /// </summary>
        public virtual IBackupsOperations Backups { get; private set; }

        /// <summary>
        /// Gets the IProtectedItemOperationResultsOperations.
        /// </summary>
        public virtual IProtectedItemOperationResultsOperations ProtectedItemOperationResults { get; private set; }

        /// <summary>
        /// Gets the IProtectedItemOperationStatusesOperations.
        /// </summary>
        public virtual IProtectedItemOperationStatusesOperations ProtectedItemOperationStatuses { get; private set; }

        /// <summary>
        /// Gets the IRecoveryPointsOperations.
        /// </summary>
        public virtual IRecoveryPointsOperations RecoveryPoints { get; private set; }

        /// <summary>
        /// Gets the IItemLevelRecoveryConnectionsOperations.
        /// </summary>
        public virtual IItemLevelRecoveryConnectionsOperations ItemLevelRecoveryConnections { get; private set; }

        /// <summary>
        /// Gets the IRestoresOperations.
        /// </summary>
        public virtual IRestoresOperations Restores { get; private set; }

        /// <summary>
        /// Gets the IJobCancellationsOperations.
        /// </summary>
        public virtual IJobCancellationsOperations JobCancellations { get; private set; }

        /// <summary>
        /// Gets the IJobOperationResultsOperations.
        /// </summary>
        public virtual IJobOperationResultsOperations JobOperationResults { get; private set; }

        /// <summary>
        /// Gets the IBackupOperationResultsOperations.
        /// </summary>
        public virtual IBackupOperationResultsOperations BackupOperationResults { get; private set; }

        /// <summary>
        /// Gets the IBackupOperationStatusesOperations.
        /// </summary>
        public virtual IBackupOperationStatusesOperations BackupOperationStatuses { get; private set; }

        /// <summary>
        /// Gets the IProtectionPoliciesOperations.
        /// </summary>
        public virtual IProtectionPoliciesOperations ProtectionPolicies { get; private set; }

        /// <summary>
        /// Gets the IProtectionPolicyOperationResultsOperations.
        /// </summary>
        public virtual IProtectionPolicyOperationResultsOperations ProtectionPolicyOperationResults { get; private set; }

        /// <summary>
        /// Gets the IProtectionPolicyOperationStatusesOperations.
        /// </summary>
        public virtual IProtectionPolicyOperationStatusesOperations ProtectionPolicyOperationStatuses { get; private set; }

        /// <summary>
        /// Gets the IBackupProtectableItemsOperations.
        /// </summary>
        public virtual IBackupProtectableItemsOperations BackupProtectableItems { get; private set; }

        /// <summary>
        /// Gets the IBackupProtectionContainersOperations.
        /// </summary>
        public virtual IBackupProtectionContainersOperations BackupProtectionContainers { get; private set; }

        /// <summary>
        /// Gets the ISecurityPINsOperations.
        /// </summary>
        public virtual ISecurityPINsOperations SecurityPINs { get; private set; }

        /// <summary>
        /// Gets the IBackupResourceStorageConfigsOperations.
        /// </summary>
        public virtual IBackupResourceStorageConfigsOperations BackupResourceStorageConfigs { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected RecoveryServicesBackupClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected RecoveryServicesBackupClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected RecoveryServicesBackupClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected RecoveryServicesBackupClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public RecoveryServicesBackupClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public RecoveryServicesBackupClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public RecoveryServicesBackupClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryServicesBackupClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public RecoveryServicesBackupClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ProtectionIntent = new ProtectionIntentOperations(this);
            BackupStatus = new BackupStatusOperations(this);
            FeatureSupport = new FeatureSupportOperations(this);
            BackupJobs = new BackupJobsOperations(this);
            JobDetails = new JobDetailsOperations(this);
            ExportJobsOperationResults = new ExportJobsOperationResultsOperations(this);
            Jobs = new JobsOperations(this);
            BackupPolicies = new BackupPoliciesOperations(this);
            BackupProtectedItems = new BackupProtectedItemsOperations(this);
            BackupUsageSummaries = new BackupUsageSummariesOperations(this);
            Operation = new OperationOperations(this);
            BackupResourceVaultConfigs = new BackupResourceVaultConfigsOperations(this);
            BackupEngines = new BackupEnginesOperations(this);
            ProtectionContainerRefreshOperationResults = new ProtectionContainerRefreshOperationResultsOperations(this);
            ProtectableContainers = new ProtectableContainersOperations(this);
            ProtectionContainers = new ProtectionContainersOperations(this);
            BackupWorkloadItems = new BackupWorkloadItemsOperations(this);
            ProtectionContainerOperationResults = new ProtectionContainerOperationResultsOperations(this);
            ProtectedItems = new ProtectedItemsOperations(this);
            Backups = new BackupsOperations(this);
            ProtectedItemOperationResults = new ProtectedItemOperationResultsOperations(this);
            ProtectedItemOperationStatuses = new ProtectedItemOperationStatusesOperations(this);
            RecoveryPoints = new RecoveryPointsOperations(this);
            ItemLevelRecoveryConnections = new ItemLevelRecoveryConnectionsOperations(this);
            Restores = new RestoresOperations(this);
            JobCancellations = new JobCancellationsOperations(this);
            JobOperationResults = new JobOperationResultsOperations(this);
            BackupOperationResults = new BackupOperationResultsOperations(this);
            BackupOperationStatuses = new BackupOperationStatusesOperations(this);
            ProtectionPolicies = new ProtectionPoliciesOperations(this);
            ProtectionPolicyOperationResults = new ProtectionPolicyOperationResultsOperations(this);
            ProtectionPolicyOperationStatuses = new ProtectionPolicyOperationStatusesOperations(this);
            BackupProtectableItems = new BackupProtectableItemsOperations(this);
            BackupProtectionContainers = new BackupProtectionContainersOperations(this);
            SecurityPINs = new SecurityPINsOperations(this);
            BackupResourceStorageConfigs = new BackupResourceStorageConfigsOperations(this);
            Operations = new Operations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<SchedulePolicy>("schedulePolicyType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<SchedulePolicy>("schedulePolicyType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RetentionPolicy>("retentionPolicyType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RetentionPolicy>("retentionPolicyType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<FeatureSupportRequest>("featureType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<FeatureSupportRequest>("featureType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Job>("jobType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<Job>("jobType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<OperationResultInfoBase>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<OperationResultInfoBase>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ProtectedItem>("protectedItemType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ProtectedItem>("protectedItemType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ProtectionIntent>("protectionIntentItemType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ProtectionIntent>("protectionIntentItemType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ProtectionPolicy>("backupManagementType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ProtectionPolicy>("backupManagementType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RestoreRequest>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RestoreRequest>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ValidateOperationRequest>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ValidateOperationRequest>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<BackupEngineBase>("backupEngineType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<BackupEngineBase>("backupEngineType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<BackupRequest>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<BackupRequest>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ILRRequest>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ILRRequest>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<OperationStatusExtendedInfo>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<OperationStatusExtendedInfo>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ProtectableContainer>("protectableContainerType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ProtectableContainer>("protectableContainerType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<ProtectionContainer>("containerType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<ProtectionContainer>("containerType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<RecoveryPoint>("objectType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<RecoveryPoint>("objectType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<WorkloadItem>("workloadItemType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<WorkloadItem>("workloadItemType"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<WorkloadProtectableItem>("protectableItemType"));
            DeserializationSettings.Converters.Add(new PolymorphicDeserializeJsonConverter<WorkloadProtectableItem>("protectableItemType"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}
