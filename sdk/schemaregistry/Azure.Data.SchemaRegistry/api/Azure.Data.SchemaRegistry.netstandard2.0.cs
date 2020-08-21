namespace Azure.Data.SchemaRegistry
{
    public partial class SchemaProperties
    {
        internal SchemaProperties() { }
        public string Content { get { throw null; } }
        public string Id { get { throw null; } }
        public int? Version { get { throw null; } }
    }
    public partial class SchemaRegistryClient
    {
        protected SchemaRegistryClient() { }
        public SchemaRegistryClient(string endpoint, Azure.Core.TokenCredential credential) { }
        public SchemaRegistryClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Data.SchemaRegistry.SchemaRegistryClientOptions options) { }
        public virtual Azure.Response<Azure.Data.SchemaRegistry.SchemaProperties> GetSchema(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Data.SchemaRegistry.SchemaProperties>> GetSchemaAsync(string schemaId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Data.SchemaRegistry.SchemaProperties> GetSchemaId(string groupName, string schemaName, string schemaContent, Azure.Data.SchemaRegistry.Models.SerializationType? serializationType = default(Azure.Data.SchemaRegistry.Models.SerializationType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Data.SchemaRegistry.SchemaProperties>> GetSchemaIdAsync(string groupName, string schemaName, string schemaContent, Azure.Data.SchemaRegistry.Models.SerializationType? serializationType = default(Azure.Data.SchemaRegistry.Models.SerializationType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Data.SchemaRegistry.SchemaProperties> RegisterSchema(string groupName, string schemaName, string schemaContent, Azure.Data.SchemaRegistry.Models.SerializationType? serializationType = default(Azure.Data.SchemaRegistry.Models.SerializationType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Data.SchemaRegistry.SchemaProperties>> RegisterSchemaAsync(string groupName, string schemaName, string schemaContent, Azure.Data.SchemaRegistry.Models.SerializationType? serializationType = default(Azure.Data.SchemaRegistry.Models.SerializationType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SchemaRegistryClientOptions : Azure.Core.ClientOptions
    {
        public SchemaRegistryClientOptions(Azure.Data.SchemaRegistry.SchemaRegistryClientOptions.ServiceVersion version = Azure.Data.SchemaRegistry.SchemaRegistryClientOptions.ServiceVersion.V1_0) { }
        public enum ServiceVersion
        {
            V1_0 = 1,
        }
    }
}
namespace Azure.Data.SchemaRegistry.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SerializationType : System.IEquatable<Azure.Data.SchemaRegistry.Models.SerializationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SerializationType(string value) { throw null; }
        public static Azure.Data.SchemaRegistry.Models.SerializationType Avro { get { throw null; } }
        public bool Equals(Azure.Data.SchemaRegistry.Models.SerializationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Data.SchemaRegistry.Models.SerializationType left, Azure.Data.SchemaRegistry.Models.SerializationType right) { throw null; }
        public static implicit operator Azure.Data.SchemaRegistry.Models.SerializationType (string value) { throw null; }
        public static bool operator !=(Azure.Data.SchemaRegistry.Models.SerializationType left, Azure.Data.SchemaRegistry.Models.SerializationType right) { throw null; }
        public override string ToString() { throw null; }
    }
}
