
using System.Xml.Linq;
public class XmlSamples
{
    public void ExtractValue()
    {
        //https://learn.microsoft.com/en-us/dotnet/standard/linq/query-linq-xml-xpath

        var xElement = XElement.Load("./data/xml-data1.xml");

        var node = from item in xElement.Descendants()
                   where item.Name.LocalName == "ServerRelativeUrl"
                   select item;

        foreach (var item in node)
        {
            Console.WriteLine(item.Value);
        }
    }
}