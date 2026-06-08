\# Sensing4U - Soil Sensor Data Management - Soil Sensor Dashboard



Project Overview

Soil Sensor Dashboard is a Windows Forms application developed in C# for monitoring and analysing soil moisture sensor data.

The application allows users to:

- Load sensor data from CSV or binary files.
- Display sensor readings in a DataGridView.
- Filter sensor data by a selected date range.
- Apply upper and lower moisture thresholds.
- Visualise sensor values using colour-coded indicators.
- Calculate average moisture values.
- Save filtered sensor data to a binary file.


## ⚡ Project Status: MVP (Minimum Viable Product)

This project is currently in its **Minimum Viable Product (MVP)** stage. The core architecture and main features are functional.

### 🛠️ Current Focus & Upcoming Improvements:
- **Error Handling & Input Validation**: Robust exception handling is currently being implemented to prevent crashes from unexpected user inputs or corrupt data.
- **Data Edge Cases**: Improving system stability when handling missing or empty rows within the CSV sensor files.




## Submitted Project Structure

The zipped source code submission should include the following files and folders:

```text
Soil Sensor Dashboard.slnx

Soil Sensor Dashboard/
│
├── Properties/
├── DataFile.cs
├── DataProcessor.cs
├── FileManager.cs
├── MainForm.cs
├── MainForm.Designer.cs
├── MainForm.resx
├── MessageService.cs
├── Program.cs
├── SensorData.cs
├── Soil Sensor Dashboard.csproj
│
├── sensor1_all.csv
├── sensor2_all.csv
├── sensor3_all.csv
└── SensorFiles.csv




\## 📌 Prerequisites \& File Setup

To ensure the application runs correctly, the required sensor data files (`.csv`) must be placed inside the build output directory after the system is compiled/built.




\### Required File 

Once the project is successfully built, copy and paste the required `.csv` files into the following execution directory:
	`Soil Sensor Dashboard\\Soil Sensor Dashboard\\bin\\Debug\\net10.0-windows\\`


The directory \*\*must\*\* contain the following four CSV files along with the executable (`.exe`):

1\. \*\*sensor1\_all.csv\*\* - Historical data for Sensor 1
2\. \*\*sensor2\_all.csv\*\* - Historical data for Sensor 2
3\. \*\*sensor3\_all.csv\*\* - Historical data for Sensor 3
4\. \*\*SensorFiles.csv\*\* - Main sensor index/configuration file



> ⚠️ \*\*Important Note:\*\* If these files are missing from the `bin\\Debug\\net10.0-windows` folder, the application will throw a `FileNotFoundException` and fail to load the dashboard data upon startup.



\## 🛠️ How to Build


1\. Open Soil Sensor Dashboard.sln in Visual Studio.
2\. Restore NuGet packages if required.
3\. Select Build Solution.
4\. Verify that the project builds successfully.



\## 🛠️ How to Run
1\. Build the project.
2\. Copy the required CSV files into:
	bin\Debug\net10.0-windows\
3\. Start the application using:
	Visual Studio (F5), or
	the generated executable file.
4\. The application will automatically load the default sensor dataset.



\## 🛠️ Maintenance Notes

Future developers should follow the existing separation of responsibilities:

- UI changes should be implemented in MainForm.
- Data processing logic should be added to DataProcessor.
- File operations should remain in FileManager.
- User notifications should remain in MessageService.

When adding new sensor attributes, update:

- SensorData
- ConvertTo2DArray()
- DisplayCurrentData()
- Grid colour visualisation logic

to ensure the new fields are displayed correctly.


