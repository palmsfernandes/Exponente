using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponente
{
    class Program
    {
        static void Main(string[] args)
        {
            int base1;
            int expoente;
            int total;

            Console.WriteLine("Eai! Bora fazer uma conta exponencial?");

            Console.Write("Digite o número base: ");
            base1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número exponencial: ");
            expoente = Convert.ToInt32(Console.ReadLine());

            

            int resultado = 1;

            for (int i = 1; i <= expoente; i++)
            {
                resultado *= base1;

                Console.WriteLine("O valor da conta é: " + resultado);              
            }

            Console.ReadLine();
         
            
        }
    }
}
