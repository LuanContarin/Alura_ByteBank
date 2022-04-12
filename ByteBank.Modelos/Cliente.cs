﻿using System;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public Cliente(decimal cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public decimal CPF { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
    }
}