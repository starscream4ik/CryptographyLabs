using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labCrypto
{
 static class Alphabet
    {
        private static string alphabet = String.Empty;
 
        ///
        /// Заглавные буквы английского алфавита
        ///
        public static string EngU
        {
            get
            {
					// another change. git features testing purpose only
                alphabet = "";
                for (char ch = 'A'; ch <= 'Z'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }
 
        ///
        /// Строчные буквы английского алфавита
        ///
        public static string EngL
        {
            get
            {
                alphabet = "";
                for (char ch = 'a'; ch <= 'z'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }
 
        ///
        /// Заглавные буквы русского алфавита
        ///
        public static string RusU
        {
            get
            {
                alphabet = "";
                for (char ch = 'А'; ch <= 'Я'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }
 
        ///
        /// Строчные буквы русского алфавита
        ///
        public static string RusL
        {
            get
            {
                alphabet = "";
                for (char ch = 'а'; ch <= 'я'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
         }

        ///
        /// Скобки и знаки препинания
        ///
        public static string SpecialCharacters
        {
            get
            {
                alphabet = "";
                for (char ch = ' '; ch <= '/'; ch++)
                {
                    if(ch != ' ')
                        alphabet += ch.ToString();
                }
                for (char ch = ':'; ch <= '?'; ch++)
                {
                    alphabet += ch.ToString();
                }
                return alphabet;
            }
        }

        public static string Numbers
        {
            get
            {
                alphabet = "";
                for (char ch = '0'; ch <= '9'; ch++)
                {
                    alphabet += ch.ToString();
                }

                return alphabet;
            }
        }

        public static String EnglishAll
        {
            get
            {
                alphabet = String.Empty;
                alphabet += EngL;
                alphabet += EngU;
                alphabet += SpecialCharacters;
                return alphabet;
            }
        }

        public static String RusAll
        {
            get
            {
                alphabet = String.Empty;
                alphabet += RusL;
                alphabet += RusU;
                alphabet += SpecialCharacters;
                return alphabet;
            }
        }

        public static String All
        {
            get
            {
                alphabet = String.Empty;
                alphabet += RusL;
                alphabet += RusU;
                //alphabet += SpecialCharacters;
                alphabet += EnglishAll;
                alphabet += Numbers;
                return alphabet;
            }
        }

        public static bool symbolsExistsInAlphabet(String line)
        {
            bool result = true;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    continue;
                }
                else
                {
                    if (cryptoAlg.CryptoStrategy.alphabet.IndexOf(line[i]) < 0)
                    {
                        throw new Exception("Not appropriate symbol was found! " + line[i]);
                    }
                }
            }

            return result;
        }

 

    }
}

