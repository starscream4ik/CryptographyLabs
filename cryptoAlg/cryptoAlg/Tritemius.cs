using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptoAlg
{
    public class Tritemius : CryptoStrategy
    {
        public Tritemius(String alphabet)
            : base(alphabet)
        { }

        public override String getCrypt(string inputMessage, string key)
        {
            String result = String.Empty;
            StringBuilder resultBuilder = new StringBuilder();
            String[] numbers = inputMessage.Split(';');
            int A, B, C;
            #region A, B
            if (numbers.Length == 2)
            {
                if (isNumber(numbers[0]) && isNumber(numbers[1]))
                {
                    A = Convert.ToInt32(numbers[0]);
                    B = Convert.ToInt32(numbers[1]);

                    int numberKey = 0;
                    String currentSymbol = String.Empty;
                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        if (inputMessage[i] == ' ')
                        {
                            resultBuilder.Append(' ');
                            continue;
                        }
                        else
                        {
                            numberKey = linearKey(A, B, i);
                            int currentIndexOfSymbol = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                            int newIndex = (currentIndexOfSymbol + numberKey) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            char newSymbol = CryptoStrategy.alphabet[newIndex];
                            resultBuilder.Append(newSymbol);
                        }
                    }
                }
            }
            #endregion
            #region A, B, C
            if (numbers.Length == 3)
            {
                if (isNumber(numbers[0]) && isNumber(numbers[1]) && isNumber(numbers[2]))
                {
                    A = Convert.ToInt32(numbers[0]);
                    B = Convert.ToInt32(numbers[1]);
                    C = Convert.ToInt32(numbers[2]);

                    int numberKey = 0;
                    String currentSymbol = String.Empty;
                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        if (inputMessage[i] == ' ')
                        {
                            resultBuilder.Append(' ');
                            continue;
                        }
                        else
                        {
                            numberKey = notLinear(A, B, C, i);
                            int currentIndexOfSymbol = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                            int newIndex = (currentIndexOfSymbol + numberKey) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            char newSymbol = CryptoStrategy.alphabet[newIndex];
                            resultBuilder.Append(newSymbol);
                        }
                    }
                }

            }
            #endregion

            #region key is a String
            else
            {
                StringBuilder wordKey = new StringBuilder();
                if (inputMessage.Length > key.Length)
                {
                    int repeatAmount = (int)Math.Round((double)((inputMessage.Length - key.Length) / key.Length)) + 2;
                    for (int i = 0; i < repeatAmount; i++)
                    {
                        wordKey.Append(key);
                    }

                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        if (inputMessage[i] == ' ')
                        {
                            resultBuilder.Append(' ');
                            continue;
                        }
                        else
                        {
                            int currentSymbolIndex = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                            int wordKeyIndex = CryptoStrategy.alphabet.IndexOf(wordKey[i]);

                            int newIndex = (currentSymbolIndex + wordKeyIndex) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            char newSymbol = CryptoStrategy.alphabet[newIndex];

                            resultBuilder.Append(newSymbol);
                        }
                        //resultBuilder
                    }

                }

            }
            #endregion
            result = resultBuilder.ToString();
            return result;
            //throw new NotImplementedException();
        }

        private int linearKey(int A, int B, int index)
        {
            return A * index + B;
        }

        private int notLinear(int A, int B, int C, int index)
        {
            return A * (int)Math.Pow(index, 2) + B * index + C;
        }

        public override String getDecrypt(string inputMessage, string key)
        {
            String result = String.Empty;
            StringBuilder resultBuilder = new StringBuilder();
            String[] numbers = inputMessage.Split(';');
            int A, B, C;
            if (numbers.Length == 2)
            {
                if (isNumber(numbers[0]) && isNumber(numbers[1]))
                {
                    A = Convert.ToInt32(numbers[0]);
                    B = Convert.ToInt32(numbers[1]);

                    int numberKey = 0;
                    String currentSymbol = String.Empty;
                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        if (inputMessage[i] == ' ')
                        {
                            resultBuilder.Append(' ');
                            continue;
                        }
                        else
                        {
                            numberKey = linearKey(A, B, i);
                            int currentIndexOfSymbol = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                            int newIndex;

                            if (numberKey > CryptoStrategy.amountOfSymbolsInAlphabet)
                            {
                                newIndex = (CryptoStrategy.amountOfSymbolsInAlphabet - numberKey + currentIndexOfSymbol) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            }
                            else
                            {
                                newIndex = (currentIndexOfSymbol - numberKey) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            }
                            char newSymbol = CryptoStrategy.alphabet[newIndex];
                            resultBuilder.Append(newSymbol);
                        }
                    }
                }
            }
            if (numbers.Length == 3)
            {
                if (isNumber(numbers[0]) && isNumber(numbers[1]) && isNumber(numbers[2]))
                {
                    A = Convert.ToInt32(numbers[0]);
                    B = Convert.ToInt32(numbers[1]);
                    C = Convert.ToInt32(numbers[2]);

                    int numberKey = 0;
                    String currentSymbol = String.Empty;
                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        if (inputMessage[i] == ' ')
                        {
                            resultBuilder.Append(' ');
                            continue;
                        }
                        else
                        {
                            numberKey = notLinear(A, B, C,i);
                            int currentIndexOfSymbol = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                            int newIndex;

                            if (numberKey > CryptoStrategy.amountOfSymbolsInAlphabet)
                            {
                                newIndex = (CryptoStrategy.amountOfSymbolsInAlphabet - numberKey + currentIndexOfSymbol) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            }
                            else
                            {
                                newIndex = (currentIndexOfSymbol - numberKey) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            }
                            char newSymbol = CryptoStrategy.alphabet[newIndex];
                            resultBuilder.Append(newSymbol);
                        }
                    }
                }

            }

            else
            {
                //String wordKey = string.Empty;
                StringBuilder wordKey = new StringBuilder();
                if (inputMessage.Length > key.Length)
                {
                    int repeatAmount = (int)Math.Round((double)((inputMessage.Length - key.Length) / key.Length)) + 2;
                    for (int i = 0; i < repeatAmount; i++)
                    {
                        wordKey.Append(key);
                    }

                    for (int i = 0; i < inputMessage.Length; i++)
                    {
                        if (inputMessage[i] == ' ')
                        {
                            resultBuilder.Append(' ');
                            continue;
                        }
                        else
                        {
                            int currentSymbolIndex = CryptoStrategy.alphabet.IndexOf(inputMessage[i]);
                            int wordKeyIndex = CryptoStrategy.alphabet.IndexOf(wordKey[i]);
                            int newIndex = 0;

                            if (wordKeyIndex > currentSymbolIndex)
                            {
                                newIndex = (CryptoStrategy.amountOfSymbolsInAlphabet - wordKeyIndex + currentSymbolIndex) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            }
                            else
                            {
                                newIndex = (currentSymbolIndex - wordKeyIndex) % CryptoStrategy.amountOfSymbolsInAlphabet;
                            }


                            char newSymbol = CryptoStrategy.alphabet[newIndex];

                            resultBuilder.Append(newSymbol);
                        }
                        //resultBuilder
                    }

                }

            }
            result = resultBuilder.ToString();
            return result;

        }

    }
}
