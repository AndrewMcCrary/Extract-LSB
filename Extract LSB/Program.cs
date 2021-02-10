using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;
using System.Collections;

namespace Extract_LSB
{
    class Program
    {
        const string PATH = @"";

        static void Main(string[] args)
        {
            if (!File.Exists(PATH)) return;

            BitArray b;

            List<bool> bits = new List<bool>();
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(PATH)))
            {
                foreach (byte b in ms.ToArray())
                {
                    bits.Add(GetBit(b));
                }
            }

            using (FileStream fs = new FileStream(@"", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(new BitArray(bits.ToArray())
                }
            }
        }

        private static bool GetBit(byte b)
        {
            return (b & 1) != 0;
        }
    }
}
