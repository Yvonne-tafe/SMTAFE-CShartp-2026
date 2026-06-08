using System;
using System.Collections.Generic;
using System.Text;

namespace Soil_Sensor_Dashboard
{
    /// <summary>
    /// Represents one loaded sensor data file in the application.
    /// It stores the file information, sensor ID, original data,
    /// and the current data displayed after filtering or processing.
    /// </summary>
    internal class DataFile
    {
        public string FileName { get; set; }
        public string SensorID { get; set; }
        public List<SensorData> OriginalData { get; set; }
        public List<SensorData> CurrentDisplayData { get; set; }
        public DataFile(string fileName, string sensorId, List<SensorData> originalData, List<SensorData> currentDisplayData)
        {
            FileName = fileName;
            SensorID = sensorId;
            OriginalData = originalData;
            CurrentDisplayData = currentDisplayData;
        }
    }
}
