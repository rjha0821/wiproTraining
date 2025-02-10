// using System;

// namespace DesignPatternsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             Logger logger1 = Logger.GetInstance();
//             Logger logger2 = Logger.GetInstance();

//             logger1.Log("Singleton Pattern Example: Logger Initialized.");
//             logger2.Log("Logging another message.");

//             Console.WriteLine($"Are both instances the same? {logger1 == logger2}");
//         }
//     }
// }


// using System;

// namespace DesignPatternsDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             Console.WriteLine("Enter document type (pdf/word): ");
//             string docType = Console.ReadLine() ?? "";

//             IDocument document = DocumentFactory.CreateDocument(docType);
//             document.Open();
//         }
//     }
// }


using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main()
        {
            WeatherStation weatherStation = new WeatherStation();

            WeatherDisplay display1 = new WeatherDisplay("Main");
            WeatherDisplay display2 = new WeatherDisplay("Secondary");

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            weatherStation.SetTemperature(25.5f);
            weatherStation.SetTemperature(30.2f);

            weatherStation.RemoveObserver(display1);
            weatherStation.SetTemperature(28.0f);
        }
    }
}
