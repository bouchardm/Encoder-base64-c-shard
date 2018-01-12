using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encoder.Test
{
    [TestClass]
    public class Base64Test
    {
        [TestMethod]
        public void I_can_encode_a_byte_array()
        {
            byte[] source = { 0x6A, 0x77, 0xC4 };

            string result = Encoder.Base64.Encode(source);

            Assert.AreEqual("anfE", result);
        }

        [TestMethod]
        public void I_can_convert_from_a_decimal_to_a_char()
        {
            int input = 26;

            char output = Encoder.Base64.DecimalToChar(input);

            Assert.AreEqual('a', output);
        }

        [TestMethod]
        public void I_can_convert_from_bytes_to_int()
        {
            int result = Encoder.Base64.BytesToInt(0x6A, 0x77, 0xC4);

            Assert.AreEqual(6977476, result);
        }

        [TestMethod]
        public void I_can_convert_from_int_to_string()
        {
            string result = Encoder.Base64.IntToString(6977476);

            Assert.AreEqual("anfE", result);
        }
    }
}
