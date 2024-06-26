using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textlow
{
    public static class additionalFunctions
    {
        public static bool isAscii(char ch)
        {
            return ch < 128;
        }

        public static bool isHex(string text)
        {
            return text.ToUpper().All(c => "0123456789ABCDEF".Contains(c));
        }

        public static string isHash(string text)
        {
            if (isHex(text))
            {
                switch (text.Length)
                {
                    case 32:
                        return "MD5";
                    case 40:
                        return "SHA1";
                    case 64:
                        return "SHA256";
                    case 96:
                        return "SHA384";
                    case 128:
                        return "SHA512";
                    default:
                        break;
                }
            }
            return "False";
        }

        public static string stringType(string text)
        {
            string[] helper1 = text.Split('.');
            if (text.All(c => "01".Contains(c)))
            {
                return "Binary (or decimal) number";
            }
            else if (text.All(c => "01234567".Contains(c)))
            {
                return "Octal (or decimal) number";
            }
            else if (text.All(char.IsDigit))
            {
                return "Decimal number";
            }
            else if (isHex(text))
            {
                return "Hexadecimal number" + (isHash(text) != "False" ? " (hash)" : "");
            }
            else if ((text.All(c => "0123456789.".Contains(c)) && text.Count(f => f == '.') == 1) || (text.All(c => "0123456789,".Contains(c)) && text.Count(f => f == ',') == 1))
            {
                return "Floating-point number";
            }
            else if (helper1.Length == 4 || helper1.All(s => s.All(Char.IsDigit)))
            {
                if (helper1.All(s => int.Parse(s) < 256 && int.Parse(s) >= 0))
                {
                    return "IP Address";
                }
            }
            return "Text";
        }

        public static string setDistance(string firstText, string secondText, int disctance)
        {
            if (disctance - firstText.Length > 0)
            {
                return firstText + new string(' ', disctance - firstText.Length) + secondText;
            }
            else
            {
                return firstText + secondText;
            }

        }

        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static char CaesarCipherHelper(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);

        }

        public static string VigenereCipherAdjustKeyLength(string text, string keystring)
        {
            string r = keystring;
            while (text.Length > keystring.Length)
            {
                keystring += r;
            }
            return keystring.ToString();
        }

        public static Dictionary<char, string> NATOPhoneticAlphabet()
        {
            Dictionary<char, string> alphabet = new Dictionary<char, string>();
            alphabet.Add('A', "Alfa");
            alphabet.Add('B', "Bravo");
            alphabet.Add('C', "Charlie");
            alphabet.Add('D', "Delta");
            alphabet.Add('E', "Echo");
            alphabet.Add('F', "Foxtrot");
            alphabet.Add('G', "Golf");
            alphabet.Add('H', "Hotel");
            alphabet.Add('I', "India");
            alphabet.Add('J', "Juliett");
            alphabet.Add('K', "Kilo");
            alphabet.Add('L', "Lima");
            alphabet.Add('M', "Mike");
            alphabet.Add('N', "November");
            alphabet.Add('O', "Oscar");
            alphabet.Add('P', "Papa");
            alphabet.Add('Q', "Quebec");
            alphabet.Add('R', "Romeo");
            alphabet.Add('S', "Sierra");
            alphabet.Add('T', "Tango");
            alphabet.Add('U', "Uniform");
            alphabet.Add('V', "Victor");
            alphabet.Add('W', "Whiskey");
            alphabet.Add('X', "X-ray");
            alphabet.Add('Y', "Yankee");
            alphabet.Add('Z', "Zulu");
            alphabet.Add('1', "One");
            alphabet.Add('2', "Two");
            alphabet.Add('3', "Three");
            alphabet.Add('4', "Four");
            alphabet.Add('5', "Five");
            alphabet.Add('6', "Six");
            alphabet.Add('7', "Seven");
            alphabet.Add('8', "Eight");
            alphabet.Add('9', "Nine");
            alphabet.Add('0', "Zeto");
            alphabet.Add(' ', "(space)");
            alphabet.Add('\n', "(enter)");
            alphabet.Add('\t', "(tab)");
            return alphabet;
        }
    }
}
