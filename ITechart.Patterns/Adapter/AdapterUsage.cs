using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;
using ITechart.Patterns.Adapter.Models;
using ITechart.Patterns.Adapter.Implementations;

namespace ITechart.Patterns.Adapter
{
    class AdapterUsage
    {
        public static void UseAdapter()
        {
            Console.WriteLine(".json input");
            Book OldestBook = BooksAnalyzer.GetOldestBook(new Json(@"..\..\Adapter\Data\Books.json"));
            Console.WriteLine($"Author: {OldestBook.Author}, Date of creation: {OldestBook.DateOfCreation}, Name: {OldestBook.Name}");

            Console.WriteLine("\n.xml input");
            IJson AdaptedXMLList = new AdapterXMLToJson(new XML(@"..\..\Adapter\Data\Books.xml"));
            OldestBook = BooksAnalyzer.GetOldestBook(AdaptedXMLList);
            Console.WriteLine($"Author: {OldestBook.Author}, Date of creation: {OldestBook.DateOfCreation}, Name: {OldestBook.Name}");
        }
    }
}
