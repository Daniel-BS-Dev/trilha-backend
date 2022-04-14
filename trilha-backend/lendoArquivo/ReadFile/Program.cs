using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileAddress = @"C:\workspace\trilha-backend\trilha-backend\lendoArquivo\ReadFile\AquivoC\WriteFile.txt"; // caminho do meu arquivo

            using (var fluxoFile = new FileStream(fileAddress, FileMode.Open))
            {
                // primeiro parametro caminho do arquivo segundo o que eu vou fazer com o arquivo

                var buffer = new byte[1024];// guardando informações temporarias
                var numberBytesRead = -1; // como o read não returna numeros negativos minha variavel recebe 1

                while (numberBytesRead != 0)
                {
                    numberBytesRead = fluxoFile.Read(buffer, 0, 1024); // vai gravar da posição ate a 1024
                    WriteBuffer(buffer, numberBytesRead);
                }
            }
            // quando eu uso o using ele já tem o close englobado
            // fluxoFile.Close();  fechando o arquivo
            Console.ReadLine();
        }

        // escrevendo na tela
        static void WriteBuffer(byte[] buffer, int bytesRead)
        {

            // usando o utf8
            var utf8 = new UTF8Encoding();
            var text = utf8.GetString(buffer, 0, bytesRead);
            Console.WriteLine(text); // lendo o arquivo do tipo texto

            //foreach (var myByte in buffer)
            //{
             //   Console.Write(myByte);
             //   Console.Write(" ");
            //}
        }
    }
}
