using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStreamDeEntrance
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fluxoEntrance = Console.OpenStandardInput())// metodo para recupearar o stream de entrada
            using (var fs = new FileStream("entranceConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesWritten = fluxoEntrance.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesWritten);
                    fs.Flush();
                    Console.WriteLine($"Bytes lidos da console: {bytesWritten}");
                }
               
            }

            Console.ReadLine();
        }
    }
}
