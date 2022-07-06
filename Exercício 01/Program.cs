using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;
            double media;

            Console.WriteLine("Digite a primeira Nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Segunda Nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2)/2;


            if (media >= 8.5)
            {
                Console.WriteLine ("Conceito : A");
            }
            else if (media >=7.0 && media < 8.4)
            {
                Console.WriteLine("Conceito : B");
            }
            else if (media >=6.0 && media < 6.9)
            {
                Console.WriteLine("Conceito : C");
            }
            else if (media >= 0.1 && media < 5.9)
            {
                Console.WriteLine("Conceito : D");
            }
            else if (media >= 0.0)
            {
                Console.WriteLine("Conceito : E");
            }


            Console.ReadKey();
        }
    }
}
