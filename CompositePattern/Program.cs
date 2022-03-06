// Client

using CompositePattern;
using System.Xml.Linq;

var xml = XElement.Load("file-system.xml");
foreach (var leaf in xml.FindElements(x => !x.HasElements))
{
    Console.WriteLine($"*********** LEAF: {leaf.Attribute("name")}, {leaf.Attribute("fileBytes")}");
}