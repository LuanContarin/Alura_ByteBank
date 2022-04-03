using System;

namespace ByteBank_01.Funcionarios
{
    public class Diretor : FuncionarioBase
    {
        public Diretor(string cpf) : base(cpf)
        {
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
