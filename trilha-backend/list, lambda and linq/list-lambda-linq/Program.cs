using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_lambda_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            foreach(int c in numbers)
            {
                Console.WriteLine(c);
                Console.WriteLine("First List");
            }

            Console.WriteLine(numbers.Count());

            List<int> addALotNumbers = new List<int>();
            AddMoreOneNumber.AddALot(addALotNumbers, 1, 2, 3, 4, 5); // adicionando varios numbers


            // adicionando varios numeros depois de usar a palavra this
            addALotNumbers.AddALot(1, 2, -2, 3, 4, 5, -1);
            addALotNumbers.Sort();
            foreach (int i in addALotNumbers)
            {
                Console.WriteLine(i);
                Console.WriteLine("Second List");
            }

            // chamando o metodo generico
            numbers.AddALot(1, 2, 3, 4, 5);

            // ordenando minha lista por numero
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => conta.Numero)
            foreach(var conta in contasOrdenadas)
            {
                Console.WriteLine($"conta numero {conta.Numero}, ag. {conta.Agencia}")
            }

            Console.ReadLine();

        }
    }
}
