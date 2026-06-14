\# Icarus Drone Service Application



\## Project Overview



Icarus Drone Service Application is a Windows Presentation Foundation (WPF) application developed in C# for managing drone service requests.



The application allows users to:



\- Add new drone service requests.

\- Assign services to either Regular or Express priority queues.

\- Automatically generate unique Service Tags.

\- Increase service cost by 15% for Express services.

\- View all Regular service items.

\- View all Express service items.

\- Complete service requests by removing them from the service queue.

\- Store completed services in a Finished Service List.

\- Remove completed services from the Finished Service List after paid and collection.

\- Display service information using ListView and ListBox controls.



\---



\## ⚡ Project Status: MVP (Minimum Viable Product)



This project is currently in its Minimum Viable Product (MVP) stage. The core functionality required by the client has been implemented and basically tested.



\### 🛠️ Current Focus \& Possible Future Improvements



\- Identify possible runtime errors and add appropriate exception handling to improve system stability.

\- Add more complete input validation to prevent invalid service data from being entered.

\- Complete more detailed testing, including normal cases, invalid inputs, empty queues, and finished list removal.

\- Improve test evidence documentation with screenshots and expected/actual results.

\---



\## Submitted Project Structure



The zipped source code submission should include the following files and folders:



```text

Icarus Drone Service Application.sln



Icarus Drone Service Application/

│

├── Properties/

├── App.xaml

├── App.xaml.cs

├── MainWindow.xaml

├── MainWindow.xaml.cs

├── AddNewWindow.xaml

├── AddNewWindow.xaml.cs

├── DisplayQueueWindow.xaml

├── DisplayQueueWindow.xaml.cs

├── DisplayFinalListWindow.xaml

├── DisplayFinalListWindow.xaml.cs

├── Drone.cs

├── CommonControls.cs

├── Icarus Drone Service Application.csproj

│

└── README.md

```



\## 📌 Prerequisites



To build and run the application, ensure the following software is installed:



\- Visual Studio 2022 or later

\- .NET Desktop Development workload

\- .NET Framework / .NET version required by the project

\- Extended.Wpf.Toolkit NuGet package





\### Required NuGet Package



Install the following package before building the project:



```powershell

Install-Package Extended.Wpf.Toolkit



\---



\## 🛠️ How to Build



1\. Open the solution file in Visual Studio.

2\. Restore NuGet packages if required.

3\. Verify that Extended.Wpf.Toolkit is installed.

4\. Select Build Solution.

5\. Verify that the project builds successfully.

\---



\## 🛠️ How to Run



1\. Build the project.

2\. Press \*\*F5\*\* in Visual Studio.



or



1\. Build the project.

2\. Navigate to the output folder.

3\. Run the generated executable file.



\---



\## 🛠️ Features



\### Add New Service



Users can enter:



\- Client Name

\- Drone Model

\- Service Problem

\- Service Cost

\- Priority (Regular or Express)



The system automatically generates a Service Tag.



\### Regular Service Queue



Displays all Regular service requests in a ListView.



\### Express Service Queue



Displays all Express service requests in a ListView.



Express services automatically receive a 15% service cost increase.



\### Complete Service



Users can complete a service request by removing the first item from the selected queue.



The completed item is automatically transferred to the Finished Service List.



\### Finished Service List



Displays completed services using the format:



```text

Client Name - $Service Cost

```



Double-clicking a completed service removes it from the list after collection and payment.



\---



\## 🛠️ Maintenance Notes



Future developers should follow the existing separation of responsibilities:



\- MainWindow manages application navigation and shared data structures.

\- AddNewWindow manages service creation and validation.

\- DisplayQueueWindow manages service queue processing.

\- DisplayFinalListWindow manages completed service.

\- Drone class stores drone service information.



When modifying the application:



\- Maintain Queue<T> usage for Regular and Express services.

\- Maintain List<T> usage for Finished Services.

\- Ensure Service Tags remain unique and increment by 10, and the minimum value is 100, maximum is 900.

\- Preserve Express Service pricing rules (+15%).



\---



