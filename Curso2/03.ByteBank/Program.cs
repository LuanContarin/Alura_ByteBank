using System;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            if (contaCorrente.titular == null)
                contaCorrente.titular = new Cliente();

            contaCorrente.titular.nome = "José";
            contaCorrente.titular.idade = 20;
            contaCorrente.titular.profissao = "Dev";

            Console.WriteLine("nome titular: " + contaCorrente.titular.nome);
            Console.WriteLine("Idade titular: " + contaCorrente.titular.idade);
            Console.WriteLine("Saldo: " + contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
