// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> HDInsight Hive activity type. </summary>
    public partial class HDInsightHiveActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightHiveActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HDInsightHiveActivity(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            StorageLinkedServices = new ChangeTrackingList<FactoryLinkedServiceReference>();
            Arguments = new ChangeTrackingList<BinaryData>();
            Defines = new ChangeTrackingDictionary<string, BinaryData>();
            Variables = new ChangeTrackingList<BinaryData>();
            ActivityType = "HDInsightHive";
        }

        /// <summary> Initializes a new instance of HDInsightHiveActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="scriptPath"> Script path. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <param name="defines"> Allows user to specify defines for Hive job request. </param>
        /// <param name="variables"> User specified arguments under hivevar namespace. </param>
        /// <param name="queryTimeout"> Query timeout value (in minutes).  Effective when the HDInsight cluster is with ESP (Enterprise Security Package). </param>
        internal HDInsightHiveActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, IList<FactoryLinkedServiceReference> storageLinkedServices, IList<BinaryData> arguments, HDInsightActivityDebugInfoOptionSetting? getDebugInfo, BinaryData scriptPath, FactoryLinkedServiceReference scriptLinkedService, IDictionary<string, BinaryData> defines, IList<BinaryData> variables, int? queryTimeout) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Defines = defines;
            Variables = variables;
            QueryTimeout = queryTimeout;
            ActivityType = activityType ?? "HDInsightHive";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<FactoryLinkedServiceReference> StorageLinkedServices { get; }
        /// <summary> User specified arguments to HDInsightActivity. </summary>
        public IList<BinaryData> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOptionSetting? GetDebugInfo { get; set; }
        /// <summary>
        /// Script path. Type: string (or Expression with resultType string).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ScriptPath { get; set; }
        /// <summary> Script linked service reference. </summary>
        public FactoryLinkedServiceReference ScriptLinkedService { get; set; }
        /// <summary> Allows user to specify defines for Hive job request. </summary>
        public IDictionary<string, BinaryData> Defines { get; }
        /// <summary> User specified arguments under hivevar namespace. </summary>
        public IList<BinaryData> Variables { get; }
        /// <summary> Query timeout value (in minutes).  Effective when the HDInsight cluster is with ESP (Enterprise Security Package). </summary>
        public int? QueryTimeout { get; set; }
    }
}
