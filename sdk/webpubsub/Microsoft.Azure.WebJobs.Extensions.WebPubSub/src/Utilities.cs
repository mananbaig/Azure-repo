﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using Microsoft.Azure.WebPubSub.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using SystemJson = System.Text.Json;

namespace Microsoft.Azure.WebJobs.Extensions.WebPubSub
{
    internal static class Utilities
    {
        public static MediaTypeHeaderValue GetMediaType(WebPubSubDataType dataType) => new(GetContentType(dataType));

        public static string GetContentType(WebPubSubDataType dataType) =>
            dataType switch
            {
                WebPubSubDataType.Text => Constants.ContentTypes.PlainTextContentType,
                WebPubSubDataType.Json => Constants.ContentTypes.JsonContentType,
                // Default set binary type to align with service side logic
                _ => Constants.ContentTypes.BinaryContentType
            };

        public static WebPubSubDataType GetDataType(string mediaType) =>
            mediaType.ToLowerInvariant() switch
            {
                Constants.ContentTypes.BinaryContentType => WebPubSubDataType.Binary,
                Constants.ContentTypes.JsonContentType => WebPubSubDataType.Json,
                Constants.ContentTypes.PlainTextContentType => WebPubSubDataType.Text,
                _ => throw new ArgumentException($"{Constants.ErrorMessages.NotSupportedDataType}{mediaType}")
            };

        public static WebPubSubEventType GetEventType(string ceType)
        {
            return ceType.StartsWith(Constants.Headers.CloudEvents.TypeSystemPrefix, StringComparison.OrdinalIgnoreCase) ?
                WebPubSubEventType.System :
                WebPubSubEventType.User;
        }

        public static HttpResponseMessage BuildUserEventResponse(UserEventResponse response, Dictionary<string, object> mergedStates)
        {
            HttpResponseMessage result = new();

            if (response.Data != null)
            {
                result.Content = new StreamContent(response.Data.ToStream());
            }

            if (mergedStates?.Count > 0)
            {
                result.Headers.Add(Constants.Headers.CloudEvents.State, mergedStates.EncodeConnectionStates());
            }
            result.Content.Headers.ContentType = GetMediaType(response.DataType);

            return result;
        }

        public static HttpResponseMessage BuildConnectEventResponse(string response, Dictionary<string, object> mergedStates, WebPubSubDataType dataType = WebPubSubDataType.Json)
        {
            HttpResponseMessage result = new();
            if (mergedStates?.Count > 0)
            {
                result.Headers.Add(Constants.Headers.CloudEvents.State, mergedStates.EncodeConnectionStates());
            }

            result.Content = new StringContent(response);
            result.Content.Headers.ContentType = GetMediaType(dataType);

            return result;
        }

        public static HttpResponseMessage BuildErrorResponse(EventErrorResponse error)
        {
            HttpResponseMessage result = new();

            result.StatusCode = GetStatusCode(error.Code);
            result.Content = new StringContent(error.ErrorMessage);
            return result;
        }

        public static HttpResponseMessage BuildValidResponse(
            object response, RequestType requestType,
            WebPubSubConnectionContext context)
        {
            JObject jResponse = null;
            string originStr = null;
            bool needConvert = true;
            if (response is WebPubSubEventResponse)
            {
                needConvert = false;
            }
            else
            {
                // JObject or string type, use string to convert between NewtonsoftJson and SystemTextJson.
                originStr = response.ToString();
                jResponse = response is JObject jObj ? jObj : JObject.Parse(originStr);
            }

            try
            {
                // Check error, errorCode is required for json convert, otherwise, ignored.
                if (needConvert && jResponse.TryGetValue("code", out var code))
                {
                    var error = SystemJson.JsonSerializer.Deserialize<EventErrorResponse>(originStr);
                    return BuildErrorResponse(error);
                }
                else if (response is EventErrorResponse errorResponse)
                {
                    return BuildErrorResponse(errorResponse);
                }

                if (requestType == RequestType.Connect)
                {
                    if (needConvert)
                    {
                        var states = GetStatesFromJson(jResponse);
                        var mergedStates = context.UpdateStates(states);
                        return BuildConnectEventResponse(originStr, mergedStates);
                    }
                    else if (response is ConnectEventResponse connectResponse)
                    {
                        var mergedStates = context.UpdateStates(connectResponse.States);
                        return BuildConnectEventResponse(SystemJson.JsonSerializer.Serialize(response), mergedStates);
                    }
                }
                if (requestType == RequestType.User)
                {
                    if (needConvert)
                    {
                        var states = GetStatesFromJson(jResponse);
                        var mergedStates = context.UpdateStates(states);
                        return BuildUserEventResponse(SystemJson.JsonSerializer.Deserialize<UserEventResponse>(originStr), mergedStates);
                    }
                    else if (response is UserEventResponse messageResponse)
                    {
                        var mergedStates = context.UpdateStates(messageResponse.States);
                        return BuildUserEventResponse(messageResponse, mergedStates);
                    }
                }
            }
            catch (Exception)
            {
                // Ignore invalid response.
            }

            return null;
        }

        public static HttpStatusCode GetStatusCode(WebPubSubErrorCode errorCode) =>
            errorCode switch
            {
                WebPubSubErrorCode.UserError => HttpStatusCode.BadRequest,
                WebPubSubErrorCode.Unauthorized => HttpStatusCode.Unauthorized,
                WebPubSubErrorCode.ServerError => HttpStatusCode.InternalServerError,
                _ => HttpStatusCode.InternalServerError
            };

        public static PropertyInfo GetProperty(Type type, string name)
        {
            return type.GetProperty(name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        }

        public static string FirstOrDefault(params string[] values)
        {
            return values.FirstOrDefault(v => !string.IsNullOrEmpty(v));
        }

        public static RequestType GetRequestType(WebPubSubEventType eventType, string eventName)
        {
            if (eventType == WebPubSubEventType.User)
            {
                return RequestType.User;
            }
            if (eventName.Equals(Constants.Events.ConnectEvent, StringComparison.OrdinalIgnoreCase))
            {
                return RequestType.Connect;
            }
            if (eventName.Equals(Constants.Events.DisconnectedEvent, StringComparison.OrdinalIgnoreCase))
            {
                return RequestType.Disconnected;
            }
            if (eventName.Equals(Constants.Events.ConnectedEvent, StringComparison.OrdinalIgnoreCase))
            {
                return RequestType.Connected;
            }
            return RequestType.Ignored;
        }

        public static bool ValidateMediaType(string mediaType, out WebPubSubDataType dataType)
        {
            try
            {
                dataType = GetDataType(mediaType);
                return true;
            }
            catch (Exception)
            {
                dataType = WebPubSubDataType.Binary;
                return false;
            }
        }

        public static bool IsValidationRequest(this HttpRequestMessage req, out List<string> requestHosts)
        {
            if (req.Method == HttpMethod.Options || req.Method == HttpMethod.Get)
            {
                requestHosts = req.Headers.GetValues(Constants.Headers.WebHookRequestOrigin).ToList();
                return true;
            }
            requestHosts = null;
            return false;
        }

        private static Dictionary<string, object> GetStatesFromJson(JObject response)
        {
            var states = new Dictionary<string, object>();
            if (response.TryGetValue("states", out var val))
            {
                // val should be a JSON object of <key,value> pairs
                if (val.Type == JTokenType.Object)
                {
                    var strongType = JsonConvert.DeserializeObject<IReadOnlyDictionary<string, BinaryData>>(val.ToString());
                    foreach (var item in strongType)
                    {
                        states.Add(item.Key, item.Value);
                    }
                }
            }
            // We don't support clear states for JS
            return states;
        }
    }
}
