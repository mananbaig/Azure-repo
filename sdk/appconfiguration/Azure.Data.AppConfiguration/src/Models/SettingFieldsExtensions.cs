﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Data.AppConfiguration
{
    internal static class SettingFieldsExtensions
    {
        /// <summary>
        /// Maps a SettingFields member to its corresponding service name in accordance with the REST API specification.
        /// </summary>
        private static readonly IReadOnlyDictionary<SettingFields, string> s_serviceNameMap = new Dictionary<SettingFields, string>()
        {
            { SettingFields.Key         , "key"           },
            { SettingFields.Label       , "label"         },
            { SettingFields.Value       , "value"         },
            { SettingFields.ContentType , "content_type"  },
            { SettingFields.ETag        , "etag"          },
            { SettingFields.LastModified, "last_modified" },
            { SettingFields.IsReadOnly  , "locked"        },
            { SettingFields.Tags        , "tags"          }
        };

        public static IEnumerable<string> Split(this SettingFields fields)
        {
            if (fields == SettingFields.All)
            {
                return null;
            }

            var splitFields = new List<string>();

            foreach (SettingFields currentField in s_serviceNameMap.Keys)
            {
                if ((fields & currentField) == currentField)
                {
                    splitFields.Add(s_serviceNameMap[currentField]);
                }
            }

            return splitFields;
        }
    }
}
