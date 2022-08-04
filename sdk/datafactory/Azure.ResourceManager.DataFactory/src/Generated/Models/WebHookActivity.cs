// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> WebHook activity. </summary>
    public partial class WebHookActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of WebHookActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="uri"> WebHook activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="uri"/> is null. </exception>
        public WebHookActivity(string name, WebHookActivityMethod method, BinaryData uri) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Method = method;
            Uri = uri;
            ActivityType = "WebHook";
        }

        /// <summary> Initializes a new instance of WebHookActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="uri"> WebHook activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <param name="timeout"> The timeout within which the webhook should be called back. If there is no value specified, it defaults to 10 minutes. Type: string. Pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="headers"> Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string). </param>
        /// <param name="body"> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Authentication method used for calling the endpoint. </param>
        /// <param name="reportStatusOnCallBack"> When set to true, statusCode, output and error in callback request body will be consumed by activity. The activity can be marked as failed by setting statusCode &gt;= 400 in callback request. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        internal WebHookActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, WebHookActivityMethod method, BinaryData uri, string timeout, BinaryData headers, BinaryData body, WebActivityAuthentication authentication, BinaryData reportStatusOnCallBack) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            Method = method;
            Uri = uri;
            Timeout = timeout;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            ReportStatusOnCallBack = reportStatusOnCallBack;
            ActivityType = activityType ?? "WebHook";
        }

        /// <summary> Rest API method for target endpoint. </summary>
        public WebHookActivityMethod Method { get; set; }
        /// <summary> WebHook activity target endpoint and path. Type: string (or Expression with resultType string). </summary>
        public BinaryData Uri { get; set; }
        /// <summary> The timeout within which the webhook should be called back. If there is no value specified, it defaults to 10 minutes. Type: string. Pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public string Timeout { get; set; }
        /// <summary> Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string). </summary>
        public BinaryData Headers { get; set; }
        /// <summary> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </summary>
        public BinaryData Body { get; set; }
        /// <summary> Authentication method used for calling the endpoint. </summary>
        public WebActivityAuthentication Authentication { get; set; }
        /// <summary> When set to true, statusCode, output and error in callback request body will be consumed by activity. The activity can be marked as failed by setting statusCode &gt;= 400 in callback request. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public BinaryData ReportStatusOnCallBack { get; set; }
    }
}
