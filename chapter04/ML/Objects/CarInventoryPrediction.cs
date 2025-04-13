namespace chapter04.ML.Objects
{
    public class CarInventoryPrediction
    {
        public bool Label { get; set; }

        /// <summary>
        /// This binary classification example will predict if a car's price is a good deal or not, akin to what you would find on a car purchase website.
        /// A binary classification is a two-class classification. The prediction simply return 0 or 1.
        /// </summary>
        public bool PredictedLabel { get; set; }

        public float Score { get; set; }

        public float Probability { get; set; }
    }
}