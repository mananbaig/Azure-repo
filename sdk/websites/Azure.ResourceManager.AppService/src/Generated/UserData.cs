// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the User data model. </summary>
    public partial class UserData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of UserData. </summary>
        public UserData()
        {
        }

        /// <summary> Initializes a new instance of UserData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="publishingUserName"> Username used for publishing. </param>
        /// <param name="publishingPassword"> Password used for publishing. </param>
        /// <param name="publishingPasswordHash"> Password hash used for publishing. </param>
        /// <param name="publishingPasswordHashSalt"> Password hash salt used for publishing. </param>
        /// <param name="scmUri"> Url of SCM site. </param>
        internal UserData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string publishingUserName, string publishingPassword, string publishingPasswordHash, string publishingPasswordHashSalt, string scmUri) : base(id, name, resourceType, systemData, kind)
        {
            PublishingUserName = publishingUserName;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
            ScmUri = scmUri;
        }

        /// <summary> Username used for publishing. </summary>
        public string PublishingUserName { get; set; }
        /// <summary> Password used for publishing. </summary>
        public string PublishingPassword { get; set; }
        /// <summary> Password hash used for publishing. </summary>
        public string PublishingPasswordHash { get; set; }
        /// <summary> Password hash salt used for publishing. </summary>
        public string PublishingPasswordHashSalt { get; set; }
        /// <summary> Url of SCM site. </summary>
        public string ScmUri { get; set; }
    }
}
