using System;

using chapter07.ML;

namespace chapter07
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine($"Invalid arguments passed in, exiting.{Environment.NewLine}{Environment.NewLine}Usage:{Environment.NewLine}" +
                                  $"predict <path to input file>{Environment.NewLine}" +
                                  $"or {Environment.NewLine}" +
                                  $"train <path to training data file> <path to test data file>{Environment.NewLine}" +
                                  $"or {Environment.NewLine}" + $"extract <path to training folder> <path to test folder>{Environment.NewLine}");

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
Warning: insufficient blocks may slow down the trainingprocess (4*nr_threads^2+1 blocks is suggested)
Warning: insufficient blocks may slow down the trainingprocess (4*nr_threads^2+1 blocks is suggested)
iter      tr_rmse          obj
   0       2.4096   9.5560e+01
   1       1.9580   6.5588e+01
   2       1.4880   4.1165e+01
   3       1.3162   3.3845e+01
   4       1.2539   3.1284e+01
   5       1.2212   3.0190e+01
   6       1.1589   2.7868e+01
   7       1.0625   2.4804e+01
   8       0.9965   2.2935e+01
   9       0.9020   2.0162e+01
  10       0.8303   1.8547e+01
  11       0.7520   1.6671e+01
  12       0.6824   1.5312e+01
  13       0.6086   1.3934e+01
  14       0.5790   1.3597e+01
  15       0.5233   1.2647e+01
  16       0.4929   1.2295e+01
  17       0.4504   1.1724e+01
  18       0.4366   1.1688e+01
  19       0.4192   1.1531e+01
Model saved to C:\Users\kris_\source\repos\Hands-On-Machine-Learning-With-ML.NET\chapter07\bin\Debug\netcoreapp3.0\chapter7.mdl

Matrix Factorization Evaluation:

Loss Function: 0,111
Mean Absolute Error: 0,253
Mean Squared Error: 0,111
R Squared: 0,939
Root Mean Squared Error: 0,333

                     */

                    break;
                default:
                    Console.WriteLine($"{args[0]} is an invalid option");
                    break;
            }
        }
    }
}