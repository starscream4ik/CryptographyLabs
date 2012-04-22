using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cryptoAlg;

namespace labCrypto
{
    public class SimpleCrypter : Crypter
    {
        public SimpleCrypter(CryptoStrategy strategy)
        {
            setStrategy(strategy);
        }
    }
}
