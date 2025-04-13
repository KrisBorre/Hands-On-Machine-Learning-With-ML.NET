using Microsoft.ML.Data;

namespace chapter04_multiclass.ML.Objects
{
    /// <summary>
    /// Jarred Capellman created a multi-class classification application, categorizing email into one of three categories: Orders, Spam, Friend.
    /// </summary>
    public class Email
    {
        [LoadColumn(0)]
        public string Subject { get; set; }

        [LoadColumn(1)]
        public string Body { get; set; }

        [LoadColumn(2)]
        public string Sender { get; set; }

        [LoadColumn(3)]
        public string Category { get; set; }
    }
}