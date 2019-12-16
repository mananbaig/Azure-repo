﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using NUnit.Framework;

#nullable enable

namespace Azure.Core.Tests
{
    public class ConnectionStringTests
    {
        [TestCase("x=y")]
        [TestCase("x=y;")]
        [TestCase("x=y;z=")]
        [TestCase("x=;y=z")]
        [TestCase("x=y;z=y")]
        [TestCase("x=eXo=")]
        [TestCase("x=y=z")]
        [TestCase(" x = y ; z = w")]
        public void ValidString(string str)
        {
            Assert.DoesNotThrow(() => ConnectionString.Parse(str, allowEmptyValues: true));
        }

        [TestCase("x;y=z;w", "=", ";")]
        [TestCase("x<>y==z<>w", "==", "<>")]
        public void ValidString_CustomSeparators(string str, string segmentSeparator, string keyValueSeparator)
        {
            var connectionString = ConnectionString.Parse(str, segmentSeparator, keyValueSeparator);
            Assert.AreEqual("y", connectionString.GetRequired("x"));
            Assert.AreEqual("w", connectionString.GetRequired("z"));
        }

        [TestCase("x")]
        [TestCase("x;z")]
        [TestCase("x=y;;")]
        [TestCase(";x=y;")]
        [TestCase(";;x=y")]
        [TestCase("x=y;z")]
        [TestCase("x=y;=z")]
        [TestCase("x;y=z")]
        [TestCase("x=y;x=z")]
        [TestCase("=y")]
        [TestCase(" x = y ; z ")]
        public void InvalidString(string str)
        {
            Assert.Throws<InvalidOperationException>(() => ConnectionString.Parse(str, allowEmptyValues: true));
        }

        [TestCase("x=y;z=")]
        [TestCase("x=;y=z")]
        public void InvalidString_NoEmptyValues(string str)
        {
            Assert.Throws<InvalidOperationException>(() => ConnectionString.Parse(str, allowEmptyValues: false));
        }

        [Test]
        public void RequiredKey()
        {
            var connectionString = ConnectionString.Parse("x=y");
            Assert.AreEqual("y", connectionString.GetRequired("x"));
            Assert.Throws<InvalidOperationException>(() => connectionString.GetRequired("y"));
        }

        [Test]
        public void NonRequiredKey()
        {
            var connectionString = ConnectionString.Parse("x=y");
            Assert.AreEqual("y", connectionString.GetNonRequired("x"));
            Assert.AreEqual(null, connectionString.GetNonRequired("y"));
        }

        [Test]
        public void Replace()
        {
            var connectionString = ConnectionString.Parse("x=y");
            connectionString.Replace("x", "z");
            connectionString.Replace("y", "w");

            Assert.AreEqual("z", connectionString.GetNonRequired("x"));
            Assert.AreEqual(null, connectionString.GetNonRequired("y"));
        }
    }
}
