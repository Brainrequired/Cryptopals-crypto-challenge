using System;
using System.Linq;
using System.Text;

namespace set_1
{
    public static class Helper
    {
        public static byte[] HexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }

        public static string ByteArrayToString(byte[] bytes)
        {
            return Encoding.Default.GetString(bytes);
        }

        public static string ByteArrayToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        public static byte[] StringToByteArray(string s)
        {
            return Encoding.ASCII.GetBytes(s);
        }
    }
}
