using Microsoft.ML.Data;

namespace chapter04_multiclass.ML.Objects
{
    public class EmailPrediction
    {
        // This multi-class classification application categorizes email into one of three categories: Orders, Spam, Friend.
        [ColumnName("PredictedLabel")]
        public string Category;
    }
}