// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Distribution expressions to sweep over values of model settings.
    /// &lt;example&gt;
    /// Some examples are:
    /// ```
    /// ModelName = "choice('seresnext', 'resnest50')";
    /// LearningRate = "uniform(0.001, 0.01)";
    /// LayersToFreeze = "choice(0, 2)";
    /// ```&lt;/example&gt;
    /// For more details on how to compose distribution expressions please check the documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-tune-hyperparameters
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    /// </summary>
    public partial class ImageModelDistributionSettingsClassification : ImageModelDistributionSettings
    {
        /// <summary> Initializes a new instance of ImageModelDistributionSettingsClassification. </summary>
        public ImageModelDistributionSettingsClassification()
        {
        }

        /// <summary> Initializes a new instance of ImageModelDistributionSettingsClassification. </summary>
        /// <param name="amsGradient"> Enable AMSGrad when optimizer is 'adam' or 'adamw'. </param>
        /// <param name="augmentations"> Settings for using Augmentations. </param>
        /// <param name="beta1"> Value of 'beta1' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </param>
        /// <param name="beta2"> Value of 'beta2' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1]. </param>
        /// <param name="distributed"> Whether to use distributer training. </param>
        /// <param name="earlyStopping"> Enable early stopping logic during training. </param>
        /// <param name="earlyStoppingDelay">
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </param>
        /// <param name="earlyStoppingPatience">
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </param>
        /// <param name="enableOnnxNormalization"> Enable normalization when exporting ONNX model. </param>
        /// <param name="evaluationFrequency"> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </param>
        /// <param name="gradientAccumulationStep">
        /// Gradient accumulation means running a configured number of "GradAccumulationStep" steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </param>
        /// <param name="layersToFreeze">
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for 'seresnext' means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="learningRate"> Initial learning rate. Must be a float in the range [0, 1]. </param>
        /// <param name="learningRateScheduler"> Type of learning rate scheduler. Must be 'warmup_cosine' or 'step'. </param>
        /// <param name="modelName">
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="momentum"> Value of momentum when optimizer is 'sgd'. Must be a float in the range [0, 1]. </param>
        /// <param name="nesterov"> Enable nesterov when optimizer is 'sgd'. </param>
        /// <param name="numberOfEpochs"> Number of training epochs. Must be a positive integer. </param>
        /// <param name="numberOfWorkers"> Number of data loader workers. Must be a non-negative integer. </param>
        /// <param name="optimizer"> Type of optimizer. Must be either 'sgd', 'adam', or 'adamw'. </param>
        /// <param name="randomSeed"> Random seed to be used when using deterministic training. </param>
        /// <param name="stepLRGamma"> Value of gamma when learning rate scheduler is 'step'. Must be a float in the range [0, 1]. </param>
        /// <param name="stepLRStepSize"> Value of step size when learning rate scheduler is 'step'. Must be a positive integer. </param>
        /// <param name="trainingBatchSize"> Training batch size. Must be a positive integer. </param>
        /// <param name="validationBatchSize"> Validation batch size. Must be a positive integer. </param>
        /// <param name="warmupCosineLRCycles"> Value of cosine cycle when learning rate scheduler is 'warmup_cosine'. Must be a float in the range [0, 1]. </param>
        /// <param name="warmupCosineLRWarmupEpochs"> Value of warmup epochs when learning rate scheduler is 'warmup_cosine'. Must be a positive integer. </param>
        /// <param name="weightDecay"> Value of weight decay when optimizer is 'sgd', 'adam', or 'adamw'. Must be a float in the range[0, 1]. </param>
        /// <param name="trainingCropSize"> Image crop size that is input to the neural network for the training dataset. Must be a positive integer. </param>
        /// <param name="validationCropSize"> Image crop size that is input to the neural network for the validation dataset. Must be a positive integer. </param>
        /// <param name="validationResizeSize"> Image size to which to resize before cropping for validation dataset. Must be a positive integer. </param>
        /// <param name="weightedLoss">
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </param>
        internal ImageModelDistributionSettingsClassification(string amsGradient, string augmentations, string beta1, string beta2, string distributed, string earlyStopping, string earlyStoppingDelay, string earlyStoppingPatience, string enableOnnxNormalization, string evaluationFrequency, string gradientAccumulationStep, string layersToFreeze, string learningRate, string learningRateScheduler, string modelName, string momentum, string nesterov, string numberOfEpochs, string numberOfWorkers, string optimizer, string randomSeed, string stepLRGamma, string stepLRStepSize, string trainingBatchSize, string validationBatchSize, string warmupCosineLRCycles, string warmupCosineLRWarmupEpochs, string weightDecay, string trainingCropSize, string validationCropSize, string validationResizeSize, string weightedLoss) : base(amsGradient, augmentations, beta1, beta2, distributed, earlyStopping, earlyStoppingDelay, earlyStoppingPatience, enableOnnxNormalization, evaluationFrequency, gradientAccumulationStep, layersToFreeze, learningRate, learningRateScheduler, modelName, momentum, nesterov, numberOfEpochs, numberOfWorkers, optimizer, randomSeed, stepLRGamma, stepLRStepSize, trainingBatchSize, validationBatchSize, warmupCosineLRCycles, warmupCosineLRWarmupEpochs, weightDecay)
        {
            TrainingCropSize = trainingCropSize;
            ValidationCropSize = validationCropSize;
            ValidationResizeSize = validationResizeSize;
            WeightedLoss = weightedLoss;
        }

        /// <summary> Image crop size that is input to the neural network for the training dataset. Must be a positive integer. </summary>
        public string TrainingCropSize { get; set; }
        /// <summary> Image crop size that is input to the neural network for the validation dataset. Must be a positive integer. </summary>
        public string ValidationCropSize { get; set; }
        /// <summary> Image size to which to resize before cropping for validation dataset. Must be a positive integer. </summary>
        public string ValidationResizeSize { get; set; }
        /// <summary>
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </summary>
        public string WeightedLoss { get; set; }
    }
}
