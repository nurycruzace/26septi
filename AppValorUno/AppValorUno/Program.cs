using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValorUno
{
    class Program
    {
        static void Main(string[] args)
        {
             string numero;
            Console.WriteLine("PROGRAMA QUE PASA DE CARACTER A NUMERO");
            Console.WriteLine("Escriba numero de 1 a 5 en NUMERO");
            numero = Console.ReadLine();
          *// numero = numero.ToLower();
           
            switch (numero)
                {
                case "1":
                        Console.WriteLine("UNO");
                        break;
                case "2":
                        Console.WriteLine("DOS");
                        break;
                case "3":
                        Console.WriteLine("TRES");
                        break;
                case "4":
                        Console.WriteLine("CUATRO");
                        break;
                case "5":
                        Console.WriteLine("CINCO");
                        break;
                default:
                        Console.WriteLine("NUMERO FUERA DE RANGO");
                        break;
                }
            Console.ReadKey();
        }
    }
}
       
   

