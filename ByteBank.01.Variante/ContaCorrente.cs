using System;
using Curso4_ByteBank_01_Variante.Util.Exceptions;

namespace Curso4_ByteBank_01_Variante
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int numero, Cliente titular)
        {
            if (agencia <= 0)
                throw new ArgumentException("A agência deve ser maior que 0.", nameof(agencia));
            if (numero <= 0)
                throw new ArgumentException("O número da conta deve ser maior que 0.", nameof(numero));

            Agencia = agencia;
            Numero = numero;
            Titular = titular ?? throw new ArgumentNullException(nameof(titular), "A conta deve possuir um titular.");
            TotalDeContas++;
        }

        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; private set; } = 100;
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public Cliente Titular { get; protected set; }
        public static int TotalDeContas { get; private set; }

        #region Métodos

        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor para saque inválido.", nameof(valor));
            if (Saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            Saldo -= valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
                throw new ArgumentException("valor para transferência inválido.", nameof(valor));

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw;
            }

            contaDestino.Depositar(valor);
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor para saque inválido.", nameof(valor));

            Saldo += valor;
        }

        #endregion
    }
}
