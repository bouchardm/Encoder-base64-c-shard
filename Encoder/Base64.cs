using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    public static class Base64
    {
        public static readonly string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/+";

        public static string Encode(byte[] source)
        {
            IEnumerator<string> enumerator = BytesToString(source).GetEnumerator();

            StringBuilder result = new StringBuilder();
            while (enumerator.MoveNext())
            {
                result.Append(enumerator.Current);
            }
            return result.ToString();
        }

        public static IEnumerable<string> BytesToString(byte[] src)
        {
            for (int i = 0; i < src.Length; i += 3)
            {
                yield return IntToString(BytesToInt(src[i], src[i + 1], src[i + 2]));
            }
        }

        public static int BytesToInt(byte one, byte two, byte three)
        {
            return (one << 16) + (two << 8) + three;
        }

        public static string IntToString(int number)
        {
            return "" + 
                DecimalToChar(number >> 18) + 
                DecimalToChar((number >> 12) & 63) + 
                DecimalToChar((number >> 6) & 63) + 
                DecimalToChar(number & 63);
        }

        public static char DecimalToChar(int input)
        {
            return characters[input];
        }
    }
}
