// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningNotebookResourceInfoOperationSource : Core.IOperationSource<MachineLearningNotebookResourceInfo>
    {
        MachineLearningNotebookResourceInfo Core.IOperationSource<MachineLearningNotebookResourceInfo>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return MachineLearningNotebookResourceInfo.DeserializeMachineLearningNotebookResourceInfo(document.RootElement);
        }

        async ValueTask<MachineLearningNotebookResourceInfo> Core.IOperationSource<MachineLearningNotebookResourceInfo>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return MachineLearningNotebookResourceInfo.DeserializeMachineLearningNotebookResourceInfo(document.RootElement);
        }
    }
}
