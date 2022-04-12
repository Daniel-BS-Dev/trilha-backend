using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string url = "pagamento?argumentos";

            int indiceInterrogacao = url.IndexOf("?"); // pega o index que esta o meu "?"
            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            Console.WriteLine(url.Substring(7)); // recorta aparti do "?"
            Console.WriteLine(url.Substring(indiceInterrogacao + 1)); // recotando da minha interrogação por diante

            try
            {
                Extrato e = new Extrato("");
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
