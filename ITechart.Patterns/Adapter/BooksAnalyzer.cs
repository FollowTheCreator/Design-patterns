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
        public static Book GetOldestBook(IJson json)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(List<Book>));
            using (FileStream fs = new FileStream(json.Path, FileMode.OpenOrCreate))
            {
                var books = (List<Book>)jsonSerializer.ReadObject(fs);
                return (books.Where(book1 => book1.DateOfCreation == books.Min(book => book.DateOfCreation))).FirstOrDefault();
            }
        }
    }
}
