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
                    alphabet += ch.ToString();
                }
                for (char ch = ':'; ch <= '?'; ch++)
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

 

    }
}

