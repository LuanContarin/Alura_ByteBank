using System;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);

            ContaCorrente contaCorrente1 = new ContaCorrente(123, 215123);
            ImprimirInformacoesConta(contaCorrente1);

            ContaCorrente contaCorrente2 = new ContaCorrente(123, 123512);
            ImprimirInformacoesConta(contaCorrente2);

            Console.ReadLine();
        }

        public static void ImprimirInformacoesConta(ContaCorrente conta)
        {
            Console.WriteLine();
            Console.WriteLine("//********************************//");
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo: " + conta.Saldo);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);
            Console.WriteLine("//********************************//");
            Console.WriteLine();
        }

    }
}
