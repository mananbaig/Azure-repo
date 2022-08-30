// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents message sent to a UserSession. </summary>
    public partial class UserSessionMessage
    {
        /// <summary> Initializes a new instance of UserSessionMessage. </summary>
        public UserSessionMessage()
        {
        }

        /// <summary> Title of message. </summary>
        public string MessageTitle { get; set; }
        /// <summary> Body of message. </summary>
        public string MessageBody { get; set; }
    }
}
