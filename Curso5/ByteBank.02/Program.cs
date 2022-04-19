using System;
using System.Collections.Generic;
using ByteBank.Modelos;
using static ByteBank.Modelos.UrlService;

namespace ByteBank_02
{
    internal class Program
    {
        private static readonly UrlService _urlService = new UrlService();

        static Program()
        {
            _urlService = new UrlService();
        }

        static void Main(string[] args)
        {
            string url = "https://testweb.com.br/home?sourceCurrency=BRL&targetCurrency=USD";

            try
            {
                var paramList = _urlService.GetAllParams(url);
                WriteList(paramList);

                string paramValueFind = _urlService.ParamValue(url, "targetcurrency");
                Console.WriteLine("Value of targetCurrency: " + paramValueFind);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void WriteList(List<Param> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Param Name: " + item.Name);
                Console.WriteLine("Param Value: " + item.Value);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
