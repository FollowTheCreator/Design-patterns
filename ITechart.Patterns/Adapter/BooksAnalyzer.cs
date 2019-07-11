using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Models;
using ITechart.Patterns.Adapter.Interfaces;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace ITechart.Patterns.Adapter
{
    class BooksAnalyzer
    {
        public static Book GetOldestBook(IJson json)
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(List<Book>));
            var books = JsonConvert.DeserializeObject<List<Book>>(json.Value);
            return books.FirstOrDefault(book1 => book1.DateOfCreation == books.Min(book => book.DateOfCreation));
        }
    }
}
