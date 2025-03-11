using chapter08.ML;
using chapter08.Objects;

namespace chapter08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arguments = new ProgramArguments();

            new Trainer().Train(arguments);
            new Predictor().Predict(arguments);

            /*
Wrote model to chapter8.mdl
Given a stock price of $101, the next 5 values are predicted to be: $128, $925, $140, $145, $1057
Given a stock price of $102, the next 5 values are predicted to be: $924, $138, $136, $1057, $158
Given a stock price of $300, the next 5 values are predicted to be: $136, $134, $852, $156, $150
Given a stock price of $40, the next 5 values are predicted to be: $133, $795, $122, $149, $864
Given a stock price of $30, the next 5 values are predicted to be: $767, $111, $114, $837, $122
Given a stock price of $400, the next 5 values are predicted to be: $105, $102, $676, $116, $108
Given a stock price of $55, the next 5 values are predicted to be: $97, $594, $91, $103, $645
Given a stock price of $69, the next 5 values are predicted to be: $557, $81, $87, $605, $90
Given a stock price of $430, the next 5 values are predicted to be: $76, $78, $515, $84, $85
             */

        }
    }
}