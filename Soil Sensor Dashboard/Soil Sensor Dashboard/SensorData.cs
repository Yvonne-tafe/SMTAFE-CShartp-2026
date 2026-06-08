using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Soil_Sensor_Dashboard
{
    /// <summary>
    /// Represents a single sensor data record.
    /// Each record contains a timestamp, sensor ID,
    /// and moisture value collected from the sensor (File).
    /// </summary>
    public class SensorData
    {
        public DateTime CreateTime { get; set; }
        public string SensorID { get; set; }
        public double Moisture { get; set; }


        public SensorData(DateTime createTime, string sensorId, double moisture)
        {
            CreateTime = createTime;
            SensorID = sensorId;
            Moisture = moisture;
        }
    }
}
