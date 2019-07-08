using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;
using ITechart.Patterns.Adapter.Models;
using ITechart.Patterns.Adapter.Implementations;
using System.IO;

namespace ITechart.Patterns.Adapter
{
    class AdapterUsage
    {
        public static void UseAdapter()
        {
            IJson adaptedXmlList = new AdapterXmlToJson(new Xml(@"..\..\Adapter\Data\Books.xml"));
            Book oldestBook = BooksAnalyzer.GetOldestBook(adaptedXmlList);
            Console.WriteLine($"Author: {oldestBook.Author}, Date of creation: {oldestBook.DateOfCreation}, Name: {oldestBook.Name}");
            File.Delete(@"..\..\Adapter\Data\Books.json");
        }
    }
}
