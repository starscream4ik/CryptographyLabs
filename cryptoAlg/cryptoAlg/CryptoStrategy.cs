using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptoAlg
{
    public interface CryptoStrategy
    {
        String  getCrypt(String inputMessage, String key);
        String  getDecrypt(String inputMessage, String key);
    }
}
