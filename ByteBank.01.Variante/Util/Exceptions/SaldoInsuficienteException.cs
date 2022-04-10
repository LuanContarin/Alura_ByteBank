using System;

namespace Curso4_ByteBank_01_Variante.Util.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque no valor de R$" + valorSaque + " com saldo disponível de R$" + saldo + "!")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

    }
}
