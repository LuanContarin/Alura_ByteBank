using System;

namespace ByteBank_01.Modelos
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }

        public SaldoInsuficienteException(string mensagem, Exception innerException)
            : base(mensagem, innerException)
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
