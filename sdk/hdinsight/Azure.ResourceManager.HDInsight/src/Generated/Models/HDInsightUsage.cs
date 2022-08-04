// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The details about the usage of a particular limited resource. </summary>
    public partial class HDInsightUsage
    {
        /// <summary> Initializes a new instance of HDInsightUsage. </summary>
        internal HDInsightUsage()
        {
        }

        /// <summary> Initializes a new instance of HDInsightUsage. </summary>
        /// <param name="unit"> The type of measurement for usage. </param>
        /// <param name="currentValue"> The current usage. </param>
        /// <param name="limit"> The maximum allowed usage. </param>
        /// <param name="name"> The details about the localizable name of the used resource. </param>
        internal HDInsightUsage(string unit, long? currentValue, long? limit, HDInsightLocalizedName name)
        {
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> The type of measurement for usage. </summary>
        public string Unit { get; }
        /// <summary> The current usage. </summary>
        public long? CurrentValue { get; }
        /// <summary> The maximum allowed usage. </summary>
        public long? Limit { get; }
        /// <summary> The details about the localizable name of the used resource. </summary>
        public HDInsightLocalizedName Name { get; }
    }
}
