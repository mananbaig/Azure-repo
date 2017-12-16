// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used to submit a new Data Lake Analytics job.
    /// </summary>
    public partial class CreateJobParameters : BaseJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the CreateJobParameters class.
        /// </summary>
        public CreateJobParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateJobParameters class.
        /// </summary>
        /// <param name="type">the job type of the current job (Hive, USql, or
        /// Scope (for internal use only)). Possible values include: 'USql',
        /// 'Hive', 'Scope'</param>
        /// <param name="properties">the job specific properties.</param>
        /// <param name="name">the friendly name of the job to submit.</param>
        /// <param name="degreeOfParallelism">the degree of parallelism to use
        /// for this job. This must be greater than 0, if set to less than 0 it
        /// will default to 1.</param>
        /// <param name="priority">the priority value to use for the current
        /// job. Lower numbers have a higher priority. By default, a job has a
        /// priority of 1000. This must be greater than 0.</param>
        /// <param name="logFilePatterns">the list of log file name patterns to
        /// find in the logFolder. '*' is the only matching character allowed.
        /// Example format: jobExecution*.log or *mylog*.txt</param>
        /// <param name="related">the recurring job relationship information
        /// properties.</param>
        public CreateJobParameters(JobType type, CreateJobProperties properties, string name, int? degreeOfParallelism = default(int?), int? priority = default(int?), IList<string> logFilePatterns = default(IList<string>), JobRelationshipProperties related = default(JobRelationshipProperties))
            : base(type, properties)
        {
            Name = name;
            DegreeOfParallelism = degreeOfParallelism;
            Priority = priority;
            LogFilePatterns = logFilePatterns;
            Related = related;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name of the job to submit.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the degree of parallelism to use for this job. This
        /// must be greater than 0, if set to less than 0 it will default to 1.
        /// </summary>
        [JsonProperty(PropertyName = "degreeOfParallelism")]
        public int? DegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the priority value to use for the current job. Lower
        /// numbers have a higher priority. By default, a job has a priority of
        /// 1000. This must be greater than 0.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the list of log file name patterns to find in the
        /// logFolder. '*' is the only matching character allowed. Example
        /// format: jobExecution*.log or *mylog*.txt
        /// </summary>
        [JsonProperty(PropertyName = "logFilePatterns")]
        public IList<string> LogFilePatterns { get; set; }

        /// <summary>
        /// Gets or sets the recurring job relationship information properties.
        /// </summary>
        [JsonProperty(PropertyName = "related")]
        public JobRelationshipProperties Related { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Related != null)
            {
                Related.Validate();
            }
        }
    }
}
