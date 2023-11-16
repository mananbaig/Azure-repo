namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiResource>, System.Collections.IEnumerable
    {
        protected ApiCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string apiId, Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string apiId, Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource> Get(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), string tags = null, bool? expandApiVersionSet = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), string tags = null, bool? expandApiVersionSet = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource>> GetAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiResource> GetIfExists(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiResource>> GetIfExistsAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiData>
    {
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public ApiData() { }
        public string ApiRevision { get { throw null; } set { } }
        public string ApiRevisionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiType? ApiType { get { throw null; } set { } }
        public string ApiVersion { get { throw null; } set { } }
        public string ApiVersionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails ApiVersionSet { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ApiVersionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract AuthenticationSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiContactInformation Contact { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsCurrent { get { throw null; } set { } }
        public bool? IsOnline { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation License { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> Protocols { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SourceApiId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get { throw null; } set { } }
        public System.Uri TermsOfServiceUri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiDiagnosticCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>, System.Collections.IEnumerable
    {
        protected ApiDiagnosticCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string diagnosticId, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string diagnosticId, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> Get(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>> GetAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> GetIfExists(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>> GetIfExistsAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiDiagnosticResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiDiagnosticResource() { }
        public virtual Azure.ResourceManager.ApiManagement.DiagnosticContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string diagnosticId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiIssueAttachmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>, System.Collections.IEnumerable
    {
        protected ApiIssueAttachmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string attachmentId, Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string attachmentId, Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> Get(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>> GetAsync(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> GetIfExists(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>> GetIfExistsAsync(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiIssueAttachmentData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>
    {
        public ApiIssueAttachmentData() { }
        public string Content { get { throw null; } set { } }
        public string ContentFormat { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiIssueAttachmentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiIssueAttachmentResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string issueId, string attachmentId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiIssueCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueResource>, System.Collections.IEnumerable
    {
        protected ApiIssueCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string issueId, Azure.ResourceManager.ApiManagement.IssueContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string issueId, Azure.ResourceManager.ApiManagement.IssueContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource> Get(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiIssueResource> GetAll(string filter = null, bool? expandCommentsAttachments = default(bool?), int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiIssueResource> GetAllAsync(string filter = null, bool? expandCommentsAttachments = default(bool?), int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource>> GetAsync(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiIssueResource> GetIfExists(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiIssueResource>> GetIfExistsAsync(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiIssueResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiIssueResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiIssueCommentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>, System.Collections.IEnumerable
    {
        protected ApiIssueCommentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string commentId, Azure.ResourceManager.ApiManagement.ApiIssueCommentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string commentId, Azure.ResourceManager.ApiManagement.ApiIssueCommentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> Get(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>> GetAsync(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> GetIfExists(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>> GetIfExistsAsync(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiIssueCommentData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>
    {
        public ApiIssueCommentData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier UserId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiIssueCommentData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiIssueCommentData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiIssueCommentData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiIssueCommentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiIssueCommentResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueCommentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string issueId, string commentId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiIssueCommentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiIssueCommentData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiIssueResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiIssueResource() { }
        public virtual Azure.ResourceManager.ApiManagement.IssueContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string issueId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource> Get(bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource> GetApiIssueAttachment(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource>> GetApiIssueAttachmentAsync(string attachmentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueAttachmentCollection GetApiIssueAttachments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource> GetApiIssueComment(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueCommentResource>> GetApiIssueCommentAsync(string commentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueCommentCollection GetApiIssueComments() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource>> GetAsync(bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementAuthorizationServerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>, System.Collections.IEnumerable
    {
        protected ApiManagementAuthorizationServerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string authsid, Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string authsid, Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> Get(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>> GetAsync(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> GetIfExists(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>> GetIfExistsAsync(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementAuthorizationServerData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>
    {
        public ApiManagementAuthorizationServerData() { }
        public string AuthorizationEndpoint { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.AuthorizationMethod> AuthorizationMethods { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod> BearerTokenSendingMethods { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod> ClientAuthenticationMethods { get { throw null; } }
        public string ClientId { get { throw null; } set { } }
        public string ClientRegistrationEndpoint { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public string DefaultScope { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? DoesSupportState { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.GrantType> GrantTypes { get { throw null; } }
        public string ResourceOwnerPassword { get { throw null; } set { } }
        public string ResourceOwnerUsername { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract> TokenBodyParameters { get { throw null; } }
        public string TokenEndpoint { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementAuthorizationServerResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementAuthorizationServerResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string authsid) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementBackendCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>, System.Collections.IEnumerable
    {
        protected ApiManagementBackendCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string backendId, Azure.ResourceManager.ApiManagement.ApiManagementBackendData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string backendId, Azure.ResourceManager.ApiManagement.ApiManagementBackendData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> Get(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>> GetAsync(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> GetIfExists(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>> GetIfExistsAsync(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementBackendData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>
    {
        public ApiManagementBackendData() { }
        public Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties BackendServiceFabricCluster { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract Credentials { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendProtocol? Protocol { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendProxyContract Proxy { get { throw null; } set { } }
        public System.Uri ResourceUri { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties Tls { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementBackendData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementBackendData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementBackendData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementBackendResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementBackendResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementBackendData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string backendId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Reconnect(Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract backendReconnectContract = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ReconnectAsync(Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract backendReconnectContract = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementCacheCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>, System.Collections.IEnumerable
    {
        protected ApiManagementCacheCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string cacheId, Azure.ResourceManager.ApiManagement.ApiManagementCacheData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string cacheId, Azure.ResourceManager.ApiManagement.ApiManagementCacheData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> Get(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> GetAll(int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> GetAllAsync(int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>> GetAsync(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> GetIfExists(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>> GetIfExistsAsync(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementCacheData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>
    {
        public ApiManagementCacheData() { }
        public string ConnectionString { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Uri ResourceUri { get { throw null; } set { } }
        public string UseFromLocation { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementCacheData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementCacheData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCacheData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementCacheResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementCacheResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementCacheData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string cacheId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementCertificateCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>, System.Collections.IEnumerable
    {
        protected ApiManagementCertificateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string certificateId, Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string certificateId, Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> Get(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), bool? isKeyVaultRefreshFailed = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? isKeyVaultRefreshFailed = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> GetAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> GetIfExists(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> GetIfExistsAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementCertificateData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>
    {
        public ApiManagementCertificateData() { }
        public System.DateTimeOffset? ExpireOn { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties KeyVaultDetails { get { throw null; } set { } }
        public string Subject { get { throw null; } set { } }
        public string Thumbprint { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementCertificateData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementCertificateData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementCertificateData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementCertificateResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementCertificateResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementCertificateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string certificateId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> RefreshSecret(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> RefreshSecretAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementDeletedServiceCollection : Azure.ResourceManager.ArmCollection
    {
        protected ApiManagementDeletedServiceCollection() { }
        public virtual Azure.Response<bool> Exists(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> Get(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource>> GetAsync(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetIfExists(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource>> GetIfExistsAsync(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementDeletedServiceData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>
    {
        public ApiManagementDeletedServiceData() { }
        public System.DateTimeOffset? DeletedOn { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.DateTimeOffset? ScheduledPurgeOn { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ServiceId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementDeletedServiceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementDeletedServiceResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, Azure.Core.AzureLocation location, string serviceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementDiagnosticCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>, System.Collections.IEnumerable
    {
        protected ApiManagementDiagnosticCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string diagnosticId, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string diagnosticId, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> Get(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>> GetAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> GetIfExists(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>> GetIfExistsAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementDiagnosticResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementDiagnosticResource() { }
        public virtual Azure.ResourceManager.ApiManagement.DiagnosticContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string diagnosticId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.DiagnosticContractData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementEmailTemplateCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>, System.Collections.IEnumerable
    {
        protected ApiManagementEmailTemplateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> Get(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementEmailTemplateData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>
    {
        public ApiManagementEmailTemplateData() { }
        public string Body { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public bool? IsDefault { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties> Parameters { get { throw null; } }
        public string Subject { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementEmailTemplateResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementEmailTemplateResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, Azure.ResourceManager.ApiManagement.Models.TemplateName templateName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ApiManagementExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult> CheckApiManagementServiceNameAvailability(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>> CheckApiManagementServiceNameAvailabilityAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiDiagnosticResource GetApiDiagnosticResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource GetApiIssueAttachmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiIssueCommentResource GetApiIssueCommentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiIssueResource GetApiIssueResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource GetApiManagementAuthorizationServerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementBackendResource GetApiManagementBackendResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementCacheResource GetApiManagementCacheResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource GetApiManagementCertificateResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetApiManagementDeletedService(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource>> GetApiManagementDeletedServiceAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource GetApiManagementDeletedServiceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceCollection GetApiManagementDeletedServices(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetApiManagementDeletedServices(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetApiManagementDeletedServicesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource GetApiManagementDiagnosticResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource GetApiManagementEmailTemplateResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource GetApiManagementGatewayCertificateAuthorityResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource GetApiManagementGatewayHostnameConfigurationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource GetApiManagementGatewayResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource GetApiManagementGlobalSchemaResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGroupResource GetApiManagementGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource GetApiManagementIdentityProviderResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementIssueResource GetApiManagementIssueResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource GetApiManagementLoggerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource GetApiManagementNamedValueResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource GetApiManagementNotificationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource GetApiManagementOpenIdConnectProviderResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource GetApiManagementPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource GetApiManagementPortalDelegationSettingResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource GetApiManagementPortalRevisionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource GetApiManagementPortalSignInSettingResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource GetApiManagementPortalSignUpSettingResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource GetApiManagementPrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource GetApiManagementPrivateLinkResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource GetApiManagementProductPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementProductResource GetApiManagementProductResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource GetApiManagementProductTagResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetApiManagementService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> GetApiManagementServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult> GetApiManagementServiceDomainOwnershipIdentifier(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>> GetApiManagementServiceDomainOwnershipIdentifierAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementServiceResource GetApiManagementServiceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementServiceCollection GetApiManagementServices(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetApiManagementServices(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetApiManagementServicesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku> GetApiManagementSkus(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku> GetApiManagementSkusAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource GetApiManagementSubscriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementTagResource GetApiManagementTagResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource GetApiManagementTenantSettingResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementUserResource GetApiManagementUserResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource GetApiManagementUserSubscriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource GetApiOperationPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiOperationResource GetApiOperationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiOperationTagResource GetApiOperationTagResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiPolicyResource GetApiPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiReleaseResource GetApiReleaseResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiResource GetApiResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiSchemaResource GetApiSchemaResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource GetApiTagDescriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiTagResource GetApiTagResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiVersionSetResource GetApiVersionSetResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ApiManagement.TenantAccessInfoResource GetTenantAccessInfoResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class ApiManagementGatewayCertificateAuthorityCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>, System.Collections.IEnumerable
    {
        protected ApiManagementGatewayCertificateAuthorityCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string certificateId, Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string certificateId, Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> Get(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>> GetAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> GetIfExists(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>> GetIfExistsAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementGatewayCertificateAuthorityData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>
    {
        public ApiManagementGatewayCertificateAuthorityData() { }
        public bool? IsTrusted { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGatewayCertificateAuthorityResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementGatewayCertificateAuthorityResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string gatewayId, string certificateId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementGatewayCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>, System.Collections.IEnumerable
    {
        protected ApiManagementGatewayCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string gatewayId, Azure.ResourceManager.ApiManagement.ApiManagementGatewayData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string gatewayId, Azure.ResourceManager.ApiManagement.ApiManagementGatewayData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> Get(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>> GetAsync(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> GetIfExists(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>> GetIfExistsAsync(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementGatewayData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>
    {
        public ApiManagementGatewayData() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract LocationData { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementGatewayData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementGatewayData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGatewayHostnameConfigurationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>, System.Collections.IEnumerable
    {
        protected ApiManagementGatewayHostnameConfigurationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string hcId, Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string hcId, Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> Get(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>> GetAsync(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> GetIfExists(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>> GetIfExistsAsync(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementGatewayHostnameConfigurationData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>
    {
        public ApiManagementGatewayHostnameConfigurationData() { }
        public string CertificateId { get { throw null; } set { } }
        public string Hostname { get { throw null; } set { } }
        public bool? IsClientCertificateRequired { get { throw null; } set { } }
        public bool? IsHttp2_0Enabled { get { throw null; } set { } }
        public bool? IsTls1_0Enabled { get { throw null; } set { } }
        public bool? IsTls1_1Enabled { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGatewayHostnameConfigurationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementGatewayHostnameConfigurationResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string gatewayId, string hcId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementGatewayResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementGatewayResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.GatewayApiData> CreateOrUpdateGatewayApi(string apiId, Azure.ResourceManager.ApiManagement.Models.AssociationContract associationContract = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>> CreateOrUpdateGatewayApiAsync(string apiId, Azure.ResourceManager.ApiManagement.Models.AssociationContract associationContract = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string gatewayId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteGatewayApi(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGatewayApiAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract> GenerateToken(Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract gatewayTokenRequestContract, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>> GenerateTokenAsync(Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract gatewayTokenRequestContract, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityCollection GetApiManagementGatewayCertificateAuthorities() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource> GetApiManagementGatewayCertificateAuthority(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource>> GetApiManagementGatewayCertificateAuthorityAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource> GetApiManagementGatewayHostnameConfiguration(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource>> GetApiManagementGatewayHostnameConfigurationAsync(string hcId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationCollection GetApiManagementGatewayHostnameConfigurations() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetGatewayApiEntityTag(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetGatewayApiEntityTagAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.GatewayApiData> GetGatewayApisByService(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.GatewayApiData> GetGatewayApisByServiceAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegenerateKey(Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegenerateKeyAsync(Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementGatewayData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementGatewayData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementGlobalSchemaCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>, System.Collections.IEnumerable
    {
        protected ApiManagementGlobalSchemaCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string schemaId, Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string schemaId, Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> Get(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>> GetAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> GetIfExists(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>> GetIfExistsAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementGlobalSchemaData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>
    {
        public ApiManagementGlobalSchemaData() { }
        public string Description { get { throw null; } set { } }
        public System.BinaryData Document { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiSchemaType? SchemaType { get { throw null; } set { } }
        public System.BinaryData Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGlobalSchemaResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementGlobalSchemaResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string schemaId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>, System.Collections.IEnumerable
    {
        protected ApiManagementGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string groupId, Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string groupId, Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> Get(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>> GetAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> GetIfExists(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>> GetIfExistsAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementGroupData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>
    {
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public ApiManagementGroupData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ExternalId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? GroupType { get { throw null; } set { } }
        public bool? IsBuiltIn { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiManagementGroupData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementGroupData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementGroupData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementGroupResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<bool> CheckGroupUserEntityExists(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckGroupUserEntityExistsAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData> CreateGroupUser(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>> CreateGroupUserAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string groupId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteGroupUser(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteGroupUserAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData> GetGroupUsers(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData> GetGroupUsersAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementIdentityProviderCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>, System.Collections.IEnumerable
    {
        protected ApiManagementIdentityProviderCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> Get(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementIdentityProviderData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>
    {
        public ApiManagementIdentityProviderData() { }
        public System.Collections.Generic.IList<string> AllowedTenants { get { throw null; } }
        public string Authority { get { throw null; } set { } }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.IdentityProviderType? IdentityProviderType { get { throw null; } set { } }
        public string PasswordResetPolicyName { get { throw null; } set { } }
        public string ProfileEditingPolicyName { get { throw null; } set { } }
        public string SignInPolicyName { get { throw null; } set { } }
        public string SignInTenant { get { throw null; } set { } }
        public string SignUpPolicyName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementIdentityProviderResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementIdentityProviderResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementIssueCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>, System.Collections.IEnumerable
    {
        protected ApiManagementIssueCollection() { }
        public virtual Azure.Response<bool> Exists(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> Get(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>> GetAsync(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> GetIfExists(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>> GetIfExistsAsync(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementIssueResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementIssueResource() { }
        public virtual Azure.ResourceManager.ApiManagement.IssueContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string issueId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementLoggerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>, System.Collections.IEnumerable
    {
        protected ApiManagementLoggerCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string loggerId, Azure.ResourceManager.ApiManagement.ApiManagementLoggerData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string loggerId, Azure.ResourceManager.ApiManagement.ApiManagementLoggerData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> Get(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>> GetAsync(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> GetIfExists(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>> GetIfExistsAsync(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementLoggerData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>
    {
        public ApiManagementLoggerData() { }
        public System.Collections.Generic.IDictionary<string, string> Credentials { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public bool? IsBuffered { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.LoggerType? LoggerType { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementLoggerData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementLoggerData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementLoggerData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementLoggerResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementLoggerResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementLoggerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string loggerId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementNamedValueCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>, System.Collections.IEnumerable
    {
        protected ApiManagementNamedValueCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string namedValueId, Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string namedValueId, Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> Get(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), bool? isKeyVaultRefreshFailed = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? isKeyVaultRefreshFailed = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> GetAsync(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> GetIfExists(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> GetIfExistsAsync(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementNamedValueData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>
    {
        public ApiManagementNamedValueData() { }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsSecret { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties KeyVaultDetails { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Tags { get { throw null; } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementNamedValueResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementNamedValueResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string namedValueId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract> GetValue(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>> GetValueAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> RefreshSecret(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> RefreshSecretAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> Update(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementNotificationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>, System.Collections.IEnumerable
    {
        protected ApiManagementNotificationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> Get(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> GetAll(int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> GetAllAsync(int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementNotificationData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>
    {
        public ApiManagementNotificationData() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties Recipients { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementNotificationData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementNotificationData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementNotificationData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementNotificationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementNotificationResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementNotificationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<bool> CheckNotificationRecipientEmailEntityExists(string email, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckNotificationRecipientEmailEntityExistsAsync(string email, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> CheckNotificationRecipientUserEntityExists(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckNotificationRecipientUserEntityExistsAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract> CreateOrUpdateNotificationRecipientEmail(string email, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>> CreateOrUpdateNotificationRecipientEmailAsync(string email, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract> CreateOrUpdateNotificationRecipientUser(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>> CreateOrUpdateNotificationRecipientUserAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName) { throw null; }
        public virtual Azure.Response DeleteNotificationRecipientEmail(string email, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteNotificationRecipientEmailAsync(string email, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteNotificationRecipientUser(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteNotificationRecipientUserAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract> GetNotificationRecipientEmails(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract> GetNotificationRecipientEmailsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract> GetNotificationRecipientUsers(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract> GetNotificationRecipientUsersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> Update(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementOpenIdConnectProviderCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>, System.Collections.IEnumerable
    {
        protected ApiManagementOpenIdConnectProviderCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string openId, Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string openId, Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> Get(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>> GetAsync(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> GetIfExists(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>> GetIfExistsAsync(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementOpenIdConnectProviderData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>
    {
        public ApiManagementOpenIdConnectProviderData() { }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string MetadataEndpoint { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementOpenIdConnectProviderResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementOpenIdConnectProviderResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string openId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPolicyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>, System.Collections.IEnumerable
    {
        protected ApiManagementPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementPolicyResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPolicyResource() { }
        public virtual Azure.ResourceManager.ApiManagement.PolicyContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPortalDelegationSettingData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>
    {
        public ApiManagementPortalDelegationSettingData() { }
        public bool? IsSubscriptionDelegationEnabled { get { throw null; } set { } }
        public bool? IsUserRegistrationDelegationEnabled { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        public string ValidationKey { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementPortalDelegationSettingResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPortalDelegationSettingResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPortalRevisionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>, System.Collections.IEnumerable
    {
        protected ApiManagementPortalRevisionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string portalRevisionId, Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string portalRevisionId, Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> Get(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>> GetAsync(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> GetIfExists(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>> GetIfExistsAsync(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementPortalRevisionData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>
    {
        public ApiManagementPortalRevisionData() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public bool? IsCurrent { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus? Status { get { throw null; } }
        public string StatusDetails { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementPortalRevisionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPortalRevisionResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string portalRevisionId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> Update(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPortalSignInSettingData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>
    {
        public ApiManagementPortalSignInSettingData() { }
        public bool? IsRedirectEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementPortalSignInSettingResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPortalSignInSettingResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPortalSignUpSettingData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>
    {
        public ApiManagementPortalSignUpSettingData() { }
        public bool? IsSignUpDeveloperPortalEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties TermsOfService { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementPortalSignUpSettingResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPortalSignUpSettingResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected ApiManagementPrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementPrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>
    {
        public ApiManagementPrivateEndpointConnectionData() { }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState ConnectionState { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState? ProvisioningState { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementPrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPrivateLinkResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementPrivateLinkResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string privateLinkSubResourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementPrivateLinkResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>, System.Collections.IEnumerable
    {
        protected ApiManagementPrivateLinkResourceCollection() { }
        public virtual Azure.Response<bool> Exists(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> Get(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>> GetAsync(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> GetIfExists(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>> GetIfExistsAsync(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementPrivateLinkResourceData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>
    {
        public ApiManagementPrivateLinkResourceData() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IList<string> RequiredZoneNames { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementProductCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>, System.Collections.IEnumerable
    {
        protected ApiManagementProductCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string productId, Azure.ResourceManager.ApiManagement.ApiManagementProductData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string productId, Azure.ResourceManager.ApiManagement.ApiManagementProductData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> Get(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), bool? expandGroups = default(bool?), string tags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? expandGroups = default(bool?), string tags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>> GetAsync(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> GetIfExists(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>> GetIfExistsAsync(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementProductData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>
    {
        public ApiManagementProductData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsApprovalRequired { get { throw null; } set { } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState? State { get { throw null; } set { } }
        public int? SubscriptionsLimit { get { throw null; } set { } }
        public string Terms { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiManagementProductData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementProductData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementProductData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementProductPolicyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>, System.Collections.IEnumerable
    {
        protected ApiManagementProductPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementProductPolicyResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementProductPolicyResource() { }
        public virtual Azure.ResourceManager.ApiManagement.PolicyContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string productId, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementProductResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementProductResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<bool> CheckProductApiEntityExists(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckProductApiEntityExistsAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> CheckProductGroupEntityExists(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckProductGroupEntityExistsAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ProductApiData> CreateOrUpdateProductApi(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ProductApiData>> CreateOrUpdateProductApiAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ProductGroupData> CreateOrUpdateProductGroup(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>> CreateOrUpdateProductGroupAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string productId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? deleteSubscriptions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? deleteSubscriptions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteProductApi(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteProductApiAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteProductGroup(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteProductGroupAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.SubscriptionContractData> GetAllProductSubscriptionData(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.SubscriptionContractData> GetAllProductSubscriptionDataAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyCollection GetApiManagementProductPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource> GetApiManagementProductPolicy(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource>> GetApiManagementProductPolicyAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> GetApiManagementProductTag(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>> GetApiManagementProductTagAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductTagCollection GetApiManagementProductTags() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ProductApiData> GetProductApis(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ProductApiData> GetProductApisAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ProductGroupData> GetProductGroups(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ProductGroupData> GetProductGroupsAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementProductTagCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>, System.Collections.IEnumerable
    {
        protected ApiManagementProductTagCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> Get(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>> GetAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> GetIfExists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>> GetIfExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementProductTagResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementProductTagResource() { }
        public virtual Azure.ResourceManager.ApiManagement.TagContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string productId, string tagId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityStateByProduct(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityStateByProductAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource> Update(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource>> UpdateAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementServiceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>, System.Collections.IEnumerable
    {
        protected ApiManagementServiceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string serviceName, Azure.ResourceManager.ApiManagement.ApiManagementServiceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string serviceName, Azure.ResourceManager.ApiManagement.ApiManagementServiceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> Get(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> GetAsync(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetIfExists(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> GetIfExistsAsync(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementServiceData : Azure.ResourceManager.Models.TrackedResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>
    {
        public ApiManagementServiceData(Azure.Core.AzureLocation location, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties sku, string publisherEmail, string publisherName) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation> AdditionalLocations { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration> Certificates { get { throw null; } }
        public System.DateTimeOffset? CreatedAtUtc { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> CustomProperties { get { throw null; } }
        public System.Uri DeveloperPortalUri { get { throw null; } }
        public bool? DisableGateway { get { throw null; } set { } }
        public bool? EnableClientCertificate { get { throw null; } set { } }
        public Azure.ETag? ETag { get { throw null; } }
        public System.Uri GatewayRegionalUri { get { throw null; } }
        public System.Uri GatewayUri { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration> HostnameConfigurations { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Uri ManagementApiUri { get { throw null; } }
        public string MinApiVersion { get { throw null; } set { } }
        public string NotificationSenderEmail { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PlatformVersion? PlatformVersion { get { throw null; } }
        public System.Uri PortalUri { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper> PrivateEndpointConnections { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Net.IPAddress> PrivateIPAddresses { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Net.IPAddress> PublicIPAddresses { get { throw null; } }
        public Azure.Core.ResourceIdentifier PublicIPAddressId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public string PublisherEmail { get { throw null; } set { } }
        public string PublisherName { get { throw null; } set { } }
        public bool? Restore { get { throw null; } set { } }
        public System.Uri ScmUri { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties Sku { get { throw null; } set { } }
        public string TargetProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration VirtualNetworkConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType? VirtualNetworkType { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Zones { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiManagementServiceData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementServiceData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementServiceData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementServiceResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementServiceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> ApplyNetworkConfigurationUpdates(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> ApplyNetworkConfigurationUpdatesAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> Backup(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> BackupAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem> CreateOrUpdateContentItem(string contentTypeId, string contentItemId, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>> CreateOrUpdateContentItemAsync(string contentTypeId, string contentItemId, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType> CreateOrUpdateContentType(string contentTypeId, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>> CreateOrUpdateContentTypeAsync(string contentTypeId, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteContentItem(string contentTypeId, string contentItemId, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteContentItemAsync(string contentTypeId, string contentItemId, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteContentType(string contentTypeId, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteContentTypeAsync(string contentTypeId, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData> DeployTenantConfiguration(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>> DeployTenantConfigurationAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource> GetApi(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource>> GetApiAsync(string apiId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource> GetApiManagementAuthorizationServer(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource>> GetApiManagementAuthorizationServerAsync(string authsid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerCollection GetApiManagementAuthorizationServers() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource> GetApiManagementBackend(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementBackendResource>> GetApiManagementBackendAsync(string backendId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementBackendCollection GetApiManagementBackends() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource> GetApiManagementCache(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCacheResource>> GetApiManagementCacheAsync(string cacheId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementCacheCollection GetApiManagementCaches() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource> GetApiManagementCertificate(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource>> GetApiManagementCertificateAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementCertificateCollection GetApiManagementCertificates() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource> GetApiManagementDiagnostic(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource>> GetApiManagementDiagnosticAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticCollection GetApiManagementDiagnostics() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource> GetApiManagementEmailTemplate(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource>> GetApiManagementEmailTemplateAsync(Azure.ResourceManager.ApiManagement.Models.TemplateName templateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateCollection GetApiManagementEmailTemplates() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource> GetApiManagementGateway(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource>> GetApiManagementGatewayAsync(string gatewayId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayCollection GetApiManagementGateways() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource> GetApiManagementGlobalSchema(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource>> GetApiManagementGlobalSchemaAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaCollection GetApiManagementGlobalSchemas() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> GetApiManagementGroup(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource>> GetApiManagementGroupAsync(string groupId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGroupCollection GetApiManagementGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource> GetApiManagementIdentityProvider(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource>> GetApiManagementIdentityProviderAsync(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType identityProviderName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderCollection GetApiManagementIdentityProviders() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource> GetApiManagementIssue(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementIssueResource>> GetApiManagementIssueAsync(string issueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementIssueCollection GetApiManagementIssues() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource> GetApiManagementLogger(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource>> GetApiManagementLoggerAsync(string loggerId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementLoggerCollection GetApiManagementLoggers() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource> GetApiManagementNamedValue(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource>> GetApiManagementNamedValueAsync(string namedValueId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementNamedValueCollection GetApiManagementNamedValues() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource> GetApiManagementNotification(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource>> GetApiManagementNotificationAsync(Azure.ResourceManager.ApiManagement.Models.NotificationName notificationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementNotificationCollection GetApiManagementNotifications() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource> GetApiManagementOpenIdConnectProvider(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource>> GetApiManagementOpenIdConnectProviderAsync(string openId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderCollection GetApiManagementOpenIdConnectProviders() { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPolicyCollection GetApiManagementPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource> GetApiManagementPolicy(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource>> GetApiManagementPolicyAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource GetApiManagementPortalDelegationSetting() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource> GetApiManagementPortalRevision(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource>> GetApiManagementPortalRevisionAsync(string portalRevisionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionCollection GetApiManagementPortalRevisions() { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource GetApiManagementPortalSignInSetting() { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource GetApiManagementPortalSignUpSetting() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource> GetApiManagementPrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource>> GetApiManagementPrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionCollection GetApiManagementPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource> GetApiManagementPrivateLinkResource(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource>> GetApiManagementPrivateLinkResourceAsync(string privateLinkSubResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceCollection GetApiManagementPrivateLinkResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> GetApiManagementProduct(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementProductResource>> GetApiManagementProductAsync(string productId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductCollection GetApiManagementProducts() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> GetApiManagementSubscription(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>> GetApiManagementSubscriptionAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionCollection GetApiManagementSubscriptions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> GetApiManagementTag(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>> GetApiManagementTagAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementTagCollection GetApiManagementTags() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> GetApiManagementTenantSetting(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>> GetApiManagementTenantSettingAsync(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingCollection GetApiManagementTenantSettings() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> GetApiManagementUser(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>> GetApiManagementUserAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementUserCollection GetApiManagementUsers() { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiCollection GetApis() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetApisByTags(string filter = null, int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedApis = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetApisByTagsAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedApis = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> GetApiVersionSet(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>> GetApiVersionSetAsync(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiVersionSetCollection GetApiVersionSets() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult> GetAvailableApiManagementServiceSkus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult> GetAvailableApiManagementServiceSkusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem> GetContentItem(string contentTypeId, string contentItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>> GetContentItemAsync(string contentTypeId, string contentItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetContentItemEntityTag(string contentTypeId, string contentItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetContentItemEntityTagAsync(string contentTypeId, string contentItemId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem> GetContentItems(string contentTypeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem> GetContentItemsAsync(string contentTypeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType> GetContentType(string contentTypeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>> GetContentTypeAsync(string contentTypeId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType> GetContentTypes(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType> GetContentTypesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract> GetNetworkStatusByLocation(Azure.Core.AzureLocation locationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>> GetNetworkStatusByLocationAsync(Azure.Core.AzureLocation locationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation> GetNetworkStatuses(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation> GetNetworkStatusesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpoints(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpointsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData> GetPolicyDescriptions(Azure.ResourceManager.ApiManagement.Models.PolicyScopeContract? scope = default(Azure.ResourceManager.ApiManagement.Models.PolicyScopeContract?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData> GetPolicyDescriptionsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyScopeContract? scope = default(Azure.ResourceManager.ApiManagement.Models.PolicyScopeContract?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData> GetPortalSettings(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData> GetPortalSettingsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetProductsByTags(string filter = null, int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedProducts = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetProductsByTagsAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedProducts = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract> GetQuotaByCounterKeys(string quotaCounterKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract> GetQuotaByCounterKeysAsync(string quotaCounterKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract> GetQuotaByPeriodKey(string quotaCounterKey, string quotaPeriodKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>> GetQuotaByPeriodKeyAsync(string quotaCounterKey, string quotaPeriodKey, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.RegionContract> GetRegions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.RegionContract> GetRegionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByApi(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByApiAsync(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByGeo(string filter, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByGeoAsync(string filter, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByOperation(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByOperationAsync(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByProduct(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByProductAsync(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract> GetReportsByRequest(string filter, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract> GetReportsByRequestAsync(string filter, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsBySubscription(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsBySubscriptionAsync(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByTime(string filter, System.TimeSpan interval, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByTimeAsync(string filter, System.TimeSpan interval, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByUser(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract> GetReportsByUserAsync(string filter, int? top = default(int?), int? skip = default(int?), string orderBy = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult> GetSsoToken(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>> GetSsoTokenAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetTagResources(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetTagResourcesAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> GetTenantAccessInfo(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>> GetTenantAccessInfoAsync(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.TenantAccessInfoCollection GetTenantAccessInfos() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract> GetTenantConfigurationSyncState(Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>> GetTenantConfigurationSyncStateAsync(Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult> PerformConnectivityCheckAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>> PerformConnectivityCheckAsyncAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> Restore(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> RestoreAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData> SaveTenantConfiguration(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>> SaveTenantConfigurationAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract> UpdateQuotaByCounterKeys(string quotaCounterKey, Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract> UpdateQuotaByCounterKeysAsync(string quotaCounterKey, Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract> UpdateQuotaByPeriodKey(string quotaCounterKey, string quotaPeriodKey, Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>> UpdateQuotaByPeriodKeyAsync(string quotaCounterKey, string quotaPeriodKey, Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData> ValidateTenantConfiguration(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>> ValidateTenantConfigurationAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ConfigurationName configurationName, Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementSubscriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>, System.Collections.IEnumerable
    {
        protected ApiManagementSubscriptionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string sid, Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent content, bool? notify = default(bool?), Azure.ETag? ifMatch = default(Azure.ETag?), Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string sid, Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent content, bool? notify = default(bool?), Azure.ETag? ifMatch = default(Azure.ETag?), Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> Get(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>> GetAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> GetIfExists(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>> GetIfExistsAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementSubscriptionResource() { }
        public virtual Azure.ResourceManager.ApiManagement.SubscriptionContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string sid) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegeneratePrimaryKey(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegeneratePrimaryKeyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegenerateSecondaryKey(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegenerateSecondaryKeyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch patch, bool? notify = default(bool?), Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch patch, bool? notify = default(bool?), Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementTagCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>, System.Collections.IEnumerable
    {
        protected ApiManagementTagCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string tagId, Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string tagId, Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> Get(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), string scope = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), string scope = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>> GetAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> GetIfExists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>> GetIfExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementTagResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementTagResource() { }
        public virtual Azure.ResourceManager.ApiManagement.TagContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string tagId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityState(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityStateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTagResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementTenantSettingCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>, System.Collections.IEnumerable
    {
        protected ApiManagementTenantSettingCollection() { }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> Get(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> GetAll(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> GetAllAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementTenantSettingData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>
    {
        public ApiManagementTenantSettingData() { }
        public System.Collections.Generic.IDictionary<string, string> Settings { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementTenantSettingResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementTenantSettingResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, Azure.ResourceManager.ApiManagement.Models.SettingsType settingsType) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementUserCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>, System.Collections.IEnumerable
    {
        protected ApiManagementUserCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string userId, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent content, bool? notify = default(bool?), Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string userId, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent content, bool? notify = default(bool?), Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> Get(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), bool? expandGroups = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? expandGroups = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>> GetAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> GetIfExists(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>> GetIfExistsAsync(string userId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementUserResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementUserResource() { }
        public virtual Azure.ResourceManager.ApiManagement.UserContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string userId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? deleteSubscriptions = default(bool?), bool? notify = default(bool?), Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? deleteSubscriptions = default(bool?), bool? notify = default(bool?), Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult> GenerateSsoUri(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>> GenerateSsoUriAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> GetApiManagementUserSubscription(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>> GetApiManagementUserSubscriptionAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionCollection GetApiManagementUserSubscriptions() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.UserTokenResult> GetSharedAccessToken(Azure.ResourceManager.ApiManagement.Models.UserTokenContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>> GetSharedAccessTokenAsync(Azure.ResourceManager.ApiManagement.Models.UserTokenContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> GetUserGroups(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementGroupResource> GetUserGroupsAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> GetUserIdentities(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> GetUserIdentitiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SendUserConfirmationPassword(Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SendUserConfirmationPasswordAsync(Azure.ResourceManager.ApiManagement.Models.AppType? appType = default(Azure.ResourceManager.ApiManagement.Models.AppType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiManagementUserSubscriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>, System.Collections.IEnumerable
    {
        protected ApiManagementUserSubscriptionCollection() { }
        public virtual Azure.Response<bool> Exists(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> Get(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>> GetAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> GetIfExists(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>> GetIfExistsAsync(string sid, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiManagementUserSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiManagementUserSubscriptionResource() { }
        public virtual Azure.ResourceManager.ApiManagement.SubscriptionContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string userId, string sid) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiOperationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationResource>, System.Collections.IEnumerable
    {
        protected ApiOperationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string operationId, Azure.ResourceManager.ApiManagement.ApiOperationData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string operationId, Azure.ResourceManager.ApiManagement.ApiOperationData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource> Get(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiOperationResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), string tags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiOperationResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), string tags = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource>> GetAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiOperationResource> GetIfExists(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiOperationResource>> GetIfExistsAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiOperationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiOperationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiOperationData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiOperationData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiOperationData>
    {
        public ApiOperationData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
        public string Policies { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.RequestContract Request { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ResponseContract> Responses { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ParameterContract> TemplateParameters { get { throw null; } }
        public string UriTemplate { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiOperationData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiOperationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiOperationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiOperationData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiOperationData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiOperationData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiOperationData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiOperationPolicyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>, System.Collections.IEnumerable
    {
        protected ApiOperationPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiOperationPolicyResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiOperationPolicyResource() { }
        public virtual Azure.ResourceManager.ApiManagement.PolicyContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string operationId, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiOperationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiOperationResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string operationId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationPolicyCollection GetApiOperationPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource> GetApiOperationPolicy(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource>> GetApiOperationPolicyAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> GetApiOperationTag(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>> GetApiOperationTagAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationTagCollection GetApiOperationTags() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiOperationTagCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>, System.Collections.IEnumerable
    {
        protected ApiOperationTagCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> Get(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>> GetAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> GetIfExists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>> GetIfExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiOperationTagResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiOperationTagResource() { }
        public virtual Azure.ResourceManager.ApiManagement.TagContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string operationId, string tagId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityStateByOperation(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityStateByOperationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationTagResource> Update(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiOperationTagResource>> UpdateAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiPolicyCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiPolicyResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiPolicyResource>, System.Collections.IEnumerable
    {
        protected ApiPolicyCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiPolicyResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiPolicyResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiPolicyResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiPolicyResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiPolicyResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiPolicyResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiPolicyResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiPolicyResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiPolicyResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiPolicyResource() { }
        public virtual Azure.ResourceManager.ApiManagement.PolicyContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, Azure.ResourceManager.ApiManagement.Models.PolicyName policyId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiPolicyResource> Get(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiPolicyResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiPolicyResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiPolicyResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.PolicyContractData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiReleaseCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiReleaseResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiReleaseResource>, System.Collections.IEnumerable
    {
        protected ApiReleaseCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiReleaseResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string releaseId, Azure.ResourceManager.ApiManagement.ApiReleaseData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiReleaseResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string releaseId, Azure.ResourceManager.ApiManagement.ApiReleaseData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource> Get(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiReleaseResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiReleaseResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource>> GetAsync(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiReleaseResource> GetIfExists(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiReleaseResource>> GetIfExistsAsync(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiReleaseResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiReleaseResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiReleaseResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiReleaseResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiReleaseData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>
    {
        public ApiReleaseData() { }
        public Azure.Core.ResourceIdentifier ApiId { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string Notes { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        Azure.ResourceManager.ApiManagement.ApiReleaseData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiReleaseData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiReleaseData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiReleaseResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiReleaseResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiReleaseData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string releaseId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiReleaseData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.ApiReleaseData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? deleteRevisions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? deleteRevisions = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource> GetApiDiagnostic(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiDiagnosticResource>> GetApiDiagnosticAsync(string diagnosticId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiDiagnosticCollection GetApiDiagnostics() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource> GetApiIssue(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiIssueResource>> GetApiIssueAsync(string issueId, bool? expandCommentsAttachments = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueCollection GetApiIssues() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource> GetApiOperation(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiOperationResource>> GetApiOperationAsync(string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationCollection GetApiOperations() { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiPolicyCollection GetApiPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiPolicyResource> GetApiPolicy(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiPolicyResource>> GetApiPolicyAsync(Azure.ResourceManager.ApiManagement.Models.PolicyName policyId, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> GetApiProducts(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementProductResource> GetApiProductsAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource> GetApiRelease(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiReleaseResource>> GetApiReleaseAsync(string releaseId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiReleaseCollection GetApiReleases() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract> GetApiRevisionsByService(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract> GetApiRevisionsByServiceAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiSchemaResource> GetApiSchema(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiSchemaResource>> GetApiSchemaAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiSchemaCollection GetApiSchemas() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagResource> GetApiTag(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagResource>> GetApiTagAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> GetApiTagDescription(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>> GetApiTagDescriptionAsync(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiTagDescriptionCollection GetApiTagDescriptions() { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiTagCollection GetApiTags() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetOperationsByTags(string filter = null, int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedOperations = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails> GetOperationsByTagsAsync(string filter = null, int? top = default(int?), int? skip = default(int?), bool? includeNotTaggedOperations = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiSchemaCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiSchemaResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiSchemaResource>, System.Collections.IEnumerable
    {
        protected ApiSchemaCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiSchemaResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string schemaId, Azure.ResourceManager.ApiManagement.ApiSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiSchemaResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string schemaId, Azure.ResourceManager.ApiManagement.ApiSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiSchemaResource> Get(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiSchemaResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiSchemaResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiSchemaResource>> GetAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiSchemaResource> GetIfExists(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiSchemaResource>> GetIfExistsAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiSchemaResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiSchemaResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiSchemaResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiSchemaResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiSchemaData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>
    {
        public ApiSchemaData() { }
        public System.BinaryData Components { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public System.BinaryData Definitions { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiSchemaData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiSchemaData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiSchemaData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiSchemaResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiSchemaResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiSchemaData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string schemaId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiSchemaResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiSchemaResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiSchemaResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiSchemaResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.ApiSchemaData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiTagCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiTagResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiTagResource>, System.Collections.IEnumerable
    {
        protected ApiTagCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagResource> Get(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiTagResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiTagResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagResource>> GetAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiTagResource> GetIfExists(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiTagResource>> GetIfExistsAsync(string tagId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiTagResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiTagResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiTagResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiTagResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiTagDescriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>, System.Collections.IEnumerable
    {
        protected ApiTagDescriptionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string tagDescriptionId, Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string tagDescriptionId, Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> Get(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>> GetAsync(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> GetIfExists(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>> GetIfExistsAsync(string tagDescriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiTagDescriptionData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>
    {
        public ApiTagDescriptionData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ExternalDocsDescription { get { throw null; } set { } }
        public System.Uri ExternalDocsUri { get { throw null; } set { } }
        public string TagId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiTagDescriptionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiTagDescriptionData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiTagDescriptionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiTagDescriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiTagDescriptionResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiTagDescriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string tagDescriptionId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent content, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiTagResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiTagResource() { }
        public virtual Azure.ResourceManager.ApiManagement.TagContractData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string apiId, string tagId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiTagResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityStateByApi(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityStateByApiAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagResource> Update(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiTagResource>> UpdateAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ApiVersionSetCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>, System.Collections.IEnumerable
    {
        protected ApiVersionSetCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string versionSetId, Azure.ResourceManager.ApiManagement.ApiVersionSetData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string versionSetId, Azure.ResourceManager.ApiManagement.ApiVersionSetData data, Azure.ETag? ifMatch = default(Azure.ETag?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> Get(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> GetAll(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> GetAllAsync(string filter = null, int? top = default(int?), int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>> GetAsync(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> GetIfExists(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>> GetIfExistsAsync(string versionSetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ApiVersionSetData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>
    {
        public ApiVersionSetData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string VersionHeaderName { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.VersioningScheme? VersioningScheme { get { throw null; } set { } }
        public string VersionQueryName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.ApiVersionSetData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.ApiVersionSetData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.ApiVersionSetData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiVersionSetResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ApiVersionSetResource() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiVersionSetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string versionSetId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, Azure.ETag ifMatch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiVersionSetResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DiagnosticContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>
    {
        public DiagnosticContractData() { }
        public Azure.ResourceManager.ApiManagement.Models.AlwaysLog? AlwaysLog { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings Backend { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings Frontend { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol? HttpCorrelationProtocol { get { throw null; } set { } }
        public bool? IsLogClientIPEnabled { get { throw null; } set { } }
        public string LoggerId { get { throw null; } set { } }
        public bool? Metrics { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.OperationNameFormat? OperationNameFormat { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SamplingSettings Sampling { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel? Verbosity { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.DiagnosticContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.DiagnosticContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.DiagnosticContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class IssueContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.IssueContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.IssueContractData>
    {
        public IssueContractData() { }
        public Azure.Core.ResourceIdentifier ApiId { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.IssueState? State { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier UserId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.IssueContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.IssueContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.IssueContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.IssueContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.IssueContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.IssueContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.IssueContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.PolicyContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.PolicyContractData>
    {
        public PolicyContractData() { }
        public Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat? Format { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.PolicyContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.PolicyContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.PolicyContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.PolicyContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.PolicyContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.PolicyContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.PolicyContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>
    {
        public SubscriptionContractData() { }
        public bool? AllowTracing { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } set { } }
        public System.DateTimeOffset? NotifiesOn { get { throw null; } set { } }
        public string OwnerId { get { throw null; } set { } }
        public string PrimaryKey { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public string SecondaryKey { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionState? State { get { throw null; } set { } }
        public string StateComment { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.SubscriptionContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.SubscriptionContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.SubscriptionContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TagContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.TagContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TagContractData>
    {
        public TagContractData() { }
        public string DisplayName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.TagContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.TagContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.TagContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.TagContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TagContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TagContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TagContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantAccessInfoCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>, System.Collections.IEnumerable
    {
        protected TenantAccessInfoCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.AccessName accessName, Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ApiManagement.Models.AccessName accessName, Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> Get(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> GetAll(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> GetAllAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>> GetAsync(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> GetIfExists(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>> GetIfExistsAsync(Azure.ResourceManager.ApiManagement.Models.AccessName accessName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TenantAccessInfoData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>
    {
        public TenantAccessInfoData() { }
        public string AccessInfoType { get { throw null; } set { } }
        public bool? IsDirectAccessEnabled { get { throw null; } set { } }
        public string PrincipalId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.TenantAccessInfoData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.TenantAccessInfoData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.TenantAccessInfoData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantAccessInfoResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TenantAccessInfoResource() { }
        public virtual Azure.ResourceManager.ApiManagement.TenantAccessInfoData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, Azure.ResourceManager.ApiManagement.Models.AccessName accessName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> GetEntityTag(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> GetEntityTagAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails> GetSecrets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>> GetSecretsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegeneratePrimaryKey(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegeneratePrimaryKeyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegeneratePrimaryKeyForGit(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegeneratePrimaryKeyForGitAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegenerateSecondaryKey(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegenerateSecondaryKeyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RegenerateSecondaryKeyForGit(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RegenerateSecondaryKeyForGitAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource> Update(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.TenantAccessInfoResource>> UpdateAsync(Azure.ETag ifMatch, Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class UserContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.UserContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.UserContractData>
    {
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public UserContractData() { }
        public string Email { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties> Groups { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> Identities { get { throw null; } }
        public string LastName { get { throw null; } set { } }
        public string Note { get { throw null; } set { } }
        public System.DateTimeOffset? RegistriesOn { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState? State { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.UserContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.UserContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.UserContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.UserContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.UserContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.UserContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.UserContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.ApiManagement.Mocking
{
    public partial class MockableApiManagementArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableApiManagementArmClient() { }
        public virtual Azure.ResourceManager.ApiManagement.ApiDiagnosticResource GetApiDiagnosticResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueAttachmentResource GetApiIssueAttachmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueCommentResource GetApiIssueCommentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiIssueResource GetApiIssueResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerResource GetApiManagementAuthorizationServerResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementBackendResource GetApiManagementBackendResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementCacheResource GetApiManagementCacheResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementCertificateResource GetApiManagementCertificateResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource GetApiManagementDeletedServiceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementDiagnosticResource GetApiManagementDiagnosticResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateResource GetApiManagementEmailTemplateResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityResource GetApiManagementGatewayCertificateAuthorityResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationResource GetApiManagementGatewayHostnameConfigurationResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGatewayResource GetApiManagementGatewayResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaResource GetApiManagementGlobalSchemaResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementGroupResource GetApiManagementGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderResource GetApiManagementIdentityProviderResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementIssueResource GetApiManagementIssueResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementLoggerResource GetApiManagementLoggerResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementNamedValueResource GetApiManagementNamedValueResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementNotificationResource GetApiManagementNotificationResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderResource GetApiManagementOpenIdConnectProviderResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPolicyResource GetApiManagementPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingResource GetApiManagementPortalDelegationSettingResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionResource GetApiManagementPortalRevisionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingResource GetApiManagementPortalSignInSettingResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingResource GetApiManagementPortalSignUpSettingResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionResource GetApiManagementPrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResource GetApiManagementPrivateLinkResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductPolicyResource GetApiManagementProductPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductResource GetApiManagementProductResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementProductTagResource GetApiManagementProductTagResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementServiceResource GetApiManagementServiceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementSubscriptionResource GetApiManagementSubscriptionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementTagResource GetApiManagementTagResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingResource GetApiManagementTenantSettingResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementUserResource GetApiManagementUserResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementUserSubscriptionResource GetApiManagementUserSubscriptionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationPolicyResource GetApiOperationPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationResource GetApiOperationResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiOperationTagResource GetApiOperationTagResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiPolicyResource GetApiPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiReleaseResource GetApiReleaseResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiResource GetApiResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiSchemaResource GetApiSchemaResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiTagDescriptionResource GetApiTagDescriptionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiTagResource GetApiTagResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiVersionSetResource GetApiVersionSetResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.TenantAccessInfoResource GetTenantAccessInfoResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableApiManagementResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableApiManagementResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetApiManagementService(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource>> GetApiManagementServiceAsync(string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementServiceCollection GetApiManagementServices() { throw null; }
    }
    public partial class MockableApiManagementSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableApiManagementSubscriptionResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult> CheckApiManagementServiceNameAvailability(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>> CheckApiManagementServiceNameAvailabilityAsync(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetApiManagementDeletedService(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource>> GetApiManagementDeletedServiceAsync(Azure.Core.AzureLocation location, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceCollection GetApiManagementDeletedServices() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetApiManagementDeletedServices(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceResource> GetApiManagementDeletedServicesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult> GetApiManagementServiceDomainOwnershipIdentifier(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>> GetApiManagementServiceDomainOwnershipIdentifierAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetApiManagementServices(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.ApiManagementServiceResource> GetApiManagementServicesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku> GetApiManagementSkus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku> GetApiManagementSkusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ApiManagement.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AccessName : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.AccessName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AccessName(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AccessName TenantAccess { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.AccessName TenantGitAccess { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.AccessName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.AccessName left, Azure.ResourceManager.ApiManagement.Models.AccessName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.AccessName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.AccessName left, Azure.ResourceManager.ApiManagement.Models.AccessName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AdditionalLocation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>
    {
        public AdditionalLocation(Azure.Core.AzureLocation location, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties sku) { }
        public bool? DisableGateway { get { throw null; } set { } }
        public System.Uri GatewayRegionalUri { get { throw null; } }
        public Azure.Core.AzureLocation Location { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PlatformVersion? PlatformVersion { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Net.IPAddress> PrivateIPAddresses { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Net.IPAddress> PublicIPAddresses { get { throw null; } }
        public Azure.Core.ResourceIdentifier PublicIPAddressId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties Sku { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration VirtualNetworkConfiguration { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Zones { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AdditionalLocation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AdditionalLocation System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AlwaysLog : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.AlwaysLog>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AlwaysLog(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AlwaysLog AllErrors { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.AlwaysLog other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.AlwaysLog left, Azure.ResourceManager.ApiManagement.Models.AlwaysLog right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.AlwaysLog (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.AlwaysLog left, Azure.ResourceManager.ApiManagement.Models.AlwaysLog right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiContactInformation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>
    {
        public ApiContactInformation() { }
        public string Email { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiContactInformation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiContactInformation System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiContactInformation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>
    {
        public ApiCreateOrUpdateContent() { }
        public string ApiRevision { get { throw null; } set { } }
        public string ApiRevisionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiType? ApiType { get { throw null; } set { } }
        public string ApiVersion { get { throw null; } set { } }
        public string ApiVersionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails ApiVersionSet { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ApiVersionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract AuthenticationSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiContactInformation Contact { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ContentFormat? Format { get { throw null; } set { } }
        public bool? IsCurrent { get { throw null; } set { } }
        public bool? IsOnline { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation License { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> Protocols { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SoapApiType? SoapApiType { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SourceApiId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get { throw null; } set { } }
        public System.Uri TermsOfServiceUri { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector WsdlSelector { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>
    {
        public ApiCreateOrUpdatePropertiesWsdlSelector() { }
        public string WsdlEndpointName { get { throw null; } set { } }
        public string WsdlServiceName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiEntityBaseContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>
    {
        internal ApiEntityBaseContract() { }
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public string ApiRevision { get { throw null; } }
        public string ApiRevisionDescription { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiType? ApiType { get { throw null; } }
        public string ApiVersion { get { throw null; } }
        public string ApiVersionDescription { get { throw null; } }
        public Azure.Core.ResourceIdentifier ApiVersionSetId { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract AuthenticationSettings { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiContactInformation Contact { get { throw null; } }
        public string Description { get { throw null; } }
        public bool? IsCurrent { get { throw null; } }
        public bool? IsOnline { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation License { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get { throw null; } }
        public System.Uri TermsOfServiceUri { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiIssuePatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>
    {
        public ApiIssuePatch() { }
        public Azure.Core.ResourceIdentifier ApiId { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.IssueState? State { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public string UserId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiIssuePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiLicenseInformation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>
    {
        public ApiLicenseInformation() { }
        public string Name { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementAuthorizationServerPatch : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>
    {
        public ApiManagementAuthorizationServerPatch() { }
        public string AuthorizationEndpoint { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.AuthorizationMethod> AuthorizationMethods { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod> BearerTokenSendingMethods { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod> ClientAuthenticationMethods { get { throw null; } }
        public string ClientId { get { throw null; } set { } }
        public string ClientRegistrationEndpoint { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public string DefaultScope { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? DoesSupportState { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.GrantType> GrantTypes { get { throw null; } }
        public string ResourceOwnerPassword { get { throw null; } set { } }
        public string ResourceOwnerUsername { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract> TokenBodyParameters { get { throw null; } }
        public string TokenEndpoint { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementBackendPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>
    {
        public ApiManagementBackendPatch() { }
        public Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties BackendServiceFabricCluster { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract Credentials { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendProtocol? Protocol { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendProxyContract Proxy { get { throw null; } set { } }
        public System.Uri ResourceUri { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties Tls { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementBackendPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementCachePatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>
    {
        public ApiManagementCachePatch() { }
        public string ConnectionString { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Uri ResourceUri { get { throw null; } set { } }
        public string UseFromLocation { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCachePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementCertificateCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>
    {
        public ApiManagementCertificateCreateOrUpdateContent() { }
        public string Data { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties KeyVaultDetails { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementCertificateCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementContentItem : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>
    {
        public ApiManagementContentItem() { }
        public string ContentItemId { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> Properties { get { throw null; } }
        public Azure.Core.ResourceType ResourceType { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentItem>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementContentType : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>
    {
        public ApiManagementContentType() { }
        public string ContentTypeId { get { throw null; } }
        public string ContentTypeIdentifier { get { throw null; } set { } }
        public string ContentTypeName { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public Azure.Core.ResourceType ResourceType { get { throw null; } }
        public System.BinaryData Schema { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementContentType>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementEmailTemplateCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>
    {
        public ApiManagementEmailTemplateCreateOrUpdateContent() { }
        public string Body { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties> Parameters { get { throw null; } }
        public string Subject { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementEmailTemplateCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGroupCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>
    {
        public ApiManagementGroupCreateOrUpdateContent() { }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? ApiManagementGroupType { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ExternalId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementGroupPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>
    {
        public ApiManagementGroupPatch() { }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? ApiManagementGroupType { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ExternalId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ApiManagementGroupType
    {
        Custom = 0,
        System = 1,
        External = 2,
    }
    public partial class ApiManagementGroupUserData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>
    {
        public ApiManagementGroupUserData() { }
        public string Email { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties> Groups { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> Identities { get { throw null; } }
        public string LastName { get { throw null; } set { } }
        public string Note { get { throw null; } set { } }
        public System.DateTimeOffset? RegistriesOn { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState? State { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementIdentityProviderCreateOrUpdateContent : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>
    {
        public ApiManagementIdentityProviderCreateOrUpdateContent() { }
        public System.Collections.Generic.IList<string> AllowedTenants { get { throw null; } }
        public string Authority { get { throw null; } set { } }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.IdentityProviderType? IdentityProviderType { get { throw null; } set { } }
        public string PasswordResetPolicyName { get { throw null; } set { } }
        public string ProfileEditingPolicyName { get { throw null; } set { } }
        public string SignInPolicyName { get { throw null; } set { } }
        public string SignInTenant { get { throw null; } set { } }
        public string SignUpPolicyName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementIdentityProviderPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>
    {
        public ApiManagementIdentityProviderPatch() { }
        public System.Collections.Generic.IList<string> AllowedTenants { get { throw null; } }
        public string Authority { get { throw null; } set { } }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.IdentityProviderType? IdentityProviderType { get { throw null; } set { } }
        public string PasswordResetPolicyName { get { throw null; } set { } }
        public string ProfileEditingPolicyName { get { throw null; } set { } }
        public string SignInPolicyName { get { throw null; } set { } }
        public string SignInTenant { get { throw null; } set { } }
        public string SignUpPolicyName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementLoggerPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>
    {
        public ApiManagementLoggerPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Credentials { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public bool? IsBuffered { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.LoggerType? LoggerType { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementLoggerPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementNamedValueCreateOrUpdateContent : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>
    {
        public ApiManagementNamedValueCreateOrUpdateContent() { }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsSecret { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties KeyVault { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Tags { get { throw null; } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementNamedValuePatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>
    {
        public ApiManagementNamedValuePatch() { }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsSecret { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties KeyVault { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Tags { get { throw null; } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValuePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementOpenIdConnectProviderPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>
    {
        public ApiManagementOpenIdConnectProviderPatch() { }
        public string ClientId { get { throw null; } set { } }
        public string ClientSecret { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string MetadataEndpoint { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementOpenIdConnectProviderPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementPrivateEndpointConnectionCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>
    {
        public ApiManagementPrivateEndpointConnectionCreateOrUpdateContent() { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiManagementPrivateEndpointConnectionProvisioningState : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiManagementPrivateEndpointConnectionProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiManagementPrivateEndpointServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiManagementPrivateEndpointServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus left, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiManagementPrivateLinkServiceConnectionState : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>
    {
        public ApiManagementPrivateLinkServiceConnectionState() { }
        public string ActionsRequired { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointServiceConnectionStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementProductPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>
    {
        public ApiManagementProductPatch() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsApprovalRequired { get { throw null; } set { } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState? State { get { throw null; } set { } }
        public int? SubscriptionsLimit { get { throw null; } set { } }
        public string Terms { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementProductPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ApiManagementProductState
    {
        NotPublished = 0,
        Published = 1,
    }
    public partial class ApiManagementResourceSkuCapacity : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>
    {
        internal ApiManagementResourceSkuCapacity() { }
        public int? Default { get { throw null; } }
        public int? Maximum { get { throw null; } }
        public int? Minimum { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType? ScaleType { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiManagementResourceSkuCapacityScaleType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiManagementResourceSkuCapacityScaleType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType Automatic { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType Manual { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType left, Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType left, Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiManagementServiceApplyNetworkConfigurationContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>
    {
        public ApiManagementServiceApplyNetworkConfigurationContent() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceApplyNetworkConfigurationContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceBackupRestoreContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>
    {
        public ApiManagementServiceBackupRestoreContent(string storageAccount, string containerName, string backupName) { }
        public string AccessKey { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType? AccessType { get { throw null; } set { } }
        public string BackupName { get { throw null; } }
        public string ClientId { get { throw null; } set { } }
        public string ContainerName { get { throw null; } }
        public string StorageAccount { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceGetDomainOwnershipIdentifierResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>
    {
        internal ApiManagementServiceGetDomainOwnershipIdentifierResult() { }
        public string DomainOwnershipIdentifier { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceGetSsoTokenResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>
    {
        internal ApiManagementServiceGetSsoTokenResult() { }
        public System.Uri RedirectUri { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceNameAvailabilityContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>
    {
        public ApiManagementServiceNameAvailabilityContent(string name) { }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceNameAvailabilityResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>
    {
        internal ApiManagementServiceNameAvailabilityResult() { }
        public bool? IsNameAvailable { get { throw null; } }
        public string Message { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameUnavailableReason? Reason { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ApiManagementServiceNameUnavailableReason
    {
        Valid = 0,
        Invalid = 1,
        AlreadyExists = 2,
    }
    public partial class ApiManagementServicePatch : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>
    {
        public ApiManagementServicePatch() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation> AdditionalLocations { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration> Certificates { get { throw null; } }
        public System.DateTimeOffset? CreatedAtUtc { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> CustomProperties { get { throw null; } }
        public System.Uri DeveloperPortalUri { get { throw null; } }
        public bool? DisableGateway { get { throw null; } set { } }
        public bool? EnableClientCertificate { get { throw null; } set { } }
        public Azure.ETag? ETag { get { throw null; } }
        public System.Uri GatewayRegionalUri { get { throw null; } }
        public System.Uri GatewayUri { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration> HostnameConfigurations { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Uri ManagementApiUri { get { throw null; } }
        public string MinApiVersion { get { throw null; } set { } }
        public string NotificationSenderEmail { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PlatformVersion? PlatformVersion { get { throw null; } }
        public System.Uri PortalUri { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper> PrivateEndpointConnections { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Net.IPAddress> PrivateIPAddresses { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Net.IPAddress> PublicIPAddresses { get { throw null; } }
        public Azure.Core.ResourceIdentifier PublicIPAddressId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        public string PublisherEmail { get { throw null; } set { } }
        public string PublisherName { get { throw null; } set { } }
        public bool? Restore { get { throw null; } set { } }
        public System.Uri ScmUri { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties Sku { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public string TargetProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration VirtualNetworkConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType? VirtualNetworkType { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Zones { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementServiceSkuProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>
    {
        public ApiManagementServiceSkuProperties(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType name, int capacity) { }
        public int Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Name { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiManagementServiceSkuType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiManagementServiceSkuType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Basic { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Consumption { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Developer { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Isolated { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Premium { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType left, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType left, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiManagementSku : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>
    {
        internal ApiManagementSku() { }
        public System.Collections.Generic.IReadOnlyList<string> ApiVersions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities> Capabilities { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity Capacity { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts> Costs { get { throw null; } }
        public string Family { get { throw null; } }
        public string Kind { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo> LocationInfo { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.AzureLocation> Locations { get { throw null; } }
        public string Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions> Restrictions { get { throw null; } }
        public string Size { get { throw null; } }
        public string Tier { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSku System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSku System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSku>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSkuCapabilities : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>
    {
        internal ApiManagementSkuCapabilities() { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSkuCapacity : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>
    {
        internal ApiManagementSkuCapacity() { }
        public int? Default { get { throw null; } }
        public int? Maximum { get { throw null; } }
        public int? Minimum { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacityScaleType? ScaleType { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ApiManagementSkuCapacityScaleType
    {
        None = 0,
        Automatic = 1,
        Manual = 2,
    }
    public partial class ApiManagementSkuCosts : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>
    {
        internal ApiManagementSkuCosts() { }
        public string ExtendedUnit { get { throw null; } }
        public string MeterId { get { throw null; } }
        public long? Quantity { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSkuLocationInfo : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>
    {
        internal ApiManagementSkuLocationInfo() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails> ZoneDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Zones { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSkuRestrictionInfo : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>
    {
        internal ApiManagementSkuRestrictionInfo() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Core.AzureLocation> Locations { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Zones { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSkuRestrictions : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>
    {
        internal ApiManagementSkuRestrictions() { }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionsReasonCode? ReasonCode { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo RestrictionInfo { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionsType? RestrictionsType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Values { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ApiManagementSkuRestrictionsReasonCode
    {
        QuotaId = 0,
        NotAvailableForSubscription = 1,
    }
    public enum ApiManagementSkuRestrictionsType
    {
        Location = 0,
        Zone = 1,
    }
    public partial class ApiManagementSkuZoneDetails : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>
    {
        internal ApiManagementSkuZoneDetails() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities> Capabilities { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Name { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSubscriptionCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>
    {
        public ApiManagementSubscriptionCreateOrUpdateContent() { }
        public bool? AllowTracing { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string OwnerId { get { throw null; } set { } }
        public string PrimaryKey { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public string SecondaryKey { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionState? State { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementSubscriptionPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>
    {
        public ApiManagementSubscriptionPatch() { }
        public bool? AllowTracing { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } set { } }
        public string OwnerId { get { throw null; } set { } }
        public string PrimaryKey { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public string SecondaryKey { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionState? State { get { throw null; } set { } }
        public string StateComment { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementSubscriptionPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementTagCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>
    {
        public ApiManagementTagCreateOrUpdateContent() { }
        public string DisplayName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementTagCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementUserCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>
    {
        public ApiManagementUserCreateOrUpdateContent() { }
        public Azure.ResourceManager.ApiManagement.Models.AppType? AppType { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType? Confirmation { get { throw null; } set { } }
        public string Email { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> Identities { get { throw null; } }
        public string LastName { get { throw null; } set { } }
        public string Note { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState? State { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiManagementUserPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>
    {
        public ApiManagementUserPatch() { }
        public string Email { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> Identities { get { throw null; } }
        public string LastName { get { throw null; } set { } }
        public string Note { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState? State { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiManagementUserState : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiManagementUserState(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState Active { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState Blocked { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState Deleted { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState Pending { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState left, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState left, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiOperationInvokableProtocol : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiOperationInvokableProtocol(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol Http { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol Https { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol Ws { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol Wss { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol left, Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol left, Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiOperationPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>
    {
        public ApiOperationPatch() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
        public string Policies { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.RequestContract Request { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ResponseContract> Responses { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ParameterContract> TemplateParameters { get { throw null; } }
        public string UriTemplate { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiOperationPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>
    {
        public ApiPatch() { }
        public string ApiRevision { get { throw null; } set { } }
        public string ApiRevisionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiType? ApiType { get { throw null; } set { } }
        public string ApiVersion { get { throw null; } set { } }
        public string ApiVersionDescription { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ApiVersionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract AuthenticationSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiContactInformation Contact { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsCurrent { get { throw null; } set { } }
        public bool? IsOnline { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation License { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> Protocols { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get { throw null; } set { } }
        public System.Uri TermsOfServiceUri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiRevisionContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>
    {
        internal ApiRevisionContract() { }
        public string ApiId { get { throw null; } }
        public string ApiRevision { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string Description { get { throw null; } }
        public bool? IsCurrent { get { throw null; } }
        public bool? IsOnline { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future release. Please use `PrivateUriString` instead.", false)]
        public System.Uri PrivateUri { get { throw null; } }
        public string PrivateUriString { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiSchemaType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiSchemaType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiSchemaType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiSchemaType Json { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiSchemaType Xml { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiSchemaType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiSchemaType left, Azure.ResourceManager.ApiManagement.Models.ApiSchemaType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiSchemaType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiSchemaType left, Azure.ResourceManager.ApiManagement.Models.ApiSchemaType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiTagDescriptionCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>
    {
        public ApiTagDescriptionCreateOrUpdateContent() { }
        public string Description { get { throw null; } set { } }
        public string ExternalDocsDescription { get { throw null; } set { } }
        public System.Uri ExternalDocsUri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiTagDescriptionCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApiType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ApiType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApiType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiType GraphQL { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiType Http { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiType Soap { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ApiType WebSocket { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ApiType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ApiType left, Azure.ResourceManager.ApiManagement.Models.ApiType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ApiType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ApiType left, Azure.ResourceManager.ApiManagement.Models.ApiType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ApiVersionSetContractDetails : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>
    {
        public ApiVersionSetContractDetails() { }
        public string Description { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string VersionHeaderName { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.VersioningScheme? VersioningScheme { get { throw null; } set { } }
        public string VersionQueryName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ApiVersionSetPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>
    {
        public ApiVersionSetPatch() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string VersionHeaderName { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.VersioningScheme? VersioningScheme { get { throw null; } set { } }
        public string VersionQueryName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ApiVersionSetPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AppType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.AppType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AppType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AppType DeveloperPortal { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.AppType Portal { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.AppType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.AppType left, Azure.ResourceManager.ApiManagement.Models.AppType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.AppType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.AppType left, Azure.ResourceManager.ApiManagement.Models.AppType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmApiManagementModelFactory
    {
        public static Azure.ResourceManager.ApiManagement.Models.AdditionalLocation AdditionalLocation(Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties sku = null, System.Collections.Generic.IEnumerable<string> zones = null, System.Collections.Generic.IEnumerable<System.Net.IPAddress> publicIPAddresses = null, System.Collections.Generic.IEnumerable<System.Net.IPAddress> privateIPAddresses = null, Azure.Core.ResourceIdentifier publicIPAddressId = null, Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration virtualNetworkConfiguration = null, System.Uri gatewayRegionalUri = null, bool? disableGateway = default(bool?), Azure.ResourceManager.ApiManagement.Models.PlatformVersion? platformVersion = default(Azure.ResourceManager.ApiManagement.Models.PlatformVersion?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdateContent ApiCreateOrUpdateContent(string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null, Azure.Core.ResourceIdentifier sourceApiId = null, string displayName = null, System.Uri serviceUri = null, string path = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> protocols = null, Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails apiVersionSet = null, string value = null, Azure.ResourceManager.ApiManagement.Models.ContentFormat? format = default(Azure.ResourceManager.ApiManagement.Models.ContentFormat?), Azure.ResourceManager.ApiManagement.Models.ApiCreateOrUpdatePropertiesWsdlSelector wsdlSelector = null, Azure.ResourceManager.ApiManagement.Models.SoapApiType? soapApiType = default(Azure.ResourceManager.ApiManagement.Models.SoapApiType?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiData ApiData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null, Azure.Core.ResourceIdentifier sourceApiId = null, string displayName = null, System.Uri serviceUri = null, string path = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> protocols = null, Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails apiVersionSet = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract ApiEntityBaseContract(string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiIssueAttachmentData ApiIssueAttachmentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string title = null, string contentFormat = null, string content = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiIssueCommentData ApiIssueCommentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string text = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), Azure.Core.ResourceIdentifier userId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementAuthorizationServerData ApiManagementAuthorizationServerData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.AuthorizationMethod> authorizationMethods = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod> clientAuthenticationMethods = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract> tokenBodyParameters = null, string tokenEndpoint = null, bool? doesSupportState = default(bool?), string defaultScope = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod> bearerTokenSendingMethods = null, string resourceOwnerUsername = null, string resourceOwnerPassword = null, string displayName = null, string clientRegistrationEndpoint = null, string authorizationEndpoint = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.GrantType> grantTypes = null, string clientId = null, string clientSecret = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementAuthorizationServerPatch ApiManagementAuthorizationServerPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.AuthorizationMethod> authorizationMethods = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod> clientAuthenticationMethods = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract> tokenBodyParameters = null, string tokenEndpoint = null, bool? doesSupportState = default(bool?), string defaultScope = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod> bearerTokenSendingMethods = null, string resourceOwnerUsername = null, string resourceOwnerPassword = null, string displayName = null, string clientRegistrationEndpoint = null, string authorizationEndpoint = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.GrantType> grantTypes = null, string clientId = null, string clientSecret = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementBackendData ApiManagementBackendData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string title = null, string description = null, System.Uri resourceUri = null, Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties backendServiceFabricCluster = null, Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract credentials = null, Azure.ResourceManager.ApiManagement.Models.BackendProxyContract proxy = null, Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties tls = null, System.Uri uri = null, Azure.ResourceManager.ApiManagement.Models.BackendProtocol? protocol = default(Azure.ResourceManager.ApiManagement.Models.BackendProtocol?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementCacheData ApiManagementCacheData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, string connectionString = null, string useFromLocation = null, System.Uri resourceUri = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementCertificateData ApiManagementCertificateData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string subject = null, string thumbprint = null, System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties keyVaultDetails = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementDeletedServiceData ApiManagementDeletedServiceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), Azure.Core.ResourceIdentifier serviceId = null, System.DateTimeOffset? scheduledPurgeOn = default(System.DateTimeOffset?), System.DateTimeOffset? deletedOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementEmailTemplateData ApiManagementEmailTemplateData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string subject = null, string body = null, string title = null, string description = null, bool? isDefault = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties> parameters = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGatewayCertificateAuthorityData ApiManagementGatewayCertificateAuthorityData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, bool? isTrusted = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGatewayData ApiManagementGatewayData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract locationData = null, string description = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGatewayHostnameConfigurationData ApiManagementGatewayHostnameConfigurationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string hostname = null, string certificateId = null, bool? isClientCertificateRequired = default(bool?), bool? isTls10Enabled = default(bool?), bool? isTls11Enabled = default(bool?), bool? isHttp20Enabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGlobalSchemaData ApiManagementGlobalSchemaData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.ApiSchemaType? schemaType = default(Azure.ResourceManager.ApiManagement.Models.ApiSchemaType?), string description = null, System.BinaryData value = null, System.BinaryData document = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementGroupData ApiManagementGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string displayName = null, string description = null, bool? isBuiltIn = default(bool?), Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? groupType = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType?), string externalId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupUserData ApiManagementGroupUserData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState? state = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState?), string note = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> identities = null, string firstName = null, string lastName = null, string email = null, System.DateTimeOffset? registriesOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties> groups = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementIdentityProviderCreateOrUpdateContent ApiManagementIdentityProviderCreateOrUpdateContent(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType? identityProviderType = default(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType?), string signInTenant = null, System.Collections.Generic.IEnumerable<string> allowedTenants = null, string authority = null, string signUpPolicyName = null, string signInPolicyName = null, string profileEditingPolicyName = null, string passwordResetPolicyName = null, string clientId = null, string clientSecret = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementIdentityProviderData ApiManagementIdentityProviderData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType? identityProviderType = default(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType?), string signInTenant = null, System.Collections.Generic.IEnumerable<string> allowedTenants = null, string authority = null, string signUpPolicyName = null, string signInPolicyName = null, string profileEditingPolicyName = null, string passwordResetPolicyName = null, string clientId = null, string clientSecret = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementLoggerData ApiManagementLoggerData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.LoggerType? loggerType = default(Azure.ResourceManager.ApiManagement.Models.LoggerType?), string description = null, System.Collections.Generic.IDictionary<string, string> credentials = null, bool? isBuffered = default(bool?), Azure.Core.ResourceIdentifier resourceId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementNamedValueCreateOrUpdateContent ApiManagementNamedValueCreateOrUpdateContent(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<string> tags = null, bool? isSecret = default(bool?), string displayName = null, string value = null, Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties keyVault = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementNamedValueData ApiManagementNamedValueData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<string> tags = null, bool? isSecret = default(bool?), string displayName = null, string value = null, Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties keyVaultDetails = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementNotificationData ApiManagementNotificationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string title = null, string description = null, Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties recipients = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementOpenIdConnectProviderData ApiManagementOpenIdConnectProviderData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string displayName = null, string description = null, string metadataEndpoint = null, string clientId = null, string clientSecret = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalDelegationSettingData ApiManagementPortalDelegationSettingData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Uri uri = null, string validationKey = null, bool? isSubscriptionDelegationEnabled = default(bool?), bool? isUserRegistrationDelegationEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalRevisionData ApiManagementPortalRevisionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, string statusDetails = null, Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus? status = default(Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus?), bool? isCurrent = default(bool?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalSignInSettingData ApiManagementPortalSignInSettingData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, bool? isRedirectEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPortalSignUpSettingData ApiManagementPortalSignUpSettingData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, bool? isSignUpDeveloperPortalEnabled = default(bool?), Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties termsOfService = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPrivateEndpointConnectionData ApiManagementPrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState connectionState = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState? provisioningState = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateEndpointConnectionProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementPrivateLinkResourceData ApiManagementPrivateLinkResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, System.Collections.Generic.IEnumerable<string> requiredZoneNames = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementProductData ApiManagementProductData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, string terms = null, bool? isSubscriptionRequired = default(bool?), bool? isApprovalRequired = default(bool?), int? subscriptionsLimit = default(int?), Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState? state = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState?), string displayName = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity ApiManagementResourceSkuCapacity(int? minimum = default(int?), int? maximum = default(int?), int? @default = default(int?), Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType? scaleType = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacityScaleType?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceBackupRestoreContent ApiManagementServiceBackupRestoreContent(string storageAccount = null, string containerName = null, string backupName = null, Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType? accessType = default(Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType?), string accessKey = null, string clientId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementServiceData ApiManagementServiceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties sku = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IEnumerable<string> zones = null, string notificationSenderEmail = null, string provisioningState = null, string targetProvisioningState = null, System.DateTimeOffset? createdAtUtc = default(System.DateTimeOffset?), System.Uri gatewayUri = null, System.Uri gatewayRegionalUri = null, System.Uri portalUri = null, System.Uri managementApiUri = null, System.Uri scmUri = null, System.Uri developerPortalUri = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration> hostnameConfigurations = null, System.Collections.Generic.IEnumerable<System.Net.IPAddress> publicIPAddresses = null, System.Collections.Generic.IEnumerable<System.Net.IPAddress> privateIPAddresses = null, Azure.Core.ResourceIdentifier publicIPAddressId = null, Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess?), Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration virtualNetworkConfiguration = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation> additionalLocations = null, System.Collections.Generic.IDictionary<string, string> customProperties = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration> certificates = null, bool? enableClientCertificate = default(bool?), bool? disableGateway = default(bool?), Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType? virtualNetworkType = default(Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType?), string minApiVersion = null, bool? restore = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper> privateEndpointConnections = null, Azure.ResourceManager.ApiManagement.Models.PlatformVersion? platformVersion = default(Azure.ResourceManager.ApiManagement.Models.PlatformVersion?), string publisherEmail = null, string publisherName = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetDomainOwnershipIdentifierResult ApiManagementServiceGetDomainOwnershipIdentifierResult(string domainOwnershipIdentifier = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceGetSsoTokenResult ApiManagementServiceGetSsoTokenResult(System.Uri redirectUri = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameAvailabilityResult ApiManagementServiceNameAvailabilityResult(bool? isNameAvailable = default(bool?), string message = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameUnavailableReason? reason = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceNameUnavailableReason?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementServicePatch ApiManagementServicePatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuProperties sku = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ETag? etag = default(Azure.ETag?), System.Collections.Generic.IEnumerable<string> zones = null, string notificationSenderEmail = null, string provisioningState = null, string targetProvisioningState = null, System.DateTimeOffset? createdAtUtc = default(System.DateTimeOffset?), System.Uri gatewayUri = null, System.Uri gatewayRegionalUri = null, System.Uri portalUri = null, System.Uri managementApiUri = null, System.Uri scmUri = null, System.Uri developerPortalUri = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration> hostnameConfigurations = null, System.Collections.Generic.IEnumerable<System.Net.IPAddress> publicIPAddresses = null, System.Collections.Generic.IEnumerable<System.Net.IPAddress> privateIPAddresses = null, Azure.Core.ResourceIdentifier publicIPAddressId = null, Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess?), Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration virtualNetworkConfiguration = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.AdditionalLocation> additionalLocations = null, System.Collections.Generic.IDictionary<string, string> customProperties = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration> certificates = null, bool? enableClientCertificate = default(bool?), bool? disableGateway = default(bool?), Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType? virtualNetworkType = default(Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType?), string minApiVersion = null, bool? restore = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper> privateEndpointConnections = null, Azure.ResourceManager.ApiManagement.Models.PlatformVersion? platformVersion = default(Azure.ResourceManager.ApiManagement.Models.PlatformVersion?), string publisherEmail = null, string publisherName = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSku ApiManagementSku(string resourceType = null, string name = null, string tier = null, string size = null, string family = null, string kind = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity capacity = null, System.Collections.Generic.IEnumerable<Azure.Core.AzureLocation> locations = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo> locationInfo = null, System.Collections.Generic.IEnumerable<string> apiVersions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts> costs = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities> capabilities = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions> restrictions = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities ApiManagementSkuCapabilities(string name = null, string value = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacity ApiManagementSkuCapacity(int? minimum = default(int?), int? maximum = default(int?), int? @default = default(int?), Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacityScaleType? scaleType = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapacityScaleType?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCosts ApiManagementSkuCosts(string meterId = null, long? quantity = default(long?), string extendedUnit = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuLocationInfo ApiManagementSkuLocationInfo(Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), System.Collections.Generic.IEnumerable<string> zones = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails> zoneDetails = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo ApiManagementSkuRestrictionInfo(System.Collections.Generic.IEnumerable<Azure.Core.AzureLocation> locations = null, System.Collections.Generic.IEnumerable<string> zones = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictions ApiManagementSkuRestrictions(Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionsType? restrictionsType = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionsType?), System.Collections.Generic.IEnumerable<string> values = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionInfo restrictionInfo = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionsReasonCode? reasonCode = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuRestrictionsReasonCode?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuZoneDetails ApiManagementSkuZoneDetails(System.Collections.Generic.IEnumerable<string> name = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiManagementSkuCapabilities> capabilities = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiManagementTenantSettingData ApiManagementTenantSettingData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> settings = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiOperationData ApiOperationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ParameterContract> templateParameters = null, string description = null, Azure.ResourceManager.ApiManagement.Models.RequestContract request = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ResponseContract> responses = null, string policies = null, string displayName = null, string method = null, string uriTemplate = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiPatch ApiPatch(string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null, string displayName = null, System.Uri serviceUri = null, string path = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> protocols = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiReleaseData ApiReleaseData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.ResourceIdentifier apiId = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string notes = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ApiRevisionContract ApiRevisionContract(string apiId = null, string apiRevision = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string description = null, string privateUriString = null, bool? isOnline = default(bool?), bool? isCurrent = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiSchemaData ApiSchemaData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string contentType = null, string value = null, System.BinaryData definitions = null, System.BinaryData components = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiTagDescriptionData ApiTagDescriptionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, System.Uri externalDocsUri = null, string externalDocsDescription = null, string tagId = null, string displayName = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.ApiVersionSetData ApiVersionSetData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, string versionQueryName = null, string versionHeaderName = null, string displayName = null, Azure.ResourceManager.ApiManagement.Models.VersioningScheme? versioningScheme = default(Azure.ResourceManager.ApiManagement.Models.VersioningScheme?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties AssociatedApiProperties(string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null, string id = null, string name = null, System.Uri serviceUri = null, string path = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> protocols = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties AssociatedOperationProperties(string id = null, string name = null, string apiName = null, string apiRevision = null, string apiVersion = null, string description = null, string method = null, string uriTemplate = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties AssociatedProductProperties(string description = null, string terms = null, bool? isSubscriptionRequired = default(bool?), bool? isApprovalRequired = default(bool?), int? subscriptionsLimit = default(int?), Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState? state = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState?), string id = null, string name = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties AssociatedTagProperties(string id = null, string name = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AssociationContract AssociationContract(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState? provisioningState = default(Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract AuthorizationServerSecretsContract(string clientSecret = null, string resourceOwnerUsername = null, string resourceOwnerPassword = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult AvailableApiManagementServiceSkuResult(Azure.Core.ResourceType? resourceType = default(Azure.Core.ResourceType?), Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType? skuName = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType?), Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity capacity = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract BackendReconnectContract(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.TimeSpan? after = default(System.TimeSpan?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ClientSecretContract ClientSecretContract(string clientSecret = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent ConnectivityCheckContent(Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource source = null, Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination destination = null, Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion? preferredIPVersion = default(Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion?), Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol? protocol = default(Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol?), Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration protocolHttpConfiguration = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource ConnectivityCheckRequestSource(string region = null, long? instance = default(long?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult ConnectivityCheckResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop> hops = null, Azure.ResourceManager.ApiManagement.Models.ConnectionStatus? connectionStatus = default(Azure.ResourceManager.ApiManagement.Models.ConnectionStatus?), long? avgLatencyInMs = default(long?), long? minLatencyInMs = default(long?), long? maxLatencyInMs = default(long?), long? probesSent = default(long?), long? probesFailed = default(long?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityHop ConnectivityHop(string connectivityHopType = null, string id = null, System.Net.IPAddress address = null, Azure.Core.ResourceIdentifier resourceId = null, System.Collections.Generic.IEnumerable<string> nextHopIds = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue> issues = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue ConnectivityIssue(Azure.ResourceManager.ApiManagement.Models.IssueOrigin? origin = default(Azure.ResourceManager.ApiManagement.Models.IssueOrigin?), Azure.ResourceManager.ApiManagement.Models.IssueSeverity? severity = default(Azure.ResourceManager.ApiManagement.Models.IssueSeverity?), Azure.ResourceManager.ApiManagement.Models.IssueType? issueType = default(Azure.ResourceManager.ApiManagement.Models.IssueType?), System.Collections.Generic.IEnumerable<System.Collections.Generic.IDictionary<string, string>> context = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract ConnectivityStatusContract(string name = null, Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType status = default(Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType), string error = null, System.DateTimeOffset lastUpdatedOn = default(System.DateTimeOffset), System.DateTimeOffset lastStatusChangedOn = default(System.DateTimeOffset), string resourceType = null, bool isOptional = false) { throw null; }
        public static Azure.ResourceManager.ApiManagement.DiagnosticContractData DiagnosticContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.AlwaysLog? alwaysLog = default(Azure.ResourceManager.ApiManagement.Models.AlwaysLog?), string loggerId = null, Azure.ResourceManager.ApiManagement.Models.SamplingSettings sampling = null, Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings frontend = null, Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings backend = null, bool? isLogClientIPEnabled = default(bool?), Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol? httpCorrelationProtocol = default(Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol?), Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel? verbosity = default(Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel?), Azure.ResourceManager.ApiManagement.Models.OperationNameFormat? operationNameFormat = default(Azure.ResourceManager.ApiManagement.Models.OperationNameFormat?), bool? metrics = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.EndpointDependency EndpointDependency(string domainName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.EndpointDetail> endpointDetails = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.EndpointDetail EndpointDetail(int? port = default(int?), string region = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GatewayApiData GatewayApiData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null, Azure.Core.ResourceIdentifier sourceApiId = null, string displayName = null, System.Uri serviceUri = null, string path = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> protocols = null, Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails apiVersionSet = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract GatewayKeysContract(string primary = null, string secondary = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract GatewayTokenContract(string value = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult GenerateSsoUriResult(string value = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData GitOperationResultContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string operationResultIdentifier = null, Azure.ResourceManager.ApiManagement.Models.AsyncOperationStatus? status = default(Azure.ResourceManager.ApiManagement.Models.AsyncOperationStatus?), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string resultInfo = null, Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody error = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract> actionLog = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GroupContractProperties GroupContractProperties(string displayName = null, string description = null, bool? isBuiltIn = default(bool?), Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? apiManagementGroupType = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType?), string externalId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.IssueContractData IssueContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), Azure.ResourceManager.ApiManagement.Models.IssueState? state = default(Azure.ResourceManager.ApiManagement.Models.IssueState?), Azure.Core.ResourceIdentifier apiId = null, string title = null, string description = null, Azure.Core.ResourceIdentifier userId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract NamedValueSecretContract(string value = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract NetworkStatusContract(System.Collections.Generic.IEnumerable<string> dnsServers = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract> connectivityStatus = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation NetworkStatusContractWithLocation(Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract networkStatus = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract OperationResultLogItemContract(string objectType = null, string action = null, string objectKey = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint OutboundEnvironmentEndpoint(string category = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.EndpointDependency> endpoints = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.PolicyContractData PolicyContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string value = null, Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat? format = default(Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData PolicyDescriptionContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, long? scope = default(long?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData PortalSettingsContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Uri uri = null, string validationKey = null, bool? isSubscriptionDelegationEnabled = default(bool?), bool? isUserRegistrationDelegationEnabled = default(bool?), bool? isRedirectEnabled = default(bool?), Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties termsOfService = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract PortalSettingValidationKeyContract(string validationKey = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ProductApiData ProductApiData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract authenticationSettings = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = null, Azure.ResourceManager.ApiManagement.Models.ApiType? apiType = default(Azure.ResourceManager.ApiManagement.Models.ApiType?), string apiRevision = null, string apiVersion = null, bool? isCurrent = default(bool?), bool? isOnline = default(bool?), string apiRevisionDescription = null, string apiVersionDescription = null, Azure.Core.ResourceIdentifier apiVersionSetId = null, bool? isSubscriptionRequired = default(bool?), System.Uri termsOfServiceUri = null, Azure.ResourceManager.ApiManagement.Models.ApiContactInformation contact = null, Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation license = null, Azure.Core.ResourceIdentifier sourceApiId = null, string displayName = null, System.Uri serviceUri = null, string path = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> protocols = null, Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails apiVersionSet = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties ProductEntityBaseProperties(string description = null, string terms = null, bool? isSubscriptionRequired = default(bool?), bool? isApprovalRequired = default(bool?), int? subscriptionsLimit = default(int?), Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState? state = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ProductGroupData ProductGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string displayName = null, string description = null, bool? isBuiltIn = default(bool?), Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? groupType = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType?), string externalId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract QuotaCounterContract(string counterKey = null, string periodKey = null, System.DateTimeOffset periodStartOn = default(System.DateTimeOffset), System.DateTimeOffset periodEndOn = default(System.DateTimeOffset), Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties value = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties QuotaCounterValueContractProperties(int? callsCount = default(int?), double? kbTransferred = default(double?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract RecipientEmailContract(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string email = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.RecipientUserContract RecipientUserContract(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string userId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.RegionContract RegionContract(string name = null, bool? isMasterRegion = default(bool?), bool? isDeleted = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper RemotePrivateEndpointConnectionWrapper(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType? resourceType = default(Azure.Core.ResourceType?), Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, string provisioningState = null, System.Collections.Generic.IEnumerable<string> groupIds = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ReportRecordContract ReportRecordContract(string name = null, System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), string interval = null, string country = null, string region = null, string zip = null, string userId = null, string productId = null, string apiId = null, string operationId = null, string apiRegion = null, Azure.Core.ResourceIdentifier subscriptionResourceId = null, int? callCountSuccess = default(int?), int? callCountBlocked = default(int?), int? callCountFailed = default(int?), int? callCountOther = default(int?), int? callCountTotal = default(int?), long? bandwidth = default(long?), int? cacheHitCount = default(int?), int? cacheMissCount = default(int?), double? apiTimeAvg = default(double?), double? apiTimeMin = default(double?), double? apiTimeMax = default(double?), double? serviceTimeAvg = default(double?), double? serviceTimeMin = default(double?), double? serviceTimeMax = default(double?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract RequestReportRecordContract(string apiId = null, string operationId = null, string productId = null, string userId = null, Azure.Core.RequestMethod? method = default(Azure.Core.RequestMethod?), System.Uri uri = null, System.Net.IPAddress ipAddress = null, string backendResponseCode = null, int? responseCode = default(int?), int? responseSize = default(int?), System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), string cache = null, double? apiTime = default(double?), double? serviceTime = default(double?), string apiRegion = null, Azure.Core.ResourceIdentifier subscriptionResourceId = null, string requestId = null, int? requestSize = default(int?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.SubscriptionContractData SubscriptionContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string ownerId = null, string scope = null, string displayName = null, Azure.ResourceManager.ApiManagement.Models.SubscriptionState? state = default(Azure.ResourceManager.ApiManagement.Models.SubscriptionState?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), System.DateTimeOffset? notifiesOn = default(System.DateTimeOffset?), string primaryKey = null, string secondaryKey = null, string stateComment = null, bool? allowTracing = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract SubscriptionKeysContract(string primaryKey = null, string secondaryKey = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.TagContractData TagContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string displayName = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails TagResourceContractDetails(Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties tag = null, Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties api = null, Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties operation = null, Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties product = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.TenantAccessInfoData TenantAccessInfoData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string accessInfoType = null, string principalId = null, bool? isDirectAccessEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails TenantAccessInfoSecretsDetails(string accessInfoType = null, string principalId = null, string primaryKey = null, string secondaryKey = null, bool? isDirectAccessEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract TenantConfigurationSyncStateContract(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string branch = null, string commitId = null, bool? isExported = default(bool?), bool? isSynced = default(bool?), bool? isGitEnabled = default(bool?), System.DateTimeOffset? syncOn = default(System.DateTimeOffset?), System.DateTimeOffset? configurationChangeOn = default(System.DateTimeOffset?), string lastOperationId = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.UserContractData UserContractData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState? state = default(Azure.ResourceManager.ApiManagement.Models.ApiManagementUserState?), string note = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract> identities = null, string firstName = null, string lastName = null, string email = null, System.DateTimeOffset? registriesOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties> groups = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.UserTokenResult UserTokenResult(string value = null) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration VirtualNetworkConfiguration(System.Guid? vnetId = default(System.Guid?), string subnetname = null, Azure.Core.ResourceIdentifier subnetResourceId = null) { throw null; }
    }
    public partial class AssociatedApiProperties : Azure.ResourceManager.ApiManagement.Models.ApiEntityBaseContract, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>
    {
        internal AssociatedApiProperties() { }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public string Path { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> Protocols { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssociatedOperationProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>
    {
        internal AssociatedOperationProperties() { }
        public string ApiName { get { throw null; } }
        public string ApiRevision { get { throw null; } }
        public string ApiVersion { get { throw null; } }
        public string Description { get { throw null; } }
        public string Id { get { throw null; } }
        public string Method { get { throw null; } }
        public string Name { get { throw null; } }
        public string UriTemplate { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssociatedProductProperties : Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>
    {
        internal AssociatedProductProperties() { }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssociatedTagProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>
    {
        internal AssociatedTagProperties() { }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AssociationContract : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>
    {
        public AssociationContract() { }
        public Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState? ProvisioningState { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.AssociationContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AssociationContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AssociationContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AssociationEntityProvisioningState : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AssociationEntityProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState Created { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState left, Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState left, Azure.ResourceManager.ApiManagement.Models.AssociationEntityProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum AsyncOperationStatus
    {
        Started = 0,
        InProgress = 1,
        Succeeded = 2,
        Failed = 3,
    }
    public partial class AuthenticationSettingsContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>
    {
        public AuthenticationSettingsContract() { }
        public Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract OAuth2 { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract OpenId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum AuthorizationMethod
    {
        Head = 0,
        Options = 1,
        Trace = 2,
        Get = 3,
        Post = 4,
        Put = 5,
        Patch = 6,
        Delete = 7,
    }
    public partial class AuthorizationServerSecretsContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>
    {
        internal AuthorizationServerSecretsContract() { }
        public string ClientSecret { get { throw null; } }
        public string ResourceOwnerPassword { get { throw null; } }
        public string ResourceOwnerUsername { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AuthorizationServerSecretsContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AvailableApiManagementServiceSkuResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>
    {
        internal AvailableApiManagementServiceSkuResult() { }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementResourceSkuCapacity Capacity { get { throw null; } }
        public Azure.Core.ResourceType? ResourceType { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementServiceSkuType? SkuName { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.AvailableApiManagementServiceSkuResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BackendAuthorizationHeaderCredentials : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>
    {
        public BackendAuthorizationHeaderCredentials(string scheme, string parameter) { }
        public string Parameter { get { throw null; } set { } }
        public string Scheme { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BackendCredentialsContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>
    {
        public BackendCredentialsContract() { }
        public Azure.ResourceManager.ApiManagement.Models.BackendAuthorizationHeaderCredentials Authorization { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Certificate { get { throw null; } }
        public System.Collections.Generic.IList<string> CertificateIds { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> Header { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> Query { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendCredentialsContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BackendProtocol : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.BackendProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BackendProtocol(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.BackendProtocol Http { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.BackendProtocol Soap { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.BackendProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.BackendProtocol left, Azure.ResourceManager.ApiManagement.Models.BackendProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.BackendProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.BackendProtocol left, Azure.ResourceManager.ApiManagement.Models.BackendProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BackendProxyContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>
    {
        public BackendProxyContract(System.Uri uri) { }
        public string Password { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.BackendProxyContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.BackendProxyContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendProxyContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BackendReconnectContract : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>
    {
        public BackendReconnectContract() { }
        public System.TimeSpan? After { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendReconnectContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BackendServiceFabricClusterProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>
    {
        public BackendServiceFabricClusterProperties(System.Collections.Generic.IEnumerable<string> managementEndpoints) { }
        public string ClientCertificateId { get { throw null; } set { } }
        public string ClientCertificatethumbprint { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ManagementEndpoints { get { throw null; } }
        public int? MaxPartitionResolutionRetries { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ServerCertificateThumbprints { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.X509CertificateName> ServerX509Names { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendServiceFabricClusterProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BackendTlsProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>
    {
        public BackendTlsProperties() { }
        public bool? ShouldValidateCertificateChain { get { throw null; } set { } }
        public bool? ShouldValidateCertificateName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.BackendTlsProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BearerTokenSendingMethod : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BearerTokenSendingMethod(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod AuthorizationHeader { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod Query { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod left, Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod left, Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CertificateConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>
    {
        public CertificateConfiguration(Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName storeName) { }
        public Azure.ResourceManager.ApiManagement.Models.CertificateInformation Certificate { get { throw null; } set { } }
        public string CertificatePassword { get { throw null; } set { } }
        public string EncodedCertificate { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName StoreName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CertificateConfigurationStoreName : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CertificateConfigurationStoreName(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName CertificateAuthority { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName Root { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName left, Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName left, Azure.ResourceManager.ApiManagement.Models.CertificateConfigurationStoreName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CertificateInformation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>
    {
        public CertificateInformation(System.DateTimeOffset expireOn, string thumbprint, string subject) { }
        public System.DateTimeOffset ExpireOn { get { throw null; } set { } }
        public string Subject { get { throw null; } set { } }
        public string Thumbprint { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.CertificateInformation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.CertificateInformation System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.CertificateInformation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CertificateSource : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.CertificateSource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CertificateSource(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateSource BuiltIn { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateSource Custom { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateSource KeyVault { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateSource Managed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.CertificateSource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.CertificateSource left, Azure.ResourceManager.ApiManagement.Models.CertificateSource right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.CertificateSource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.CertificateSource left, Azure.ResourceManager.ApiManagement.Models.CertificateSource right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CertificateStatus : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.CertificateStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CertificateStatus(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.CertificateStatus InProgress { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.CertificateStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.CertificateStatus left, Azure.ResourceManager.ApiManagement.Models.CertificateStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.CertificateStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.CertificateStatus left, Azure.ResourceManager.ApiManagement.Models.CertificateStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClientAuthenticationMethod : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClientAuthenticationMethod(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod Basic { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod Body { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod left, Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod left, Azure.ResourceManager.ApiManagement.Models.ClientAuthenticationMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ClientSecretContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>
    {
        internal ClientSecretContract() { }
        public string ClientSecret { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ClientSecretContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ClientSecretContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ClientSecretContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConfigurationDeployContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>
    {
        public ConfigurationDeployContent() { }
        public string Branch { get { throw null; } set { } }
        public bool? ForceDelete { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationDeployContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfigurationName : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ConfigurationName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfigurationName(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConfigurationName Configuration { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ConfigurationName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ConfigurationName left, Azure.ResourceManager.ApiManagement.Models.ConfigurationName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ConfigurationName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ConfigurationName left, Azure.ResourceManager.ApiManagement.Models.ConfigurationName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfigurationSaveContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>
    {
        public ConfigurationSaveContent() { }
        public string Branch { get { throw null; } set { } }
        public bool? ForceUpdate { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConfigurationSaveContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfirmationEmailType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfirmationEmailType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType Invite { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType SignUp { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType left, Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType left, Azure.ResourceManager.ApiManagement.Models.ConfirmationEmailType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectionStatus : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectionStatus Connected { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectionStatus Degraded { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectionStatus Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ConnectionStatus left, Azure.ResourceManager.ApiManagement.Models.ConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ConnectionStatus left, Azure.ResourceManager.ApiManagement.Models.ConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConnectivityCheckContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>
    {
        public ConnectivityCheckContent(Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource source, Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination destination) { }
        public Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination Destination { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion? PreferredIPVersion { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol? Protocol { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration ProtocolHttpConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource Source { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectivityCheckProtocol : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectivityCheckProtocol(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol Http { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol Https { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol Tcp { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol left, Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol left, Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConnectivityCheckRequestDestination : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>
    {
        public ConnectivityCheckRequestDestination(string address, long port) { }
        public string Address { get { throw null; } }
        public long Port { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestDestination>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectivityCheckRequestHttpConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>
    {
        public ConnectivityCheckRequestHttpConfiguration() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration> Headers { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration? Method { get { throw null; } set { } }
        public System.Collections.Generic.IList<long> ValidStatusCodes { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestHttpConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectivityCheckRequestSource : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>
    {
        public ConnectivityCheckRequestSource(string region) { }
        public long? Instance { get { throw null; } set { } }
        public string Region { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckRequestSource>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectivityCheckResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>
    {
        internal ConnectivityCheckResult() { }
        public long? AvgLatencyInMs { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ConnectionStatus? ConnectionStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop> Hops { get { throw null; } }
        public long? MaxLatencyInMs { get { throw null; } }
        public long? MinLatencyInMs { get { throw null; } }
        public long? ProbesFailed { get { throw null; } }
        public long? ProbesSent { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityCheckResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectivityHop : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>
    {
        internal ConnectivityHop() { }
        public System.Net.IPAddress Address { get { throw null; } }
        public string ConnectivityHopType { get { throw null; } }
        public string Id { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue> Issues { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> NextHopIds { get { throw null; } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityHop System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityHop System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityHop>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectivityIssue : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>
    {
        internal ConnectivityIssue() { }
        public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IDictionary<string, string>> Context { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.IssueType? IssueType { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.IssueOrigin? Origin { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.IssueSeverity? Severity { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityIssue>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ConnectivityStatusContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>
    {
        internal ConnectivityStatusContract() { }
        public string Error { get { throw null; } }
        public bool IsOptional { get { throw null; } }
        public System.DateTimeOffset LastStatusChangedOn { get { throw null; } }
        public System.DateTimeOffset LastUpdatedOn { get { throw null; } }
        public string Name { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType Status { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConnectivityStatusType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConnectivityStatusType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType Failure { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType Initializing { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType Success { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType left, Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType left, Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContentFormat : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.ContentFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContentFormat(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat GraphQLLink { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat OpenApi { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat OpenApiJson { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat OpenApiJsonLink { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat OpenApiLink { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat SwaggerJson { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat SwaggerLinkJson { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat WadlLinkJson { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat WadlXml { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat Wsdl { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.ContentFormat WsdlLink { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.ContentFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.ContentFormat left, Azure.ResourceManager.ApiManagement.Models.ContentFormat right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.ContentFormat (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.ContentFormat left, Azure.ResourceManager.ApiManagement.Models.ContentFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataMasking : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>
    {
        public DataMasking() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity> Headers { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity> QueryParams { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.DataMasking System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.DataMasking System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMasking>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataMaskingEntity : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>
    {
        public DataMaskingEntity() { }
        public Azure.ResourceManager.ApiManagement.Models.DataMaskingMode? Mode { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.DataMaskingEntity>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataMaskingMode : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.DataMaskingMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataMaskingMode(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.DataMaskingMode Hide { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.DataMaskingMode Mask { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.DataMaskingMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.DataMaskingMode left, Azure.ResourceManager.ApiManagement.Models.DataMaskingMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.DataMaskingMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.DataMaskingMode left, Azure.ResourceManager.ApiManagement.Models.DataMaskingMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EmailTemplateParametersContractProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>
    {
        public EmailTemplateParametersContractProperties() { }
        public string Description { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EmailTemplateParametersContractProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EndpointDependency : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>
    {
        internal EndpointDependency() { }
        public string DomainName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.EndpointDetail> EndpointDetails { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.EndpointDependency System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.EndpointDependency System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDependency>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class EndpointDetail : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>
    {
        internal EndpointDetail() { }
        public int? Port { get { throw null; } }
        public string Region { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.EndpointDetail System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.EndpointDetail System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.EndpointDetail>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorFieldContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>
    {
        public ErrorFieldContract() { }
        public string Code { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public string Target { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ErrorResponseBody : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>
    {
        public ErrorResponseBody() { }
        public string Code { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ErrorFieldContract> Details { get { throw null; } }
        public string Message { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GatewayApiData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>
    {
        public GatewayApiData() { }
        public string ApiRevision { get { throw null; } set { } }
        public string ApiRevisionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiType? ApiType { get { throw null; } set { } }
        public string ApiVersion { get { throw null; } set { } }
        public string ApiVersionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails ApiVersionSet { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ApiVersionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract AuthenticationSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiContactInformation Contact { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsCurrent { get { throw null; } set { } }
        public bool? IsOnline { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation License { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> Protocols { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SourceApiId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get { throw null; } set { } }
        public System.Uri TermsOfServiceUri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.GatewayApiData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GatewayApiData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayApiData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GatewayKeyRegenerateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>
    {
        public GatewayKeyRegenerateContent(Azure.ResourceManager.ApiManagement.Models.GatewayRegenerateKeyType keyType) { }
        public Azure.ResourceManager.ApiManagement.Models.GatewayRegenerateKeyType KeyType { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeyRegenerateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GatewayKeysContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>
    {
        internal GatewayKeysContract() { }
        public string Primary { get { throw null; } }
        public string Secondary { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayKeysContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum GatewayRegenerateKeyType
    {
        Primary = 0,
        Secondary = 1,
    }
    public partial class GatewayTokenContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>
    {
        internal GatewayTokenContract() { }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GatewayTokenRequestContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>
    {
        public GatewayTokenRequestContract(Azure.ResourceManager.ApiManagement.Models.TokenGenerationUsedKeyType keyType, System.DateTimeOffset expiry) { }
        public System.DateTimeOffset Expiry { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.TokenGenerationUsedKeyType KeyType { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GatewayTokenRequestContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GenerateSsoUriResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>
    {
        internal GenerateSsoUriResult() { }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GenerateSsoUriResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GitOperationResultContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>
    {
        public GitOperationResultContractData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract> ActionLog { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ErrorResponseBody Error { get { throw null; } set { } }
        public string OperationResultIdentifier { get { throw null; } set { } }
        public string ResultInfo { get { throw null; } set { } }
        public System.DateTimeOffset? StartedOn { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.AsyncOperationStatus? Status { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GitOperationResultContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GrantType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.GrantType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GrantType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.GrantType AuthorizationCode { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.GrantType ClientCredentials { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.GrantType Implicit { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.GrantType ResourceOwnerPassword { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.GrantType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.GrantType left, Azure.ResourceManager.ApiManagement.Models.GrantType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.GrantType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.GrantType left, Azure.ResourceManager.ApiManagement.Models.GrantType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GroupContractProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>
    {
        internal GroupContractProperties() { }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? ApiManagementGroupType { get { throw null; } }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string ExternalId { get { throw null; } }
        public bool? IsBuiltIn { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.GroupContractProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.GroupContractProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.GroupContractProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HostnameConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>
    {
        public HostnameConfiguration(Azure.ResourceManager.ApiManagement.Models.HostnameType hostnameType, string hostName) { }
        public Azure.ResourceManager.ApiManagement.Models.CertificateInformation Certificate { get { throw null; } set { } }
        public string CertificatePassword { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.CertificateSource? CertificateSource { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.CertificateStatus? CertificateStatus { get { throw null; } set { } }
        public string EncodedCertificate { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.HostnameType HostnameType { get { throw null; } set { } }
        public string IdentityClientId { get { throw null; } set { } }
        public bool? IsClientCertificateNegotiationEnabled { get { throw null; } set { } }
        public bool? IsDefaultSslBindingEnabled { get { throw null; } set { } }
        public System.Uri KeyVaultSecretUri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HostnameConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HostnameType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.HostnameType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HostnameType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.HostnameType DeveloperPortal { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HostnameType Management { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HostnameType Portal { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HostnameType Proxy { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HostnameType Scm { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.HostnameType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.HostnameType left, Azure.ResourceManager.ApiManagement.Models.HostnameType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.HostnameType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.HostnameType left, Azure.ResourceManager.ApiManagement.Models.HostnameType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HttpCorrelationProtocol : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HttpCorrelationProtocol(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol Legacy { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol None { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol W3C { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol left, Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol left, Azure.ResourceManager.ApiManagement.Models.HttpCorrelationProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HttpHeaderConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>
    {
        public HttpHeaderConfiguration(string name, string value) { }
        public string Name { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpHeaderConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HttpMessageDiagnostic : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>
    {
        public HttpMessageDiagnostic() { }
        public int? BodyBytes { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.DataMasking DataMasking { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Headers { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HttpMethodConfiguration : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HttpMethodConfiguration(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration Get { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration Post { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration left, Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration left, Azure.ResourceManager.ApiManagement.Models.HttpMethodConfiguration right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IdentityProviderType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.IdentityProviderType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IdentityProviderType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.IdentityProviderType Aad { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IdentityProviderType AadB2C { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IdentityProviderType Facebook { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IdentityProviderType Google { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IdentityProviderType Microsoft { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IdentityProviderType Twitter { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType left, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.IdentityProviderType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.IdentityProviderType left, Azure.ResourceManager.ApiManagement.Models.IdentityProviderType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IssueOrigin : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.IssueOrigin>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IssueOrigin(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.IssueOrigin Inbound { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueOrigin Local { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueOrigin Outbound { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.IssueOrigin other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.IssueOrigin left, Azure.ResourceManager.ApiManagement.Models.IssueOrigin right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.IssueOrigin (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.IssueOrigin left, Azure.ResourceManager.ApiManagement.Models.IssueOrigin right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IssueSeverity : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.IssueSeverity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IssueSeverity(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.IssueSeverity Error { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueSeverity Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.IssueSeverity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.IssueSeverity left, Azure.ResourceManager.ApiManagement.Models.IssueSeverity right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.IssueSeverity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.IssueSeverity left, Azure.ResourceManager.ApiManagement.Models.IssueSeverity right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IssueState : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.IssueState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IssueState(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.IssueState Closed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueState Open { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueState Proposed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueState Removed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueState Resolved { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.IssueState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.IssueState left, Azure.ResourceManager.ApiManagement.Models.IssueState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.IssueState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.IssueState left, Azure.ResourceManager.ApiManagement.Models.IssueState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IssueType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.IssueType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IssueType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType AgentStopped { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType DnsResolution { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType GuestFirewall { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType NetworkSecurityRule { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType Platform { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType PortThrottled { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType SocketBind { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType Unknown { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.IssueType UserDefinedRoute { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.IssueType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.IssueType left, Azure.ResourceManager.ApiManagement.Models.IssueType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.IssueType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.IssueType left, Azure.ResourceManager.ApiManagement.Models.IssueType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KeyVaultContractCreateProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>
    {
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public KeyVaultContractCreateProperties() { }
        public string IdentityClientId { get { throw null; } set { } }
        public string SecretIdentifier { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultContractProperties : Azure.ResourceManager.ApiManagement.Models.KeyVaultContractCreateProperties, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>
    {
        public KeyVaultContractProperties() { }
        public Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties LastStatus { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultContractProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KeyVaultLastAccessStatusContractProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>
    {
        public KeyVaultLastAccessStatusContractProperties() { }
        public string Code { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public System.DateTimeOffset? TimeStampUtc { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.KeyVaultLastAccessStatusContractProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LoggerType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.LoggerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LoggerType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.LoggerType ApplicationInsights { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.LoggerType AzureEventHub { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.LoggerType AzureMonitor { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.LoggerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.LoggerType left, Azure.ResourceManager.ApiManagement.Models.LoggerType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.LoggerType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.LoggerType left, Azure.ResourceManager.ApiManagement.Models.LoggerType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NamedValueSecretContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>
    {
        internal NamedValueSecretContract() { }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NamedValueSecretContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkStatusContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>
    {
        internal NetworkStatusContract() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.ConnectivityStatusContract> ConnectivityStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> DnsServers { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NetworkStatusContractWithLocation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>
    {
        internal NetworkStatusContractWithLocation() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.NetworkStatusContract NetworkStatus { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.NetworkStatusContractWithLocation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NotificationName : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.NotificationName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NotificationName(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName AccountClosedPublisher { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName Bcc { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName NewApplicationNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName NewIssuePublisherNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName PurchasePublisherNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName QuotaLimitApproachingPublisherNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.NotificationName RequestPublisherNotificationMessage { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.NotificationName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.NotificationName left, Azure.ResourceManager.ApiManagement.Models.NotificationName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.NotificationName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.NotificationName left, Azure.ResourceManager.ApiManagement.Models.NotificationName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OAuth2AuthenticationSettingsContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>
    {
        public OAuth2AuthenticationSettingsContract() { }
        public string AuthorizationServerId { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OAuth2AuthenticationSettingsContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OpenIdAuthenticationSettingsContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>
    {
        public OpenIdAuthenticationSettingsContract() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.BearerTokenSendingMethod> BearerTokenSendingMethods { get { throw null; } }
        public string OpenIdProviderId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OpenIdAuthenticationSettingsContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OperationNameFormat : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.OperationNameFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OperationNameFormat(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.OperationNameFormat Name { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.OperationNameFormat Uri { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.OperationNameFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.OperationNameFormat left, Azure.ResourceManager.ApiManagement.Models.OperationNameFormat right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.OperationNameFormat (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.OperationNameFormat left, Azure.ResourceManager.ApiManagement.Models.OperationNameFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OperationResultLogItemContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>
    {
        internal OperationResultLogItemContract() { }
        public string Action { get { throw null; } }
        public string ObjectKey { get { throw null; } }
        public string ObjectType { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OperationResultLogItemContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OutboundEnvironmentEndpoint : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>
    {
        internal OutboundEnvironmentEndpoint() { }
        public string Category { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ApiManagement.Models.EndpointDependency> Endpoints { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.OutboundEnvironmentEndpoint>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ParameterContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>
    {
        public ParameterContract(string name, string parameterContractType) { }
        public string DefaultValue { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract> Examples { get { throw null; } }
        public bool? IsRequired { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ParameterContractType { get { throw null; } set { } }
        public string SchemaId { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Values { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ParameterContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ParameterContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ParameterExampleContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>
    {
        public ParameterExampleContract() { }
        public string Description { get { throw null; } set { } }
        public string ExternalValue { get { throw null; } set { } }
        public string Summary { get { throw null; } set { } }
        public System.BinaryData Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PipelineDiagnosticSettings : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>
    {
        public PipelineDiagnosticSettings() { }
        public Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic Request { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.HttpMessageDiagnostic Response { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PipelineDiagnosticSettings>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PlatformVersion : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PlatformVersion>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PlatformVersion(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PlatformVersion Mtv1 { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PlatformVersion Stv1 { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PlatformVersion Stv2 { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PlatformVersion Undetermined { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PlatformVersion other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PlatformVersion left, Azure.ResourceManager.ApiManagement.Models.PlatformVersion right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PlatformVersion (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PlatformVersion left, Azure.ResourceManager.ApiManagement.Models.PlatformVersion right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyContentFormat : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyContentFormat(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat RawXml { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat RawXmlLink { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat Xml { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat XmlLink { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat left, Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat left, Azure.ResourceManager.ApiManagement.Models.PolicyContentFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PolicyDescriptionContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>
    {
        public PolicyDescriptionContractData() { }
        public string Description { get { throw null; } }
        public long? Scope { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PolicyDescriptionContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyExportFormat : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyExportFormat(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat RawXml { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat Xml { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat left, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat left, Azure.ResourceManager.ApiManagement.Models.PolicyExportFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyName : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PolicyName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyName(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PolicyName Policy { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PolicyName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PolicyName left, Azure.ResourceManager.ApiManagement.Models.PolicyName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PolicyName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PolicyName left, Azure.ResourceManager.ApiManagement.Models.PolicyName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum PolicyScopeContract
    {
        Tenant = 0,
        Product = 1,
        Api = 2,
        Operation = 3,
        All = 4,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PortalRevisionStatus : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PortalRevisionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus Publishing { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus left, Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus left, Azure.ResourceManager.ApiManagement.Models.PortalRevisionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PortalSettingsContractData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>
    {
        public PortalSettingsContractData() { }
        public bool? IsRedirectEnabled { get { throw null; } set { } }
        public bool? IsSubscriptionDelegationEnabled { get { throw null; } set { } }
        public bool? IsUserRegistrationDelegationEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties TermsOfService { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        public string ValidationKey { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingsContractData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PortalSettingValidationKeyContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>
    {
        internal PortalSettingValidationKeyContract() { }
        public string ValidationKey { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.PortalSettingValidationKeyContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PreferredIPVersion : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PreferredIPVersion(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion IPv4 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion left, Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion left, Azure.ResourceManager.ApiManagement.Models.PreferredIPVersion right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProductApiData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>
    {
        public ProductApiData() { }
        public string ApiRevision { get { throw null; } set { } }
        public string ApiRevisionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiType? ApiType { get { throw null; } set { } }
        public string ApiVersion { get { throw null; } set { } }
        public string ApiVersionDescription { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiVersionSetContractDetails ApiVersionSet { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ApiVersionSetId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.AuthenticationSettingsContract AuthenticationSettings { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiContactInformation Contact { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsCurrent { get { throw null; } set { } }
        public bool? IsOnline { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiLicenseInformation License { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ApiOperationInvokableProtocol> Protocols { get { throw null; } }
        public System.Uri ServiceUri { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SourceApiId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get { throw null; } set { } }
        public System.Uri TermsOfServiceUri { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ProductApiData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ProductApiData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductApiData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProductEntityBaseProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>
    {
        internal ProductEntityBaseProperties() { }
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public string Description { get { throw null; } }
        public bool? IsApprovalRequired { get { throw null; } }
        public bool? IsSubscriptionRequired { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementProductState? State { get { throw null; } }
        public int? SubscriptionsLimit { get { throw null; } }
        public string Terms { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductEntityBaseProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProductGroupData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>
    {
        public ProductGroupData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ExternalId { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementGroupType? GroupType { get { throw null; } set { } }
        public bool? IsBuiltIn { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ProductGroupData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ProductGroupData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ProductGroupData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublicNetworkAccess : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess left, Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess left, Azure.ResourceManager.ApiManagement.Models.PublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class QuotaCounterContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>
    {
        internal QuotaCounterContract() { }
        public string CounterKey { get { throw null; } }
        public System.DateTimeOffset PeriodEndOn { get { throw null; } }
        public string PeriodKey { get { throw null; } }
        public System.DateTimeOffset PeriodStartOn { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class QuotaCounterValueContractProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>
    {
        internal QuotaCounterValueContractProperties() { }
        public int? CallsCount { get { throw null; } }
        public double? KbTransferred { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueContractProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class QuotaCounterValueUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>
    {
        public QuotaCounterValueUpdateContent() { }
        public int? CallsCount { get { throw null; } set { } }
        public double? KbTransferred { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.QuotaCounterValueUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecipientEmailContract : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>
    {
        public RecipientEmailContract() { }
        public string Email { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientEmailContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecipientsContractProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>
    {
        public RecipientsContractProperties() { }
        public System.Collections.Generic.IList<string> Emails { get { throw null; } }
        public System.Collections.Generic.IList<string> Users { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientsContractProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecipientUserContract : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>
    {
        public RecipientUserContract() { }
        public string UserId { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.RecipientUserContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RecipientUserContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RecipientUserContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RegionContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>
    {
        internal RegionContract() { }
        public bool? IsDeleted { get { throw null; } }
        public bool? IsMasterRegion { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.RegionContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RegionContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RegionContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RemotePrivateEndpointConnectionWrapper : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>
    {
        public RemotePrivateEndpointConnectionWrapper() { }
        public System.Collections.Generic.IReadOnlyList<string> GroupIds { get { throw null; } }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.ApiManagementPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceType? ResourceType { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RemotePrivateEndpointConnectionWrapper>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReportRecordContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>
    {
        internal ReportRecordContract() { }
        public string ApiId { get { throw null; } }
        public string ApiRegion { get { throw null; } }
        public double? ApiTimeAvg { get { throw null; } }
        public double? ApiTimeMax { get { throw null; } }
        public double? ApiTimeMin { get { throw null; } }
        public long? Bandwidth { get { throw null; } }
        public int? CacheHitCount { get { throw null; } }
        public int? CacheMissCount { get { throw null; } }
        public int? CallCountBlocked { get { throw null; } }
        public int? CallCountFailed { get { throw null; } }
        public int? CallCountOther { get { throw null; } }
        public int? CallCountSuccess { get { throw null; } }
        public int? CallCountTotal { get { throw null; } }
        public string Country { get { throw null; } }
        public string Interval { get { throw null; } }
        public string Name { get { throw null; } }
        public string OperationId { get { throw null; } }
        public string ProductId { get { throw null; } }
        public string Region { get { throw null; } }
        public double? ServiceTimeAvg { get { throw null; } }
        public double? ServiceTimeMax { get { throw null; } }
        public double? ServiceTimeMin { get { throw null; } }
        public Azure.Core.ResourceIdentifier SubscriptionResourceId { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        public string UserId { get { throw null; } }
        public string Zip { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.ReportRecordContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ReportRecordContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ReportRecordContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RepresentationContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>
    {
        public RepresentationContract(string contentType) { }
        public string ContentType { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.ApiManagement.Models.ParameterExampleContract> Examples { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ParameterContract> FormParameters { get { throw null; } }
        public string SchemaId { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.RepresentationContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RepresentationContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RepresentationContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RequestContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>
    {
        public RequestContract() { }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ParameterContract> Headers { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ParameterContract> QueryParameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.RepresentationContract> Representations { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.RequestContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RequestContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RequestReportRecordContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>
    {
        internal RequestReportRecordContract() { }
        public string ApiId { get { throw null; } }
        public string ApiRegion { get { throw null; } }
        public double? ApiTime { get { throw null; } }
        public string BackendResponseCode { get { throw null; } }
        public string Cache { get { throw null; } }
        public System.Net.IPAddress IPAddress { get { throw null; } }
        public Azure.Core.RequestMethod? Method { get { throw null; } }
        public string OperationId { get { throw null; } }
        public string ProductId { get { throw null; } }
        public string RequestId { get { throw null; } }
        public int? RequestSize { get { throw null; } }
        public int? ResponseCode { get { throw null; } }
        public int? ResponseSize { get { throw null; } }
        public double? ServiceTime { get { throw null; } }
        public Azure.Core.ResourceIdentifier SubscriptionResourceId { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        public string UserId { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.RequestReportRecordContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceLocationDataContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>
    {
        public ResourceLocationDataContract(string name) { }
        public string City { get { throw null; } set { } }
        public string CountryOrRegion { get { throw null; } set { } }
        public string District { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResourceLocationDataContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResponseContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>
    {
        public ResponseContract(int statusCode) { }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.ParameterContract> Headers { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ApiManagement.Models.RepresentationContract> Representations { get { throw null; } }
        public int StatusCode { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.ResponseContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.ResponseContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.ResponseContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SamplingSettings : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>
    {
        public SamplingSettings() { }
        public double? Percentage { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.SamplingType? SamplingType { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.SamplingSettings System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.SamplingSettings System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SamplingSettings>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SamplingType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.SamplingType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SamplingType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.SamplingType Fixed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.SamplingType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.SamplingType left, Azure.ResourceManager.ApiManagement.Models.SamplingType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.SamplingType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.SamplingType left, Azure.ResourceManager.ApiManagement.Models.SamplingType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SettingsType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.SettingsType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SettingsType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.SettingsType Public { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.SettingsType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.SettingsType left, Azure.ResourceManager.ApiManagement.Models.SettingsType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.SettingsType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.SettingsType left, Azure.ResourceManager.ApiManagement.Models.SettingsType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SoapApiType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.SoapApiType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SoapApiType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.SoapApiType GraphQL { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.SoapApiType SoapPassThrough { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.SoapApiType SoapToRest { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.SoapApiType WebSocket { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.SoapApiType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.SoapApiType left, Azure.ResourceManager.ApiManagement.Models.SoapApiType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.SoapApiType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.SoapApiType left, Azure.ResourceManager.ApiManagement.Models.SoapApiType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StorageAccountAccessType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StorageAccountAccessType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType AccessKey { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType SystemAssignedManagedIdentity { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType UserAssignedManagedIdentity { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType left, Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType left, Azure.ResourceManager.ApiManagement.Models.StorageAccountAccessType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SubscriptionKeyParameterNamesContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>
    {
        public SubscriptionKeyParameterNamesContract() { }
        public string Header { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeyParameterNamesContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionKeysContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>
    {
        internal SubscriptionKeysContract() { }
        public string PrimaryKey { get { throw null; } }
        public string SecondaryKey { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.SubscriptionKeysContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum SubscriptionState
    {
        Suspended = 0,
        Active = 1,
        Expired = 2,
        Submitted = 3,
        Rejected = 4,
        Cancelled = 5,
    }
    public partial class TagResourceContractDetails : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>
    {
        internal TagResourceContractDetails() { }
        public Azure.ResourceManager.ApiManagement.Models.AssociatedApiProperties Api { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.AssociatedOperationProperties Operation { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.AssociatedProductProperties Product { get { throw null; } }
        public Azure.ResourceManager.ApiManagement.Models.AssociatedTagProperties Tag { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TagResourceContractDetails>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TemplateName : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.TemplateName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TemplateName(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName AccountClosedDeveloper { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName ApplicationApprovedNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName ConfirmSignUpIdentityDefault { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName EmailChangeIdentityDefault { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName InviteUserNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName NewCommentNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName NewDeveloperNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName NewIssueNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName PasswordResetByAdminNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName PasswordResetIdentityDefault { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName PurchaseDeveloperNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName QuotaLimitApproachingDeveloperNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName RejectDeveloperNotificationMessage { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TemplateName RequestDeveloperNotificationMessage { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.TemplateName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.TemplateName left, Azure.ResourceManager.ApiManagement.Models.TemplateName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.TemplateName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.TemplateName left, Azure.ResourceManager.ApiManagement.Models.TemplateName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TenantAccessInfoCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>
    {
        public TenantAccessInfoCreateOrUpdateContent() { }
        public bool? IsDirectAccessEnabled { get { throw null; } set { } }
        public string PrimaryKey { get { throw null; } set { } }
        public string PrincipalId { get { throw null; } set { } }
        public string SecondaryKey { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantAccessInfoPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>
    {
        public TenantAccessInfoPatch() { }
        public bool? IsDirectAccessEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantAccessInfoSecretsDetails : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>
    {
        internal TenantAccessInfoSecretsDetails() { }
        public string AccessInfoType { get { throw null; } }
        public bool? IsDirectAccessEnabled { get { throw null; } }
        public string PrimaryKey { get { throw null; } }
        public string PrincipalId { get { throw null; } }
        public string SecondaryKey { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantAccessInfoSecretsDetails>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantConfigurationSyncStateContract : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>
    {
        public TenantConfigurationSyncStateContract() { }
        public string Branch { get { throw null; } set { } }
        public string CommitId { get { throw null; } set { } }
        public System.DateTimeOffset? ConfigurationChangeOn { get { throw null; } set { } }
        public bool? IsExported { get { throw null; } set { } }
        public bool? IsGitEnabled { get { throw null; } set { } }
        public bool? IsSynced { get { throw null; } set { } }
        public string LastOperationId { get { throw null; } set { } }
        public System.DateTimeOffset? SyncOn { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TenantConfigurationSyncStateContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TermsOfServiceProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>
    {
        public TermsOfServiceProperties() { }
        public bool? IsConsentRequired { get { throw null; } set { } }
        public bool? IsDisplayEnabled { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TermsOfServiceProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TokenBodyParameterContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>
    {
        public TokenBodyParameterContract(string name, string value) { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.TokenBodyParameterContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum TokenGenerationUsedKeyType
    {
        Primary = 0,
        Secondary = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TraceVerbosityLevel : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TraceVerbosityLevel(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel Error { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel Information { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel Verbose { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel left, Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel left, Azure.ResourceManager.ApiManagement.Models.TraceVerbosityLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UserIdentityContract : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>
    {
        public UserIdentityContract() { }
        public string Id { get { throw null; } set { } }
        public string Provider { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.UserIdentityContract System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.UserIdentityContract System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserIdentityContract>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserTokenContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>
    {
        public UserTokenContent() { }
        public System.DateTimeOffset? ExpireOn { get { throw null; } set { } }
        public Azure.ResourceManager.ApiManagement.Models.TokenGenerationUsedKeyType? KeyType { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.UserTokenContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.UserTokenContent System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class UserTokenResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>
    {
        internal UserTokenResult() { }
        public string Value { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.UserTokenResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.UserTokenResult System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.UserTokenResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VersioningScheme : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.VersioningScheme>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VersioningScheme(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.VersioningScheme Header { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.VersioningScheme Query { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.VersioningScheme Segment { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.VersioningScheme other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.VersioningScheme left, Azure.ResourceManager.ApiManagement.Models.VersioningScheme right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.VersioningScheme (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.VersioningScheme left, Azure.ResourceManager.ApiManagement.Models.VersioningScheme right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VirtualNetworkConfiguration : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>
    {
        public VirtualNetworkConfiguration() { }
        public string Subnetname { get { throw null; } }
        public Azure.Core.ResourceIdentifier SubnetResourceId { get { throw null; } set { } }
        public System.Guid? VnetId { get { throw null; } }
        Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkConfiguration>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VirtualNetworkType : System.IEquatable<Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VirtualNetworkType(string value) { throw null; }
        public static Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType External { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType Internal { get { throw null; } }
        public static Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType left, Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType left, Azure.ResourceManager.ApiManagement.Models.VirtualNetworkType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class X509CertificateName : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>, System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>
    {
        public X509CertificateName() { }
        public string IssuerCertificateThumbprint { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.ApiManagement.Models.X509CertificateName System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ApiManagement.Models.X509CertificateName System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.ResourceManager.ApiManagement.Models.X509CertificateName>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
