using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace cryptoAlg
{
    public class DESalgo : CryptoStrategy
    {
        public DESalgo(String alphabet)
            : base(alphabet)
        { }

        
        public override string getCrypt(string inputMessage, string key)
        {
            String result = String.Empty;
            String[] keys = key.Split(';');
            String desKey = keys[0];
            String initVect = keys[1];

            //if (desKey.Length != 8 && initVect.Length != 8)
            //    throw new Exception("You must enter word with 8 symbols");

            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
            //cryptic.Key = ASCIIEncoding.ASCII.GetBytes(desKey);
            //cryptic.IV = ASCIIEncoding.ASCII.GetBytes(initVect);

            cryptic.Key = UnicodeEncoding.Unicode.GetBytes(desKey);
            cryptic.IV = UnicodeEncoding.Unicode.GetBytes(initVect);

            FileStream fs = new FileStream(@"d:\test.txt", FileMode.Create, FileAccess.Write);
            CryptoStream crStream = new CryptoStream(fs, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
            try
            {
                byte[] data = UnicodeEncoding.Unicode.GetBytes(inputMessage);
                //byte[] data = ASCIIEncoding.ASCII.GetBytes(inputMessage);
                //data = Encoding.Convert(Encoding.ASCII, Encoding.UTF32, data);
                crStream.Write(data, 0, data.Length);
            }
            finally
            {
                crStream.Close();
                fs.Close();
            }

            result =  File.ReadAllText(@"d:\test.txt");  
            return result;
            //throw new NotImplementedException();
        }

        public override string getDecrypt(string inputMessage, string key)
        {
            String result = String.Empty;
            String[] keys = key.Split(';');
            String desKey = keys[0];
            String initVect = keys[1];



            //if (desKey.Length != 8 && initVect.Length != 8)
            //    throw new Exception("You must enter word with 8 symbols");
            
            FileStream fs = new FileStream(@"d:\test.txt", FileMode.Open, FileAccess.Read);
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
            //cryptic.Key = UTF32Encoding.UTF32.GetBytes(desKey);
            //cryptic.IV = UTF32Encoding.UTF32.GetBytes(initVect);
            //cryptic.Key = ASCIIEncoding.ASCII.GetBytes(desKey);
            //cryptic.IV = ASCIIEncoding.ASCII.GetBytes(initVect);

            cryptic.Key = UnicodeEncoding.Unicode.GetBytes(desKey);
            cryptic.IV = UnicodeEncoding.Unicode.GetBytes(initVect);

            CryptoStream crStream = new CryptoStream(fs, cryptic.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(crStream, Encoding.Unicode);
            try
            {
                string data = reader.ReadToEnd();
                result = data;
                //byte[] byteData = Encoding.ASCII.GetBytes(data);
                //byteData = Encoding.Convert(Encoding.ASCII, Encoding.UTF32, byteData);
                //result =  byteData.ToString();
            }
            finally
            {
                reader.Close();
                crStream.Close();
            }
            //throw new NotImplementedException();

            return result;
        }

    }
}
