using System;

namespace ByteBank.Modelos.Abstracts
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
