using Microsoft.ML.Data;

namespace chapter04_multiclass.ML.Objects
{
    public class EmailPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Category;
    }
}