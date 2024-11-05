// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteFunction.
/// </summary>
public partial class SiteFunction : ProvisionableResource
{
    /// <summary>
    /// Function name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Config information.                          To assign an object to
    /// this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Config 
    {
        get { Initialize(); return _config!; }
        set { Initialize(); _config!.Assign(value); }
    }
    private BicepValue<BinaryData>? _config;

    /// <summary>
    /// Config URI.
    /// </summary>
    public BicepValue<string> ConfigHref 
    {
        get { Initialize(); return _configHref!; }
        set { Initialize(); _configHref!.Assign(value); }
    }
    private BicepValue<string>? _configHref;

    /// <summary>
    /// File list.
    /// </summary>
    public BicepDictionary<string> Files 
    {
        get { Initialize(); return _files!; }
        set { Initialize(); _files!.Assign(value); }
    }
    private BicepDictionary<string>? _files;

    /// <summary>
    /// Function App ID.
    /// </summary>
    public BicepValue<string> FunctionAppId 
    {
        get { Initialize(); return _functionAppId!; }
        set { Initialize(); _functionAppId!.Assign(value); }
    }
    private BicepValue<string>? _functionAppId;

    /// <summary>
    /// Function URI.
    /// </summary>
    public BicepValue<string> Href 
    {
        get { Initialize(); return _href!; }
        set { Initialize(); _href!.Assign(value); }
    }
    private BicepValue<string>? _href;

    /// <summary>
    /// The invocation URL.
    /// </summary>
    public BicepValue<string> InvokeUrlTemplate 
    {
        get { Initialize(); return _invokeUrlTemplate!; }
        set { Initialize(); _invokeUrlTemplate!.Assign(value); }
    }
    private BicepValue<string>? _invokeUrlTemplate;

    /// <summary>
    /// Gets or sets a value indicating whether the function is disabled.
    /// </summary>
    public BicepValue<bool> IsDisabled 
    {
        get { Initialize(); return _isDisabled!; }
        set { Initialize(); _isDisabled!.Assign(value); }
    }
    private BicepValue<bool>? _isDisabled;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// The function language.
    /// </summary>
    public BicepValue<string> Language 
    {
        get { Initialize(); return _language!; }
        set { Initialize(); _language!.Assign(value); }
    }
    private BicepValue<string>? _language;

    /// <summary>
    /// Script URI.
    /// </summary>
    public BicepValue<string> ScriptHref 
    {
        get { Initialize(); return _scriptHref!; }
        set { Initialize(); _scriptHref!.Assign(value); }
    }
    private BicepValue<string>? _scriptHref;

    /// <summary>
    /// Script root path URI.
    /// </summary>
    public BicepValue<string> ScriptRootPathHref 
    {
        get { Initialize(); return _scriptRootPathHref!; }
        set { Initialize(); _scriptRootPathHref!.Assign(value); }
    }
    private BicepValue<string>? _scriptRootPathHref;

    /// <summary>
    /// Secrets file URI.
    /// </summary>
    public BicepValue<string> SecretsFileHref 
    {
        get { Initialize(); return _secretsFileHref!; }
        set { Initialize(); _secretsFileHref!.Assign(value); }
    }
    private BicepValue<string>? _secretsFileHref;

    /// <summary>
    /// Test data used when testing via the Azure Portal.
    /// </summary>
    public BicepValue<string> TestData 
    {
        get { Initialize(); return _testData!; }
        set { Initialize(); _testData!.Assign(value); }
    }
    private BicepValue<string>? _testData;

    /// <summary>
    /// Test data URI.
    /// </summary>
    public BicepValue<string> TestDataHref 
    {
        get { Initialize(); return _testDataHref!; }
        set { Initialize(); _testDataHref!.Assign(value); }
    }
    private BicepValue<string>? _testDataHref;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WebSite.
    /// </summary>
    public WebSite? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<WebSite>? _parent;

    /// <summary>
    /// Creates a new SiteFunction.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SiteFunction resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteFunction.</param>
    public SiteFunction(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Web/sites/functions", resourceVersion ?? "2024-04-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SiteFunction.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _config = DefineProperty<BinaryData>("Config", ["properties", "config"]);
        _configHref = DefineProperty<string>("ConfigHref", ["properties", "config_href"]);
        _files = DefineDictionaryProperty<string>("Files", ["properties", "files"]);
        _functionAppId = DefineProperty<string>("FunctionAppId", ["properties", "function_app_id"]);
        _href = DefineProperty<string>("Href", ["properties", "href"]);
        _invokeUrlTemplate = DefineProperty<string>("InvokeUrlTemplate", ["properties", "invoke_url_template"]);
        _isDisabled = DefineProperty<bool>("IsDisabled", ["properties", "isDisabled"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _language = DefineProperty<string>("Language", ["properties", "language"]);
        _scriptHref = DefineProperty<string>("ScriptHref", ["properties", "script_href"]);
        _scriptRootPathHref = DefineProperty<string>("ScriptRootPathHref", ["properties", "script_root_path_href"]);
        _secretsFileHref = DefineProperty<string>("SecretsFileHref", ["properties", "secrets_file_href"]);
        _testData = DefineProperty<string>("TestData", ["properties", "test_data"]);
        _testDataHref = DefineProperty<string>("TestDataHref", ["properties", "test_data_href"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<WebSite>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SiteFunction resource versions.
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
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-08-01.
        /// </summary>
        public static readonly string V2016_08_01 = "2016-08-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

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
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";

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
    /// Creates a reference to an existing SiteFunction.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SiteFunction resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SiteFunction.</param>
    /// <returns>The existing SiteFunction resource.</returns>
    public static SiteFunction FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
