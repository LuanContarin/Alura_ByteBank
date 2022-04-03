using System;
using ByteBank_01.Funcionarios;

namespace ByteBank_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diretor bruno = new Diretor("321.123.951-08")
            {
                Nome = "Bruno",
                Salario = 1000
            };
            GerenciadorBonificacao.Registrar(bruno);

            Console.WriteLine("Total de funcionarios: " + FuncionarioBase.TotalFuncionarios);
            EscreverBonificacao(bruno);

            Diretor joel = new Diretor("123.321.975-01")
            {
                Nome = "Joel",
                Salario = 5000
            };
            GerenciadorBonificacao.Registrar(joel);

            Console.WriteLine("Total de funcionarios: " + FuncionarioBase.TotalFuncionarios);
            EscreverBonificacao(joel);

            Console.WriteLine("Total de bonificações: " + GerenciadorBonificacao.GetTotalBonificacao());

            Console.ReadLine();
        }

        static void EscreverBonificacao(FuncionarioBase funcionario)
        {
            Console.WriteLine($"Bonificação {funcionario.Nome}: " + funcionario.GetBonificacao());
        }

    }
}
