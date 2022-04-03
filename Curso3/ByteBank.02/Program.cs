using System;
using ByteBank_02.Funcionarios;
using ByteBank_02.Sistemas;

namespace ByteBank_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diretor bruno = new Diretor("123.326.123-12")
            {
                Nome = "Bruno",
                Senha = "123abc"
            };
            EscreverInformacoes(bruno);

            Desenvolvedor joao = new Desenvolvedor("981.325.754-23")
            {
                Nome = "João"
            };
            EscreverInformacoes(joao);

            ParceiroComercial parceiroComercial = new ParceiroComercial
            {
                Senha = "12345"
            };

            Console.Write("Tentativa login Diretor: ");
            SistemaInterno.Logar(bruno, "123abc");

            Console.Write("Tentativa login Parceiro: ");
            SistemaInterno.Logar(parceiroComercial, "12345");
            
            Console.ReadLine();
        }

        static void EscreverInformacoes(Funcionario funcionario)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Cargo: " + funcionario.GetType().Name);
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("CPF: " + funcionario.Cpf);
            Console.WriteLine("Salário: " + funcionario.Salario);
            Console.WriteLine("Bonificação: " + funcionario.GetBonificacao());
            Console.WriteLine("--------------");
            Console.WriteLine();
        }
    }
}
