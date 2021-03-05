﻿using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using System;
using System.Collections.Generic;

namespace Proto.Billing
{
    /// <summary>
    /// A class representing the availability set data model.
    /// </summary>
    public class BillingAccountData : TrackedResource<Azure.ResourceManager.Billing.Models.BillingAccount>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAccountData"/> class.
        /// </summary>
        /// <param name="billingAccount"> The availability set to initialize. </param>
        public BillingAccountData(Azure.ResourceManager.Billing.Models.BillingAccount billingAccount)
            : base(billingAccount.Id, "westus", billingAccount)
        {
        }
    }
}
