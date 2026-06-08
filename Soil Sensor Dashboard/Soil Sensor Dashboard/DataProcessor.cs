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
    /// <summary>
    /// Provides data processing functions for sensor data,
    /// including sorting, searching, filtering, average calculation,
    /// and conversion to a 2D array for display.
    /// </summary>
    internal class DataProcessor
    {
        private static DataProcessor instance;
        /// <summary>
        /// Private constructor used to support the Singleton pattern.
        /// </summary>
        private DataProcessor()
        {
            // init if need

        }
        /// <summary>
        /// Gets the single shared instance of the DataProcessor class.
        /// </summary>
        public static DataProcessor GetInstance()
        {
            // create if no instance
            return instance ??= new DataProcessor();
        }
        /// <summary>
        /// Sorts the sensor data list by timestamp in descending order.
        /// The most recent sensor readings will appear first.
        /// </summary>
        /// <param name="list">
        /// The sensor data list to be sorted.
        /// </param>
        public void SortByTimestamp(List<SensorData> list)
        {
            list.Sort((a, b) => b.CreateTime.CompareTo(a.CreateTime));
        }
        /// <summary>
        /// Performs a binary search to find the index of a sensor record
        /// that matches the target date.
        /// </summary>
        /// <param name="data">The sorted sensor data list.</param>
        /// <param name="TargetTime">The date to search for.</param>
        /// <param name="isFirst">
        /// True to find the first matching record for the date;
        /// false to find the last matching record for the date.
        /// </param>
        /// <returns>
        /// The index of the matching sensor record, or -1 if no match is found.
        /// </returns>
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
        /// <summary>
        /// Filters sensor data by a selected timestamp range.
        /// Binary search is used to find the start and end positions.
        /// </summary>
        /// <param name="data">The original sensor data list.</param>
        /// <param name="starttime">The start time selected by the user.</param>
        /// <param name="endtime">The end time selected by the user.</param>
        /// <returns>A filtered list of sensor data within the selected period.</returns>
        public List<SensorData> FilterByTimestampRange(List<SensorData> data, DateTime starttime, DateTime endtime)
        {
            SortByTimestamp(data);
            int startIdx = BinarySearchByTimestamp(data, endtime, true);
            int endIdx = BinarySearchByTimestamp(data, starttime, false);
            // Error - proofing here
            startIdx = (startIdx == -1) ? 0 : startIdx;
            endIdx = (endIdx == -1) ? data.Count -1 : endIdx;

            return data.GetRange(startIdx, (endIdx - startIdx));
        }

        /// <summary>
        /// Calculates the average moisture value from the displayed sensor data.
        /// </summary>
        /// <param name="list">The sensor data list to calculate from.</param>
        /// <returns>The average moisture value.</returns>
        public double CalculateAverageMoisture(List<SensorData> list)
        {
            double averageMoisture = list.Average(data => data.Moisture);
            return averageMoisture;
        }

        /// <summary>
        /// Converts the sensor data list into a 2D array.
        /// This supports the project requirement to use a 2D array
        /// for displaying sensor data in the grid.
        /// </summary>
        /// <param name="list">The sensor data list to convert.</param>
        /// <returns>A 2D object array containing sensor data values.</returns>
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
