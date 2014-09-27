using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int num;
            Console.WriteLine("Programa Numero Positivo");
            Console.WriteLine("Digite un numero entre 1 y 99");
            numero = Console.ReadLine();
            num = int.Parse(numero);
            if(numero.Length<=2&& num>0)
        {
            
            Console.WriteLine("Numero Positivo");
                if(numero.Length==2)
                    {
                        Console.WriteLine("El numero tiene 2 digitos");
                    }
                else
                     {
                         Console.WriteLine("El numero tiene 1 digito ");
                     }
            }
            Console.ReadKey();
        }
    }
}
