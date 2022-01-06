using System.Linq;

namespace InterviewSolution
{
    /// <summary>
    /// вспомогательные функции
    /// </summary>   
    internal class Utilities
    {         
        /// <summary>
        /// возвращает максимальную сторону из трех
        /// </summary>
        internal static double Max(double x, double y, double z)
        {
            var values = new double[] { x, y, z };

            return values.Max();
        }


        /// <summary>
        /// возвращает сумму квадратов трех сторон БЕЗ максимальной
        /// </summary>
        internal static double SumWithoutMaxElement(double x, double y, double z)
        {
            var values = new double[] { x, y, z };

            var maxValue = values.Max();

            double remainingSidesSum = 0;
            for (int i = 0; i < 3; i++)
            {
                if (values[i] == maxValue)
                    continue;

                remainingSidesSum += values[i] * values[i];
            }

            return remainingSidesSum;
        }
    }
}
