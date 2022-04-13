using System;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : FuncionarioBase
    {
        public Desenvolvedor(decimal cpf) : base(cpf, 3500)
        {
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.1;
        }

        internal protected override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
