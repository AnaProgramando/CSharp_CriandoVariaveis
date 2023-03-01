using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Executando Projeto 2 - Criando Variáveis___");

            int idade;
            idade = 25;
            Console.WriteLine("A minha idade é " + idade + " anos.");

            idade = 11;
            Console.WriteLine("Ela tem " + idade + " anos de idade.");

            idade = 10 + 5;
            Console.WriteLine("A soma das idades 10 e 5 é igual a " + idade + ".");

            idade = 10 + 5 * 2;
            Console.WriteLine("A multiplicação por dois das idades 10 e 5 é igual a " + idade + " anos.");

            idade = (10 + 5) * 2;
            Console.WriteLine("A multiplicação por dois das idades 10 e 5 com a soma executada antes é igual a " + idade + " anos.");

            Console.WriteLine("Execução finalizada. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
