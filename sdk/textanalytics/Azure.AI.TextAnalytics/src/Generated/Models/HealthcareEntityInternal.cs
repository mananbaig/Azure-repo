// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The HealthcareEntity. </summary>
    internal partial class HealthcareEntityInternal
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareEntityInternal"/>. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Healthcare Entity Category. </param>
        /// <param name="offset"> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public HealthcareEntityInternal(string text, HealthcareEntityCategory category, int offset, int length, double confidenceScore)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            Category = category;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
            Links = new ChangeTrackingList<EntityDataSource>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityInternal"/>. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Healthcare Entity Category. </param>
        /// <param name="subcategory"> (Optional) Entity sub type. </param>
        /// <param name="offset"> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <param name="assertion"></param>
        /// <param name="name"> Preferred name for the entity. Example: 'histologically' would have a 'name' of 'histologic'. </param>
        /// <param name="links"> Entity references in known data sources. </param>
        internal HealthcareEntityInternal(string text, HealthcareEntityCategory category, string subcategory, int offset, int length, double confidenceScore, HealthcareEntityAssertion assertion, string name, IList<EntityDataSource> links)
        {
            Text = text;
            Category = category;
            Subcategory = subcategory;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
            Assertion = assertion;
            Name = name;
            Links = links;
        }

        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; set; }
        /// <summary> Healthcare Entity Category. </summary>
        public HealthcareEntityCategory Category { get; set; }
        /// <summary> (Optional) Entity sub type. </summary>
        public string Subcategory { get; set; }
        /// <summary> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </summary>
        public int Offset { get; set; }
        /// <summary> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </summary>
        public int Length { get; set; }
        /// <summary> Confidence score between 0 and 1 of the extracted entity. </summary>
        public double ConfidenceScore { get; set; }
        /// <summary> Gets or sets the assertion. </summary>
        public HealthcareEntityAssertion Assertion { get; set; }
        /// <summary> Preferred name for the entity. Example: 'histologically' would have a 'name' of 'histologic'. </summary>
        public string Name { get; set; }
        /// <summary> Entity references in known data sources. </summary>
        public IList<EntityDataSource> Links { get; }
    }
}
