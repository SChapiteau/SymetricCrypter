using System;
using System.Linq;
using Xunit;

namespace AsymetricCrypter
{
    public class CrypterShould
    {
        [Fact]
        public void EncrypAndDecryptText()
        {
            var text = "Hello SOAT";
            var key = "MySuperRandomKey";

            var cryptage = Crypter.EncryptDecrypt(text, key);
            Assert.NotEqual(text, cryptage);

            var textDecrypt = Crypter.EncryptDecrypt(cryptage, key);
            Assert.Equal(text, textDecrypt);

        }
    }
}
