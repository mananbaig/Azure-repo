// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A billing account resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BillingAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BillingAccount class.
        /// </summary>
        public BillingAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingAccount class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The billing account name.</param>
        /// <param name="accountType">The billing account Type. Possible values
        /// include: 'Organization', 'Enrollment'</param>
        /// <param name="address">The address associated with billing
        /// account.</param>
        /// <param name="company">Company Name.</param>
        /// <param name="country">Country Name.</param>
        /// <param name="invoiceSections">The invoice sections associated to
        /// the billing account. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="billingProfiles">The billing profiles associated to
        /// the billing account. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="enrollmentDetails">The details about the associated
        /// legacy enrollment. By default this is not populated, unless it's
        /// specified in $expand.</param>
        /// <param name="departments">The departments associated to the
        /// enrollment.</param>
        /// <param name="enrollmentAccounts">The accounts associated to the
        /// enrollment.</param>
        /// <param name="hasReadAccess">Specifies whether the user has read
        /// access on billing account.</param>
        public BillingAccount(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string accountType = default(string), Address address = default(Address), string company = default(string), string country = default(string), IList<InvoiceSection> invoiceSections = default(IList<InvoiceSection>), IList<BillingProfile> billingProfiles = default(IList<BillingProfile>), Enrollment enrollmentDetails = default(Enrollment), IList<Department> departments = default(IList<Department>), IList<EnrollmentAccount> enrollmentAccounts = default(IList<EnrollmentAccount>), bool? hasReadAccess = default(bool?))
            : base(id, name, type)
        {
            DisplayName = displayName;
            AccountType = accountType;
            Address = address;
            Company = company;
            Country = country;
            InvoiceSections = invoiceSections;
            BillingProfiles = billingProfiles;
            EnrollmentDetails = enrollmentDetails;
            Departments = departments;
            EnrollmentAccounts = enrollmentAccounts;
            HasReadAccess = hasReadAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the billing account name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the billing account Type. Possible values include:
        /// 'Organization', 'Enrollment'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public string AccountType { get; private set; }

        /// <summary>
        /// Gets or sets the address associated with billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets company Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.company")]
        public string Company { get; private set; }

        /// <summary>
        /// Gets country Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.country")]
        public string Country { get; private set; }

        /// <summary>
        /// Gets or sets the invoice sections associated to the billing
        /// account. By default this is not populated, unless it's specified in
        /// $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSections")]
        public IList<InvoiceSection> InvoiceSections { get; set; }

        /// <summary>
        /// Gets or sets the billing profiles associated to the billing
        /// account. By default this is not populated, unless it's specified in
        /// $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfiles")]
        public IList<BillingProfile> BillingProfiles { get; set; }

        /// <summary>
        /// Gets the details about the associated legacy enrollment. By default
        /// this is not populated, unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentDetails")]
        public Enrollment EnrollmentDetails { get; private set; }

        /// <summary>
        /// Gets or sets the departments associated to the enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.departments")]
        public IList<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the accounts associated to the enrollment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentAccounts")]
        public IList<EnrollmentAccount> EnrollmentAccounts { get; set; }

        /// <summary>
        /// Gets specifies whether the user has read access on billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasReadAccess")]
        public bool? HasReadAccess { get; private set; }

    }
}
