using AbstactClass.Models;
using AbstactClass.Const;
using SerializationLesson;



var column = new ColumnRound(/*0.01, 1, Material.Steel*/);

#region XML serialization
//var xmlSerializer = new XMLSerializer();
//var data = xmlSerializer.Serialize(column);
//var deserialized = xmlSerializer.Deserialize(data);
#endregion

#region JSON serialization
var jsonSerializer = new JSONSerialiser();
var json = jsonSerializer.Serialize(column);
var deserializedEmployee = jsonSerializer.Deserialize(json);
#endregion