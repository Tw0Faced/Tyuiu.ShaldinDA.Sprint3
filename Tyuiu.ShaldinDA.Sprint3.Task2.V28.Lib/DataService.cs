﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShaldinDA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1.0;
            int k = startValue;
            do
            {
                p *= Math.Pow(2, k) / (k + 1) * Math.Cos(1.8);
                k++;
            }
            while (k <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
