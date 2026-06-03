using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Soil_Sensor_Dashboard
{
    internal class DataProcessor
    {
        private static DataProcessor instance;
        private DataProcessor()
        {
            // init if need
        }
        public static DataProcessor GetInstance()
        {
            // create if no instance
            return instance ??= new DataProcessor();
        }
        public void SortByTimestamp(List<SensorData> list)
        {
            list = list.OrderByDescending(x => x.CreateTime).ToList();
        }
        public int BinarySearchByTimestamp(List<SensorData> data, DateTime TargetTime, bool isFirst)
        {
            int Low = 0;
            int High = data.Count -1;
            int resultIdx = -1; 
            while (Low < High)
            {
                int Mid = (Low + High) / 2;
                if (TargetTime.Date == data[Mid].CreateTime.Date)
                {
                    int step = -1;
                    if (!isFirst) step = 1;
                    while (Mid+step < data.Count && Mid+step >= 0 && data[Mid].CreateTime.Date == data[Mid + 1].CreateTime.Date)
                    {
                        Mid += step;
                    }
                    resultIdx = Mid - step;
                    resultIdx = (resultIdx < 0 ? 0 : resultIdx);
                    resultIdx = (resultIdx >= data.Count ? data.Count-1 : resultIdx);
                    return resultIdx;
                } else if (TargetTime.Date < data[Mid].CreateTime)
                {
                    Low = Mid;
                } else
                {
                    High = Mid;
                }
            }
            return resultIdx;
        }
        public List<SensorData> FileterByTimestampRange(List<SensorData> data, DateTime starttime, DateTime endtime)
        {
            SortByTimestamp(data);
            int startIdx = BinarySearchByTimestamp(data, endtime, true);
            int endIdx = BinarySearchByTimestamp(data, starttime, false);
            // Error - proofing here
            startIdx = (startIdx == -1) ? 0 : startIdx;
            endIdx = (endIdx == -1) ? data.Count -1 : endIdx;

            return data.GetRange(startIdx, (endIdx - startIdx));
        }
        public double CalculateAverageMoisture(List<SensorData> list)
        {
            double averageMoisture = list.Average(data => data.Moisture);
            return averageMoisture;
        }
        public object[,] ConvertTo2DArray(List<SensorData> list)
        {
            PropertyInfo[] properties = typeof(SensorData).GetProperties();
            object[,] array2D = new object[list.Count, properties.Length];
            for (int i = 0; i< list.Count; i++)
            {
                array2D[i,0] = list[i].CreateTime;
                array2D[i,1] = list[i].SensorID;
                array2D[i,2] = list[i].Moisture;
            }

            return array2D;
        }
    }
}
