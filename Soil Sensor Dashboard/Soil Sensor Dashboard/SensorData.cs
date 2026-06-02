using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Soil_Sensor_Dashboard
{
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
