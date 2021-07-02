// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeOrder.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Order item details
    /// </summary>
    public partial class OrderItemDetails
    {
        /// <summary>
        /// Initializes a new instance of the OrderItemDetails class.
        /// </summary>
        public OrderItemDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderItemDetails class.
        /// </summary>
        /// <param name="productDetails">Unique identifier for
        /// configuration.</param>
        /// <param name="orderItemType">Order item type. Possible values
        /// include: 'Purchase', 'Rental'</param>
        /// <param name="currentStage">Current Order item Status</param>
        /// <param name="orderItemStageHistory">Order item status
        /// history</param>
        /// <param name="preferences">Customer notification Preferences</param>
        /// <param name="forwardShippingDetails">Forward Package Shipping
        /// details</param>
        /// <param name="reverseShippingDetails">Reverse Package Shipping
        /// details</param>
        /// <param name="notificationEmailList">Additional notification email
        /// list</param>
        /// <param name="cancellationReason">Cancellation reason.</param>
        /// <param name="cancellationStatus">Describes whether the orderItem is
        /// cancellable or not. Possible values include: 'Cancellable',
        /// 'CancellableWithFee', 'NotCancellable'</param>
        /// <param name="deletionStatus">Describes whether the order item is
        /// deletable or not. Possible values include: 'Allowed',
        /// 'NotAllowed'</param>
        /// <param name="returnReason">Return reason.</param>
        /// <param name="returnStatus">Describes whether the orderItem is
        /// returnable or not. Possible values include: 'Returnable',
        /// 'ReturnableWithFee', 'NotReturnable'</param>
        /// <param name="managementRpDetails">parent RP details</param>
        /// <param name="error">Top level error for the job.</param>
        public OrderItemDetails(ProductDetails productDetails, string orderItemType, StageDetails currentStage = default(StageDetails), IList<StageDetails> orderItemStageHistory = default(IList<StageDetails>), Preferences preferences = default(Preferences), ShippingDetails forwardShippingDetails = default(ShippingDetails), ShippingDetails reverseShippingDetails = default(ShippingDetails), IList<string> notificationEmailList = default(IList<string>), string cancellationReason = default(string), string cancellationStatus = default(string), string deletionStatus = default(string), string returnReason = default(string), string returnStatus = default(string), object managementRpDetails = default(object), ErrorDetail error = default(ErrorDetail))
        {
            ProductDetails = productDetails;
            OrderItemType = orderItemType;
            CurrentStage = currentStage;
            OrderItemStageHistory = orderItemStageHistory;
            Preferences = preferences;
            ForwardShippingDetails = forwardShippingDetails;
            ReverseShippingDetails = reverseShippingDetails;
            NotificationEmailList = notificationEmailList;
            CancellationReason = cancellationReason;
            CancellationStatus = cancellationStatus;
            DeletionStatus = deletionStatus;
            ReturnReason = returnReason;
            ReturnStatus = returnStatus;
            ManagementRpDetails = managementRpDetails;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for configuration.
        /// </summary>
        [JsonProperty(PropertyName = "productDetails")]
        public ProductDetails ProductDetails { get; set; }

        /// <summary>
        /// Gets or sets order item type. Possible values include: 'Purchase',
        /// 'Rental'
        /// </summary>
        [JsonProperty(PropertyName = "orderItemType")]
        public string OrderItemType { get; set; }

        /// <summary>
        /// Gets current Order item Status
        /// </summary>
        [JsonProperty(PropertyName = "currentStage")]
        public StageDetails CurrentStage { get; private set; }

        /// <summary>
        /// Gets order item status history
        /// </summary>
        [JsonProperty(PropertyName = "orderItemStageHistory")]
        public IList<StageDetails> OrderItemStageHistory { get; private set; }

        /// <summary>
        /// Gets or sets customer notification Preferences
        /// </summary>
        [JsonProperty(PropertyName = "preferences")]
        public Preferences Preferences { get; set; }

        /// <summary>
        /// Gets forward Package Shipping details
        /// </summary>
        [JsonProperty(PropertyName = "forwardShippingDetails")]
        public ShippingDetails ForwardShippingDetails { get; private set; }

        /// <summary>
        /// Gets reverse Package Shipping details
        /// </summary>
        [JsonProperty(PropertyName = "reverseShippingDetails")]
        public ShippingDetails ReverseShippingDetails { get; private set; }

        /// <summary>
        /// Gets or sets additional notification email list
        /// </summary>
        [JsonProperty(PropertyName = "notificationEmailList")]
        public IList<string> NotificationEmailList { get; set; }

        /// <summary>
        /// Gets cancellation reason.
        /// </summary>
        [JsonProperty(PropertyName = "cancellationReason")]
        public string CancellationReason { get; private set; }

        /// <summary>
        /// Gets describes whether the orderItem is cancellable or not.
        /// Possible values include: 'Cancellable', 'CancellableWithFee',
        /// 'NotCancellable'
        /// </summary>
        [JsonProperty(PropertyName = "cancellationStatus")]
        public string CancellationStatus { get; private set; }

        /// <summary>
        /// Gets describes whether the order item is deletable or not. Possible
        /// values include: 'Allowed', 'NotAllowed'
        /// </summary>
        [JsonProperty(PropertyName = "deletionStatus")]
        public string DeletionStatus { get; private set; }

        /// <summary>
        /// Gets return reason.
        /// </summary>
        [JsonProperty(PropertyName = "returnReason")]
        public string ReturnReason { get; private set; }

        /// <summary>
        /// Gets describes whether the orderItem is returnable or not. Possible
        /// values include: 'Returnable', 'ReturnableWithFee', 'NotReturnable'
        /// </summary>
        [JsonProperty(PropertyName = "returnStatus")]
        public string ReturnStatus { get; private set; }

        /// <summary>
        /// Gets parent RP details
        /// </summary>
        [JsonProperty(PropertyName = "managementRpDetails")]
        public object ManagementRpDetails { get; private set; }

        /// <summary>
        /// Gets top level error for the job.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorDetail Error { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProductDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProductDetails");
            }
            if (OrderItemType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OrderItemType");
            }
            if (ProductDetails != null)
            {
                ProductDetails.Validate();
            }
            if (Preferences != null)
            {
                Preferences.Validate();
            }
        }
    }
}
