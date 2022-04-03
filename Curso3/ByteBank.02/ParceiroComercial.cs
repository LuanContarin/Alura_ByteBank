using System;
using ByteBank_02.Sistemas;

namespace ByteBank_02
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
