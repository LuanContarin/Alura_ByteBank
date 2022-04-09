using System;

namespace Curso4_ByteBank_01
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
        public Cliente Titular { get; set; }
        public static int TotalDeContas { get; private set; }

        #region Saldo

        private double _saldo = 100;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value >= 0)
                    _saldo = value;
            }
        }

        #endregion

        #region Métodos

        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
                return false;

            Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        #endregion
    }
}
