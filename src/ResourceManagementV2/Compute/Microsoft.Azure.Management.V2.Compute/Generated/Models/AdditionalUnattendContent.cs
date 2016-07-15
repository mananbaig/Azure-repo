// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// additional XML formatted information that can be included in the
    /// Unattend.xml file, which is used by Windows Setup. Contents are
    /// defined by setting name, component name, and the pass in which the
    /// content is a applied.
    /// </summary>
    public partial class AdditionalUnattendContent
    {
        /// <summary>
        /// Initializes a new instance of the AdditionalUnattendContent class.
        /// </summary>
        public AdditionalUnattendContent() { }

        /// <summary>
        /// Initializes a new instance of the AdditionalUnattendContent class.
        /// </summary>
        /// <param name="passName">the pass name. Currently, the only
        /// allowable value is oobeSystem. Possible values include:
        /// 'oobeSystem'</param>
        /// <param name="componentName">the component name. Currently, the
        /// only allowable value is Microsoft-Windows-Shell-Setup. Possible
        /// values include: 'Microsoft-Windows-Shell-Setup'</param>
        /// <param name="settingName">setting name (e.g. FirstLogonCommands,
        /// AutoLogon ). Possible values include: 'AutoLogon',
        /// 'FirstLogonCommands'</param>
        /// <param name="content">XML formatted content that is added to the
        /// unattend.xml file in the specified pass and component.The XML
        /// must be less than 4 KB and must include the root element for the
        /// setting or feature that is being inserted.</param>
        public AdditionalUnattendContent(PassNames? passName = default(PassNames?), ComponentNames? componentName = default(ComponentNames?), SettingNames? settingName = default(SettingNames?), string content = default(string))
        {
            PassName = passName;
            ComponentName = componentName;
            SettingName = settingName;
            Content = content;
        }

        /// <summary>
        /// Gets or sets the pass name. Currently, the only allowable value is
        /// oobeSystem. Possible values include: 'oobeSystem'
        /// </summary>
        [JsonProperty(PropertyName = "passName")]
        public PassNames? PassName { get; set; }

        /// <summary>
        /// Gets or sets the component name. Currently, the only allowable
        /// value is Microsoft-Windows-Shell-Setup. Possible values include:
        /// 'Microsoft-Windows-Shell-Setup'
        /// </summary>
        [JsonProperty(PropertyName = "componentName")]
        public ComponentNames? ComponentName { get; set; }

        /// <summary>
        /// Gets or sets setting name (e.g. FirstLogonCommands, AutoLogon ).
        /// Possible values include: 'AutoLogon', 'FirstLogonCommands'
        /// </summary>
        [JsonProperty(PropertyName = "settingName")]
        public SettingNames? SettingName { get; set; }

        /// <summary>
        /// Gets or sets XML formatted content that is added to the
        /// unattend.xml file in the specified pass and component.The XML
        /// must be less than 4 KB and must include the root element for the
        /// setting or feature that is being inserted.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

    }
}
