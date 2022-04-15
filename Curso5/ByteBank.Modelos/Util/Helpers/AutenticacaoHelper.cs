using System;

namespace ByteBank.Modelos.Util
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senha, string senhaTentativa)
        {
            return senha == senhaTentativa;
        }
    }
}
