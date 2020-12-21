namespace Azure.Communication.Chat
{
    public partial class AddChatParticipantsErrors
    {
        internal AddChatParticipantsErrors() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.Chat.ChatError> InvalidParticipants { get { throw null; } }
    }
    public partial class AddChatParticipantsResult
    {
        internal AddChatParticipantsResult() { }
        public Azure.Communication.Chat.AddChatParticipantsErrors Errors { get { throw null; } }
    }
    public partial class ChatClient
    {
        protected ChatClient() { }
        public ChatClient(System.Uri endpointUrl, Azure.Communication.Identity.CommunicationUserCredential communicationUserCredential, Azure.Communication.Chat.ChatClientOptions? options = null) { }
        public virtual Azure.Response<Azure.Communication.Chat.CreateChatThreadResult> CreateChatThread(string topic, System.Collections.Generic.IEnumerable<Azure.Communication.Chat.ChatParticipant> participants, string repeatabilityRequestId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.Chat.CreateChatThreadResult>> CreateChatThreadAsync(string topic, System.Collections.Generic.IEnumerable<Azure.Communication.Chat.ChatParticipant> participants, string repeatabilityRequestId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteChatThread(string threadId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteChatThreadAsync(string threadId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.Chat.ChatThread> GetChatThread(string threadId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.Chat.ChatThread>> GetChatThreadAsync(string threadId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.Chat.ChatThreadClient GetChatThreadClient(string threadId) { throw null; }
        public virtual Azure.Pageable<Azure.Communication.Chat.ChatThreadInfo> GetChatThreadsInfo(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Communication.Chat.ChatThreadInfo> GetChatThreadsInfoAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ChatClientOptions : Azure.Core.ClientOptions
    {
        public const Azure.Communication.Chat.ChatClientOptions.ServiceVersion LatestVersion = Azure.Communication.Chat.ChatClientOptions.ServiceVersion.V1;
        public ChatClientOptions(Azure.Communication.Chat.ChatClientOptions.ServiceVersion version = Azure.Communication.Chat.ChatClientOptions.ServiceVersion.V1) { }
        public enum ServiceVersion
        {
            V1 = 1,
        }
    }
    public partial class ChatError
    {
        internal ChatError() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.Chat.ChatError> InnerErrors { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
    }
    public partial class ChatMessage
    {
        internal ChatMessage() { }
        public string Content { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public System.DateTimeOffset? DeletedOn { get { throw null; } }
        public System.DateTimeOffset? EditedOn { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.Communication.Chat.ChatMessagePriority? Priority { get { throw null; } }
        public Azure.Communication.CommunicationUser Sender { get { throw null; } }
        public string SenderDisplayName { get { throw null; } }
        public string Type { get { throw null; } }
        public string Version { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ChatMessagePriority : System.IEquatable<Azure.Communication.Chat.ChatMessagePriority>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ChatMessagePriority(string value) { throw null; }
        public static Azure.Communication.Chat.ChatMessagePriority High { get { throw null; } }
        public static Azure.Communication.Chat.ChatMessagePriority Normal { get { throw null; } }
        public bool Equals(Azure.Communication.Chat.ChatMessagePriority other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.Chat.ChatMessagePriority left, Azure.Communication.Chat.ChatMessagePriority right) { throw null; }
        public static implicit operator Azure.Communication.Chat.ChatMessagePriority (string value) { throw null; }
        public static bool operator !=(Azure.Communication.Chat.ChatMessagePriority left, Azure.Communication.Chat.ChatMessagePriority right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ChatMessageReadReceipt
    {
        internal ChatMessageReadReceipt() { }
        public string ChatMessageId { get { throw null; } }
        public System.DateTimeOffset? ReadOn { get { throw null; } }
        public Azure.Communication.CommunicationUser Sender { get { throw null; } }
    }
    public static partial class ChatModelFactory
    {
        public static Azure.Communication.Chat.ChatMessage ChatMessage(string id, string type, Azure.Communication.Chat.ChatMessagePriority? priority, string version, string content, string senderDisplayName, System.DateTimeOffset? createdOn, string senderId, System.DateTimeOffset? deletedOn, System.DateTimeOffset? editedOn) { throw null; }
        public static Azure.Communication.Chat.ChatMessageReadReceipt ChatMessageReadReceipt(string senderId, string chatMessageId, System.DateTimeOffset? readOn) { throw null; }
        public static Azure.Communication.Chat.ChatThreadInfo ChatThreadInfo(string id, string topic, System.DateTimeOffset? deletedOn, System.DateTimeOffset? lastMessageReceivedOn) { throw null; }
    }
    public partial class ChatParticipant
    {
        public ChatParticipant(Azure.Communication.CommunicationUser communicationUser) { }
        public string? DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? ShareHistoryTime { get { throw null; } set { } }
        public Azure.Communication.CommunicationUser User { get { throw null; } set { } }
    }
    public partial class ChatThread
    {
        internal ChatThread() { }
        public string CreatedBy { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public System.DateTimeOffset? DeletedOn { get { throw null; } }
        public string Id { get { throw null; } }
        public string Topic { get { throw null; } }
    }
    public partial class ChatThreadClient
    {
        protected ChatThreadClient() { }
        public virtual string Id { get { throw null; } }
        public virtual Azure.Response<Azure.Communication.Chat.AddChatParticipantsResult> AddParticipant(Azure.Communication.Chat.ChatParticipant participant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.Chat.AddChatParticipantsResult>> AddParticipantAsync(Azure.Communication.Chat.ChatParticipant participant, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.Chat.AddChatParticipantsResult> AddParticipants(System.Collections.Generic.IEnumerable<Azure.Communication.Chat.ChatParticipant> participants, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.Chat.AddChatParticipantsResult>> AddParticipantsAsync(System.Collections.Generic.IEnumerable<Azure.Communication.Chat.ChatParticipant> participants, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteMessage(string messageId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteMessageAsync(string messageId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.Chat.ChatMessage> GetMessage(string messageId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.Chat.ChatMessage>> GetMessageAsync(string messageId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Communication.Chat.ChatMessage> GetMessages(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Communication.Chat.ChatMessage> GetMessagesAsync(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Communication.Chat.ChatParticipant> GetParticipants(int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Communication.Chat.ChatParticipant> GetParticipantsAsync(int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.Communication.Chat.ChatMessageReadReceipt> GetReadReceipts(int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Communication.Chat.ChatMessageReadReceipt> GetReadReceiptsAsync(int? skip = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RemoveParticipant(Azure.Communication.CommunicationUser user, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RemoveParticipantAsync(Azure.Communication.CommunicationUser user, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<string> SendMessage(string content, Azure.Communication.Chat.ChatMessagePriority? priority = default(Azure.Communication.Chat.ChatMessagePriority?), string senderDisplayName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<string>> SendMessageAsync(string content, Azure.Communication.Chat.ChatMessagePriority? priority = default(Azure.Communication.Chat.ChatMessagePriority?), string senderDisplayName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SendReadReceipt(string messageId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SendReadReceiptAsync(string messageId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SendTypingNotification(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SendTypingNotificationAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateMessage(string messageId, string content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateMessageAsync(string messageId, string content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateTopic(string topic, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateTopicAsync(string topic, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ChatThreadInfo
    {
        internal ChatThreadInfo() { }
        public System.DateTimeOffset? DeletedOn { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset? LastMessageReceivedOn { get { throw null; } }
        public string Topic { get { throw null; } }
    }
    public partial class CreateChatThreadErrors
    {
        internal CreateChatThreadErrors() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.Chat.ChatError> InvalidParticipants { get { throw null; } }
    }
    public partial class CreateChatThreadResult
    {
        internal CreateChatThreadResult() { }
        public Azure.Communication.Chat.ChatThread ChatThread { get { throw null; } }
        public Azure.Communication.Chat.CreateChatThreadErrors Errors { get { throw null; } }
    }
}
