using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____Executando Projeto - Criando Variáveis____ \r\n");

            int idade;
            idade = 23;
            Console.WriteLine("A minha idade é " + idade + " anos.");

            idade = 11;
            Console.WriteLine("Ela tem " + idade + " anos de idade.");

            idade = 10 + 5;
            Console.WriteLine("A soma das idades 10 e 5 é igual a " + idade + ".");

            idade = 10 + 5 * 2;
            Console.WriteLine("A multiplicação por dois das idades 10 e 5 é igual a " + idade + " anos.");

            idade = (10 + 5) * 2;
            Console.WriteLine("A multiplicação por dois das idades 10 e 5 com a soma antes é igual a " + idade + ". \r\n");

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}