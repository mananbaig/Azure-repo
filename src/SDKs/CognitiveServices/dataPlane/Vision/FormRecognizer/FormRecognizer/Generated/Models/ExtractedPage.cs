// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extraction information of a single page in a
    /// with a document.
    /// </summary>
    public partial class ExtractedPage
    {
        /// <summary>
        /// Initializes a new instance of the ExtractedPage class.
        /// </summary>
        public ExtractedPage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtractedPage class.
        /// </summary>
        /// <param name="number">Page number.</param>
        /// <param name="height">Height of the page (in pixels).</param>
        /// <param name="width">Width of the page (in pixels).</param>
        /// <param name="clusterId">Cluster identifier.</param>
        /// <param name="keyValuePairs">List of Key-Value pairs extracted from
        /// the page.</param>
        /// <param name="tables">List of Tables and their information extracted
        /// from the page.</param>
        public ExtractedPage(int? number = default(int?), int? height = default(int?), int? width = default(int?), int? clusterId = default(int?), IList<ExtractedKeyValuePair> keyValuePairs = default(IList<ExtractedKeyValuePair>), IList<ExtractedTable> tables = default(IList<ExtractedTable>))
        {
            Number = number;
            Height = height;
            Width = width;
            ClusterId = clusterId;
            KeyValuePairs = keyValuePairs;
            Tables = tables;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets page number.
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or sets height of the page (in pixels).
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets width of the page (in pixels).
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets cluster identifier.
        /// </summary>
        [JsonProperty(PropertyName = "clusterId")]
        public int? ClusterId { get; set; }

        /// <summary>
        /// Gets or sets list of Key-Value pairs extracted from the page.
        /// </summary>
        [JsonProperty(PropertyName = "keyValuePairs")]
        public IList<ExtractedKeyValuePair> KeyValuePairs { get; set; }

        /// <summary>
        /// Gets or sets list of Tables and their information extracted from
        /// the page.
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<ExtractedTable> Tables { get; set; }

    }
}
