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
        public static string GetBooksXML()
        {
            return "<?xml version=\"1.0\" encoding=\"utf - 8\"?>" +
                   "<Books>" +
                       "<Book>" +
                           "<Author>Fyodor Dostoevsky</Author>" +
                           "<DateOfCreation>1866</DateOfCreation>" +
                           "<Name>Crime and Punishment</Name>" +
                       "</Book>" +
                       "<Book>" +
                           "<Author>Lev Tolstoy</Author>" +
                           "<DateOfCreation>1869</DateOfCreation>" +
                           "<Name>War and Peace</Name> " +
                       "</Book>" +
                       "<Book>" +
                           "<Author>Nikolai Gogol</Author>" +
                           "<DateOfCreation>1842</DateOfCreation>" +
                           "<Name>Dead Souls</Name>" +
                       "</Book>" +
                   "</Books>";
        }
    }
}
