using System;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioBase
    {
        protected FuncionarioBase(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public static int TotalFuncionarios { get; private set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        internal protected abstract double GetBonificacao();
        internal protected abstract void AumentarSalario();
    }
}
