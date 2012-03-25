using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptoAlg
{
    public class Ceasar : CryptoStrategy
    {
        private String alphabet;
        private int amountOfSymbolsInAlphabet;


        public Ceasar(String alphabet)
        {
            this.alphabet = alphabet;
            amountOfSymbolsInAlphabet = this.alphabet.Length;
        }

        public String getCrypt(String inputMessage, String key)
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
                int cryptedSymbolPosition = (indexOfSymbolInAlphabet + shiftKey) % this.amountOfSymbolsInAlphabet;
                cipher += alphabet[cryptedSymbolPosition].ToString();

            }

            return cipher;
        }

        public String getDecrypt(String inputMessage, String key)
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
                    decryptSymbolPosition = (this.amountOfSymbolsInAlphabet - shiftKey + indexOfSymbolInAlphabet) % this.amountOfSymbolsInAlphabet;
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
