// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Which authentication method Cassandra should use to authenticate clients. 'None' turns off authentication, so should not be used except in emergencies. 'Cassandra' is the default password based authentication. The default is 'Cassandra'. </summary>
    public readonly partial struct CassandraAuthenticationMethod : IEquatable<CassandraAuthenticationMethod>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CassandraAuthenticationMethod"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CassandraAuthenticationMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string CassandraValue = "Cassandra";
        private const string LdapValue = "Ldap";

        /// <summary> None. </summary>
        public static CassandraAuthenticationMethod None { get; } = new CassandraAuthenticationMethod(NoneValue);
        /// <summary> Cassandra. </summary>
        public static CassandraAuthenticationMethod Cassandra { get; } = new CassandraAuthenticationMethod(CassandraValue);
        /// <summary> Ldap. </summary>
        public static CassandraAuthenticationMethod Ldap { get; } = new CassandraAuthenticationMethod(LdapValue);
        /// <summary> Determines if two <see cref="CassandraAuthenticationMethod"/> values are the same. </summary>
        public static bool operator ==(CassandraAuthenticationMethod left, CassandraAuthenticationMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CassandraAuthenticationMethod"/> values are not the same. </summary>
        public static bool operator !=(CassandraAuthenticationMethod left, CassandraAuthenticationMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CassandraAuthenticationMethod"/>. </summary>
        public static implicit operator CassandraAuthenticationMethod(string value) => new CassandraAuthenticationMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CassandraAuthenticationMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CassandraAuthenticationMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
