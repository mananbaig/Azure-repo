// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{

    /// <summary>
    /// Defines a page in Azure responses.
    /// </summary>
    /// <typeparam name="T">Type of the page content items</typeparam>
    [Newtonsoft.Json.JsonObject]
    public class Page1<T> : Microsoft.Rest.Azure.IPage<T>
    {
         /// <summary>
         /// Gets the link to the next page.
         /// </summary>
         [Newtonsoft.Json.JsonProperty("nextLink")]
         public System.String NextPageLink { get; private set; }

         [Newtonsoft.Json.JsonProperty("value")]
         private System.Collections.Generic.IList<T> Items{ get; set; }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         public System.Collections.Generic.IEnumerator<T> GetEnumerator()
         {
              return (Items == null) ? System.Linq.Enumerable.Empty<T>().GetEnumerator() : Items.GetEnumerator();
         }

         /// <summary>
         /// Returns an enumerator that iterates through the collection.
         /// </summary>
         /// <returns>A an enumerator that can be used to iterate through the collection.</returns>
         System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }
    }
}
