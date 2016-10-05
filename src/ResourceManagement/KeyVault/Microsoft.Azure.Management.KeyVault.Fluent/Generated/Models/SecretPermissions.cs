// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.KeyVault.Fluent.Models
{

    /// <summary>
    /// Defines values for SecretPermissions.
    /// </summary>
    public partial class SecretPermissions
    {
        public static readonly SecretPermissions All = new SecretPermissions("all");
        public static readonly SecretPermissions Get = new SecretPermissions("get");
        public static readonly SecretPermissions List = new SecretPermissions("list");
        public static readonly SecretPermissions Set = new SecretPermissions("set");
        public static readonly SecretPermissions Delete = new SecretPermissions("delete");

        private string value;

        /// <summary>
        /// Creates a custom value for SecretPermissions.
        /// </summary>
        /// <param name="permission">the permission value</param>
        public SecretPermissions(string permission)
        {
            this.value = permission;
        }

        public override string ToString()
        {
            return this.value;
        }

        public override bool Equals(object obj)
        {

            string value = this.ToString();
            if (!(obj is KeyPermissions))
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            SecretPermissions rhs = (SecretPermissions) obj;
            if (value == null)
            {
                return rhs.value == null;
            }
            return value.Equals(rhs.value);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}
