using System;
using System.IO;

using chapter04_multiclass.ML.Base;
using chapter04_multiclass.ML.Objects;

using Microsoft.ML;

using Newtonsoft.Json;

namespace chapter04_multiclass.ML
{
    public class Predictor : BaseML
    {
        public void Predict(string inputDataFile)
        {
            if (!File.Exists(ModelPath))
            {
                Console.WriteLine($"Failed to find model at {ModelPath}");

                return;
            }

            if (!File.Exists(inputDataFile))
            {
                Console.WriteLine($"Failed to find input data at {inputDataFile}");

                return;
            }

            ITransformer mlModel;

            using (var stream = new FileStream(ModelPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                mlModel = MlContext.Model.Load(stream, out _);
            }

            if (mlModel == null)
            {
                Console.WriteLine("Failed to load model");

                return;
            }

            PredictionEngine<Email, EmailPrediction> predictionEngine = MlContext.Model.CreatePredictionEngine<Email, EmailPrediction>(mlModel);

            string json = File.ReadAllText(inputDataFile);

            EmailPrediction prediction = predictionEngine.Predict(JsonConvert.DeserializeObject<Email>(json));

            Console.WriteLine(
                                $"Based on input json:{Environment.NewLine}" +
                                $"{json}{Environment.NewLine}" +
                                $"The email is predicted to be a {prediction.Category}");
        }
    }
}