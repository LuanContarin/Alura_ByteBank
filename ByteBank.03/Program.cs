using System;
using ByteBank.Modelos;

namespace ByteBank_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestaBusca();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }

        static void TestaBusca()
        {
            Lista<ContaCorrente> listaDeContas = new Lista<ContaCorrente>();

            var conta1 = new ContaCorrente(105, 245829, new Cliente(86797867953, "Luan C."));
            var conta2 = new ContaCorrente(140, 735736, new Cliente(58947594595, "Pedro T."));
            var conta3 = new ContaCorrente(105, 483748, new Cliente(48628462842, "João A."));

            listaDeContas.Adicionar(conta1, conta2, conta3);

            Console.WriteLine("Todas as contas:");
            EscreverContas(listaDeContas);

            var buscarPorAgencia = listaDeContas.Buscar(x => x.Agencia == 105);
            Console.WriteLine("Contas buscadas pela agência 105:");
            EscreverContas(buscarPorAgencia);

            var buscarPorTitular = listaDeContas.Buscar(x => x.Titular.Nome.Contains("A"));
            Console.WriteLine("Contas que contêm \"A\" no nome do titular: (case sensitive)");
            EscreverContas(buscarPorTitular);
        }

        static void TestaRemocao()
        {
            Lista<int> listaIdades = new Lista<int>(5);
            listaIdades.Adicionar(4, 5, 6, 2, 9, 10, 2, 7, 10);

            Console.WriteLine("Lista completa:");
            Escreverlistas(listaIdades);

            // Remove o valor no index 0.
            listaIdades.Remover(index: 0);
            Console.WriteLine("Removendo item no index 0...");

            // Remove apenas a primeira ocorrência do valor "2".
            listaIdades.Remover(valor: 2);
            Console.WriteLine("Removendo a primeira ocorrência do valor 2...");

            // Remove todas as ocorrências do valor "10".
            listaIdades.Remover(valor: 10, true);
            Console.WriteLine("Removendo todas as ocorrências do valor 10...");

            Console.WriteLine();
            Console.WriteLine("Apos remoção dos itens descritos:");
            Escreverlistas(listaIdades);
        }

        static void Escreverlistas<T>(params Lista<T>[] listas)
        {
            foreach (Lista<T> lista in listas)
            {
                Console.WriteLine("\t------------------");
                Console.WriteLine($"\tItens da lista:");

                int i = 0;
                foreach (T item in lista)
                {
                    Console.WriteLine($"\tItem[{i}] = {item}");
                    i++;
                }
                Console.WriteLine($"\tTamanho total: {lista.Tamanho}");

                Console.WriteLine("\t------------------");
                Console.WriteLine();
            }
        }

        static void EscreverContas(Lista<ContaCorrente> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine("\t-------------------");
                Console.WriteLine($"\tAgencia: {conta.Agencia}");
                Console.WriteLine($"\tNumero conta: {conta.Numero}");
                Console.WriteLine($"\tTitular: {conta.Titular.Nome}");
                Console.WriteLine("\t-------------------");
                Console.WriteLine();
            }
        }
    }
}
