// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FaceOperations.
    /// </summary>
    public static partial class FaceOperationsExtensions
    {
            /// <summary>
            /// Given query face's faceId, to search the similar-looking faces from a
            /// faceId array, a face list or a large face list. faceId array contains the
            /// faces created by [Face - Detect With
            /// Url](https://docs.microsoft.com/rest/api/faceapi/face/detectwithurl) or
            /// [Face - Detect With
            /// Stream](https://docs.microsoft.com/rest/api/faceapi/face/detectwithstream),
            /// which will expire at the time specified by faceIdTimeToLive after creation.
            /// A "faceListId" is created by [FaceList -
            /// Create](https://docs.microsoft.com/rest/api/faceapi/facelist/create)
            /// containing persistedFaceIds that will not expire. And a "largeFaceListId"
            /// is created by [LargeFaceList -
            /// Create](https://docs.microsoft.com/rest/api/faceapi/largefacelist/create)
            /// containing persistedFaceIds that will also not expire. Depending on the
            /// input the returned similar faces list contains faceIds or persistedFaceIds
            /// ranked by similarity.
            /// &lt;br/&gt;Find similar has two working modes, "matchPerson" and
            /// "matchFace". "matchPerson" is the default mode that it tries to find faces
            /// of the same person as possible by using internal same-person thresholds. It
            /// is useful to find a known person's other photos. Note that an empty list
            /// will be returned if no faces pass the internal thresholds. "matchFace" mode
            /// ignores same-person thresholds and returns ranked similar faces anyway,
            /// even the similarity is low. It can be used in the cases like searching
            /// celebrity-looking faces.
            /// &lt;br/&gt;The 'recognitionModel' associated with the query face's faceId
            /// should be the same as the 'recognitionModel' used by the target faceId
            /// array, face list or large face list.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceId'>
            /// FaceId of the query face. User needs to call Face - Detect first to get a
            /// valid faceId. Note that this faceId is not persisted and will expire at the
            /// time specified by faceIdTimeToLive after the detection call
            /// </param>
            /// <param name='faceListId'>
            /// An existing user-specified unique candidate face list, created in Face List
            /// - Create a Face List. Face list contains a set of persistedFaceIds which
            /// are persisted and will never expire. Parameter faceListId, largeFaceListId
            /// and faceIds should not be provided at the same time.
            /// </param>
            /// <param name='largeFaceListId'>
            /// An existing user-specified unique candidate large face list, created in
            /// LargeFaceList - Create. Large face list contains a set of persistedFaceIds
            /// which are persisted and will never expire. Parameter faceListId,
            /// largeFaceListId and faceIds should not be provided at the same time.
            /// </param>
            /// <param name='faceIds'>
            /// An array of candidate faceIds. All of them are created by Face - Detect and
            /// the faceIds will expire at the time specified by faceIdTimeToLive after the
            /// detection call. The number of faceIds is limited to 1000. Parameter
            /// faceListId, largeFaceListId and faceIds should not be provided at the same
            /// time.
            /// </param>
            /// <param name='maxNumOfCandidatesReturned'>
            /// The number of top similar faces returned. The valid range is [1, 1000].
            /// </param>
            /// <param name='mode'>
            /// Similar face searching mode. It can be "matchPerson" or "matchFace".
            /// Possible values include: 'matchPerson', 'matchFace'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SimilarFace>> FindSimilarAsync(this IFaceOperations operations, System.Guid faceId, string faceListId = default(string), string largeFaceListId = default(string), IList<System.Guid?> faceIds = default(IList<System.Guid?>), int? maxNumOfCandidatesReturned = 20, FindSimilarMatchMode mode = default(FindSimilarMatchMode), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FindSimilarWithHttpMessagesAsync(faceId, faceListId, largeFaceListId, faceIds, maxNumOfCandidatesReturned, mode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Divide candidate faces into groups based on face similarity.&lt;br /&gt;
            /// * The output is one or more disjointed face groups and a messyGroup. A face
            /// group contains faces that have similar looking, often of the same person.
            /// Face groups are ranked by group size, i.e. number of faces. Notice that
            /// faces belonging to a same person might be split into several groups in the
            /// result.
            /// * MessyGroup is a special face group containing faces that cannot find any
            /// similar counterpart face from original faces. The messyGroup will not
            /// appear in the result if all faces found their counterparts.
            /// * Group API needs at least 2 candidate faces and 1000 at most. We suggest
            /// to try [Face -
            /// Verify](https://docs.microsoft.com/rest/api/faceapi/face/verifyfacetoface)
            /// when you only have 2 candidate faces.
            /// * The 'recognitionModel' associated with the query faces' faceIds should be
            /// the same.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceIds'>
            /// Array of candidate faceId created by Face - Detect. The maximum is 1000
            /// faces
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GroupResult> GroupAsync(this IFaceOperations operations, IList<System.Guid> faceIds, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GroupWithHttpMessagesAsync(faceIds, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// 1-to-many identification to find the closest matches of the specific query
            /// person face from a person group or large person group.
            /// &lt;br/&gt; For each face in the faceIds array, Face Identify will compute
            /// similarities between the query face and all the faces in the person group
            /// (given by personGroupId) or large person group (given by
            /// largePersonGroupId), and return candidate person(s) for that face ranked by
            /// similarity confidence. The person group/large person group should be
            /// trained to make it ready for identification. See more in [PersonGroup -
            /// Train](https://docs.microsoft.com/rest/api/faceapi/persongroup/train) and
            /// [LargePersonGroup -
            /// Train](https://docs.microsoft.com/rest/api/faceapi/largepersongroup/train).
            /// &lt;br/&gt;
            ///
            /// Remarks:&lt;br /&gt;
            /// * The algorithm allows more than one face to be identified independently at
            /// the same request, but no more than 10 faces.
            /// * Each person in the person group/large person group could have more than
            /// one face, but no more than 248 faces.
            /// * Higher face image quality means better identification precision. Please
            /// consider high-quality faces: frontal, clear, and face size is 200x200
            /// pixels (100 pixels between eyes) or bigger.
            /// * Number of candidates returned is restricted by maxNumOfCandidatesReturned
            /// and confidenceThreshold. If no person is identified, the returned
            /// candidates will be an empty array.
            /// * Try [Face - Find
            /// Similar](https://docs.microsoft.com/rest/api/faceapi/face/findsimilar) when
            /// you need to find similar faces from a face list/large face list instead of
            /// a person group/large person group.
            /// * The 'recognitionModel' associated with the query faces' faceIds should be
            /// the same as the 'recognitionModel' used by the target person group or large
            /// person group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceIds'>
            /// Array of query faces faceIds, created by the Face - Detect. Each of the
            /// faces are identified independently. The valid number of faceIds is between
            /// [1, 10].
            /// </param>
            /// <param name='personGroupId'>
            /// PersonGroupId of the target person group, created by PersonGroup - Create.
            /// Parameter personGroupId and largePersonGroupId should not be provided at
            /// the same time.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// LargePersonGroupId of the target large person group, created by
            /// LargePersonGroup - Create. Parameter personGroupId and largePersonGroupId
            /// should not be provided at the same time.
            /// </param>
            /// <param name='maxNumOfCandidatesReturned'>
            /// The range of maxNumOfCandidatesReturned is between 1 and 5 (default is 1).
            /// </param>
            /// <param name='confidenceThreshold'>
            /// Confidence threshold of identification, used to judge whether one face
            /// belong to one person. The range of confidenceThreshold is [0, 1] (default
            /// specified by algorithm).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<IdentifyResult>> IdentifyAsync(this IFaceOperations operations, IList<System.Guid> faceIds, string personGroupId = default(string), string largePersonGroupId = default(string), int? maxNumOfCandidatesReturned = 1, double? confidenceThreshold = default(double?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IdentifyWithHttpMessagesAsync(faceIds, personGroupId, largePersonGroupId, maxNumOfCandidatesReturned, confidenceThreshold, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Verify whether two faces belong to a same person or whether one face
            /// belongs to a person.
            /// &lt;br/&gt;
            /// Remarks:&lt;br /&gt;
            /// * Higher face image quality means better identification precision. Please
            /// consider high-quality faces: frontal, clear, and face size is 200x200
            /// pixels (100 pixels between eyes) or bigger.
            /// * For the scenarios that are sensitive to accuracy please make your own
            /// judgment.
            /// * The 'recognitionModel' associated with the query faces' faceIds should be
            /// the same as the 'recognitionModel' used by the target face, person group or
            /// large person group.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceId1'>
            /// FaceId of the first face, comes from Face - Detect
            /// </param>
            /// <param name='faceId2'>
            /// FaceId of the second face, comes from Face - Detect
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VerifyResult> VerifyFaceToFaceAsync(this IFaceOperations operations, System.Guid faceId1, System.Guid faceId2, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyFaceToFaceWithHttpMessagesAsync(faceId1, faceId2, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Detect human faces in an image, return face rectangles, and optionally with
            /// faceIds, landmarks, and attributes.&lt;br /&gt;
            /// * No image will be stored. Only the extracted face feature will be stored
            /// on server. The faceId is an identifier of the face feature and will be used
            /// in [Face -
            /// Identify](https://docs.microsoft.com/rest/api/faceapi/face/identify), [Face
            /// -
            /// Verify](https://docs.microsoft.com/rest/api/faceapi/face/verifyfacetoface),
            /// and [Face - Find
            /// Similar](https://docs.microsoft.com/rest/api/faceapi/face/findsimilar). The
            /// stored face feature(s) will expire and be deleted at the time specified by
            /// faceIdTimeToLive after the original detection call.
            /// * Optional parameters include faceId, landmarks, and attributes. Attributes
            /// include age, gender, headPose, smile, facialHair, glasses, emotion, hair,
            /// makeup, occlusion, accessories, blur, exposure, noise, and mask. Some of
            /// the results returned for specific attributes may not be highly accurate.
            /// * JPEG, PNG, GIF (the first frame), and BMP format are supported. The
            /// allowed image file size is from 1KB to 6MB.
            /// * Up to 100 faces can be returned for an image. Faces are ranked by face
            /// rectangle size from large to small.
            /// * For optimal results when querying [Face -
            /// Identify](https://docs.microsoft.com/rest/api/faceapi/face/identify), [Face
            /// -
            /// Verify](https://docs.microsoft.com/rest/api/faceapi/face/verifyfacetoface),
            /// and [Face - Find
            /// Similar](https://docs.microsoft.com/rest/api/faceapi/face/findsimilar)
            /// ('returnFaceId' is true), please use faces that are: frontal, clear, and
            /// with a minimum size of 200x200 pixels (100 pixels between eyes).
            /// * The minimum detectable face size is 36x36 pixels in an image no larger
            /// than 1920x1080 pixels. Images with dimensions higher than 1920x1080 pixels
            /// will need a proportionally larger minimum face size.
            /// * Different 'detectionModel' values can be provided. To use and compare
            /// different detection models, please refer to [How to specify a detection
            /// model](https://docs.microsoft.com/azure/cognitive-services/face/face-api-how-to-topics/specify-detection-model).
            ///
            /// * Different 'recognitionModel' values are provided. If follow-up operations
            /// like Verify, Identify, Find Similar are needed, please specify the
            /// recognition model with 'recognitionModel' parameter. The default value for
            /// 'recognitionModel' is 'recognition_01', if latest model needed, please
            /// explicitly specify the model you need in this parameter. Once specified,
            /// the detected faceIds will be associated with the specified recognition
            /// model. More details, please refer to [Specify a recognition
            /// model](https://docs.microsoft.com/azure/cognitive-services/face/face-api-how-to-topics/specify-recognition-model).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// Publicly reachable URL of an image
            /// </param>
            /// <param name='returnFaceId'>
            /// A value indicating whether the operation should return faceIds of detected
            /// faces.
            /// </param>
            /// <param name='returnFaceLandmarks'>
            /// A value indicating whether the operation should return landmarks of the
            /// detected faces.
            /// </param>
            /// <param name='returnFaceAttributes'>
            /// Analyze and return the one or more specified face attributes in the
            /// comma-separated string like "returnFaceAttributes=age,gender". The
            /// available attributes depends on the 'detectionModel' specified.
            /// 'detection_01' supports age, gender, headPose, smile, facialHair, glasses,
            /// emotion, hair, makeup, occlusion, accessories, blur, exposure, and noise.
            /// While 'detection_02' does not support any attributes and 'detection_03'
            /// only supports mask. Note that each face attribute analysis has additional
            /// computational and time cost.
            /// </param>
            /// <param name='recognitionModel'>
            /// Name of recognition model. Recognition model is used when the face features
            /// are extracted and associated with detected faceIds, (Large)FaceList or
            /// (Large)PersonGroup. A recognition model name can be provided when
            /// performing Face - Detect or (Large)FaceList - Create or (Large)PersonGroup
            /// - Create. The default value is 'recognition_01', if latest model needed,
            /// please explicitly specify the model you need. Possible values include:
            /// 'recognition_01', 'recognition_02', 'recognition_03', 'recognition_04'
            /// </param>
            /// <param name='returnRecognitionModel'>
            /// A value indicating whether the operation should return 'recognitionModel'
            /// in response.
            /// </param>
            /// <param name='detectionModel'>
            /// Name of detection model. Detection model is used to detect faces in the
            /// submitted image. A detection model name can be provided when performing
            /// Face - Detect or (Large)FaceList - Add Face or (Large)PersonGroup - Add
            /// Face. The default value is 'detection_01', if another model is needed,
            /// please explicitly specify it. Possible values include: 'detection_01',
            /// 'detection_02', 'detection_03'
            /// </param>
            /// <param name='faceIdTimeToLive'>
            /// The number of seconds for the faceId being cached. Supported range from 60
            /// seconds up to 86400 seconds. The default value is 86400 (24 hours).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DetectedFace>> DetectWithUrlAsync(this IFaceOperations operations, string url, bool? returnFaceId = true, bool? returnFaceLandmarks = false, IList<FaceAttributeType> returnFaceAttributes = default(IList<FaceAttributeType>), string recognitionModel = default(string), bool? returnRecognitionModel = false, string detectionModel = default(string), int? faceIdTimeToLive = 86400, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DetectWithUrlWithHttpMessagesAsync(url, returnFaceId, returnFaceLandmarks, returnFaceAttributes, recognitionModel, returnRecognitionModel, detectionModel, faceIdTimeToLive, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Verify whether two faces belong to a same person. Compares a face Id with a
            /// Person Id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='faceId'>
            /// FaceId of the face, comes from Face - Detect
            /// </param>
            /// <param name='personId'>
            /// Specify a certain person in a person group or a large person group.
            /// personId is created in PersonGroup Person - Create or LargePersonGroup
            /// Person - Create.
            /// </param>
            /// <param name='personGroupId'>
            /// Using existing personGroupId and personId for fast loading a specified
            /// person. personGroupId is created in PersonGroup - Create. Parameter
            /// personGroupId and largePersonGroupId should not be provided at the same
            /// time.
            /// </param>
            /// <param name='largePersonGroupId'>
            /// Using existing largePersonGroupId and personId for fast loading a specified
            /// person. largePersonGroupId is created in LargePersonGroup - Create.
            /// Parameter personGroupId and largePersonGroupId should not be provided at
            /// the same time.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VerifyResult> VerifyFaceToPersonAsync(this IFaceOperations operations, System.Guid faceId, System.Guid personId, string personGroupId = default(string), string largePersonGroupId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyFaceToPersonWithHttpMessagesAsync(faceId, personId, personGroupId, largePersonGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Detect human faces in an image, return face rectangles, and optionally with
            /// faceIds, landmarks, and attributes.&lt;br /&gt;
            /// * No image will be stored. Only the extracted face feature will be stored
            /// on server. The faceId is an identifier of the face feature and will be used
            /// in [Face -
            /// Identify](https://docs.microsoft.com/rest/api/faceapi/face/identify), [Face
            /// -
            /// Verify](https://docs.microsoft.com/rest/api/faceapi/face/verifyfacetoface),
            /// and [Face - Find
            /// Similar](https://docs.microsoft.com/rest/api/faceapi/face/findsimilar). The
            /// stored face feature(s) will expire and be deleted at the time specified by
            /// faceIdTimeToLive after the original detection call.
            /// * Optional parameters include faceId, landmarks, and attributes. Attributes
            /// include age, gender, headPose, smile, facialHair, glasses, emotion, hair,
            /// makeup, occlusion, accessories, blur, exposure, noise, and mask. Some of
            /// the results returned for specific attributes may not be highly accurate.
            /// * JPEG, PNG, GIF (the first frame), and BMP format are supported. The
            /// allowed image file size is from 1KB to 6MB.
            /// * Up to 100 faces can be returned for an image. Faces are ranked by face
            /// rectangle size from large to small.
            /// * For optimal results when querying [Face -
            /// Identify](https://docs.microsoft.com/rest/api/faceapi/face/identify), [Face
            /// -
            /// Verify](https://docs.microsoft.com/rest/api/faceapi/face/verifyfacetoface),
            /// and [Face - Find
            /// Similar](https://docs.microsoft.com/rest/api/faceapi/face/findsimilar)
            /// ('returnFaceId' is true), please use faces that are: frontal, clear, and
            /// with a minimum size of 200x200 pixels (100 pixels between eyes).
            /// * The minimum detectable face size is 36x36 pixels in an image no larger
            /// than 1920x1080 pixels. Images with dimensions higher than 1920x1080 pixels
            /// will need a proportionally larger minimum face size.
            /// * Different 'detectionModel' values can be provided. To use and compare
            /// different detection models, please refer to [How to specify a detection
            /// model](https://docs.microsoft.com/azure/cognitive-services/face/face-api-how-to-topics/specify-detection-model)
            /// * Different 'recognitionModel' values are provided. If follow-up operations
            /// like Verify, Identify, Find Similar are needed, please specify the
            /// recognition model with 'recognitionModel' parameter. The default value for
            /// 'recognitionModel' is 'recognition_01', if latest model needed, please
            /// explicitly specify the model you need in this parameter. Once specified,
            /// the detected faceIds will be associated with the specified recognition
            /// model. More details, please refer to [Specify a recognition
            /// model](https://docs.microsoft.com/azure/cognitive-services/face/face-api-how-to-topics/specify-recognition-model).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='returnFaceId'>
            /// A value indicating whether the operation should return faceIds of detected
            /// faces.
            /// </param>
            /// <param name='returnFaceLandmarks'>
            /// A value indicating whether the operation should return landmarks of the
            /// detected faces.
            /// </param>
            /// <param name='returnFaceAttributes'>
            /// Analyze and return the one or more specified face attributes in the
            /// comma-separated string like "returnFaceAttributes=age,gender". The
            /// available attributes depends on the 'detectionModel' specified.
            /// 'detection_01' supports age, gender, headPose, smile, facialHair, glasses,
            /// emotion, hair, makeup, occlusion, accessories, blur, exposure, and noise.
            /// While 'detection_02' does not support any attributes and 'detection_03'
            /// only supports mask. Note that each face attribute analysis has additional
            /// computational and time cost.
            /// </param>
            /// <param name='recognitionModel'>
            /// Name of recognition model. Recognition model is used when the face features
            /// are extracted and associated with detected faceIds, (Large)FaceList or
            /// (Large)PersonGroup. A recognition model name can be provided when
            /// performing Face - Detect or (Large)FaceList - Create or (Large)PersonGroup
            /// - Create. The default value is 'recognition_01', if latest model needed,
            /// please explicitly specify the model you need. Possible values include:
            /// 'recognition_01', 'recognition_02', 'recognition_03', 'recognition_04'
            /// </param>
            /// <param name='returnRecognitionModel'>
            /// A value indicating whether the operation should return 'recognitionModel'
            /// in response.
            /// </param>
            /// <param name='detectionModel'>
            /// Name of detection model. Detection model is used to detect faces in the
            /// submitted image. A detection model name can be provided when performing
            /// Face - Detect or (Large)FaceList - Add Face or (Large)PersonGroup - Add
            /// Face. The default value is 'detection_01', if another model is needed,
            /// please explicitly specify it. Possible values include: 'detection_01',
            /// 'detection_02', 'detection_03'
            /// </param>
            /// <param name='faceIdTimeToLive'>
            /// The number of seconds for the faceId being cached. Supported range from 60
            /// seconds up to 86400 seconds. The default value is 86400 (24 hours).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DetectedFace>> DetectWithStreamAsync(this IFaceOperations operations, Stream image, bool? returnFaceId = true, bool? returnFaceLandmarks = false, IList<FaceAttributeType> returnFaceAttributes = default(IList<FaceAttributeType>), string recognitionModel = default(string), bool? returnRecognitionModel = false, string detectionModel = default(string), int? faceIdTimeToLive = 86400, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DetectWithStreamWithHttpMessagesAsync(image, returnFaceId, returnFaceLandmarks, returnFaceAttributes, recognitionModel, returnRecognitionModel, detectionModel, faceIdTimeToLive, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
