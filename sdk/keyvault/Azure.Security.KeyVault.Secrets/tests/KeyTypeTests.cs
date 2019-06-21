﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using Azure.Core.Testing;
using Azure.Identity;
using Azure.Security.KeyVault.Keys;
using Azure.Security.KeyVault.Secrets;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Test
{
    public class KeyTypeTests
    {
        [Test]
        public void EnsureOperatorWorks()
        {
            KeyType ec = KeyType.EllipticCurve;
            KeyType ecesm = KeyType.EllipticCurveHsm;

            Assert.IsTrue(ec != ecesm);
            Assert.AreNotEqual(ec, ecesm);
        }

        [TestCaseSource(nameof(KeyTypeCombinationsToTest))]
        public void ValidateKeyTypeWithString(string keyName, KeyType expectedKeyType)
        {
            KeyType kt = Create<KeyType>(keyName);

            // Their string representation will be the same
            Assert.AreEqual(expectedKeyType.ToString(), kt.ToString());

            // using the operators
            //Assert.AreNotEqual(kt, expectedKeyType); // we are not going to have the same type (one is created based on the string, the other 
            //Assert.IsFalse(kt != expectedKeyType);
        }

        [TestCaseSource(nameof(KeyTypeCombinationsToTestEnum))]
        public void ValidateKeyTypeWithEnum(KeyType.KeyTypeValue keyType, KeyType expectedKeyType)
        {
            KeyType kt = new KeyType(keyType);

            // using the equals method
            Assert.AreEqual(expectedKeyType, kt);
            Assert.AreEqual(expectedKeyType.Value, kt.Value);

            //// using the operators
            Assert.IsTrue(kt == expectedKeyType);
            Assert.IsFalse(kt != expectedKeyType);
        }

        private static T Create<T>(string value)
        {
            var ctorObj = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, new Type[] { typeof(string) }, null);
            return (T)ctorObj.Invoke(new object[] { value });
        }

        static readonly object[] KeyTypeCombinationsToTest =
        {
            new object[]{"RSA", KeyType.Rsa},
            new object[]{"RSA-HSM", KeyType.RsaHsm},
            new object[]{"EC", KeyType.EllipticCurve},
            new object[]{"EC-HSM", KeyType.EllipticCurveHsm},
            new object[]{"Octet", KeyType.Octet},
            new object[]{"UnknownValue", Create<KeyType>("UnknownValue")},
        };

        static readonly object[] KeyTypeCombinationsToTestEnum =
       {
            new object[]{ KeyType.KeyTypeValue.Rsa, KeyType.Rsa},
            new object[]{ KeyType.KeyTypeValue.RsaHsm, KeyType.RsaHsm},
            new object[]{ KeyType.KeyTypeValue.EllipticCurve, KeyType.EllipticCurve},
            new object[]{ KeyType.KeyTypeValue.EllipticCurveHsm, KeyType.EllipticCurveHsm},
            new object[]{ KeyType.KeyTypeValue.Octet, KeyType.Octet},
        };
    }
}