using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int> { 2,5,6,7,1,8,9,10,3,4};
            //Encontrar Elementos
            //Contains
            bool existeSiete = numeros.Contains(7);
            Console.WriteLine(existeSiete);
            //Any
            bool existeDiez = numeros.Any(numero => numero == 10);
            Console.WriteLine(existeDiez);
            //Find retorna el elemento si existe sino un elemento por default
            int result = numeros.Find(numero => numero == 5);
            Console.WriteLine(result);
            //Single
            /*
            result = numeros.Single(numero => numero == 3);
            Console.WriteLine(result);
            */
            Console.ReadLine();
        }
    }
}
