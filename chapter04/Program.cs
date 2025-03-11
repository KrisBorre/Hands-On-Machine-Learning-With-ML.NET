using System;

using chapter04.ML;

namespace chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine($"Invalid arguments passed in, exiting.{Environment.NewLine}{Environment.NewLine}Usage:{Environment.NewLine}" +
                                  $"predict <path to input json file>{Environment.NewLine}" +
                                  $"or {Environment.NewLine}" +
                                  $"train <path to training data file> <path to test data file>{Environment.NewLine}");

                return;
            }

            switch (args[0])
            {
                case "predict":
                    new Predictor().Predict(args[1]);
                    break;
                case "train":
                    new Trainer().Train(args[1], args[2]);

                    /*
Accuracy: 88,89%
Area Under Curve: 100,00%
Area under Precision recall Curve: 100,00%
F1Score: 87,50%
LogLoss: 2,19
LogLossReduction: -1,19
PositivePrecision: 1
PositiveRecall: ,78
NegativePrecision: ,82
NegativeRecall: 100,00%
                     */


                    break;
                default:
                    Console.WriteLine($"{args[0]} is an invalid option");
                    break;
            }
        }
    }
}