using Microsoft.ML.Data;

namespace chapter04.ML.Objects
{
    public class CarInventory
    {
        [LoadColumn(0)]
        public float HasSunroof { get; set; }

        [LoadColumn(1)]
        public float HasAC { get; set; }

        [LoadColumn(2)]
        public float HasAutomaticTransmission { get; set; }

        [LoadColumn(3)]
        public float Amount { get; set; }

        // This binary classification example will predict if a car's price is a good deal or not, akin to what you would find on a car purchase website.
        // A binary classification is a two-class classification. The prediction simply return 0 or 1.
        [LoadColumn(4)]
        public bool Label { get; set; }
    }
}