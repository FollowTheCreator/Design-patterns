using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Models;
using ITechart.Patterns.Adapter.Interfaces;
using System.IO;
using System.Runtime.Serialization.Json;

namespace ITechart.Patterns.Adapter
{
    class BooksAnalyzer
    {
        public static Book GetOldestBook(IJson Json)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Book>));
            using (FileStream fs = new FileStream(Json.GetJsonPath(), FileMode.OpenOrCreate))
            {
                List<Book> Books = (List<Book>)jsonSerializer.ReadObject(fs);
                return (Books.Where(book1 => book1.DateOfCreation == Books.Min(book => book.DateOfCreation))).FirstOrDefault();
            }
        }
    }
}
