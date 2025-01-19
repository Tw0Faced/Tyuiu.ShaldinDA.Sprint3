﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShaldinDA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Sin(x) + (2.0 / k);
                }
            }
            return Math.Round(sum, 3);
        }
    }
}
