using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadBinary();
            
            Console.ReadLine();
        }
        
        // escrevendo o arquivo
       static void WriteBinary()
        {
            using (var fs = new FileStream("CorrentAccount.txt", FileMode.Create))
            using (var written = new BinaryWriter(fs))
            {
                written.Write(464); // agencia da conta
                written.Write(123443); // numero
                written.Write(1234.54); // saldo
                written.Write("Gustavo");// nome
            }
        }

        // lendo o arquivo
        static void ReadBinary()
        {
            using (var fs = new FileStream("CorrentAccount.txt", FileMode.Open))
            using (var read = new BinaryReader(fs))
            {
               var agency = read.ReadInt32(); // agencia
               var number = read.ReadInt32(); // numero
               var balance = read.ReadDouble(); // saldo
               var name = read.ReadString();// nome

                Console.WriteLine($"{agency}: {number}: {balance}: {name}");
            }
        }
    }
}
