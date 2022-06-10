﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    [CodeGenModel("ContentType1")]
    internal enum ContentType1
    {
        /// <summary> Content Type &apos;application/octet-stream&apos;. </summary>
        ApplicationOctetStream,
        /// <summary> Content Type &apos;application/pdf&apos;. </summary>
        ApplicationPdf,
        /// <summary> Content Type &apos;image/bmp&apos;. </summary>
        ImageBmp,
        /// <summary> Content Type &apos;image/heif&apos;. </summary>
        ImageHeif,
        /// <summary> Content Type &apos;image/jpeg&apos;. </summary>
        ImageJpeg,
        /// <summary> Content Type &apos;image/png&apos;. </summary>
        ImagePng,
        /// <summary> Content Type &apos;image/tiff&apos;. </summary>
        ImageTiff,
        /// <summary> Content Type &apos;application/vnd.openxmlformats-officedocument.presentationml.presentation&apos;. </summary>
        ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation,
        /// <summary> Content Type &apos;application/vnd.openxmlformats-officedocument.spreadsheetml.sheet&apos;. </summary>
        ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet,
        /// <summary> Content Type &apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&apos;. </summary>
        ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument
    }
}
