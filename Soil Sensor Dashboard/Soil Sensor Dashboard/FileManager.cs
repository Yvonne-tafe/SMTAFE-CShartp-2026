using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Soil_Sensor_Dashboard
{
    /// <summary>
    /// Handles file input and output operations for the sensor data application.
    /// This includes loading CSV files, loading saved binary files,
    /// and saving sensor data into a binary file.
    /// </summary>
    internal class FileManager
    {
        /// <summary>
        /// Loads sensor data from a CSV file and adds it to the loaded file collection.
        /// </summary>
        /// /// <param name="filePath">The path of the CSV file to load.</param>
        /// <param name="loadedFiles">The list used to store loaded sensor data files.</param>
        /// <param name="msg">Returns a success or error message.</param>
        /// <returns>True if the file is loaded successfully; otherwise, false.</returns>
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
        /// <summary>
        /// Loads previously saved sensor data from a binary file.
        /// The binary file stores JSON text encoded as UTF-8 bytes.
        /// </summary>
        /// <param name="filePath">The path of the binary file to load.</param>
        /// <param name="loadedFiles">The list used to store loaded sensor data files.</param>
        /// <param name="msg">Returns a success or error message.</param>
        /// <returns>True if the binary file is loaded successfully; otherwise, false.</returns>
        public bool LoadBinFile(string filePath, List<DataFile> loadedFiles, out string msg)
        {
            try
            {
                byte[] binData = File.ReadAllBytes(filePath);
                string jsonString = Encoding.UTF8.GetString(binData);

                List<SensorData>? data = JsonSerializer.Deserialize<List<SensorData>>(jsonString);
                if (data == null)
                {
                    throw new Exception("loading data error");
                }

                var firstItem = data.FirstOrDefault() ?? throw new Exception("Data list is empty");
                loadedFiles.Add(new DataFile(filePath, firstItem.SensorID, data, data.ToList()));

                msg = $"Succeeded";
                return true;
            }
            catch (Exception ex)
            {
                msg = $"Failed to load file: {ex.Message}";
                return false;
            }
        }
        /// <summary>
        /// Saves the current sensor data into a binary file.
        /// The sensor data is first serialised to JSON and then written as UTF-8 bytes.
        /// </summary>
        /// <param name="filePath">The path where the binary file will be saved.</param>
        /// <param name="data">The sensor data list to save.</param>
        /// <param name="msg">Returns a success or error message.</param>
        /// <returns>True if the file is saved successfully; otherwise, false.</returns>
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
