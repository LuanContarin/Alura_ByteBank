using System;
using ByteBank.Modelos.Abstracts;
using ByteBank.Modelos.Util;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : FuncionarioBase, IAutenticavel
    {
        private readonly AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        protected FuncionarioAutenticavel(decimal cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenha(Senha, senha);
        }
    }
}
