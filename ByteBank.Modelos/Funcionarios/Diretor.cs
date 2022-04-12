using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 7000)
        {
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        internal protected override void AumentarSalario()
        {
            Salario *= 1.3;
        }
    }
}
