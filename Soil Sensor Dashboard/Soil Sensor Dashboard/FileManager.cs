using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Soil_Sensor_Dashboard
{
    internal class FileManager
    {
        public bool LoadFile(string filePath, List<DataFile> loadedFiles, out string msg)
        {
            try
            {
                var originalData = new List<SensorData>();
                var lines = File.ReadAllLines(filePath);
                for (int i = 1; i < lines.Length; i++) // skip header
                {
                    if (string.IsNullOrWhiteSpace(lines[i])) continue;
                    var parts = lines[i].Split(',');
                    if (parts.Length < 3)
                    {
                        throw new Exception($"Invalid data format at line {i + 1}.");
                    }

                    var data = new SensorData(
                        DateTime.Parse(parts[0]),
                        parts[1],
                        double.Parse(parts[2])
                    );

                    originalData.Add(data);
                }

                if (originalData.Count == 0)
                {
                    throw new Exception("No valid sensor data found in the file.");
                }

                loadedFiles.Add(
                    new DataFile(
                        filePath,
                        originalData.First().SensorID,
                        originalData,
                        originalData.ToList()
                    )
                );
                msg = $"Succeeded";
                return true;
            }
            catch (Exception ex)
            {
                msg = $"Failed to load file: {ex.Message}";
                return false;
            }

        }
        public bool LoadBinFile(string filePath, List<DataFile> loadedFiles, out string msg)
        {
            try
            {
                byte[] binData = File.ReadAllBytes(filePath);
                string jsonString = Encoding.UTF8.GetString(binData);
                List<SensorData>? data = JsonSerializer.Deserialize<List<SensorData>>(jsonString);
                // TODO:
                loadedFiles.Add(new DataFile(filePath, data.FirstOrDefault().SensorID, data, data));

                msg = $"Succeeded";
                return true;
            }
            catch (Exception ex)
            {
                msg = $"Failed to load file: {ex.Message}";
                return false;
            }
        }
        public bool SaveBinaryFile(string filePath, List<SensorData> data, out string msg)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(data);
                byte[] binData = Encoding.UTF8.GetBytes(jsonString);
                File.WriteAllBytes(filePath, binData);
                msg = $"Succeeded";
                return true;
            }
            catch (Exception ex)
            {
                msg = $"Failed to save file: {ex.Message}";
                return false;
            }
        }
    }
}
