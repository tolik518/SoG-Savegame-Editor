using System.IO;

namespace SoG_SGreader.Serialization
{
    /// <summary>
    /// Interface for objects that can be serialized to/from binary format
    /// </summary>
    public interface IBinarySerializable
    {
        /// <summary>
        /// Serialize this object to a binary writer
        /// </summary>
        /// <param name="writer">The binary writer to write to</param>
        void Serialize(BinaryWriter writer);

        /// <summary>
        /// Deserialize this object from a binary reader
        /// </summary>
        /// <param name="reader">The binary reader to read from</param>
        void Deserialize(BinaryReader reader);
    }
}