using System;

namespace DesignPatternsDemo
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a Word Document.");
        }
    }
}
