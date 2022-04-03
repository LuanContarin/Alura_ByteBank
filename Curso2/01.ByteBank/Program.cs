using System;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente
            {
                titular = "Luan Contarin",
                idConta = 150,
                idAgencia = 48921,
                saldo = 200
            };

            Console.WriteLine(contaCorrente.titular);
            Console.WriteLine("Agência: " + contaCorrente.idAgencia);
            Console.WriteLine("Conta: " + contaCorrente.idConta);
            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
