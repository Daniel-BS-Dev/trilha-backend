using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Regex
    {
        string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"; // verificando de 0 a 9
        string padrao1 = "[0-9]{4}[-][0-9]{4}"; // mesma expressão acima
        string padrao1 = "[0-9]{4,5}[-][0-9]{4}"; // pega de 4 a 5 digitos
        string padrao1 = "[0-9]{4,5}[-]{0,1}[0-9]{4}";// pegando o valor com o - e sem o -
        string padrao1 = "[0-9]{4,5}-?[0-9]{4}"; // mesmo codigo que o decima
        string textOfTest = "asdfghjkloiuytrdfgh 8751-5456";

        Match result = Regex.Match(textOfTest, padrao);

        Console.write(result.value);
    }
}
