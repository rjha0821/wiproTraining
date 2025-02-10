using System;

namespace DesignPatternsDemo
{
    public class PDFDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a PDF Document.");
        }
    }
}
