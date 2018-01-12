using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Byte> source = new List<byte>();

            for(int i = 0; i < 11111111; i++)
            {
                source.Add(0x6A);
                source.Add(0x77);
                source.Add(0xC4);
            }

            string result = Encoder.Base64.Encode(source.ToArray());

            Console.WriteLine(result);            
            Console.ReadLine();
        }
    }
}
