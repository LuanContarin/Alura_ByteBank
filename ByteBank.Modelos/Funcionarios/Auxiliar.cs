using System;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : FuncionarioBase
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        internal protected override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
