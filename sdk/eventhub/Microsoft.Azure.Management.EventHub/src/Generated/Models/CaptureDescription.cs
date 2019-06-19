// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties to configure capture description for eventhub
    /// </summary>
    public partial class CaptureDescription
    {
        /// <summary>
        /// Initializes a new instance of the CaptureDescription class.
        /// </summary>
        public CaptureDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CaptureDescription class.
        /// </summary>
        /// <param name="enabled">A value that indicates whether capture
        /// description is enabled. </param>
        /// <param name="encoding">Enumerates the possible values for the
        /// encoding format of capture description. Note: 'AvroDeflate' will be
        /// deprecated in New API Version. Possible values include: 'Avro',
        /// 'AvroDeflate'</param>
        /// <param name="intervalInSeconds">The time window allows you to set
        /// the frequency with which the capture to Azure Blobs will happen,
        /// value should between 60 to 900 seconds</param>
        /// <param name="sizeLimitInBytes">The size window defines the amount
        /// of data built up in your Event Hub before an capture operation,
        /// value should be between 10485760 to 524288000 bytes</param>
        /// <param name="destination">Properties of Destination where capture
        /// will be stored. (Storage Account, Blob Names)</param>
        /// <param name="skipEmptyArchives">A value that indicates whether to
        /// Skip Empty Archives</param>
        public CaptureDescription(bool? enabled = default(bool?), EncodingCaptureDescription? encoding = default(EncodingCaptureDescription?), int? intervalInSeconds = default(int?), int? sizeLimitInBytes = default(int?), Destination destination = default(Destination), bool? skipEmptyArchives = default(bool?))
        {
            Enabled = enabled;
            Encoding = encoding;
            IntervalInSeconds = intervalInSeconds;
            SizeLimitInBytes = sizeLimitInBytes;
            Destination = destination;
            SkipEmptyArchives = skipEmptyArchives;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value that indicates whether capture description is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets enumerates the possible values for the encoding format
        /// of capture description. Note: 'AvroDeflate' will be deprecated in
        /// New API Version. Possible values include: 'Avro', 'AvroDeflate'
        /// </summary>
        [JsonProperty(PropertyName = "encoding")]
        public EncodingCaptureDescription? Encoding { get; set; }

        /// <summary>
        /// Gets or sets the time window allows you to set the frequency with
        /// which the capture to Azure Blobs will happen, value should between
        /// 60 to 900 seconds
        /// </summary>
        [JsonProperty(PropertyName = "intervalInSeconds")]
        public int? IntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the size window defines the amount of data built up in
        /// your Event Hub before an capture operation, value should be between
        /// 10485760 to 524288000 bytes
        /// </summary>
        [JsonProperty(PropertyName = "sizeLimitInBytes")]
        public int? SizeLimitInBytes { get; set; }

        /// <summary>
        /// Gets or sets properties of Destination where capture will be
        /// stored. (Storage Account, Blob Names)
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public Destination Destination { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether to Skip Empty Archives
        /// </summary>
        [JsonProperty(PropertyName = "skipEmptyArchives")]
        public bool? SkipEmptyArchives { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IntervalInSeconds > 900)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "IntervalInSeconds", 900);
            }
            if (IntervalInSeconds < 60)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "IntervalInSeconds", 60);
            }
            if (SizeLimitInBytes > 524288000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "SizeLimitInBytes", 524288000);
            }
            if (SizeLimitInBytes < 10485760)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "SizeLimitInBytes", 10485760);
            }
        }
    }
}
