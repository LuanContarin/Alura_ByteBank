using System;
using System.Collections.Generic;
using ByteBank_01.Modelos;

namespace ByteBank_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>
            {
                new ContaCorrente(140, 75162, new Cliente(95849747632, "Pedro")),
                new ContaCorrente(140, 48927, new Cliente(58923795878, "João")),
                new ContaCorrente(130, 37648, new Cliente(58923795878, "Matheus")),
                new ContaCorrente(125, 52165, new Cliente(58923795878, "Jorge")),
                new ContaCorrente(151, 69475, new Cliente(58923795878, "Luan")),
                new ContaCorrente(152, 72637, new Cliente(58923795878, "Luana"))
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine($"Agência: {conta.Agencia} | Número: {conta.Numero}, Titular: {conta.Titular.Nome}");
            }

            Console.ReadLine();
        }
    }
}
