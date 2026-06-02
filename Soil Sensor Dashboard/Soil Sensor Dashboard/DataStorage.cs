using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Soil_Sensor_Dashboard
{
    internal class DataStorage
    {
        public List<SensorData> CurrentList { get; private set; } = new List<SensorData>();
        public DataStorage()
        {
            //DateTime defaultStartTime = DateTime.Today;
            //DateTime defaultEndTime = DateTime.Today.AddDays(-365);
            //LoadDataFromDatabase(defaultStartTime, defaultEndTime); 

            LoadDataFromDatabase();
        }
        public bool LoadDataFromDatabase(DateTime startTime, DateTime endTime)
        {
            //read and load data from database based on the startTime and endTime
            //transfor to list
            return true;
        }
        public bool LoadDataFromDatabase()
        {
            //var list = new List<SensorData>();
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sensor_data_02052025_2026.csv");
            //var lines = File.ReadAllLines(path);
            //for (int i = 1; i < lines.Length; i++) // skip header
            //{
            //    var parts = lines[i].Split(',');
            //    var data = new SensorData(DateTime.Parse(parts[0]), parts[1], parts[2], float.Parse(parts[3]), float.Parse(parts[4]), float.Parse(parts[5]));
            //    list.Add(data);
            //}
            //CurrentList = list;
            ////Debug.WriteLine(CurrentList[0].SensorID.ToString());            ;
            return true;
        }

    }
}
