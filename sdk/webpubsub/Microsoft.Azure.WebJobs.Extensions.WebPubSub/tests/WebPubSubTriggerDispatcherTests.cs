﻿using Microsoft.Azure.WebJobs.Host.Executors;
using Moq;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Azure.WebJobs.Extensions.WebPubSub.Tests
{
    public class WebPubSubTriggerDispatcherTests
    {
        private static (string ConnectionId, string AccessKey, string Signature) TestKey = 
            ("0f9c97a2f0bf4706afe87a14e0797b11", "7aab239577fd4f24bc919802fb629f5f", "sha256=7767effcb3946f3e1de039df4b986ef02c110b1469d02c0a06f41b3b727ab561");
        private const string TestHub = "testhub";
        private const WebPubSubEventType TestType = WebPubSubEventType.System;
        private const string TestEvent = Constants.Events.ConnectedEvent;

        private static HashSet<string> EmptySetting = new HashSet<string>();
        private static HashSet<string> ValidAccessKeys = new HashSet<string>(new string[] { TestKey.AccessKey });
        private static string[] ValidSignature = new string[] { TestKey.Signature };

        [Fact]
        public async Task TestProcessRequest_ValidRequest()
        {
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, TestKey.ConnectionId, ValidSignature);
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestProcessRequest_AllowNullUserId()
        {
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, TestKey.ConnectionId, ValidSignature, userId: null);
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestProcessRequest_RouteNotFound()
        {
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage("hub1", TestType, TestEvent, TestKey.ConnectionId, ValidSignature);
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task TestProcessRequest_SignatureInvalid()
        {
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, TestKey.ConnectionId, new string[] { "abc" });
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestProcessRequest_ConnectionIdNullBadRequest()
        {
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, null, ValidSignature, httpMethod: "Delete");
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task TestProcessRequest_DeleteMethodBadRequest()
        {
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, TestKey.ConnectionId, ValidSignature, httpMethod: "Delete");
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory]
        [InlineData("OPTIONS", "abc.com")]
        [InlineData("GET", "abc.com")]
        public async Task TestProcessRequest_AbuseProtectionValidOK(string method, string host)
        {
            var allowedHost = new HashSet<string>(new string[] { host });
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, TestKey.ConnectionId, new string[] { TestKey.Signature }, httpMethod: method, host: host);
            var response = await dispatcher.ExecuteAsync(request, allowedHost, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Theory]
        [InlineData("OPTIONS", "abc.com")]
        [InlineData("GET", "abc.com")]
        public async Task TestProcessRequest_AbuseProtectionInvalidBadRequest(string method, string allowedHost)
        {
            var allowedHosts = new HashSet<string>(new string[] { allowedHost });
            var testhost = "def.com";
            var dispatcher = SetupDispatcher();
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, TestType, TestEvent, TestKey.ConnectionId, new string[] { TestKey.Signature }, httpMethod: method, host: testhost);
            var response = await dispatcher.ExecuteAsync(request, allowedHosts, ValidAccessKeys);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Theory]
        [InlineData("application/xml", HttpStatusCode.BadRequest)]
        public async Task TestProcessRequest_MessageMediaTypes(string mediaType, HttpStatusCode expectedCode)
        {
            var dispatcher = SetupDispatcher(TestHub, WebPubSubEventType.User, Constants.Events.MessageEvent);
            var request = TestHelpers.CreateHttpRequestMessage(TestHub, WebPubSubEventType.User, Constants.Events.MessageEvent, TestKey.ConnectionId, ValidSignature, contentType: mediaType);
            var response = await dispatcher.ExecuteAsync(request, EmptySetting, ValidAccessKeys).ConfigureAwait(false);
            Assert.Equal(expectedCode, response.StatusCode);
        }

        private WebPubSubTriggerDispatcher SetupDispatcher(string hub = TestHub, WebPubSubEventType type = TestType, string eventName = TestEvent)
        {
            var funcName = $"{hub}.{type}.{eventName}".ToLower();
            var dispatcher = new WebPubSubTriggerDispatcher();
            var executor = new Mock<ITriggeredFunctionExecutor>();
            executor.Setup(f => f.TryExecuteAsync(It.IsAny<TriggeredFunctionData>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(new FunctionResult(true)));
            var listener = new WebPubSubListener(executor.Object, funcName, dispatcher);

            dispatcher.AddListener(funcName, listener);

            return dispatcher;
        }
    }
}
