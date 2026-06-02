\# Soil Sensor Dashboard



This project is a dashboard system designed to monitor and visualize soil sensor data.


## ⚡ Project Status: MVP (Minimum Viable Product)

This project is currently in its **Minimum Viable Product (MVP)** stage. The core architecture and main features are functional, but active development is ongoing.

### 🛠️ Current Focus & Upcoming Improvements:
- **Error Handling & Input Validation**: Robust exception handling is currently being implemented to prevent crashes from unexpected user inputs or corrupt data.
- **Data Edge Cases**: Improving system stability when handling missing or empty rows within the CSV sensor files.



\## 📌 Prerequisites \& File Setup



To ensure the application runs correctly, the required sensor data files (`.csv`) must be placed inside the build output directory after the system is compiled/built.



\### Required File Structure



Once the project is successfully built, copy and paste the required `.csv` files into the following execution directory:



`Soil Sensor Dashboard\\Soil Sensor Dashboard\\bin\\Debug\\net10.0-windows\\`



The directory \*\*must\*\* contain the following four CSV files along with the executable (`.exe`):

1\. \*\*sensor1\_all.csv\*\* - Historical data for Sensor 1

2\. \*\*sensor2\_all.csv\*\* - Historical data for Sensor 2

3\. \*\*sensor3\_all.csv\*\* - Historical data for Sensor 3

4\. \*\*SensorFiles.csv\*\* - Main sensor index/configuration file



> ⚠️ \*\*Important Note:\*\* If these files are missing from the `bin\\Debug\\net10.0-windows` folder, the application will throw a `FileNotFoundException` and fail to load the dashboard data upon startup.



\## 🛠️ How to Run the Project



1\. \*\*Clone\*\* this repository to your local machine.

2\. Open `Soil Sensor Dashboard.slnx` using Visual Studio.

3\. \*\*Build the project\*\* (or press F5 to Run) to generate the output folders.

4\. Copy the four required `.csv` files into the newly created `bin\\Debug\\net10.0-windows` folder.

5\. Launch the application from Visual Studio or directly double-click the `.exe` file.




