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
    class AdapterXmlToJson : IJson
    {
        private string path;
        public string Path {
            get
            {
                XDocument xDocument = XDocument.Load(XmlPath);
                var books = (from book in xDocument.Element("Books").Elements("Book")
                             select new Book
                             {
                                 Author = book.Element("Author").Value,
                                 DateOfCreation = Int32.Parse(book.Element("DateOfCreation").Value),
                                 Name = book.Element("Name").Value
                             }).ToList();

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Book>));
                path = @"..\..\Adapter\Data\Books.json";
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    jsonSerializer.WriteObject(fs, books);
                }
                return path;
            }
            set
            {
                path = value;
            }
        }

        public string XmlPath { get; set; }

        public AdapterXmlToJson(Xml xml)
        {
            XmlPath = xml.Path;
        }
    }
}
