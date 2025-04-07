using Microsoft.ML.Data;

namespace chapter03_6Apr2025.ML.Objects
{
    public class EmploymentHistoryPrediction
    {
        [ColumnName("Score")]
        public float DurationInMonths;
    }
}