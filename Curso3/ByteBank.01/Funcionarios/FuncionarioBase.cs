using System;
using ByteBank_01;

namespace ByteBank_01.Funcionarios
{
    public abstract class FuncionarioBase
    {
        public FuncionarioBase(string cpf)
        {
            Cpf = cpf;
            TotalFuncionarios++;
        }

        public static int TotalFuncionarios { get; private set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
