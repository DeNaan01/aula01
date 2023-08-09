using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float soma;
            float sub;
            float mult;
            float div;
            float resto;


            Console.Write("Digite um numero: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            b = float.Parse(Console.ReadLine());


            soma = a + b; //estamos somando os valores das variaveis "a e b"
            Console.WriteLine("A soma dos valores é: "+ soma) ;

            sub = a - b; //estamos subtraindo os valores das variaveis "a e b"

            Console.WriteLine("A subtração dos valores é: " + sub);

            mult = a * b;

            Console.WriteLine("A multiplicação dos numeros é: " + mult);


            div = a / b;

            Console.WriteLine("A divisão dos numeros é: " + div);












            Console.ReadKey();














        }
    }
}
