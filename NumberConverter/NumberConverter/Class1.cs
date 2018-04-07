using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    public class Roman_Arabic
    {
        // Maps letters to numbers.
        public static Dictionary<char, int> CharValues = null;

        // Convert Roman numerals to an integer.
        public static int RomanToArabic(string roman)
        {
            // Initialize the letter map.
            if (CharValues == null)
            {
                CharValues = new Dictionary<char, int>();
                CharValues.Add('I', 1);
                CharValues.Add('V', 5);
                CharValues.Add('X', 10);
                CharValues.Add('L', 50);
                CharValues.Add('C', 100);
                CharValues.Add('D', 500);
                CharValues.Add('M', 1000);
            }

            if (roman.Length == 0) return 0;
            roman = roman.ToUpper();

            // See if the number begins with (.
            if (roman[0] == '(')
            {
                // Find the closing parenthesis.
                int pos = roman.LastIndexOf(')');

                // Get the value inside the parentheses.
                string part1 = roman.Substring(1, pos - 1);
                string part2 = roman.Substring(pos + 1);
                return 1000 * RomanToArabic(part1) + RomanToArabic(part2);
            }

            // The number doesn't begin with (.
            // Convert the letters' values.
            int total = 0;
            int last_value = 0;
            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int new_value = CharValues[roman[i]];

                // See if we should add or subtract.
                if (new_value < last_value)
                    total -= new_value;
                else
                {
                    total += new_value;
                    last_value = new_value;
                }
            }

            if (roman.Contains("VV") || roman.Contains("LL") || roman.Contains("DD"))
            { throw new System.InvalidOperationException("Incorrect format."); }

            if (roman.Contains("IIII") || roman.Contains("XXXX") || roman.Contains("CCCC"))
            { throw new System.InvalidOperationException("Incorrect format."); }

            // Return the result.
            return total;
        }

        internal static double RomanToArabic(Func<string> toString)
        {
            throw new NotImplementedException();
        }
    }
    public class Arabic_Roman
    {
        // Map digits to letters.
        public static string[] ThouLetters = { "", "M", "MM", "MMM" };
        public static string[] HundLetters =
            { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        public static string[] TensLetters =
            { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        public static string[] OnesLetters =
            { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        // Convert Roman numerals to an integer.
        public static string ArabicToRoman(int arabic)
        {
            // See if it's >= 4000 or < 1.
            if (arabic < 1 || arabic >= 4000)
            {
                // Throw an error for the incorrect values.
                throw new System.InvalidOperationException("Input cannot be over 3999 or less than 1");
            }
            // Otherwise process the letters.
            string result = "";

            // Pull out thousands.
            int num;
            num = arabic / 1000;
            result += ThouLetters[num];
            arabic %= 1000;

            // Handle hundreds.
            num = arabic / 100;
            result += HundLetters[num];
            arabic %= 100;

            // Handle tens.
            num = arabic / 10;
            result += TensLetters[num];
            arabic %= 10;

            // Handle ones.
            result += OnesLetters[arabic];

            return result;


        }




    }
    
    
    public class Bin_Hex
    {
        public static string BinaryToHexadecimal(string Binary)
        {
            string strHex = Convert.ToInt32(Binary, 2).ToString("X");
            return strHex;
        }
    }
    public class Hex_Bin
    {
        public static string HexadecimalToBinary(string Hex)
        {
            string strBinary = Convert.ToString(Convert.ToInt32(Hex, 16), 2);
            return strBinary;
        }
    }
    public class Roman_Bin
    {
        public static string RomanToBinary(string Roman)
        {
            int a = Roman_Arabic.RomanToArabic(Roman);
            string strRoman = Convert.ToString(a, 2);
            return strRoman;
        }
    }
    public class Bin_Roman
    {
        public static string BinaryToRoman(int Bin)
        {
            string B2A = Convert.ToString(Bin, 10);
            int ara = Convert.ToInt32(B2A, 2);
            string a = Arabic_Roman.ArabicToRoman(ara);
            string strBin = Convert.ToString(a);
            return strBin;
        }
    }
    public class Arabic_Hex
    {
        public static string ArabicToHexadecimal(string Arabic)
        {
            string strArabic = Convert.ToInt32(Arabic, 10).ToString("X");
            return strArabic;
        }
    }
    public class Hex_Arabic
    {
        public static string HexadecimalToArabic(string Hex)
        {
            string strHexdec = Convert.ToString(Convert.ToInt32(Hex, 16), 10);
            return strHexdec;
        }
    }
    public class Arabic_Bin
    {
        public static string ArabicToBinary(int Arabic)
        {
            string strAra = Convert.ToString(Arabic, 2);
            return strAra;
        }
    }
    public class Bin_Arabic
    {
        public static string BinaryToArabic(string Binary)
        {
            string strBin = Convert.ToString(Convert.ToInt32(Binary, 2), 10);
            return strBin;
        }
    }
    public class Hex_Roman
    {
        public static string HexToRoman(string Hex)
        {
            string H2A = Convert.ToString(Convert.ToInt32(Hex, 16), 10);
            int ara = Convert.ToInt32(H2A);
            string a = Arabic_Roman.ArabicToRoman(ara);
            string strHex = Convert.ToString(a);
            return strHex;
        }
    }
    public class Roman_Hex
    {
        public static string RomanToHexadecimal(string Roman)
        {
            int a = Roman_Arabic.RomanToArabic(Roman);
            string strRoman = Convert.ToString(a, 16);
            return strRoman;
        }
    }
}


        


