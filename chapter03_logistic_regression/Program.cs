using System;

using chapter03_logistic_regression.ML;

namespace chapter03_logistic_regression
{
    class Program
    {
        static void Main(string[] args)
        {
            // The logistic regression application will perform basic static file analysis on a file to determine whether it is malicious or benign.
            // We are looking for a Boolean (that is, 0 or 1) value, so logistic regression models should be used in this file classification application.
            
            if (args.Length != 2)
            {
                Console.WriteLine($"Invalid arguments passed in, exiting.{Environment.NewLine}{Environment.NewLine}Usage:{Environment.NewLine}" +
                                  $"predict <path to input file>{Environment.NewLine}" +
                                  $"or {Environment.NewLine}" +
                                  $"train <path to training data file>{Environment.NewLine}" +
                                  $"or {Environment.NewLine}" +
                                  $"extract <path to folder>{Environment.NewLine}");

                return;
            }

            switch (args[0])
            {
                case "extract":
                    new FeatureExtractor().Extract(args[1]);
                    break;
                case "predict":
                    new Predictor().Predict(args[1]);
                    break;
                case "train":
                    new Trainer().Train(args[1]);
                    break;
                default:
                    Console.WriteLine($"{args[0]} is an invalid option");
                    break;
            }
        }
    }
}