using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Textlow
{
    public class TextlowEncrypter
    {
        public string tripleDES(string text, string encryptKey)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(text);
            string key = encryptKey;
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string base64(string text)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }

        public string CaesarCipher(string input, int key)
        {
            TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
            input = textlowTextOperations.TextToASCII(input);
            string output = string.Empty;

            foreach (char ch in input)
                output += additionalFunctions.CaesarCipherHelper(ch, key);

            return output;
        }

        public string VigenereCipher(string plainText, string keyText)
        {
            string encryption = "";
            TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
            plainText = textlowTextOperations.TextToASCII(plainText);
            keyText = textlowTextOperations.TextToASCII(keyText);
            keyText = keyText.ToUpper();
            keyText = keyText.Replace(" ", "");

            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphabet2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            string key = additionalFunctions.VigenereCipherAdjustKeyLength(plainText, keyText);

            int j = 0;
            foreach (char ch in plainText)
            {
                if (alphabet.Contains(ch))
                {
                    int a = 0;
                    if ((Array.IndexOf(alphabet, ch) + Array.IndexOf(alphabet, key[j])) < 0)
                    {
                        a = 26 + (Array.IndexOf(alphabet, ch) - Array.IndexOf(alphabet, key[j]));
                    }
                    else
                    {
                        a = (Array.IndexOf(alphabet, ch) + Array.IndexOf(alphabet, key[j]));
                    }
                    encryption += alphabet[a % 26];
                    j++;
                }
                else if (alphabet2.Contains(ch))
                {
                    int a = 0;
                    if ((Array.IndexOf(alphabet2, ch) + Array.IndexOf(alphabet, key[j])) < 0)
                    {
                        a = 26 + (Array.IndexOf(alphabet2, ch) - Array.IndexOf(alphabet, key[j]));
                    }
                    else
                    {
                        a = (Array.IndexOf(alphabet2, ch) + Array.IndexOf(alphabet, key[j]));
                    }
                    encryption += alphabet2[a % 26];
                    j++;
                }
                else
                {
                    encryption += ch;
                }
            }
            return encryption;
        }

    }
}
