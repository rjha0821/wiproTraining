using System;

namespace DesignPatternsDemo
{
    public static class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            return type.ToLower() switch
            {
                "pdf" => new PDFDocument(),
                "word" => new WordDocument(),
                _ => throw new ArgumentException("Invalid document type")
            };
        }
    }
}
