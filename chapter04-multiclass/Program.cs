using System;

using chapter04_multiclass.ML;

namespace chapter04_multiclass
{
    /// <summary>
    /// Jarred Capellman build two ML.NET applications: the first, a binary classification example that will predict if a car's price is a good deal or not, akin to what you would find on a car purchase website; 
    /// the other application, a multi-class classification application that categorizes emails.
    /// Jarred Capellman created a multi-class classification application, categorizing email into one of three categories: Orders, Spam, Friend.
    /// </summary>
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
                    break;
                default:
                    Console.WriteLine($"{args[0]} is an invalid option");
                    break;
            }
        }
    }
}