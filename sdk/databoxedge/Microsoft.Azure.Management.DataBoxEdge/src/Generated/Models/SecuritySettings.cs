// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The security settings of a device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecuritySettings : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the SecuritySettings class.
        /// </summary>
        public SecuritySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecuritySettings class.
        /// </summary>
        /// <param name="deviceAdminPassword">Device administrator password as
        /// an encrypted string (encrypted using RSA PKCS #1) is used to sign
        /// into the  local web UI of the device. The Actual password should
        /// have at least 8 characters that are a combination of  uppercase,
        /// lowercase, numeric, and special characters.</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        public SecuritySettings(AsymmetricEncryptedSecret deviceAdminPassword, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            DeviceAdminPassword = deviceAdminPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets device administrator password as an encrypted string
        /// (encrypted using RSA PKCS #1) is used to sign into the  local web
        /// UI of the device. The Actual password should have at least 8
        /// characters that are a combination of  uppercase, lowercase,
        /// numeric, and special characters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceAdminPassword")]
        public AsymmetricEncryptedSecret DeviceAdminPassword { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeviceAdminPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceAdminPassword");
            }
            if (DeviceAdminPassword != null)
            {
                DeviceAdminPassword.Validate();
            }
        }
    }
}
