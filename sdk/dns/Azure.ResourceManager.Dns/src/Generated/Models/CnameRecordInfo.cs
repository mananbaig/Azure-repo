// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> A CNAME record. </summary>
    internal partial class CnameRecordInfo
    {
        /// <summary> Initializes a new instance of CnameRecordInfo. </summary>
        public CnameRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of CnameRecordInfo. </summary>
        /// <param name="cname"> The canonical name for this CNAME record. </param>
        internal CnameRecordInfo(string cname)
        {
            Cname = cname;
        }

        /// <summary> The canonical name for this CNAME record. </summary>
        public string Cname { get; set; }
    }
}
