﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

using Windows.Data.Xml.Dom;
using Windows.Web.Syndication;

namespace Microsoft.WindowsAzure.ServiceLayer
{
    /// <summary>
    /// Serialization/deserialization helper.
    /// </summary>
    static class SerializationHelper
    {
        /// <summary>
        /// Deserializes the feed into a collection of items of the same type.
        /// </summary>
        /// <typeparam name="T">Type of result items in the collection</typeparam>
        /// <param name="feed">Atom feed with serialized items</param>
        /// <param name="itemAction">Additional action to perform on each item</param>
        /// <returns>Collection of deserialized items</returns>
        static internal IEnumerable<T> DeserializeCollection<T>(SyndicationFeed feed, Action<SyndicationItem, T> itemAction)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(T));
            foreach (SyndicationItem item in feed.Items)
            {
                yield return DeserializeItem(serializer, item, itemAction);
            }
        }

        static internal T DeserializeItem<T>(SyndicationItem item, Action<SyndicationItem, T> itemAction)
        {
            return DeserializeItem<T>(new DataContractSerializer(typeof(T)), item, itemAction);
        }

        static T DeserializeItem<T>(DataContractSerializer serializer, SyndicationItem item, Action<SyndicationItem, T> itemAction)
        {
            string serializedString = item.Content.Xml.GetXml();
            using (StringReader stringReader = new StringReader(serializedString))
            using (XmlReader xmlReader = XmlReader.Create(stringReader))
            {
                T deserializedObject = (T)serializer.ReadObject(xmlReader);
                itemAction(item, deserializedObject);
                return deserializedObject;
            }
        }
    }
}
