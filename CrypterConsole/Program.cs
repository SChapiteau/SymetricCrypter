using AsymetricCrypter;
using System;

namespace CrypterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
  
            var text = "Hello SOAT";
            var key = "MySuperRandomKey";

            Console.WriteLine($@"Text : {text}");
            Console.WriteLine($@"Clef : {key}");

            var cryptage = Crypter.EncryptDecrypt(text, key);
            Console.WriteLine($@"Cryptage : {cryptage}");

            var textDecrypt = Crypter.EncryptDecrypt(cryptage, key);
            Console.WriteLine($@"DeCryptage : {textDecrypt}");

            Console.ReadLine();
        }
    }
}
