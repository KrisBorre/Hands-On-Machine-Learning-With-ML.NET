using System;

using chapter02.ML;

namespace chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            new Trainer().Train("..\\..\\..\\..\\chapter02\\Data\\sampledata.csv");
            new Predictor().Predict("Friendly staff");


            /*
Area Under Curve: 100,00%
Area Under Precision Recall Curve: 100,00%
Accuracy: 100,00%
F1Score: 100,00%
Positive Recall: 1
Negative Recall: 1

Based on "Friendly staff", the feedback is predicted to be:
Positive at a 11% confidence
             
             */
        }
    }
}