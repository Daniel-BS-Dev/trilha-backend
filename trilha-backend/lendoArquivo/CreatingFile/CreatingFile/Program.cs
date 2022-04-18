using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingFile
{
    class Program
    {
        static void Main(string[] args)
        {

            CreatingFileWithFlush();

            Console.ReadLine();
        }

        // usando flush para escrever no arquivo
        static void CreatingFileWithFlush()
        {
            // dessa maneira eu estou usando writer
            var newWayFile = "exportsAccounts.csv"; // tipo do arquivo

            using (var fluxoFile = new FileStream(newWayFile, FileMode.Create))
            using (var written = new StreamWriter(fluxoFile))
            {
                for(int i=0; i< 100; i++)
                {
                    written.WriteLine($"Linha {i}");
                    written.Flush();  // flush vai jogar o que foi escrito aqui no meu programa para o arquivo
                    Console.WriteLine($"Linha {i} foi escrita. Tecle enter para adicionar outra");
                    Console.ReadLine();
                 }
            };
        }

        static void CreatingFileWithWriter()
        {
            // dessa maneira eu estou usando writer
            var newWayFile = "exportAccounts.csv"; // tipo do arquivo

            using (var fluxoFile = new FileStream(newWayFile, FileMode.Create))
            using (var written = new StreamWriter(fluxoFile))
            {
                written.Write("456,78746,474.34,Daniel Benedito");// numero,agencia,saldo,nome
            };
        }


            static void CreatingFileWithBuffer()
        {
            // dessa maneira eu estou usando o buffer
            var newWayFile = "exportAccount.csv"; // tipo do arquivo

            using (var fluxoFile = new FileStream(newWayFile, FileMode.Create))
            {
                var accountLikeString = "456,78746,474.34,Daniel Silva"; // numero,agencia,saldo,nome

                var encoding = Encoding.UTF8; // tipo do arquivo

                var bytes = encoding.GetBytes(accountLikeString); // pegango o arquivo

                fluxoFile.Write(bytes, 0, bytes.Length); // escrevendo


            }


        }
    }
}
