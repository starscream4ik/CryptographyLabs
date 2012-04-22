using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptoAlg
{
    public class Gamma : CryptoStrategy
    {
        public Gamma(String alphabet)
            : base(alphabet)
        { }


        // key - key for Random
        public override string getCrypt(string inputMessage, string key)
        {
            StringBuilder resultBuilder = new StringBuilder();

            int numberKey = Convert.ToInt32(key);
            Random rand = new Random(numberKey);

            for (int i = 0; i < inputMessage.Length; i++)
            {
                //int currentIndex = inputMessage[i];
                if (inputMessage[i] == ' ')
                {
                    resultBuilder.Append(' ');
                    continue;
                }
                else
                {
                    int indexOfCurrentSymbol = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                    int k = rand.Next(CryptoStrategy.amountOfSymbolsInAlphabet);
                    int newIndex = (indexOfCurrentSymbol + k) % CryptoStrategy.amountOfSymbolsInAlphabet;

                    char newSymbol = CryptoStrategy.alphabet[newIndex];
                    resultBuilder.Append(newSymbol);
                }
            }

            return resultBuilder.ToString();


        }

        public override string getDecrypt(string inputMessage, string key)
        {
            StringBuilder resultBuilder = new StringBuilder();

            int numberKey = Convert.ToInt32(key);
            Random rand = new Random(numberKey);

            for (int i = 0; i < inputMessage.Length; i++)
            {
                //int currentIndex = inputMessage[i];
                if (inputMessage[i] == ' ')
                {
                    resultBuilder.Append(' ');
                    continue;
                }
                else
                {
                    int indexOfCurrentSymbol = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                    int k = rand.Next(CryptoStrategy.amountOfSymbolsInAlphabet);
                    char newSymbol;

                    if (indexOfCurrentSymbol > k)
                    {
                        int newIndex = (indexOfCurrentSymbol - k) % CryptoStrategy.amountOfSymbolsInAlphabet;
                        newSymbol = CryptoStrategy.alphabet[newIndex];
                    }
                    else
                    {
                        int newIndex = (CryptoStrategy.amountOfSymbolsInAlphabet -k + indexOfCurrentSymbol) % CryptoStrategy.amountOfSymbolsInAlphabet;
                        newSymbol = CryptoStrategy.alphabet[newIndex];
                    }
                    resultBuilder.Append(newSymbol);
                }
            }

            return resultBuilder.ToString();
        }
    }
}
