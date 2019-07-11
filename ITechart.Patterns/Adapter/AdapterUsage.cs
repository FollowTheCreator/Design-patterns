using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;
using ITechart.Patterns.Adapter;
using ITechart.Patterns.Adapter.Models;
using ITechart.Patterns.Adapter.Implementations;
using System.IO;

namespace ITechart.Patterns.Adapter
{
    class AdapterUsage
    {
        public static void UseAdapter()
        {
            Console.WriteLine(".xml input");
            IJson adaptedXmlList = new AdapterXmlToJson(new Xml(BooksLibrary.GetBooksXML()));
            DescribeBook(BooksAnalyzer.GetOldestBook(adaptedXmlList));
            
            Console.WriteLine(".json input");
            DescribeBook(BooksAnalyzer.GetOldestBook(new Json(adaptedXmlList.Value)));
        }

        private static void DescribeBook(Book book)
        {
            Console.WriteLine($"Author: {book.Author}, Date of creation: {book.DateOfCreation}, Name: {book.Name}");
        }
    }
}
