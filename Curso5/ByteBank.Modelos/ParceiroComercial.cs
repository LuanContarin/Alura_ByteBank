using System;
using ByteBank.Modelos.Abstracts;
using ByteBank.Modelos.Util;

namespace ByteBank.Modelos
{
    public class ParceiroComercial: IAutenticavel
    {
        private readonly AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenha(Senha, senha);
        }
    }
}
