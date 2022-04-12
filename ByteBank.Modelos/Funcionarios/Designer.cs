using System;

namespace ByteBank.Funcionarios
{
    public class Designer : FuncionarioBase
    {
        public Designer(string cpf) : base(cpf, 2500)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
