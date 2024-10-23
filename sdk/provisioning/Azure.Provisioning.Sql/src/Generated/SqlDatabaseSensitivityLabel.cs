// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlDatabaseSensitivityLabel.
/// </summary>
public partial class SqlDatabaseSensitivityLabel : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The information type.
    /// </summary>
    public BicepValue<string> InformationType { get => _informationType; set => _informationType.Assign(value); }
    private readonly BicepValue<string> _informationType;

    /// <summary>
    /// The information type ID.
    /// </summary>
    public BicepValue<string> InformationTypeId { get => _informationTypeId; set => _informationTypeId.Assign(value); }
    private readonly BicepValue<string> _informationTypeId;

    /// <summary>
    /// The label ID.
    /// </summary>
    public BicepValue<string> LabelId { get => _labelId; set => _labelId.Assign(value); }
    private readonly BicepValue<string> _labelId;

    /// <summary>
    /// The label name.
    /// </summary>
    public BicepValue<string> LabelName { get => _labelName; set => _labelName.Assign(value); }
    private readonly BicepValue<string> _labelName;

    /// <summary>
    /// Gets or sets the rank.
    /// </summary>
    public BicepValue<SensitivityLabelRank> Rank { get => _rank; set => _rank.Assign(value); }
    private readonly BicepValue<SensitivityLabelRank> _rank;

    /// <summary>
    /// The column name.
    /// </summary>
    public BicepValue<string> ColumnName { get => _columnName; }
    private readonly BicepValue<string> _columnName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Is sensitivity recommendation disabled. Applicable for recommended
    /// sensitivity label only. Specifies whether the sensitivity
    /// recommendation on this column is disabled (dismissed) or not.
    /// </summary>
    public BicepValue<bool> IsDisabled { get => _isDisabled; }
    private readonly BicepValue<bool> _isDisabled;

    /// <summary>
    /// Resource that manages the sensitivity label.
    /// </summary>
    public BicepValue<string> ManagedBy { get => _managedBy; }
    private readonly BicepValue<string> _managedBy;

    /// <summary>
    /// The schema name.
    /// </summary>
    public BicepValue<string> SchemaName { get => _schemaName; }
    private readonly BicepValue<string> _schemaName;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The table name.
    /// </summary>
    public BicepValue<string> TableName { get => _tableName; }
    private readonly BicepValue<string> _tableName;

    /// <summary>
    /// Creates a new SqlDatabaseSensitivityLabel.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlDatabaseSensitivityLabel
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlDatabaseSensitivityLabel.</param>
    public SqlDatabaseSensitivityLabel(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/schemas/tables/columns/sensitivityLabels", resourceVersion)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _informationType = BicepValue<string>.DefineProperty(this, "InformationType", ["properties", "informationType"]);
        _informationTypeId = BicepValue<string>.DefineProperty(this, "InformationTypeId", ["properties", "informationTypeId"]);
        _labelId = BicepValue<string>.DefineProperty(this, "LabelId", ["properties", "labelId"]);
        _labelName = BicepValue<string>.DefineProperty(this, "LabelName", ["properties", "labelName"]);
        _rank = BicepValue<SensitivityLabelRank>.DefineProperty(this, "Rank", ["properties", "rank"]);
        _columnName = BicepValue<string>.DefineProperty(this, "ColumnName", ["properties", "columnName"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _isDisabled = BicepValue<bool>.DefineProperty(this, "IsDisabled", ["properties", "isDisabled"], isOutput: true);
        _managedBy = BicepValue<string>.DefineProperty(this, "ManagedBy", ["managedBy"], isOutput: true);
        _schemaName = BicepValue<string>.DefineProperty(this, "SchemaName", ["properties", "schemaName"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _tableName = BicepValue<string>.DefineProperty(this, "TableName", ["properties", "tableName"], isOutput: true);
    }

    /// <summary>
    /// Creates a reference to an existing SqlDatabaseSensitivityLabel.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SqlDatabaseSensitivityLabel
    /// resource.  This can be used to refer to the resource in expressions,
    /// but is not the Azure name of the resource.  This value can contain
    /// letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SqlDatabaseSensitivityLabel.</param>
    /// <returns>The existing SqlDatabaseSensitivityLabel resource.</returns>
    public static SqlDatabaseSensitivityLabel FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
