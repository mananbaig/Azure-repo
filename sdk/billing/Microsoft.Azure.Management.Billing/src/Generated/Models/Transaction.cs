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
    using System.Linq;

    /// <summary>
    /// A reservation transaction resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Transaction : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Transaction class.
        /// </summary>
        public Transaction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Transaction class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="kind">The kind of transaction. Choices are all and
        /// reservation. Possible values include: 'all', 'reservation'</param>
        /// <param name="date">The date of reservation transaction.</param>
        /// <param name="invoice">Invoice number or 'pending' if not
        /// invoiced.</param>
        /// <param name="orderId">The reservation order id.</param>
        /// <param name="orderName">The reservation order name.</param>
        /// <param name="productFamily">The product family.</param>
        /// <param name="productTypeId">The product type id.</param>
        /// <param name="productType">The type of product.</param>
        /// <param name="productDescription">Product description.</param>
        /// <param name="transactionType">Transaction types. Possible values
        /// include: 'Purchase', 'Usage Charge'</param>
        /// <param name="transactionAmount">Last charge associated with the
        /// purchase.</param>
        /// <param name="quantity">Purchase quantity.</param>
        /// <param name="invoiceSectionId">Invoice section id to which this
        /// product belongs.</param>
        /// <param name="invoiceSectionDisplayName">Invoice section display
        /// name to which this product belongs.</param>
        /// <param name="billingProfileId">Billing Profile id to which this
        /// product belongs.</param>
        /// <param name="billingProfileDisplayName">Billing Profile display
        /// name to which this product belongs.</param>
        /// <param name="customerId">Customer id to which this product
        /// belongs.</param>
        /// <param name="customerDisplayName">Display name of customer to which
        /// this product belongs.</param>
        /// <param name="subscriptionId">The subscription id.</param>
        /// <param name="subscriptionName">The subscription name.</param>
        public Transaction(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), System.DateTime? date = default(System.DateTime?), string invoice = default(string), string orderId = default(string), string orderName = default(string), string productFamily = default(string), string productTypeId = default(string), string productType = default(string), string productDescription = default(string), string transactionType = default(string), Amount transactionAmount = default(Amount), int? quantity = default(int?), string invoiceSectionId = default(string), string invoiceSectionDisplayName = default(string), string billingProfileId = default(string), string billingProfileDisplayName = default(string), string customerId = default(string), string customerDisplayName = default(string), string subscriptionId = default(string), string subscriptionName = default(string))
            : base(id, name, type)
        {
            Kind = kind;
            Date = date;
            Invoice = invoice;
            OrderId = orderId;
            OrderName = orderName;
            ProductFamily = productFamily;
            ProductTypeId = productTypeId;
            ProductType = productType;
            ProductDescription = productDescription;
            TransactionType = transactionType;
            TransactionAmount = transactionAmount;
            Quantity = quantity;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            CustomerId = customerId;
            CustomerDisplayName = customerDisplayName;
            SubscriptionId = subscriptionId;
            SubscriptionName = subscriptionName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the kind of transaction. Choices are all and
        /// reservation. Possible values include: 'all', 'reservation'
        /// </summary>
        [JsonProperty(PropertyName = "properties.kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets the date of reservation transaction.
        /// </summary>
        [JsonProperty(PropertyName = "properties.date")]
        public System.DateTime? Date { get; private set; }

        /// <summary>
        /// Gets invoice number or 'pending' if not invoiced.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoice")]
        public string Invoice { get; private set; }

        /// <summary>
        /// Gets the reservation order id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orderId")]
        public string OrderId { get; private set; }

        /// <summary>
        /// Gets the reservation order name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.orderName")]
        public string OrderName { get; private set; }

        /// <summary>
        /// Gets the product family.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productFamily")]
        public string ProductFamily { get; private set; }

        /// <summary>
        /// Gets the product type id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productTypeId")]
        public string ProductTypeId { get; private set; }

        /// <summary>
        /// Gets the type of product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productType")]
        public string ProductType { get; private set; }

        /// <summary>
        /// Gets product description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productDescription")]
        public string ProductDescription { get; private set; }

        /// <summary>
        /// Gets or sets transaction types. Possible values include:
        /// 'Purchase', 'Usage Charge'
        /// </summary>
        [JsonProperty(PropertyName = "properties.transactionType")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets last charge associated with the purchase.
        /// </summary>
        [JsonProperty(PropertyName = "properties.transactionAmount")]
        public Amount TransactionAmount { get; private set; }

        /// <summary>
        /// Gets purchase quantity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public int? Quantity { get; private set; }

        /// <summary>
        /// Gets invoice section id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets invoice section display name to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionDisplayName")]
        public string InvoiceSectionDisplayName { get; private set; }

        /// <summary>
        /// Gets billing Profile id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing Profile display name to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; private set; }

        /// <summary>
        /// Gets customer id to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets display name of customer to which this product belongs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerDisplayName")]
        public string CustomerDisplayName { get; private set; }

        /// <summary>
        /// Gets the subscription id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets the subscription name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionName")]
        public string SubscriptionName { get; private set; }

    }
}
