using System;

namespace _03_ByteBank
{
    public class ContaCorrente
    {
        public int idAgencia;
        public int idConta;
        public double saldo = 100;
        public Cliente titular;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
    }
}
