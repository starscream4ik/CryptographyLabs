using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cryptoAlg;

namespace labCrypto
{
    public abstract class Crypter
    {
        private CryptoStrategy cryptMethod;

        public void  setStrategy(CryptoStrategy strategy)
        {
            this.cryptMethod = strategy;
        }
        
        public String getCrypt(String message, String key)
        {
            return cryptMethod.getCrypt(message, key);
        }

        public String getDecrypt(String message, string key)
        {
            return cryptMethod.getDecrypt(message, key);
        }

    }
}
