using System;
using ByteBank.Modelos.Util;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioBase
    {
        private readonly CpfValidator _cpfValidator = new CpfValidator();

        protected FuncionarioBase(decimal cpf, double salario)
        {
            _cpfValidator.ValidarTamanhoCpf(cpf);

            Cpf = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        public static int TotalFuncionarios { get; private set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Cpf { get; private set; }
        public double Salario { get; protected set; }

        internal protected abstract double GetBonificacao();
        internal protected abstract void AumentarSalario();
    }
}
