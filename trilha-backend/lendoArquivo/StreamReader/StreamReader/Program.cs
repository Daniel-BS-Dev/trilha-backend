using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader
{
    class Program 
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\workspace\trilha-backend\trilha-backend\lendoArquivo\StreamReader\StreamReader\fileReader\file.txt";

            using(var fluxoFile = new FileStream(filePath, FileMode.Open))
            // { quando eu tenho dois blocos de using eu retiro as chaves

           using (var leitor = new System.IO.StreamReader(fluxoFile)) // usando o streamReader eu não preciso usar o buffer
           {
                    // lendo o arquivo linha por linha
             while (!leitor.EndOfStream)  // enquanto meu arquivo não estiver no fim
               {
                   var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaCorrente(linha);
                   Console.WriteLine($"numero {contaCorrente.Numero}: Agencia {contaCorrente.Agencia}: Saldo {contaCorrente.Saldo}: Nome {contaCorrente.Nome}");
               }
           };

                //string linha = leitor.ReadLine(); // ler a primeira linha
                //string linha = leitor.ReadToEnd(); // ler ate p fim
                //var linha = leitor.Read(); // ler o primeiro byte
                //Console.WriteLine(linha); // escrevendo o conteudo na tela

            //}


            Console.ReadLine();
        }

        // adiciaonando o meu arquivo txt em uma classe separando pelo espaço
        static ContaCorrente ConverterStringParaCorrente(string linha)
        {
            string[] campos = linha.Split(' '); // separando os elementos pelo espaço

            var agencia = campos[0]; // agencia recebe o meu primeiro atributo
            var numero = campos[1];  // numero recebe o segundo
            var saldo = campos[2].Replace('.',',');  // recebe o terceiro. replace trocando o ponto pela virgula
            var nome = campos[3];   // recebe o quarto

            // transformando um string em um int
            var agenciaComoInt = int.Parse(agencia);
            var numeroComoInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var result = new ContaCorrente(agenciaComoInt, numeroComoInt, saldoComoDouble, nome);
            return result;
        }  

    }
}
