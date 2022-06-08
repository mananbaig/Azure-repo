// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active directory provider. </summary>
    public partial class AzureActiveDirectory
    {
        /// <summary> Initializes a new instance of <see cref="AzureActiveDirectory"/>. </summary>
        public AzureActiveDirectory()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureActiveDirectory"/>. </summary>
        /// <param name="enabled"> &lt;code&gt;false&lt;/code&gt; if the Azure Active Directory provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Azure Active Directory app registration. </param>
        /// <param name="login"> The configuration settings of the Azure Active Directory login flow. </param>
        /// <param name="validation"> The configuration settings of the Azure Active Directory token validation flow. </param>
        /// <param name="isAutoProvisioned">
        /// Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        /// read or write to this property.
        /// </param>
        internal AzureActiveDirectory(bool? enabled, AzureActiveDirectoryRegistration registration, AzureActiveDirectoryLogin login, AzureActiveDirectoryValidation validation, bool? isAutoProvisioned)
        {
            Enabled = enabled;
            Registration = registration;
            Login = login;
            Validation = validation;
            IsAutoProvisioned = isAutoProvisioned;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Azure Active Directory provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The configuration settings of the Azure Active Directory app registration. </summary>
        public AzureActiveDirectoryRegistration Registration { get; set; }
        /// <summary> The configuration settings of the Azure Active Directory login flow. </summary>
        public AzureActiveDirectoryLogin Login { get; set; }
        /// <summary> The configuration settings of the Azure Active Directory token validation flow. </summary>
        public AzureActiveDirectoryValidation Validation { get; set; }
        /// <summary>
        /// Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        /// This is an internal flag primarily intended to support the Azure Management Portal. Users should not
        /// read or write to this property.
        /// </summary>
        public bool? IsAutoProvisioned { get; set; }
    }
}
