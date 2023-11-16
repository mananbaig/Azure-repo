namespace Azure.ResourceManager.HybridCompute
{
    public partial class ExtensionValueCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.ExtensionValueResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.ExtensionValueResource>, System.Collections.IEnumerable
    {
        protected ExtensionValueCollection() { }
        public virtual Azure.Response<bool> Exists(string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource> Get(string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.ExtensionValueResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.ExtensionValueResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource>> GetAsync(string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HybridCompute.ExtensionValueResource> GetIfExists(string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HybridCompute.ExtensionValueResource>> GetIfExistsAsync(string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridCompute.ExtensionValueResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.ExtensionValueResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridCompute.ExtensionValueResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.ExtensionValueResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ExtensionValueData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>
    {
        public ExtensionValueData() { }
        public string ExtensionType { get { throw null; } }
        public string Publisher { get { throw null; } }
        public string Version { get { throw null; } }
        Azure.ResourceManager.HybridCompute.ExtensionValueData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.ExtensionValueData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.ExtensionValueData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtensionValueResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ExtensionValueResource() { }
        public virtual Azure.ResourceManager.HybridCompute.ExtensionValueData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, Azure.Core.AzureLocation location, string publisher, string extensionType, string version) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HybridComputeExtensions
    {
        public static Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource> GetExtensionValue(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string publisher, string extensionType, string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource>> GetExtensionValueAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string publisher, string extensionType, string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridCompute.ExtensionValueResource GetExtensionValueResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridCompute.ExtensionValueCollection GetExtensionValues(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string publisher, string extensionType) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetHybridComputeMachine(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> GetHybridComputeMachineAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource GetHybridComputeMachineExtensionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputeMachineResource GetHybridComputeMachineResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputeMachineCollection GetHybridComputeMachines(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetHybridComputeMachines(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetHybridComputeMachinesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource GetHybridComputePrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource GetHybridComputePrivateLinkResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScope(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> GetHybridComputePrivateLinkScopeAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource GetHybridComputePrivateLinkScopeResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeCollection GetHybridComputePrivateLinkScopes(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopes(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails> GetValidationDetailsPrivateLinkScope(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string privateLinkScopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>> GetValidationDetailsPrivateLinkScopeAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string privateLinkScopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridComputeMachineCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>, System.Collections.IEnumerable
    {
        protected HybridComputeMachineCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string machineName, Azure.ResourceManager.HybridCompute.HybridComputeMachineData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string machineName, Azure.ResourceManager.HybridCompute.HybridComputeMachineData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> Get(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> GetAsync(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetIfExists(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> GetIfExistsAsync(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HybridComputeMachineData : Azure.ResourceManager.Models.TrackedResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>
    {
        public HybridComputeMachineData(Azure.Core.AzureLocation location) { }
        public string AdFqdn { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.AgentConfiguration AgentConfiguration { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.AgentUpgrade AgentUpgrade { get { throw null; } set { } }
        public string AgentVersion { get { throw null; } }
        public string ClientPublicKey { get { throw null; } set { } }
        public string CloudMetadataProvider { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> DetectedProperties { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string DnsFqdn { get { throw null; } }
        public string DomainName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResponseError> ErrorDetails { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView> Extensions { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.DateTimeOffset? LastStatusChange { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.LocationData LocationData { get { throw null; } set { } }
        public string MachineFqdn { get { throw null; } }
        public string MssqlDiscovered { get { throw null; } set { } }
        public string OSName { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.OSProfile OSProfile { get { throw null; } set { } }
        public string OSSku { get { throw null; } }
        public string OSType { get { throw null; } set { } }
        public string OSVersion { get { throw null; } }
        public Azure.Core.ResourceIdentifier ParentClusterResourceId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateLinkScopeResourceId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData> Resources { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses ServiceStatuses { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType? Status { get { throw null; } }
        public System.Guid? VmId { get { throw null; } set { } }
        public System.Guid? VmUuid { get { throw null; } }
        Azure.ResourceManager.HybridCompute.HybridComputeMachineData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.HybridComputeMachineData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeMachineExtensionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>, System.Collections.IEnumerable
    {
        protected HybridComputeMachineExtensionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string extensionName, Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string extensionName, Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> Get(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> GetAll(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> GetAllAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> GetAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> GetIfExists(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> GetIfExistsAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HybridComputeMachineExtensionData : Azure.ResourceManager.Models.TrackedResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>
    {
        public HybridComputeMachineExtensionData(Azure.Core.AzureLocation location) { }
        public bool? AutoUpgradeMinorVersion { get { throw null; } set { } }
        public bool? EnableAutomaticUpgrade { get { throw null; } set { } }
        public string ForceUpdateTag { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView InstanceView { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> ProtectedSettings { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string Publisher { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Settings { get { throw null; } }
        public string TypeHandlerVersion { get { throw null; } set { } }
        public string TypePropertiesType { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeMachineExtensionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridComputeMachineExtensionResource() { }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string machineName, string extensionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridComputeMachineResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridComputeMachineResource() { }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputeMachineData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult> AssessPatches(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>> AssessPatchesAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string machineName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> Get(Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> GetAsync(Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource> GetHybridComputeMachineExtension(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource>> GetHybridComputeMachineExtensionAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionCollection GetHybridComputeMachineExtensions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.Models.NetworkProfile> GetNetworkProfile(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>> GetNetworkProfileAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails> GetValidationDetailsForMachinePrivateLinkScope(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>> GetValidationDetailsForMachinePrivateLinkScopeAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult> InstallPatches(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>> InstallPatchesAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> Update(Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> UpdateAsync(Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation UpgradeExtensions(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade extensionUpgradeParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> UpgradeExtensionsAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade extensionUpgradeParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridComputePrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected HybridComputePrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HybridComputePrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>
    {
        public HybridComputePrivateEndpointConnectionData() { }
        public Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties Properties { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridComputePrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string scopeName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridComputePrivateLinkResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridComputePrivateLinkResource() { }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string scopeName, string groupName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridComputePrivateLinkResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>, System.Collections.IEnumerable
    {
        protected HybridComputePrivateLinkResourceCollection() { }
        public virtual Azure.Response<bool> Exists(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> Get(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>> GetAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> GetIfExists(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>> GetIfExistsAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HybridComputePrivateLinkResourceData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>
    {
        public HybridComputePrivateLinkResourceData() { }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties Properties { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateLinkScopeCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>, System.Collections.IEnumerable
    {
        protected HybridComputePrivateLinkScopeCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string scopeName, Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string scopeName, Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> Get(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> GetAsync(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetIfExists(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> GetIfExistsAsync(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HybridComputePrivateLinkScopeData : Azure.ResourceManager.Models.TrackedResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>
    {
        public HybridComputePrivateLinkScopeData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties Properties { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateLinkScopeResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridComputePrivateLinkScopeResource() { }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string scopeName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource> GetHybridComputePrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource>> GetHybridComputePrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionCollection GetHybridComputePrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource> GetHybridComputePrivateLinkResource(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource>> GetHybridComputePrivateLinkResourceAsync(string groupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceCollection GetHybridComputePrivateLinkResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> Update(Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> UpdateAsync(Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.HybridCompute.Mocking
{
    public partial class MockableHybridComputeArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableHybridComputeArmClient() { }
        public virtual Azure.ResourceManager.HybridCompute.ExtensionValueResource GetExtensionValueResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionResource GetHybridComputeMachineExtensionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputeMachineResource GetHybridComputeMachineResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionResource GetHybridComputePrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResource GetHybridComputePrivateLinkResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource GetHybridComputePrivateLinkScopeResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableHybridComputeResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHybridComputeResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetHybridComputeMachine(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource>> GetHybridComputeMachineAsync(string machineName, Azure.ResourceManager.HybridCompute.Models.InstanceViewType? expand = default(Azure.ResourceManager.HybridCompute.Models.InstanceViewType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputeMachineCollection GetHybridComputeMachines() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScope(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource>> GetHybridComputePrivateLinkScopeAsync(string scopeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeCollection GetHybridComputePrivateLinkScopes() { throw null; }
    }
    public partial class MockableHybridComputeSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableHybridComputeSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource> GetExtensionValue(Azure.Core.AzureLocation location, string publisher, string extensionType, string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.ExtensionValueResource>> GetExtensionValueAsync(Azure.Core.AzureLocation location, string publisher, string extensionType, string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridCompute.ExtensionValueCollection GetExtensionValues(Azure.Core.AzureLocation location, string publisher, string extensionType) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetHybridComputeMachines(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputeMachineResource> GetHybridComputeMachinesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopes(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeResource> GetHybridComputePrivateLinkScopesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails> GetValidationDetailsPrivateLinkScope(Azure.Core.AzureLocation location, string privateLinkScopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>> GetValidationDetailsPrivateLinkScopeAsync(Azure.Core.AzureLocation location, string privateLinkScopeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class AgentConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>
    {
        internal AgentConfiguration() { }
        public Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode? ConfigMode { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension> ExtensionsAllowList { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension> ExtensionsBlockList { get { throw null; } }
        public string ExtensionsEnabled { get { throw null; } }
        public string GuestConfigurationEnabled { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> IncomingConnectionsPorts { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ProxyBypass { get { throw null; } }
        public System.Uri ProxyUri { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.AgentConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.AgentConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AgentConfigurationMode : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AgentConfigurationMode(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode Full { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode Monitor { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode left, Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode left, Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AgentUpgrade : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>
    {
        public AgentUpgrade() { }
        public System.Guid? CorrelationId { get { throw null; } set { } }
        public string DesiredVersion { get { throw null; } set { } }
        public bool? EnableAutomaticUpgrade { get { throw null; } set { } }
        public string LastAttemptMessage { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum? LastAttemptStatus { get { throw null; } }
        public System.DateTimeOffset? LastAttemptTimestamp { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.AgentUpgrade System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.AgentUpgrade System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AgentUpgrade>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmHybridComputeModelFactory
    {
        public static Azure.ResourceManager.HybridCompute.Models.AgentConfiguration AgentConfiguration(System.Uri proxyUri = null, System.Collections.Generic.IEnumerable<string> incomingConnectionsPorts = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension> extensionsAllowList = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension> extensionsBlockList = null, System.Collections.Generic.IEnumerable<string> proxyBypass = null, string extensionsEnabled = null, string guestConfigurationEnabled = null, Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode? configMode = default(Azure.ResourceManager.HybridCompute.Models.AgentConfigurationMode?)) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.AgentUpgrade AgentUpgrade(string desiredVersion = null, System.Guid? correlationId = default(System.Guid?), bool? enableAutomaticUpgrade = default(bool?), System.DateTimeOffset? lastAttemptTimestamp = default(System.DateTimeOffset?), Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum? lastAttemptStatus = default(Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum?), string lastAttemptMessage = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification AvailablePatchCountByClassification(int? security = default(int?), int? critical = default(int?), int? definition = default(int?), int? updateRollup = default(int?), int? featurePack = default(int?), int? servicePack = default(int?), int? tools = default(int?), int? updates = default(int?), int? other = default(int?)) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension ConfigurationExtension(string publisher = null, string configurationExtensionType = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.ConnectionDetail ConnectionDetail(string id = null, string privateIPAddress = null, string linkIdentifier = null, string groupId = null, string memberName = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.ExtensionValueData ExtensionValueData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string version = null, string extensionType = null, string publisher = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputeMachineData HybridComputeMachineData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData> resources = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.HybridCompute.Models.LocationData locationData = null, Azure.ResourceManager.HybridCompute.Models.AgentConfiguration agentConfiguration = null, Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses serviceStatuses = null, string cloudMetadataProvider = null, Azure.ResourceManager.HybridCompute.Models.AgentUpgrade agentUpgrade = null, Azure.ResourceManager.HybridCompute.Models.OSProfile osProfile = null, string provisioningState = null, Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType? status = default(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType?), System.DateTimeOffset? lastStatusChange = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResponseError> errorDetails = null, string agentVersion = null, System.Guid? vmId = default(System.Guid?), string displayName = null, string machineFqdn = null, string clientPublicKey = null, string osName = null, string osVersion = null, string osType = null, System.Guid? vmUuid = default(System.Guid?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView> extensions = null, string osSku = null, string domainName = null, string adFqdn = null, string dnsFqdn = null, Azure.Core.ResourceIdentifier privateLinkScopeResourceId = null, Azure.Core.ResourceIdentifier parentClusterResourceId = null, string mssqlDiscovered = null, System.Collections.Generic.IReadOnlyDictionary<string, string> detectedProperties = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputeMachineExtensionData HybridComputeMachineExtensionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), string forceUpdateTag = null, string publisher = null, string typePropertiesType = null, string typeHandlerVersion = null, bool? enableAutomaticUpgrade = default(bool?), bool? autoUpgradeMinorVersion = default(bool?), System.Collections.Generic.IDictionary<string, System.BinaryData> settings = null, System.Collections.Generic.IDictionary<string, System.BinaryData> protectedSettings = null, string provisioningState = null, Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView instanceView = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateEndpointConnectionData HybridComputePrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkResourceData HybridComputePrivateLinkResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties HybridComputePrivateLinkResourceProperties(string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, System.Collections.Generic.IEnumerable<string> requiredZoneNames = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.HybridComputePrivateLinkScopeData HybridComputePrivateLinkScopeData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties HybridComputePrivateLinkScopeProperties(Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType? publicNetworkAccess = default(Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType?), string provisioningState = null, string privateLinkScopeId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel> privateEndpointConnections = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty HybridComputePrivateLinkServiceConnectionStateProperty(string status = null, string description = null, string actionsRequired = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.IPAddress IPAddress(string address = null, string ipAddressVersion = null, string subnetAddressPrefix = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult MachineAssessPatchesResult(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus? status = default(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus?), System.Guid? assessmentActivityId = default(System.Guid?), bool? rebootPending = default(bool?), Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification availablePatchCountByClassification = null, System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastModifiedOn = default(System.DateTimeOffset?), Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy? startedBy = default(Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy?), Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed? patchServiceUsed = default(Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed?), Azure.ResourceManager.HybridCompute.Models.OSType? osType = default(Azure.ResourceManager.HybridCompute.Models.OSType?), Azure.ResponseError errorDetails = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent MachineInstallPatchesContent(System.TimeSpan maximumDuration = default(System.TimeSpan), Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting rebootSetting = default(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting), Azure.ResourceManager.HybridCompute.Models.WindowsParameters windowsParameters = null, Azure.ResourceManager.HybridCompute.Models.LinuxParameters linuxParameters = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult MachineInstallPatchesResult(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus? status = default(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus?), string installationActivityId = null, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus? rebootStatus = default(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus?), bool? maintenanceWindowExceeded = default(bool?), int? excludedPatchCount = default(int?), int? notSelectedPatchCount = default(int?), int? pendingPatchCount = default(int?), int? installedPatchCount = default(int?), int? failedPatchCount = default(int?), System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastModifiedOn = default(System.DateTimeOffset?), Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy? startedBy = default(Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy?), Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed? patchServiceUsed = default(Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed?), Azure.ResourceManager.HybridCompute.Models.OSType? osType = default(Azure.ResourceManager.HybridCompute.Models.OSType?), Azure.ResponseError errorDetails = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.NetworkInterface NetworkInterface(System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.IPAddress> ipAddresses = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.NetworkProfile NetworkProfile(System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.NetworkInterface> networkInterfaces = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.OSProfile OSProfile(string computerName = null, Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration windowsConfiguration = null, Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration linuxConfiguration = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel PrivateEndpointConnectionDataModel(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties properties = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties PrivateEndpointConnectionProperties(Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty connectionState = null, string provisioningState = null, System.Collections.Generic.IEnumerable<string> groupIds = null) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails PrivateLinkScopeValidationDetails(string id = null, Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType? publicNetworkAccess = default(Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail> connectionDetails = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AssessmentModeType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.AssessmentModeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AssessmentModeType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.AssessmentModeType AutomaticByPlatform { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.AssessmentModeType ImageDefault { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.AssessmentModeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.AssessmentModeType left, Azure.ResourceManager.HybridCompute.Models.AssessmentModeType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.AssessmentModeType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.AssessmentModeType left, Azure.ResourceManager.HybridCompute.Models.AssessmentModeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AvailablePatchCountByClassification : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>
    {
        internal AvailablePatchCountByClassification() { }
        public int? Critical { get { throw null; } }
        public int? Definition { get { throw null; } }
        public int? FeaturePack { get { throw null; } }
        public int? Other { get { throw null; } }
        public int? Security { get { throw null; } }
        public int? ServicePack { get { throw null; } }
        public int? Tools { get { throw null; } }
        public int? UpdateRollup { get { throw null; } }
        public int? Updates { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfigurationExtension : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>
    {
        internal ConfigurationExtension() { }
        public string ConfigurationExtensionType { get { throw null; } }
        public string Publisher { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConfigurationExtension>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectionDetail : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>
    {
        internal ConnectionDetail() { }
        public string GroupId { get { throw null; } }
        public string Id { get { throw null; } }
        public string LinkIdentifier { get { throw null; } }
        public string MemberName { get { throw null; } }
        public string PrivateIPAddress { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.ConnectionDetail System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.ConnectionDetail System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtensionTargetProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>
    {
        public ExtensionTargetProperties() { }
        public string TargetVersion { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeMachineExtensionPatch : Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>
    {
        public HybridComputeMachineExtensionPatch() { }
        public bool? AutoUpgradeMinorVersion { get { throw null; } set { } }
        public bool? EnableAutomaticUpgrade { get { throw null; } set { } }
        public string ForceUpdateTag { get { throw null; } set { } }
        public string MachineExtensionUpdatePropertiesType { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> ProtectedSettings { get { throw null; } }
        public string Publisher { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Settings { get { throw null; } }
        public string TypeHandlerVersion { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachineExtensionPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeMachinePatch : Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>
    {
        public HybridComputeMachinePatch() { }
        public Azure.ResourceManager.HybridCompute.Models.AgentUpgrade AgentUpgrade { get { throw null; } set { } }
        public string CloudMetadataProvider { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.LocationData LocationData { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.OSProfile OSProfile { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ParentClusterResourceId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateLinkScopeResourceId { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeMachinePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateLinkResourceProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>
    {
        public HybridComputePrivateLinkResourceProperties() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkResourceProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateLinkScopePatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>
    {
        public HybridComputePrivateLinkScopePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateLinkScopeProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>
    {
        public HybridComputePrivateLinkScopeProperties() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel> PrivateEndpointConnections { get { throw null; } }
        public string PrivateLinkScopeId { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType? PublicNetworkAccess { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkScopeProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputePrivateLinkServiceConnectionStateProperty : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>
    {
        public HybridComputePrivateLinkServiceConnectionStateProperty(string status, string description) { }
        public string ActionsRequired { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public string Status { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeResourceUpdate : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>
    {
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public HybridComputeResourceUpdate() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeResourceUpdate>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeServiceStatus : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>
    {
        public HybridComputeServiceStatus() { }
        public string StartupType { get { throw null; } set { } }
        public string Status { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HybridComputeServiceStatuses : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>
    {
        public HybridComputeServiceStatuses() { }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus ExtensionService { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatus GuestConfigurationService { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.HybridComputeServiceStatuses>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HybridComputeStatusLevelType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HybridComputeStatusLevelType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType Error { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType Info { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType left, Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType left, Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HybridComputeStatusType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HybridComputeStatusType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType Connected { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType Disconnected { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType Error { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType left, Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType left, Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InstanceViewType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.InstanceViewType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InstanceViewType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.InstanceViewType InstanceView { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.InstanceViewType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.InstanceViewType left, Azure.ResourceManager.HybridCompute.Models.InstanceViewType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.InstanceViewType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.InstanceViewType left, Azure.ResourceManager.HybridCompute.Models.InstanceViewType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IPAddress : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>
    {
        internal IPAddress() { }
        public string Address { get { throw null; } }
        public string IPAddressVersion { get { throw null; } }
        public string SubnetAddressPrefix { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.IPAddress System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.IPAddress System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.IPAddress>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LastAttemptStatusEnum : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LastAttemptStatusEnum(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum Failed { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum Success { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum left, Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum left, Azure.ResourceManager.HybridCompute.Models.LastAttemptStatusEnum right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinuxParameters : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>
    {
        public LinuxParameters() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux> ClassificationsToInclude { get { throw null; } }
        public System.Collections.Generic.IList<string> PackageNameMasksToExclude { get { throw null; } }
        public System.Collections.Generic.IList<string> PackageNameMasksToInclude { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.LinuxParameters System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.LinuxParameters System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LinuxParameters>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LocationData : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.LocationData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LocationData>
    {
        public LocationData(string name) { }
        public string City { get { throw null; } set { } }
        public string CountryOrRegion { get { throw null; } set { } }
        public string District { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.LocationData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.LocationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.LocationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.LocationData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LocationData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LocationData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.LocationData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MachineAssessPatchesResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>
    {
        internal MachineAssessPatchesResult() { }
        public System.Guid? AssessmentActivityId { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.AvailablePatchCountByClassification AvailablePatchCountByClassification { get { throw null; } }
        public Azure.ResponseError ErrorDetails { get { throw null; } }
        public System.DateTimeOffset? LastModifiedOn { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.OSType? OSType { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed? PatchServiceUsed { get { throw null; } }
        public bool? RebootPending { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy? StartedBy { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus? Status { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineAssessPatchesResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MachineExtensionInstanceView : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>
    {
        public MachineExtensionInstanceView() { }
        public string MachineExtensionInstanceViewType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus Status { get { throw null; } set { } }
        public string TypeHandlerVersion { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceView>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MachineExtensionInstanceViewStatus : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>
    {
        public MachineExtensionInstanceViewStatus() { }
        public string Code { get { throw null; } set { } }
        public string DisplayStatus { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputeStatusLevelType? Level { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public System.DateTimeOffset? Time { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionInstanceViewStatus>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MachineExtensionUpgrade : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>
    {
        public MachineExtensionUpgrade() { }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridCompute.Models.ExtensionTargetProperties> ExtensionTargets { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineExtensionUpgrade>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MachineInstallPatchesContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>
    {
        public MachineInstallPatchesContent(System.TimeSpan maximumDuration, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting rebootSetting) { }
        public Azure.ResourceManager.HybridCompute.Models.LinuxParameters LinuxParameters { get { throw null; } set { } }
        public System.TimeSpan MaximumDuration { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting RebootSetting { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.WindowsParameters WindowsParameters { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MachineInstallPatchesResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>
    {
        internal MachineInstallPatchesResult() { }
        public Azure.ResponseError ErrorDetails { get { throw null; } }
        public int? ExcludedPatchCount { get { throw null; } }
        public int? FailedPatchCount { get { throw null; } }
        public string InstallationActivityId { get { throw null; } }
        public int? InstalledPatchCount { get { throw null; } }
        public System.DateTimeOffset? LastModifiedOn { get { throw null; } }
        public bool? MaintenanceWindowExceeded { get { throw null; } }
        public int? NotSelectedPatchCount { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.OSType? OSType { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed? PatchServiceUsed { get { throw null; } }
        public int? PendingPatchCount { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus? RebootStatus { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy? StartedBy { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus? Status { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.MachineInstallPatchesResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkInterface : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>
    {
        internal NetworkInterface() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.Models.IPAddress> IPAddresses { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.NetworkInterface System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.NetworkInterface System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkInterface>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkProfile : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>
    {
        internal NetworkProfile() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.Models.NetworkInterface> NetworkInterfaces { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.NetworkProfile System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.NetworkProfile System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.NetworkProfile>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSProfile : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>
    {
        public OSProfile() { }
        public string ComputerName { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration LinuxConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration WindowsConfiguration { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.OSProfile System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.OSProfile System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfile>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSProfileLinuxConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>
    {
        public OSProfileLinuxConfiguration() { }
        public Azure.ResourceManager.HybridCompute.Models.AssessmentModeType? AssessmentMode { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.PatchModeType? PatchMode { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileLinuxConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSProfileWindowsConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>
    {
        public OSProfileWindowsConfiguration() { }
        public Azure.ResourceManager.HybridCompute.Models.AssessmentModeType? AssessmentMode { get { throw null; } set { } }
        public Azure.ResourceManager.HybridCompute.Models.PatchModeType? PatchMode { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.OSProfileWindowsConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OSType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.OSType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OSType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.OSType Linux { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.OSType Windows { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.OSType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.OSType left, Azure.ResourceManager.HybridCompute.Models.OSType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.OSType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.OSType left, Azure.ResourceManager.HybridCompute.Models.OSType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PatchModeType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.PatchModeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PatchModeType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PatchModeType AutomaticByOS { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchModeType AutomaticByPlatform { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchModeType ImageDefault { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchModeType Manual { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.PatchModeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.PatchModeType left, Azure.ResourceManager.HybridCompute.Models.PatchModeType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.PatchModeType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.PatchModeType left, Azure.ResourceManager.HybridCompute.Models.PatchModeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PatchOperationStartedBy : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PatchOperationStartedBy(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy Platform { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy User { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy left, Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy left, Azure.ResourceManager.HybridCompute.Models.PatchOperationStartedBy right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PatchOperationStatus : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PatchOperationStatus(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus CompletedWithWarnings { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus InProgress { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus Succeeded { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus left, Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus left, Azure.ResourceManager.HybridCompute.Models.PatchOperationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PatchServiceUsed : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PatchServiceUsed(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed APT { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed Unknown { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed WU { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed WUWsus { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed YUM { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed Zypper { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed left, Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed left, Azure.ResourceManager.HybridCompute.Models.PatchServiceUsed right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrivateEndpointConnectionDataModel : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>
    {
        internal PrivateEndpointConnectionDataModel() { }
        public Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties Properties { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionDataModel>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateEndpointConnectionProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>
    {
        public PrivateEndpointConnectionProperties() { }
        public Azure.ResourceManager.HybridCompute.Models.HybridComputePrivateLinkServiceConnectionStateProperty ConnectionState { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> GroupIds { get { throw null; } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateEndpointConnectionProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PrivateLinkScopeValidationDetails : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>
    {
        internal PrivateLinkScopeValidationDetails() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridCompute.Models.ConnectionDetail> ConnectionDetails { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType? PublicNetworkAccess { get { throw null; } }
        Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.PrivateLinkScopeValidationDetails>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccessType : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccessType(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType Disabled { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType left, Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType left, Azure.ResourceManager.HybridCompute.Models.PublicNetworkAccessType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VmGuestPatchClassificationLinux : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VmGuestPatchClassificationLinux(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux Critical { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux Other { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux Security { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationLinux right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VmGuestPatchClassificationWindow : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VmGuestPatchClassificationWindow(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow Critical { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow Definition { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow FeaturePack { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow Security { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow ServicePack { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow Tools { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow UpdateRollUp { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow Updates { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VmGuestPatchRebootSetting : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VmGuestPatchRebootSetting(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting Always { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting IfRequired { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting Never { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootSetting right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VmGuestPatchRebootStatus : System.IEquatable<Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VmGuestPatchRebootStatus(string value) { throw null; }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus NotNeeded { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus Required { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus Started { get { throw null; } }
        public static Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus left, Azure.ResourceManager.HybridCompute.Models.VmGuestPatchRebootStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WindowsParameters : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>
    {
        public WindowsParameters() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridCompute.Models.VmGuestPatchClassificationWindow> ClassificationsToInclude { get { throw null; } }
        public bool? ExcludeKbsRequiringReboot { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> KbNumbersToExclude { get { throw null; } }
        public System.Collections.Generic.IList<string> KbNumbersToInclude { get { throw null; } }
        public System.DateTimeOffset? MaxPatchPublishOn { get { throw null; } set { } }
        Azure.ResourceManager.HybridCompute.Models.WindowsParameters System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.HybridCompute.Models.WindowsParameters System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.HybridCompute.Models.WindowsParameters>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
