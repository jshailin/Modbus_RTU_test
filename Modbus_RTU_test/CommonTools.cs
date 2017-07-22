using System;
using System.Text;
using System.Windows.Forms;

namespace Modbus_RTU_test
{
    public partial class CommonTools
    {

        /// <summary>
        /// byte[]转16进制格式string (new byte[]{ 0x30, 0x31}转成"3031")
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF " 
        {
            string hexString = string.Empty;

            if (bytes != null)
            {

                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {

                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;

        }


        /// <summary>
        /// 16进制格式string 转byte[]
        /// </summary>
        /// <param name="hexString"></param>
        /// <param name="discarded"></param>
        /// <returns></returns>
        public static byte[] GetBytes(string hexString, out int discarded)
        {
            discarded = 0;
            string newString = "";
            char c;
            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];
                if (Uri.IsHexDigit(c))
                    newString += c;
                else
                    discarded++;
            }
            // if odd number of characters, discard last character
            if (newString.Length % 2 != 0)
            {
                discarded++;
                newString = newString.Substring(0, newString.Length - 1);
            }

            //int byteLength = newString.Length / 2;
            //byte[] bytes = new byte[byteLength];
            //string hex;
            //int j = 0;
            //for (int i=0; i<bytes.Length; i++)
            //{
            //    hex = new String(new Char[] {newString[j], newString[j+1]});
            //    bytes[i] = HexToByte(hex);
            //    j = j+2;
            //}
            return HexToByte(newString);
        }

        private static byte[] HexToByte(string hexString)
        {
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 获取取第index位
        /// </summary>
        /// <param name="b"></param>
        /// <param name="index">index从0开始 </param>
        /// <returns></returns>
        public static bool GetBit(byte b, int index) { return ((b & (1 << index)) > 0) ? true : false; }

        /// <summary>
        /// 将第index位设为1
        /// </summary>
        /// <param name="b"></param>
        /// <param name="index">index从0开始</param>
        /// <returns></returns>
        public static byte SetBit(byte b, int index) { return (byte)(b | (1 << index)); }

        /// <summary>
        /// 将第index位设为0 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="index">index从0开始</param>
        /// <returns></returns>
        public static byte ClearBit(byte b, int index) { return (byte)(b & (byte.MaxValue - (1 << index))); }

        /// <summary>
        /// 将第index位取反 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="index">index从0开始</param>
        /// <returns></returns>
        public static byte ReverseBit(byte b, int index) { return (byte)(b ^ (byte)(1 << index)); }

        /// <summary>
        /// 非独占性延时函数
        /// </summary>
        /// <param name="milliSecond"></param>
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }

    }
}