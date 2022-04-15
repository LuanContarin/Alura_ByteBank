using System;
using Humanizer;

namespace ByteBank._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFim = new DateTime(2022, 4, 20);
            DateTime dataInicio = DateTime.Now;

            TimeSpan diferenca = dataFim - dataInicio;

            Console.WriteLine("Data início: " + dataInicio);
            Console.WriteLine("Data fim: " + dataFim);

            Console.WriteLine("Diferença das datas: " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            Console.ReadLine();
        }
    }
}
