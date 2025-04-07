using chapter03_6Apr2025.ML;

namespace chapter03_6Apr2025
{
    class Program
    {
        static void Main(string[] args)
        {
            // The linear regression application will predict employee attrition based on various employee attributes.
            // Given a set of attributes tied to an employee, we can predict how long they will remain at their current job.
            // We predict a singular numeric output based on several (numeric) attributes.

            Trainer trainer = new Trainer();
            // train <path to training data file>
            trainer.Train(trainingFileName: "..\\..\\..\\..\\chapter03_6Apr2025\\Data\\sampledata.csv");

            /*
            Loss Function: 333,7
            Mean Absolute Error: 14,98
            Mean Squared Error: 333,7
            RSquared: 0,08
            Root Mean Squared Error: 18,27
             */

            Predictor predictor = new Predictor();
            // predict <path to input json file>
            predictor.Predict(inputDataFile: "");


            Console.ReadLine();
        }
    }
}