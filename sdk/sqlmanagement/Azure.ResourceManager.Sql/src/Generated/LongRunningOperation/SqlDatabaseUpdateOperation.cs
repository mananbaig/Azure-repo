// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Updates an existing database. </summary>
    public partial class SqlDatabaseUpdateOperation : Operation<SqlDatabase>, IOperationSource<SqlDatabase>
    {
        private readonly OperationInternals<SqlDatabase> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SqlDatabaseUpdateOperation for mocking. </summary>
        protected SqlDatabaseUpdateOperation()
        {
        }

        internal SqlDatabaseUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SqlDatabase>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlDatabaseUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SqlDatabase Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlDatabase>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlDatabase>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SqlDatabase IOperationSource<SqlDatabase>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlDatabaseData.DeserializeSqlDatabaseData(document.RootElement);
            return new SqlDatabase(_armClient, data);
        }

        async ValueTask<SqlDatabase> IOperationSource<SqlDatabase>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlDatabaseData.DeserializeSqlDatabaseData(document.RootElement);
            return new SqlDatabase(_armClient, data);
        }
    }
}
