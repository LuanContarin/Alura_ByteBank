using System;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(decimal cpf) : base(cpf, 2000)
        {
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        internal protected override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
