
using AbstactClass.Models;
using Newtonsoft.Json;

namespace SerializationLesson
{
    internal class JSONSerialiser
    {
        public string Serialize(ColumnRound column)
        {
            var json = JsonConvert.SerializeObject(column);
            Console.WriteLine(json);
            return json;
        }

        public ColumnRound Deserialize(string json)
        {
            var deserializedColumn = JsonConvert.DeserializeObject<ColumnRound>(json);
            return deserializedColumn;
        }
    }
}
