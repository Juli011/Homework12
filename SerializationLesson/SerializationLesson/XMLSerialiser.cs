
using AbstactClass.Models;
using System.Xml.Serialization;

namespace SerializationLesson
{
    internal class XMLSerializer
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(ColumnRound));

        public string Serialize(ColumnRound column)
        {
            var writer = new StringWriter();

            serializer.Serialize(writer, column);
            var xmlString = writer.ToString();

            Console.WriteLine(xmlString);
            return xmlString;
        }

        public ColumnRound Deserialize(string data)
        {
            var reader = new StringReader(data);
            var deserializedColumn = (ColumnRound)serializer.Deserialize(reader);
            return deserializedColumn;
        }
    }
}
