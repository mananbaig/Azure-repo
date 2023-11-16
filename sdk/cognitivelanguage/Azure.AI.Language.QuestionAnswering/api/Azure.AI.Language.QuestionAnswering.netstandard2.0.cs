namespace Azure.AI.Language.QuestionAnswering
{
    public partial class AnswersFromTextOptions : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>
    {
        public AnswersFromTextOptions(string question, System.Collections.Generic.IEnumerable<Azure.AI.Language.QuestionAnswering.TextDocument> textDocuments) { }
        public string Language { get { throw null; } set { } }
        public string Question { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.Language.QuestionAnswering.TextDocument> TextDocuments { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnswersFromTextResult : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>
    {
        internal AnswersFromTextResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.QuestionAnswering.TextAnswer> Answers { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.AnswersFromTextResult System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.AnswersFromTextResult System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnswersOptions : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>
    {
        public AnswersOptions() { }
        public Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext AnswerContext { get { throw null; } set { } }
        public double? ConfidenceThreshold { get { throw null; } set { } }
        public Azure.AI.Language.QuestionAnswering.QueryFilters Filters { get { throw null; } set { } }
        public bool? IncludeUnstructuredSources { get { throw null; } set { } }
        public Azure.AI.Language.QuestionAnswering.RankerKind? RankerKind { get { throw null; } set { } }
        public Azure.AI.Language.QuestionAnswering.ShortAnswerOptions ShortAnswerOptions { get { throw null; } set { } }
        public int? Size { get { throw null; } set { } }
        public string UserId { get { throw null; } set { } }
        Azure.AI.Language.QuestionAnswering.AnswersOptions System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.AnswersOptions System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersOptions>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnswerSpan : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>
    {
        internal AnswerSpan() { }
        public double? Confidence { get { throw null; } }
        public int? Length { get { throw null; } }
        public int? Offset { get { throw null; } }
        public string Text { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.AnswerSpan System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.AnswerSpan System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswerSpan>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AnswersResult : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersResult>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersResult>
    {
        internal AnswersResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer> Answers { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.AnswersResult System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.AnswersResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.AnswersResult System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersResult>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.AnswersResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KnowledgeBaseAnswer : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>
    {
        internal KnowledgeBaseAnswer() { }
        public string Answer { get { throw null; } }
        public double? Confidence { get { throw null; } }
        public Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog Dialog { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Metadata { get { throw null; } }
        public int? QnaId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Questions { get { throw null; } }
        public Azure.AI.Language.QuestionAnswering.AnswerSpan ShortAnswer { get { throw null; } }
        public string Source { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KnowledgeBaseAnswerContext : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>
    {
        public KnowledgeBaseAnswerContext(int previousQnaId) { }
        public int PreviousQnaId { get { throw null; } }
        public string PreviousQuestion { get { throw null; } set { } }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KnowledgeBaseAnswerDialog : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>
    {
        internal KnowledgeBaseAnswerDialog() { }
        public bool? IsContextOnly { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt> Prompts { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class KnowledgeBaseAnswerPrompt : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>
    {
        internal KnowledgeBaseAnswerPrompt() { }
        public int? DisplayOrder { get { throw null; } }
        public string DisplayText { get { throw null; } }
        public int? QnaId { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LogicalOperationKind : System.IEquatable<Azure.AI.Language.QuestionAnswering.LogicalOperationKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LogicalOperationKind(string value) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.LogicalOperationKind And { get { throw null; } }
        public static Azure.AI.Language.QuestionAnswering.LogicalOperationKind Or { get { throw null; } }
        public bool Equals(Azure.AI.Language.QuestionAnswering.LogicalOperationKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.QuestionAnswering.LogicalOperationKind left, Azure.AI.Language.QuestionAnswering.LogicalOperationKind right) { throw null; }
        public static implicit operator Azure.AI.Language.QuestionAnswering.LogicalOperationKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.QuestionAnswering.LogicalOperationKind left, Azure.AI.Language.QuestionAnswering.LogicalOperationKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetadataFilter : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>
    {
        public MetadataFilter() { }
        public Azure.AI.Language.QuestionAnswering.LogicalOperationKind? LogicalOperation { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.Language.QuestionAnswering.MetadataRecord> Metadata { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.MetadataFilter System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.MetadataFilter System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataFilter>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MetadataRecord : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>
    {
        public MetadataRecord(string key, string value) { }
        public string Key { get { throw null; } }
        public string Value { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.MetadataRecord System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.MetadataRecord System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.MetadataRecord>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class QueryFilters : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.QueryFilters>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.QueryFilters>
    {
        public QueryFilters() { }
        public Azure.AI.Language.QuestionAnswering.LogicalOperationKind? LogicalOperation { get { throw null; } set { } }
        public Azure.AI.Language.QuestionAnswering.MetadataFilter MetadataFilter { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> SourceFilter { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.QueryFilters System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.QueryFilters>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.QueryFilters>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.QueryFilters System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.QueryFilters>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.QueryFilters>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.QueryFilters>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct QuestionAnsweringAudience : System.IEquatable<Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public QuestionAnsweringAudience(string value) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience AzureChina { get { throw null; } }
        public static Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience AzureGovernment { get { throw null; } }
        public static Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience AzurePublicCloud { get { throw null; } }
        public bool Equals(Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience left, Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience right) { throw null; }
        public static implicit operator Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience left, Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class QuestionAnsweringClient
    {
        protected QuestionAnsweringClient() { }
        public QuestionAnsweringClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public QuestionAnsweringClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions options) { }
        public QuestionAnsweringClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public QuestionAnsweringClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions options) { }
        public virtual System.Uri Endpoint { get { throw null; } }
        public virtual Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersResult> GetAnswers(int qnaId, Azure.AI.Language.QuestionAnswering.QuestionAnsweringProject project, Azure.AI.Language.QuestionAnswering.AnswersOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersResult> GetAnswers(string question, Azure.AI.Language.QuestionAnswering.QuestionAnsweringProject project, Azure.AI.Language.QuestionAnswering.AnswersOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersResult>> GetAnswersAsync(int qnaId, Azure.AI.Language.QuestionAnswering.QuestionAnsweringProject project, Azure.AI.Language.QuestionAnswering.AnswersOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersResult>> GetAnswersAsync(string question, Azure.AI.Language.QuestionAnswering.QuestionAnsweringProject project, Azure.AI.Language.QuestionAnswering.AnswersOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult> GetAnswersFromText(Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult> GetAnswersFromText(string question, System.Collections.Generic.IEnumerable<Azure.AI.Language.QuestionAnswering.TextDocument> textDocuments, string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult> GetAnswersFromText(string question, System.Collections.Generic.IEnumerable<string> textDocuments, string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>> GetAnswersFromTextAsync(Azure.AI.Language.QuestionAnswering.AnswersFromTextOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>> GetAnswersFromTextAsync(string question, System.Collections.Generic.IEnumerable<Azure.AI.Language.QuestionAnswering.TextDocument> textDocuments, string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.Language.QuestionAnswering.AnswersFromTextResult>> GetAnswersFromTextAsync(string question, System.Collections.Generic.IEnumerable<string> textDocuments, string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class QuestionAnsweringClientOptions : Azure.Core.ClientOptions
    {
        public QuestionAnsweringClientOptions(Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions.ServiceVersion version = Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions.ServiceVersion.V2021_10_01) { }
        public Azure.AI.Language.QuestionAnswering.QuestionAnsweringAudience? Audience { get { throw null; } set { } }
        public string DefaultLanguage { get { throw null; } set { } }
        public enum ServiceVersion
        {
            V2021_10_01 = 1,
        }
    }
    public static partial class QuestionAnsweringModelFactory
    {
        public static Azure.AI.Language.QuestionAnswering.AnswersFromTextResult AnswersFromTextResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.QuestionAnswering.TextAnswer> answers = null) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.AnswerSpan AnswerSpan(string text = null, double? confidence = default(double?), int? offset = default(int?), int? length = default(int?)) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.AnswersResult AnswersResult(System.Collections.Generic.IEnumerable<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer> answers = null) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswer KnowledgeBaseAnswer(System.Collections.Generic.IEnumerable<string> questions = null, string answer = null, double? confidence = default(double?), int? qnaId = default(int?), string source = null, System.Collections.Generic.IReadOnlyDictionary<string, string> metadata = null, Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog dialog = null, Azure.AI.Language.QuestionAnswering.AnswerSpan shortAnswer = null) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerContext KnowledgeBaseAnswerContext(int previousQnaId = 0, string previousQuestion = null) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerDialog KnowledgeBaseAnswerDialog(bool? isContextOnly = default(bool?), System.Collections.Generic.IEnumerable<Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt> prompts = null) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.KnowledgeBaseAnswerPrompt KnowledgeBaseAnswerPrompt(int? displayOrder = default(int?), int? qnaId = default(int?), string displayText = null) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.TextAnswer TextAnswer(string answer = null, double? confidence = default(double?), string id = null, Azure.AI.Language.QuestionAnswering.AnswerSpan shortAnswer = null, int? offset = default(int?), int? length = default(int?)) { throw null; }
    }
    public partial class QuestionAnsweringProject
    {
        public QuestionAnsweringProject(string projectName, string deploymentName) { }
        public string DeploymentName { get { throw null; } }
        public string ProjectName { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RankerKind : System.IEquatable<Azure.AI.Language.QuestionAnswering.RankerKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RankerKind(string value) { throw null; }
        public static Azure.AI.Language.QuestionAnswering.RankerKind Default { get { throw null; } }
        public static Azure.AI.Language.QuestionAnswering.RankerKind QuestionOnly { get { throw null; } }
        public bool Equals(Azure.AI.Language.QuestionAnswering.RankerKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.Language.QuestionAnswering.RankerKind left, Azure.AI.Language.QuestionAnswering.RankerKind right) { throw null; }
        public static implicit operator Azure.AI.Language.QuestionAnswering.RankerKind (string value) { throw null; }
        public static bool operator !=(Azure.AI.Language.QuestionAnswering.RankerKind left, Azure.AI.Language.QuestionAnswering.RankerKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ShortAnswerOptions : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>
    {
        public ShortAnswerOptions() { }
        public double? ConfidenceThreshold { get { throw null; } set { } }
        public int? Size { get { throw null; } set { } }
        Azure.AI.Language.QuestionAnswering.ShortAnswerOptions System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.ShortAnswerOptions System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.ShortAnswerOptions>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TextAnswer : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.TextAnswer>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextAnswer>
    {
        internal TextAnswer() { }
        public string Answer { get { throw null; } }
        public double? Confidence { get { throw null; } }
        public string Id { get { throw null; } }
        public int? Length { get { throw null; } }
        public int? Offset { get { throw null; } }
        public Azure.AI.Language.QuestionAnswering.AnswerSpan ShortAnswer { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.TextAnswer System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.TextAnswer>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.TextAnswer>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.TextAnswer System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextAnswer>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextAnswer>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextAnswer>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TextDocument : System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.TextDocument>, System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextDocument>
    {
        public TextDocument(string id, string text) { }
        public string Id { get { throw null; } }
        public string Text { get { throw null; } }
        Azure.AI.Language.QuestionAnswering.TextDocument System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.TextDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.AI.Language.QuestionAnswering.TextDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        Azure.AI.Language.QuestionAnswering.TextDocument System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextDocument>.Create(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextDocument>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IPersistableModel<Azure.AI.Language.QuestionAnswering.TextDocument>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.AI.Language.QuestionAnswering.Authoring
{
    public partial class QuestionAnsweringAuthoringClient
    {
        protected QuestionAnsweringAuthoringClient() { }
        public QuestionAnsweringAuthoringClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public QuestionAnsweringAuthoringClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions options) { }
        public QuestionAnsweringAuthoringClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public QuestionAnsweringAuthoringClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response AddFeedback(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> AddFeedbackAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateProject(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateProjectAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation DeleteProject(Azure.WaitUntil waitUntil, string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation> DeleteProjectAsync(Azure.WaitUntil waitUntil, string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> DeployProject(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> DeployProjectAsync(Azure.WaitUntil waitUntil, string projectName, string deploymentName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> Export(Azure.WaitUntil waitUntil, string projectName, string format = null, string assetKind = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> ExportAsync(Azure.WaitUntil waitUntil, string projectName, string format = null, string assetKind = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetDeleteStatus(string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeleteStatusAsync(string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetDeployments(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetDeploymentsAsync(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetDeployStatus(string projectName, string deploymentName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDeployStatusAsync(string projectName, string deploymentName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetExportStatus(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetExportStatusAsync(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetImportStatus(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetImportStatusAsync(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetProjectDetails(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetProjectDetailsAsync(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetProjects(Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetProjectsAsync(Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetQnas(string projectName, string source = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetQnasAsync(string projectName, string source = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetSources(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetSourcesAsync(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Pageable<System.BinaryData> GetSynonyms(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.AsyncPageable<System.BinaryData> GetSynonymsAsync(string projectName, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetUpdateQnasStatus(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetUpdateQnasStatusAsync(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetUpdateSourcesStatus(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetUpdateSourcesStatusAsync(string projectName, string jobId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<System.BinaryData> Import(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, string format = null, string assetKind = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<System.BinaryData>> ImportAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, string format = null, string assetKind = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.Pageable<System.BinaryData>> UpdateQnas(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AsyncPageable<System.BinaryData>>> UpdateQnasAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Operation<Azure.Pageable<System.BinaryData>> UpdateSources(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Operation<Azure.AsyncPageable<System.BinaryData>>> UpdateSourcesAsync(Azure.WaitUntil waitUntil, string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response UpdateSynonyms(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateSynonymsAsync(string projectName, Azure.Core.RequestContent content, Azure.RequestContext context = null) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class QuestionAnsweringClientExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.QuestionAnswering.Authoring.QuestionAnsweringAuthoringClient, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions> AddQuestionAnsweringAuthoringClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.QuestionAnswering.Authoring.QuestionAnsweringAuthoringClient, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions> AddQuestionAnsweringAuthoringClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.QuestionAnswering.QuestionAnsweringClient, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions> AddQuestionAnsweringClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.AI.Language.QuestionAnswering.QuestionAnsweringClient, Azure.AI.Language.QuestionAnswering.QuestionAnsweringClientOptions> AddQuestionAnsweringClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
