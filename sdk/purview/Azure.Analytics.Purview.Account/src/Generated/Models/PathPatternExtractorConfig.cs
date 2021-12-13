// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.Account.Models
{
    /// <summary> The PathPatternExtractorConfig. </summary>
    public partial class PathPatternExtractorConfig
    {
        /// <summary> Initializes a new instance of PathPatternExtractorConfig. </summary>
        /// <param name="createdBy"></param>
        /// <param name="enableDefaultPatterns"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="createdBy"/> is null. </exception>
        public PathPatternExtractorConfig(string createdBy, bool enableDefaultPatterns)
        {
            if (createdBy == null)
            {
                throw new ArgumentNullException(nameof(createdBy));
            }

            AcceptedPatterns = new ChangeTrackingList<Filter>();
            ComplexReplacers = new ChangeTrackingList<ComplexReplacerConfig>();
            CreatedBy = createdBy;
            EnableDefaultPatterns = enableDefaultPatterns;
            NormalizationRules = new ChangeTrackingList<NormalizationRule>();
            RegexReplacers = new ChangeTrackingList<RegexReplacer>();
            RejectedPatterns = new ChangeTrackingList<Filter>();
            ScopedRules = new ChangeTrackingList<ScopedRule>();
        }

        /// <summary> Initializes a new instance of PathPatternExtractorConfig. </summary>
        /// <param name="acceptedPatterns"></param>
        /// <param name="complexReplacers"></param>
        /// <param name="createdBy"></param>
        /// <param name="enableDefaultPatterns"></param>
        /// <param name="lastUpdatedTimestamp"></param>
        /// <param name="modifiedBy"></param>
        /// <param name="normalizationRules"></param>
        /// <param name="regexReplacers"></param>
        /// <param name="rejectedPatterns"></param>
        /// <param name="scopedRules"></param>
        /// <param name="version"></param>
        internal PathPatternExtractorConfig(IList<Filter> acceptedPatterns, IList<ComplexReplacerConfig> complexReplacers, string createdBy, bool enableDefaultPatterns, long? lastUpdatedTimestamp, string modifiedBy, IList<NormalizationRule> normalizationRules, IList<RegexReplacer> regexReplacers, IList<Filter> rejectedPatterns, IList<ScopedRule> scopedRules, int? version)
        {
            AcceptedPatterns = acceptedPatterns;
            ComplexReplacers = complexReplacers;
            CreatedBy = createdBy;
            EnableDefaultPatterns = enableDefaultPatterns;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            ModifiedBy = modifiedBy;
            NormalizationRules = normalizationRules;
            RegexReplacers = regexReplacers;
            RejectedPatterns = rejectedPatterns;
            ScopedRules = scopedRules;
            Version = version;
        }

        /// <summary> Gets the accepted patterns. </summary>
        public IList<Filter> AcceptedPatterns { get; }
        /// <summary> Gets the complex replacers. </summary>
        public IList<ComplexReplacerConfig> ComplexReplacers { get; }
        /// <summary> Gets or sets the created by. </summary>
        public string CreatedBy { get; set; }
        /// <summary> Gets or sets the enable default patterns. </summary>
        public bool EnableDefaultPatterns { get; set; }
        /// <summary> Gets or sets the last updated timestamp. </summary>
        public long? LastUpdatedTimestamp { get; set; }
        /// <summary> Gets or sets the modified by. </summary>
        public string ModifiedBy { get; set; }
        /// <summary> Gets the normalization rules. </summary>
        public IList<NormalizationRule> NormalizationRules { get; }
        /// <summary> Gets the regex replacers. </summary>
        public IList<RegexReplacer> RegexReplacers { get; }
        /// <summary> Gets the rejected patterns. </summary>
        public IList<Filter> RejectedPatterns { get; }
        /// <summary> Gets the scoped rules. </summary>
        public IList<ScopedRule> ScopedRules { get; }
        /// <summary> Gets or sets the version. </summary>
        public int? Version { get; set; }
    }
}
