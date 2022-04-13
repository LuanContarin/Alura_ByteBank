using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using System.IO;

namespace ProgramaTeste
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(123, 123415, new Cliente(12345678946, "teste"));

                Console.WriteLine(conta.Saldo);
                Console.WriteLine(conta.Titular.Nome);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
