using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ITechart.Patterns.Adapter.Models;
using ITechart.Patterns.Adapter.Interfaces;

namespace ITechart.Patterns.Adapter.Implementations
{
    class AdapterXMLToJson : IJson
    {
        public string Path { get; set; }

        public string XMLPath { get; set; }

        public AdapterXMLToJson(XML XML)
        {
            XMLPath = XML.GetXMLPath();
        }

        public string GetJsonPath()
        {
            XDocument xDocument = XDocument.Load(XMLPath);
            List<Book> Books = (from book in xDocument.Element("Books").Elements("Book")
                                select new Book
                                {
                                    Author = book.Element("Author").Value,
                                    DateOfCreation = Int32.Parse(book.Element("DateOfCreation").Value),
                                    Name = book.Element("Name").Value
                                }).ToList();

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Book>));
            Path = @"..\..\Adapter\Data\Books.json";
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, Books);
            }
            return Path;
        }
    }
}
