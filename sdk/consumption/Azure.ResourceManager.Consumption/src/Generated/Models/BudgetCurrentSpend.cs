// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The current amount of cost which is being tracked for a budget. </summary>
    public partial class BudgetCurrentSpend
    {
        /// <summary> Initializes a new instance of BudgetCurrentSpend. </summary>
        internal BudgetCurrentSpend()
        {
        }

        /// <summary> Initializes a new instance of BudgetCurrentSpend. </summary>
        /// <param name="amount"> The total amount of cost which is being tracked by the budget. </param>
        /// <param name="unit"> The unit of measure for the budget amount. </param>
        internal BudgetCurrentSpend(decimal? amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }

        /// <summary> The total amount of cost which is being tracked by the budget. </summary>
        public decimal? Amount { get; }
        /// <summary> The unit of measure for the budget amount. </summary>
        public string Unit { get; }
    }
}
