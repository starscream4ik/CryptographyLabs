using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptoAlg
{
    public abstract class CryptoStrategy
    {
        public static String alphabet;
        public static int amountOfSymbolsInAlphabet;

        public CryptoStrategy(String alphabet)
        {
            CryptoStrategy.alphabet = alphabet;
            CryptoStrategy.amountOfSymbolsInAlphabet = alphabet.Length;
        }

        public CryptoStrategy():this(String.Empty)
        {
            
        }
        public abstract String getCrypt(String inputMessage, String key);
        public abstract String getDecrypt(String inputMessage, String key);

        public bool isNumber(String str)
        {
            bool result = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
