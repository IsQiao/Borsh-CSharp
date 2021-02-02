using System;
using System.IO;

namespace Borsh
{
    public class BorshConvert
    {
        public static byte[] SerializeObject(object? value)
        {
            return SerializeObject(value);
        }

        public static byte[] SerializeObject(object? value, Type? type)
        {
            var jsonSerializer = BorshSerializer.CreateDefault(settings);
            return SerializeObjectInternal(value, null, jsonSerializer);
        }

        public static byte[] SerializeObjectInternal(object? value, Type? type, BorshSerializer borshSerializer)
        {
            var memStream = new MemoryStream();

            using (var binWriter = new BinaryWriter(memStream))
            {
                borshSerializer.Serialize(binWriter, value, type);
            }

            return memStream.GetBuffer();
        }
    }
}