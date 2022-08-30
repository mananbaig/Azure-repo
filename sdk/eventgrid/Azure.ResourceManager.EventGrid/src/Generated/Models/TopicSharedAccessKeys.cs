// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Shared access keys of the Topic. </summary>
    public partial class TopicSharedAccessKeys
    {
        /// <summary> Initializes a new instance of TopicSharedAccessKeys. </summary>
        internal TopicSharedAccessKeys()
        {
        }

        /// <summary> Initializes a new instance of TopicSharedAccessKeys. </summary>
        /// <param name="key1"> Shared access key1 for the topic. </param>
        /// <param name="key2"> Shared access key2 for the topic. </param>
        internal TopicSharedAccessKeys(string key1, string key2)
        {
            Key1 = key1;
            Key2 = key2;
        }

        /// <summary> Shared access key1 for the topic. </summary>
        public string Key1 { get; }
        /// <summary> Shared access key2 for the topic. </summary>
        public string Key2 { get; }
    }
}
