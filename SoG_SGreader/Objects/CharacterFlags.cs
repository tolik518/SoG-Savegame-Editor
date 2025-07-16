using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class CharacterFlags : IBinarySerializable   //.archie.....lmb...C
    {
        public string Name { get; set; }
        public float Value { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(Value);
        }

        public void Deserialize(BinaryReader reader)
        {
            Name = reader.ReadString();
            Value = reader.ReadSingle();
        }
    }
}