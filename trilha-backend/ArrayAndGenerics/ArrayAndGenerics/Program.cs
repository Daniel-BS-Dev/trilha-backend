using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];

            int[] value = {1, 2, 3, 4, 5 };

            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);
            }

            List<int> number = new List<int>();

            foreach (int n in number){
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
