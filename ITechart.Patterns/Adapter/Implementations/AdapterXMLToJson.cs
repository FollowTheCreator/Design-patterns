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
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ITechart.Patterns.Adapter.Implementations
{
    class AdapterXmlToJson : IJson
    {
        private string _value;

        public string Value
        {
            get
            {
                return Adapt(_value);
            }
            set
            {
                _value = value;
            }
        }

        public AdapterXmlToJson(Xml xml)
        {
            _value = xml.Value;
        }

        private static string Adapt(string stream)
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(stream);
            var books = (from XmlNode book in xmlDoc.GetElementsByTagName("Book")
                         select new Book
                         {
                             Author = book.SelectSingleNode("Author").InnerText,
                             DateOfCreation = int.Parse(book.SelectSingleNode("DateOfCreation").InnerText),
                             Name = book.SelectSingleNode("Name").InnerText
                         }).ToList();

            return JsonConvert.SerializeObject(books);
        }
    }
}
