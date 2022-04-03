using System;

namespace _02_ByteBank
{
    public class ContaCorrente
    {
        public int idAgencia;
        public int idConta;
        public string titular;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
    }
}
