using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShaldinDA.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            if (startValue > stopValue || value <= 0)
            
                throw new ArgumentException();

                double result = 1;
                int k = startValue;

                while (k <= stopValue)
                {
                    result *= Math.Pow(1.0 / (value * k), -1);
                    k++;
                }
            return Math.Round(result, 3);
        }
    }
}
