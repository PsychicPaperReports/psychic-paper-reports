using System.Xml;
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestReports.Core;

public class Parser
{
    public void Parse(string str)
    {
        var doc = new XmlDocument();
        var stringReader = new StringReader(str);
        var reader = XmlReader.Create(stringReader);
        doc.Load(reader);
        var root = doc.DocumentElement;
        Document.Create(document =>
        {
            foreach (XmlElement childNode in root!.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "page":
                    {
                        document.Page(page =>
                        {
                            foreach (XmlElement child in childNode)
                            {
                            }
                        });
                        break;
                    }
                }
            }
        });
    }
}