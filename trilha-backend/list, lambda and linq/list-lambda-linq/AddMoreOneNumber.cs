using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_lambda_linq
{
    public static class AddMoreOneNumber
    {
        public static void AddALot(this List<int> listAll, params int[] itens) // com a palavra this eu falo que estou estendendo a minha lista
        {
            foreach(int item in itens)
            {
                listAll.Add(item);
            }
        }

        public static void AddALot<T>(this List<int> listAll, params int[] itens) // com a palavra this eu falo que estou estendendo a minha lista
        {
            foreach (int item in itens)
            {
                listAll.Add(item);
            }
        }
    }
}
