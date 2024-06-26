using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace Textlow
{
    public class TextlowTextOperations
    {
        public string TextToBrainfuck(string input)
        {
            input = TextToASCII(input);
            string s = "++++++++++" + "[";
            string t = "";
            string s2 = "";
            string s3 = "";
            foreach (char ch in input)
            {
                int i_ord = (int)ch;
                int i_cdc = cdc((int)ch);
                int i_max = 256 - i_ord;
                string s1 = "";
                string t1 = "";

                if (i_max < 128)
                {
                    for (int i = 0; i < i_max; i++)
                    {
                        s1 += '-';
                    }
                }
                else
                {
                    for (int i = 0; i < i_cdc / 10; i++)
                    {
                        s1 += '+';
                    }
                }
                s += '>' + s1;
                if (i_ord - i_cdc > 0)
                {
                    for (int i = 0; i < Math.Abs(i_ord - i_cdc); i++)
                    {
                        t1 += '+';
                    }

                }
                else
                {
                    for (int i = 0; i < Math.Abs(i_ord - i_cdc); i++)
                    {
                        t1 += '-';
                    }
                }
                t += '>' + t1;
            }
            for (int i = 0; i < input.Length; i++)
            {
                s2 += '<';
            }
            for (int i = 0; i < input.Length - 1; i++)
            {
                s3 += '<';
            }
            s += s2 + "-]" + t + s3 + "[.>]";
            return s;
        }

        public string BrainfuckToText(string input)
        {
            input = TextToASCII(input);
            string output = "";
            byte[] tape;
            int pointer = 0;
            char[] chinput;
            chinput = input.ToCharArray();
            tape = new byte[300000];
            var unmatchedBracketCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '>':
                        pointer++;
                        break;
                    case '<':
                        pointer--;
                        break;
                    case '+':
                        tape[pointer]++;
                        break;
                    case '-':
                        tape[pointer]--;
                        break;
                    case '.':
                        output += Convert.ToChar(tape[pointer]);
                        break;
                    case ',':
                        output += " ";
                        break;
                    case '[':
                        if (tape[pointer] == 0)
                        {
                            unmatchedBracketCounter++;
                            while (input[i] != ']' || unmatchedBracketCounter != 0)
                            {
                                i++;

                                if (input[i] == '[')
                                {
                                    unmatchedBracketCounter++;
                                }
                                else if (input[i] == ']')
                                {
                                    unmatchedBracketCounter--;
                                }
                            }
                        }
                        break;
                    case ']':
                        if (tape[pointer] != 0)
                        {
                            unmatchedBracketCounter++;
                            while (input[i] != '[' || unmatchedBracketCounter != 0)
                            {
                                i--;

                                if (input[i] == ']')
                                {
                                    unmatchedBracketCounter++;
                                }
                                else if (input[i] == '[')
                                {
                                    unmatchedBracketCounter--;
                                }
                            }
                        }
                        break;
                }
            }
            return output;
        }

        private static int cdc(int i)
        {
            int t = i % 10;
            if (t > 5)
            {
                i += 10;
            }
            return i - t;
        }

        public string TextToBinary(string text)
        {
            byte[] bytes = Encoding.GetEncoding(437).GetBytes(text);
            StringBuilder sb = new StringBuilder();
            foreach (char c in bytes)
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public string BinaryToText(string text)
        {
            text = text.Replace(" ", "");
            if (!text.All(c => "01".Contains(c)))
            {
                return "Error: Text is not a binary string";
            }
            if (text.Length % 8 != 0)
            {
                int a = ((text.Length / 8) + 1) * 8;
                text = text.PadLeft(((text.Length / 8) + 1) * 8, '0');
            }
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < text.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(text.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public string TextDivision(string separator, string text, int number, bool back)
        {
            if (back)
            {
                text = additionalFunctions.ReverseString(text);
                separator = additionalFunctions.ReverseString(separator);
            }
            string result = "";
            int i = 0;
            foreach (char c in text)
            {
                if (i % number == 0 && i != 0)
                {
                    result += separator;
                }
                result += c;
                i++;
            }
            if (back)
            {
                result = additionalFunctions.ReverseString(result);
            }
            return result;
        }

        public string TextToASCII(string text)
        {
            byte[] bytes = Encoding.GetEncoding(437).GetBytes(text);
            return Encoding.ASCII.GetString(bytes);
        }

        public string Capitalize(string text)
        {
            Char[] ca = text.ToCharArray();

            foreach (Match m in Regex.Matches(text, @"\b[a-z]"))
            {
                ca[m.Index] = Char.ToUpper(ca[m.Index]);
            }
            return new string(ca);
        }

        public string TextToNATOPhoneticAlphabet(string text)
        {
            Dictionary<char, string> alphabet = additionalFunctions.NATOPhoneticAlphabet();
            text = text.ToUpper();
            string result = "";
            bool firstLoop = true;
            foreach (char ch in text)
            {
                result += firstLoop ? "" : " ";
                if (alphabet.ContainsKey(ch))
                {
                    result += alphabet[ch];
                }
                else
                {
                    result += ch;
                }
                firstLoop = false;
            }
            return result;
        }

        public string TextFromNATOPhoneticAlphabet(string text)
        {
            Dictionary<char, string> alphabet = additionalFunctions.NATOPhoneticAlphabet();            
            string result = "";
            foreach (string s in text.Split(' '))
            {
                if (alphabet.ContainsValue(s))
                {
                    result += alphabet.FirstOrDefault(x => x.Value == s).Key;
                }
                else
                {
                    result += s;
                }
            }
            return result;
        }
        public string TextToByteArray(string text, string separator)
        {
            return string.Join(separator, text.Select(x => (int)x)); 
        }
        
        public string ByteArrayToText(string text, string separator)
        {
            return string.Join("", text.Replace(separator, "|").Split('|').Select(x => (char)int.Parse(x))); 
        }
    }
}
