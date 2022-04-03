using System;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;
            TotalDeContas++;
        }

        public int Agencia { get; set; }
        public int Conta { get; set; }
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
        public Cliente Titular { get; set; }
        public static int TotalDeContas { get; private set; }

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
    }
}
