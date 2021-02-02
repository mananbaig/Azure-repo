﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Azure.Messaging.ServiceBus;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.ServiceBus.UnitTests
{
    public class ServiceBusTriggerStrategyTests
    {
        [Test]
        public void GetStaticBindingContract_ReturnsExpectedValue()
        {
            var strategy = new ServiceBusTriggerBindingStrategy();
            var bindingDataContract = strategy.GetBindingContract();

            CheckBindingContract(bindingDataContract);
        }

        [Test]
        public void GetBindingContract_SingleDispatch_ReturnsExpectedValue()
        {
            var strategy = new ServiceBusTriggerBindingStrategy();
            var bindingDataContract = strategy.GetBindingContract(true);

            CheckBindingContract(bindingDataContract);
        }

        [Test]
        public void GetBindingContract_MultipleDispatch_ReturnsExpectedValue()
        {
            var strategy = new ServiceBusTriggerBindingStrategy();
            var bindingDataContract = strategy.GetBindingContract(false);

            Assert.AreEqual(15, bindingDataContract.Count);
            Assert.AreEqual(typeof(int[]), bindingDataContract["DeliveryCountArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["DeadLetterSourceArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["LockTokenArray"]);
            Assert.AreEqual(typeof(DateTime[]), bindingDataContract["ExpiresAtArray"]);
            Assert.AreEqual(typeof(DateTime[]), bindingDataContract["EnqueuedTimeArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["MessageIdArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["ContentTypeArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["ReplyToArray"]);
            Assert.AreEqual(typeof(long[]), bindingDataContract["SequenceNumberArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["ToArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["SubjectArray"]);
            Assert.AreEqual(typeof(string[]), bindingDataContract["CorrelationIdArray"]);
            Assert.AreEqual(typeof(IDictionary<string, object>[]), bindingDataContract["ApplicationPropertiesArray"]);
            Assert.AreEqual(typeof(ServiceBusReceiver), bindingDataContract["MessageReceiver"]);
            Assert.AreEqual(typeof(ServiceBusSessionReceiver), bindingDataContract["MessageSession"]);
        }

        [Test]
        public void GetBindingData_SingleDispatch_ReturnsExpectedValue()
        {
            IDictionary<string, object> userProps = new Dictionary<string, object>();
            userProps.Add(new KeyValuePair<string, object>("prop1", "value1"));
            userProps.Add(new KeyValuePair<string, object>("prop2", "value2"));
            var message = CreateMessageWithSystemProperties(applicationProperties: userProps);

            var input = ServiceBusTriggerInput.CreateSingle(message);
            var strategy = new ServiceBusTriggerBindingStrategy();
            var bindingData = strategy.GetBindingData(input);

            Assert.AreEqual(15, bindingData.Count);

            Assert.AreSame(input.Receiver, bindingData["Receiver"]);
            Assert.AreSame(input.SessionReceiver, bindingData["SessionReceiver"]);
            Assert.AreEqual(message.LockToken, bindingData["LockToken"]);
            Assert.AreEqual(message.SequenceNumber, bindingData["SequenceNumber"]);
            Assert.AreEqual(message.DeliveryCount, bindingData["DeliveryCount"]);
            Assert.AreSame(message.DeadLetterSource, bindingData["DeadLetterSource"]);
            Assert.AreEqual(message.ExpiresAt, bindingData["ExpiresAt"]);
            Assert.AreEqual(message.EnqueuedTime, bindingData["EnqueuedTime"]);
            Assert.AreSame(message.MessageId, bindingData["MessageId"]);
            Assert.AreSame(message.ContentType, bindingData["ContentType"]);
            Assert.AreSame(message.ReplyTo, bindingData["ReplyTo"]);
            Assert.AreSame(message.To, bindingData["To"]);
            Assert.AreSame(message.Subject, bindingData["Subject"]);
            Assert.AreSame(message.CorrelationId, bindingData["CorrelationId"]);

            IDictionary<string, object> bindingDataUserProps = bindingData["ApplicationProperties"] as IDictionary<string, object>;
            Assert.NotNull(bindingDataUserProps);
            Assert.AreEqual("value1", bindingDataUserProps["prop1"]);
            Assert.AreEqual("value2", bindingDataUserProps["prop2"]);
        }

        [Test]
        public void GetBindingData_MultipleDispatch_ReturnsExpectedValue()
        {
            var messages = new ServiceBusReceivedMessage[3]
            {
                CreateMessageWithSystemProperties("Event 1"),
                CreateMessageWithSystemProperties("Event 2"),
                CreateMessageWithSystemProperties("Event 3"),
            };

             var input = ServiceBusTriggerInput.CreateBatch(messages);
            var strategy = new ServiceBusTriggerBindingStrategy();
            var bindingData = strategy.GetBindingData(input);

            Assert.AreEqual(15, bindingData.Count);
            Assert.AreSame(input.Receiver, bindingData["Receiver"]);
            Assert.AreSame(input.SessionReceiver, bindingData["SessionReceiver"]);

            // verify an array was created for each binding data type
            Assert.AreEqual(messages.Length, ((int[])bindingData["DeliveryCountArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["DeadLetterSourceArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["LockTokenArray"]).Length);
            Assert.AreEqual(messages.Length, ((DateTime[])bindingData["ExpiresAtArray"]).Length);
            Assert.AreEqual(messages.Length, ((DateTime[])bindingData["EnqueuedTimeArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["MessageIdArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["ContentTypeArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["ReplyToArray"]).Length);
            Assert.AreEqual(messages.Length, ((long[])bindingData["SequenceNumberArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["ToArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["SubjectArray"]).Length);
            Assert.AreEqual(messages.Length, ((string[])bindingData["CorrelationIdArray"]).Length);
            Assert.AreEqual(messages.Length, ((IDictionary<string, object>[])bindingData["ApplicationPropertiesArray"]).Length);
        }

        [Test]
        public void BindSingle_Returns_Exptected_Message()
        {
            string data = "123";

            var strategy = new ServiceBusTriggerBindingStrategy();
            ServiceBusTriggerInput triggerInput = strategy.ConvertFromString(data);

            var contract = strategy.GetBindingData(triggerInput);

            ServiceBusReceivedMessage single = strategy.BindSingle(triggerInput, null);
            string body = single.Body.ToString();

            Assert.AreEqual(data, body);
            Assert.Null(contract["MessageReceiver"]);
            Assert.Null(contract["MessageSession"]);
        }

        private static void CheckBindingContract(Dictionary<string, Type> bindingDataContract)
        {
            Assert.AreEqual(15, bindingDataContract.Count);
            Assert.AreEqual(typeof(int), bindingDataContract["DeliveryCount"]);
            Assert.AreEqual(typeof(string), bindingDataContract["DeadLetterSource"]);
            Assert.AreEqual(typeof(string), bindingDataContract["LockToken"]);
            Assert.AreEqual(typeof(DateTime), bindingDataContract["ExpiresAt"]);
            Assert.AreEqual(typeof(DateTime), bindingDataContract["EnqueuedTime"]);
            Assert.AreEqual(typeof(string), bindingDataContract["MessageId"]);
            Assert.AreEqual(typeof(string), bindingDataContract["ContentType"]);
            Assert.AreEqual(typeof(string), bindingDataContract["ReplyTo"]);
            Assert.AreEqual(typeof(long), bindingDataContract["SequenceNumber"]);
            Assert.AreEqual(typeof(string), bindingDataContract["To"]);
            Assert.AreEqual(typeof(string), bindingDataContract["Subject"]);
            Assert.AreEqual(typeof(string), bindingDataContract["CorrelationId"]);
            Assert.AreEqual(typeof(IDictionary<string, object>), bindingDataContract["ApplicationProperties"]);
            Assert.AreEqual(typeof(ServiceBusReceiver), bindingDataContract["MessageReceiver"]);
            Assert.AreEqual(typeof(ServiceBusSessionReceiver), bindingDataContract["MessageSession"]);
        }

        private static ServiceBusReceivedMessage CreateMessageWithSystemProperties(string body = default, IDictionary<string, object> applicationProperties = default)
        {
            ServiceBusReceivedMessage receivedMessage = ServiceBusModelFactory.ServiceBusReceivedMessage(
                body: body == null ? null : new BinaryData(body),
                deliveryCount: 1,
                lockedUntil: DateTime.MinValue,
                sequenceNumber: 1,
                enqueuedTime: DateTime.MinValue,
                lockTokenGuid: Guid.NewGuid(),
                deadLetterSource: "test",
                properties: applicationProperties);
            return receivedMessage;
        }
    }
}
