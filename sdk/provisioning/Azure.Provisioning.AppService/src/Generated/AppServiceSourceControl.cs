// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// AppServiceSourceControl.
/// </summary>
public partial class AppServiceSourceControl : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// OAuth token expiration.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOn { get => _expireOn; set => _expireOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _expireOn;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// OAuth refresh token.
    /// </summary>
    public BicepValue<string> RefreshToken { get => _refreshToken; set => _refreshToken.Assign(value); }
    private readonly BicepValue<string> _refreshToken;

    /// <summary>
    /// OAuth access token.
    /// </summary>
    public BicepValue<string> Token { get => _token; set => _token.Assign(value); }
    private readonly BicepValue<string> _token;

    /// <summary>
    /// OAuth access token secret.
    /// </summary>
    public BicepValue<string> TokenSecret { get => _tokenSecret; set => _tokenSecret.Assign(value); }
    private readonly BicepValue<string> _tokenSecret;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new AppServiceSourceControl.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceSourceControl resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceSourceControl.</param>
    public AppServiceSourceControl(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/sourcecontrols", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _expireOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOn", ["properties", "expirationTime"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _refreshToken = BicepValue<string>.DefineProperty(this, "RefreshToken", ["properties", "refreshToken"]);
        _token = BicepValue<string>.DefineProperty(this, "Token", ["properties", "token"]);
        _tokenSecret = BicepValue<string>.DefineProperty(this, "TokenSecret", ["properties", "tokenSecret"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported AppServiceSourceControl resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppServiceSourceControl.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppServiceSourceControl resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppServiceSourceControl.</param>
    /// <returns>The existing AppServiceSourceControl resource.</returns>
    public static AppServiceSourceControl FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
