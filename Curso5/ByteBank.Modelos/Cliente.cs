using System;
using ByteBank.Modelos.Util;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        private readonly CpfValidator _cpfValidator = new CpfValidator();

        public Cliente(decimal cpf, string nome)
        {
            _cpfValidator.ValidarTamanhoCpf(cpf);

            CPF = cpf;
            Nome = nome;
        }

        public decimal CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
    }
}
