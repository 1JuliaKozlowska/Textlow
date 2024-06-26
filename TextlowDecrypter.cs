using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Textlow
{
    public class TextlowDecrypter
    {
        public string tripleDES(string text, string decryptKey)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(text);
            string key = decryptKey;
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public string base64(string text)
        {
            var base64EncodedBytes = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public string CaesarCipher(string input, int key)
        {
            TextlowEncrypter textlowEncrypter = new TextlowEncrypter();
            return textlowEncrypter.CaesarCipher(input, 26 - key);
        }

        public string VigenereCipher(string chiffre, string keyText)
        {
            TextlowTextOperations textlowTextOperations = new TextlowTextOperations();
            chiffre = textlowTextOperations.TextToASCII(chiffre);
            keyText = textlowTextOperations.TextToASCII(keyText);
            keyText = keyText.ToUpper();
            keyText = keyText.Replace(" ", "");           

            string encryption = "";
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphabet2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            string key = additionalFunctions.VigenereCipherAdjustKeyLength(chiffre, keyText);

            int j = 0;
            foreach (char ch in chiffre)
            {
                if (alphabet.Contains(ch))
                {
                    int a = 0;
                    if ((Array.IndexOf(alphabet, ch) - Array.IndexOf(alphabet, key[j])) < 0)
                    {
                        a = 26 + (Array.IndexOf(alphabet, ch) - Array.IndexOf(alphabet, key[j]));
                    }
                    else
                    {
                        a = (Array.IndexOf(alphabet, ch) - Array.IndexOf(alphabet, key[j]));
                    }
                    encryption += alphabet[a % 26];
                    j++;
                }
                else if (alphabet2.Contains(ch))
                {
                    int a = 0;
                    if ((Array.IndexOf(alphabet2, ch) - Array.IndexOf(alphabet, key[j])) < 0)
                    {
                        a = 26 + (Array.IndexOf(alphabet2, ch) - Array.IndexOf(alphabet, key[j]));
                    }
                    else
                    {
                        a = (Array.IndexOf(alphabet2, ch) - Array.IndexOf(alphabet, key[j]));
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
