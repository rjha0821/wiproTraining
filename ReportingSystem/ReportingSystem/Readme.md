# **Reporting System - SOLID Principles Implementation**

## **Introduction**
This project is a refactored **Reporting System** that follows the **SOLID principles** to improve maintainability, scalability, and code organization.  
The system includes separate responsibilities for **report generation, formatting, and saving**, making it more flexible and easier to extend.

---

## **Project Structure**
```
ReportingSystem/
│── Program.cs
│── Reports/
│   ├── IReport.cs
│   ├── Report.cs
│   ├── PDFReport.cs
│   ├── ExcelReport.cs
│── ReportGeneration/
│   ├── IReportGenerator.cs
│   ├── ReportGenerator.cs
│── ReportSaving/
│   ├── IReportSaver.cs
│   ├── FileReportSaver.cs
│── ReportFormatting/
│   ├── IReportFormatter.cs
│   ├── PDFReportFormatter.cs
│   ├── ExcelReportFormatter.cs
│── Services/
│   ├── ReportService.cs
└── README.md
```

---

## **SOLID Principles Applied**

### **1️⃣ Single Responsibility Principle (SRP)**
✔ **Refactored** `ReportManager` class into **three separate classes**:  
   - `ReportGenerator` - Responsible for generating reports.  
   - `ReportSaver` - Handles file saving.  
   - `ReportFormatter` - Manages report formatting.  

```csharp
IReportGenerator generator = new ReportGenerator();
IReportSaver saver = new FileReportSaver();
IReportFormatter formatter = new PDFReportFormatter();
```

---

### **2️⃣ Open/Closed Principle (OCP)**
✔ Introduced `IReportFormatter` **interface** for different formatting strategies.  
✔ New report formats (e.g., **PDF, Excel**) can be added **without modifying** existing code.  

```csharp
IReportFormatter formatter = new PDFReportFormatter();
formatter.Format(report);
```

---

### **3️⃣ Liskov Substitution Principle (LSP)**
✔ Ensured derived classes (`PDFReport`, `ExcelReport`) **can replace** the base `Report` class without breaking functionality.  

```csharp
List<Report> reports = new List<Report> { new PDFReport(), new ExcelReport() };
foreach (var report in reports) report.Generate();
```

---

### **4️⃣ Interface Segregation Principle (ISP)**
✔ Split the `IReport` interface into **smaller, focused** interfaces:  
   - `IReportGenerator` (for generation)  
   - `IReportSaver` (for saving)  
   - `IReportFormatter` (for formatting)  

```csharp
public interface IReportGenerator { void Generate(Report report); }
public interface IReportSaver { void Save(Report report, string path); }
public interface IReportFormatter { void Format(Report report); }
```

---

### **5️⃣ Dependency Inversion Principle (DIP)**
✔ `ReportService` depends on **abstractions** (`IReportGenerator`, `IReportSaver`, `IReportFormatter`) rather than concrete classes.  
✔ Implemented **Dependency Injection** to allow flexibility.  

```csharp
var reportService = new ReportService(new ReportGenerator(), new FileReportSaver(), new PDFReportFormatter());
reportService.GenerateAndSaveReport();
```

---

## **How to Run the Project**

1️⃣ **Clone the repository:**  
```sh
git clone https://github.com/your-repo/reporting-system.git
cd reporting-system
```

2️⃣ **Open the project in VS Code:**  
```sh
code .
```

3️⃣ **Run the application:**  
```sh
dotnet run
```

---

## **Conclusion**
This project successfully applies **SOLID principles** to improve **code organization, flexibility, and maintainability**.

| Principle | Applied By | Benefit |
|-----------|-----------|---------|
| **SRP** | Separate classes for report generation, saving, and formatting | Easier to maintain |
| **OCP** | Used interfaces for formatting | Easily extendable |
| **LSP** | Ensured subclasses can replace base class | No unexpected behavior |
| **ISP** | Split interfaces into smaller ones | No unnecessary dependencies |
| **DIP** | Used dependency injection | Loosely coupled and flexible |

📌 **By following SOLID principles, the system is now easier to test, extend, and maintain.** 🚀  

---

### **Author**  
👨‍💻 **Rahul Jha**  
📧 rjha0821@gmail.com  
🔗 [LinkedIn](https://linkedin.com/in/rjha0821) | [GitHub](https://github.com/rjha0821)
