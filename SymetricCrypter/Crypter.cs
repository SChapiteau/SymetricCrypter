using System;
using System.Text;

namespace AsymetricCrypter
{
    public class Crypter
    {
        public static string EncryptDecrypt(string text, string key)
        {
            Byte[] messageByte = Encoding.ASCII.GetBytes(text);
            Byte[] keyByte = Encoding.ASCII.GetBytes(key);

            byte[] cryptageByte = new byte[messageByte.Length];
            for (int i = 0; i < messageByte.Length; i++)
            {
                cryptageByte[i] = (byte)(messageByte[i] ^ keyByte[i]);
            }

            return Encoding.UTF8.GetString(cryptageByte);
        }
    }
}
