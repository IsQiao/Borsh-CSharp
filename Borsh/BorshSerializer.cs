using System;
using System.IO;

namespace Borsh
{
    public class BorshSerializer
    {
        public void Serialize(BinaryWriter binaryWriter, object? value, Type? objectType)
        {
            SerializeInternal(binaryWriter, value, objectType);
        }
    }
}