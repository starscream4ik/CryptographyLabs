using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptoAlg
{
    public class Ceasar : CryptoStrategy
    {
        public Ceasar(String alphabet):base(alphabet)
        {
            //this.alphabet = alphabet;
            //CryptoStrategy.alphabet = alphabet;
            //amountOfSymbolsInAlphabet = CryptoStrategy.alphabet.Length;
        }

        public override String getCrypt(String inputMessage, String key)
        {
            String cipher = String.Empty;
            int shiftKey = Int32.Parse(key);

            if (shiftKey >= alphabet.Length || shiftKey <= 0) throw new Exception("Wrong shift!");

            for (int i = 0; i < inputMessage.Length; i++)
            {
                char currentCharacterOfInputString = inputMessage[i];

                if (alphabet.IndexOf(currentCharacterOfInputString) < 0)
                {
                    throw new Exception("No such character in alphabet!");
                }


                int indexOfSymbolInAlphabet = alphabet.IndexOf(currentCharacterOfInputString);
                int cryptedSymbolPosition = (indexOfSymbolInAlphabet + shiftKey) % CryptoStrategy.amountOfSymbolsInAlphabet;
                cipher += alphabet[cryptedSymbolPosition].ToString();

            }

            return cipher;
        }

        public override String getDecrypt(String inputMessage, String key)
        {
            String cipher = String.Empty;
            int shiftKey = Int32.Parse(key);
            if (shiftKey >= alphabet.Length || shiftKey <= 0) throw new Exception("Wrong shift!");

            for (int i = 0; i < inputMessage.Length; i++)
            {
                char currentCharacterOfInputString = inputMessage[i];

                if (alphabet.IndexOf(currentCharacterOfInputString) < 0)
                {
                    throw new Exception("No such character in alphabet!");
                }

                int indexOfSymbolInAlphabet = alphabet.IndexOf(currentCharacterOfInputString);
                int decryptSymbolPosition;

                if (indexOfSymbolInAlphabet - shiftKey < 0)
                {
                    decryptSymbolPosition = (CryptoStrategy.amountOfSymbolsInAlphabet - shiftKey + indexOfSymbolInAlphabet) % CryptoStrategy.amountOfSymbolsInAlphabet;
                    cipher += alphabet[decryptSymbolPosition].ToString();
                }
                else
                {
                    decryptSymbolPosition = (indexOfSymbolInAlphabet - shiftKey) % amountOfSymbolsInAlphabet;
                    cipher += alphabet[decryptSymbolPosition].ToString();
                }


            }

            return cipher;

        }

    }

}
