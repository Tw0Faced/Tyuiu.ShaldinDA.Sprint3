﻿using System.Runtime.InteropServices;
using Tyuiu.ShaldinDA.Sprint3.Task7.V15.Lib;

namespace Tyuiu.ShaldinDA.Sprint3.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = startValue - stopValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 0.96;
            valueWaitArray[1] = 0.76;
            valueWaitArray[2] = -0.14;
            valueWaitArray[3] = -0.91;
            valueWaitArray[4] = -0.84;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 0.84;
            valueWaitArray[7] = 0.91;
            valueWaitArray[8] = 0.14;
            valueWaitArray[9] = -0.76;
            valueWaitArray[10] = -0.96;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
            
        }
    }
}