using System;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : FuncionarioBase
    {
        public Desenvolvedor(string cpf) : base(cpf, 3500)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
