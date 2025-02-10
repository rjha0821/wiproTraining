# **Design Patterns in .NET**

## **Introduction**
This project demonstrates three commonly used **design patterns** in .NET using C#:

1. **Singleton Pattern** - Ensures a class has only one instance and provides a global point of access.  
2. **Factory Pattern** - Allows object creation without specifying the exact class type.  
3. **Observer Pattern** - Enables multiple objects to receive updates when the subject’s state changes.  

Each pattern is implemented with a simple real-world example.

---

## **Project Structure**
```
DesignPatternsDemo/
│── Program.cs
│── Singleton/
│   └── Logger.cs
│── Factory/
│   ├── IDocument.cs
│   ├── PDFDocument.cs
│   ├── WordDocument.cs
│   └── DocumentFactory.cs
│── Observer/
│   ├── IObserver.cs
│   ├── ISubject.cs
│   ├── WeatherStation.cs
│   └── WeatherDisplay.cs
└── README.md
```

---

## **Design Patterns Implemented**

### **1️⃣ Singleton Pattern - Logger**
**Use Case:** Ensure only **one instance** of a class exists and is used globally.  
✔ **Example:** A `Logger` class that logs messages using a **single shared instance**.

```csharp
Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();
Console.WriteLine(logger1 == logger2); // Output: True
```

---

### **2️⃣ Factory Pattern - Document Factory**
**Use Case:** Create objects **without specifying the exact class** type.  
✔ **Example:** A `DocumentFactory` that creates **PDF** or **Word** documents based on input.

```csharp
IDocument document = DocumentFactory.CreateDocument("pdf");
document.Open(); // Output: Opening a PDF Document.
```

---

### **3️⃣ Observer Pattern - Weather Station**
**Use Case:** Allow **multiple objects** (observers) to react when a subject’s state changes.  
✔ **Example:** `WeatherStation` notifies multiple `WeatherDisplay` instances when temperature changes.

```csharp
WeatherStation station = new WeatherStation();
WeatherDisplay display = new WeatherDisplay("Main Display");
station.RegisterObserver(display);
station.SetTemperature(25.0f);
```

---

## **How to Run the Project**

1️⃣ **Clone the repository:**  
```sh
git clone https://github.com/your-repo/design-patterns-demo.git
cd design-patterns-demo
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
This project demonstrates how **design patterns** improve **code structure, reusability, and maintainability**.

| Pattern | Purpose | When to Use |
|---------|---------|-------------|
| **Singleton** | Ensures only one instance of a class | Logging, Configuration |
| **Factory** | Creates objects without specifying exact class | UI Components, Object Creation |
| **Observer** | Allows multiple objects to listen for changes | Event Handling, Notifications |

📌 **By following SOLID principles, these patterns make applications easier to test, extend, and maintain.** 🚀  

---

### **Author**  
👨‍💻 **Rahul Jha**  
📧 your.email@example.com  
🔗 [LinkedIn](https://linkedin.com/in/rjha0821) | [GitHub](https://github.com/rjha0821)
