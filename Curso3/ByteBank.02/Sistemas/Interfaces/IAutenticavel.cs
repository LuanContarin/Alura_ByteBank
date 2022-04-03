using System;

namespace ByteBank_02.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
