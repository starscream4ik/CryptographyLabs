using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cryptoAlg;

namespace labCrypto
{
    public class CeasarCrypter : Crypter
    {
        public CeasarCrypter(CryptoStrategy strategy)
        {
            setStrategy(strategy);
        }
    }
}
