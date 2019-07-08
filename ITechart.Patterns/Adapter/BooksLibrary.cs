using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ITechart.Patterns.Adapter.Interfaces;

namespace ITechart.Patterns.Adapter
{
    class BooksLibrary
    {
        public static string GetBooksXML(IXml xml)
        {
            XDocument xDocument = new XDocument(
                new XElement(
                    "Books",
                    new XElement(
                        "Book",
                        new XElement("Author", "Fyodor Dostoevsky"),
                        new XElement("DateOfCreation", "1866"),
                        new XElement("Name", "Crime and Punishment")
                    ),
                    new XElement(
                        "Book",
                        new XElement("Author", "Lev Tolstoy"),
                        new XElement("DateOfCreation", "1869"),
                        new XElement("Name", "War and Peace")
                    ),
                    new XElement(
                        "Book",
                        new XElement("Author", "Nikolai Gogol"),
                        new XElement("DateOfCreation", "1842"),
                        new XElement("Name", "Dead Souls")
                    )
                )
            );
            xDocument.Save(xml.Path);
            return xml.Path;
        }
    }
}
