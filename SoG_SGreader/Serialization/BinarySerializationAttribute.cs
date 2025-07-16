using System;

namespace SoG_SGreader.Serialization
{
    /// <summary>
    /// Attribute to specify the order of binary serialization for properties
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class BinarySerializationAttribute : Attribute
    {
        public int Order { get; }

        public BinarySerializationAttribute(int order)
        {
            Order = order;
        }
    }
}