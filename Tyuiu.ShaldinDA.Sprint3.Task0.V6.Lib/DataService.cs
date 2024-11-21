using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShaldinDA.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = 1 / Math.Pow(Math.Cos(5) + 1, 2);
                product *= term;
            }
            return product;
        }
    }
}
