using System;

namespace ByteBank.Funcionarios
{
    public class Designer : FuncionarioBase
    {
        public Designer(decimal cpf) : base(cpf, 2500)
        {
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        internal protected override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
