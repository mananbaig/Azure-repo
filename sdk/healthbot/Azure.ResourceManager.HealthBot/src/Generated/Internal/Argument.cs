// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;

namespace Azure.ResourceManager.HealthBot
{
    internal static class Argument
    {
        public static void AssertNotNull<T>(T value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void AssertNotNull<T>(T? value, string name)
        where T : struct
        {
            if (!value.HasValue)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void AssertNotNullOrEmpty<T>(IEnumerable<T> value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
            if (value is ICollection<T> collectionOfT && collectionOfT.Count == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", name);
            }
            if (value is ICollection collection && collection.Count == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", name);
            }
            using IEnumerator<T> e = value.GetEnumerator();
            if (!e.MoveNext())
            {
                throw new ArgumentException("Value cannot be an empty collection.", name);
            }
        }

        public static void AssertNotNullOrEmpty(string value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
            if (value.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", name);
            }
        }

        public static void AssertNotNullOrWhiteSpace(string value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Value cannot be empty or contain only white-space characters.", name);
            }
        }

        public static void AssertNotDefault<T>(ref T value, string name)
        where T : struct, IEquatable<T>
        {
            if (value.Equals(default))
            {
                throw new ArgumentException("Value cannot be empty.", name);
            }
        }

        public static void AssertInRange<T>(T value, T minimum, T maximum, string name)
        where T : notnull, IComparable<T>
        {
            if (minimum.CompareTo(value) > 0)
            {
                throw new ArgumentOutOfRangeException(name, "Value is less than the minimum allowed.");
            }
            if (maximum.CompareTo(value) < 0)
            {
                throw new ArgumentOutOfRangeException(name, "Value is greater than the maximum allowed.");
            }
        }

        public static void AssertEnumDefined(Type enumType, object value, string name)
        {
            if (!Enum.IsDefined(enumType, value))
            {
                throw new ArgumentException($"Value not defined for {enumType.FullName}.", name);
            }
        }

        public static T CheckNotNull<T>(T value, string name)
        where T : class
        {
            AssertNotNull(value, name);
            return value;
        }

        public static string CheckNotNullOrEmpty(string value, string name)
        {
            AssertNotNullOrEmpty(value, name);
            return value;
        }

        public static void AssertNull<T>(T value, string name, string message = null)
        {
            if (value != null)
            {
                throw new ArgumentException(message ?? "Value must be null.", name);
            }
        }
    }
}
