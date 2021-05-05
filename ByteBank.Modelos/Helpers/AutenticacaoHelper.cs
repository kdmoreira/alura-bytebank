using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos.Helpers
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
