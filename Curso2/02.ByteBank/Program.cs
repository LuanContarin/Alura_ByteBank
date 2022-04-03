using System;

namespace _02_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente
            {
                titular = "Luan Contarin da Silva",
                saldo = 222.13
            };

            Console.WriteLine("Saldo inicial: " + contaCorrente.saldo);

            Console.Write("Digite o valor para saque: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());

            bool resultSaque = contaCorrente.Sacar(valorSaque);

            if (resultSaque)
                Console.WriteLine("Valor sacado com sucesso!\nNovo saldo da conta: " + contaCorrente.saldo);
            else
                Console.WriteLine("Não foi possível sacar o valor.");

            Console.ReadLine();
        }
    }
}
