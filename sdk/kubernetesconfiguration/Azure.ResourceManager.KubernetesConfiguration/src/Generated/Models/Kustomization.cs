// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The Kustomization defining how to reconcile the artifact pulled by the source type on the cluster. </summary>
    public partial class Kustomization
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Kustomization"/>. </summary>
        public Kustomization()
        {
            DependsOn = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="Kustomization"/>. </summary>
        /// <param name="name"> Name of the Kustomization, matching the key in the Kustomizations object map. </param>
        /// <param name="path"> The path in the source reference to reconcile on the cluster. </param>
        /// <param name="dependsOn"> Specifies other Kustomizations that this Kustomization depends on. This Kustomization will not reconcile until all dependencies have completed their reconciliation. </param>
        /// <param name="timeoutInSeconds"> The maximum time to attempt to reconcile the Kustomization on the cluster. </param>
        /// <param name="syncIntervalInSeconds"> The interval at which to re-reconcile the Kustomization on the cluster. </param>
        /// <param name="retryIntervalInSeconds"> The interval at which to re-reconcile the Kustomization on the cluster in the event of failure on reconciliation. </param>
        /// <param name="prune"> Enable/disable garbage collections of Kubernetes objects created by this Kustomization. </param>
        /// <param name="force"> Enable/disable re-creating Kubernetes resources on the cluster when patching fails due to an immutable field change. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Kustomization(string name, string path, IList<string> dependsOn, long? timeoutInSeconds, long? syncIntervalInSeconds, long? retryIntervalInSeconds, bool? prune, bool? force, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Path = path;
            DependsOn = dependsOn;
            TimeoutInSeconds = timeoutInSeconds;
            SyncIntervalInSeconds = syncIntervalInSeconds;
            RetryIntervalInSeconds = retryIntervalInSeconds;
            Prune = prune;
            Force = force;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the Kustomization, matching the key in the Kustomizations object map. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The path in the source reference to reconcile on the cluster. </summary>
        [WirePath("path")]
        public string Path { get; set; }
        /// <summary> Specifies other Kustomizations that this Kustomization depends on. This Kustomization will not reconcile until all dependencies have completed their reconciliation. </summary>
        [WirePath("dependsOn")]
        public IList<string> DependsOn { get; set; }
        /// <summary> The maximum time to attempt to reconcile the Kustomization on the cluster. </summary>
        [WirePath("timeoutInSeconds")]
        public long? TimeoutInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the Kustomization on the cluster. </summary>
        [WirePath("syncIntervalInSeconds")]
        public long? SyncIntervalInSeconds { get; set; }
        /// <summary> The interval at which to re-reconcile the Kustomization on the cluster in the event of failure on reconciliation. </summary>
        [WirePath("retryIntervalInSeconds")]
        public long? RetryIntervalInSeconds { get; set; }
        /// <summary> Enable/disable garbage collections of Kubernetes objects created by this Kustomization. </summary>
        [WirePath("prune")]
        public bool? Prune { get; set; }
        /// <summary> Enable/disable re-creating Kubernetes resources on the cluster when patching fails due to an immutable field change. </summary>
        [WirePath("force")]
        public bool? Force { get; set; }
    }
}
