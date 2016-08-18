using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings Settings = new XmlWriterSettings();
            Settings.Indent = true;
            Settings.IndentChars=("   ");
            Settings.CloseOutput = true;
            try
            {
                XDocument xDocument = XDocument.Load("F:\\abc.xml");
                XElement root = xDocument.Element("School");
                IEnumerable<XElement> rows = root.Descendants("Student");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Student",
                   new XElement("FirstName","Shivam"),
                   new XElement("LastName", "Thakur")));
                xDocument.Save("f:\\abc.xml");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }
    }
}
