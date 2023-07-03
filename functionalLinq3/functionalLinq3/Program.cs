using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int> { 2,5,6,7,1,8,9,10,3,4};
            //Ordenar los numeros de forma ascendente

            //Ascendente
            var result = numeros.OrderBy( numero => numero);
            foreach (int numero in result)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine();
            //Descendente
            var result2 = numeros.OrderBy(numero => -numero);
            foreach (int numero in result2)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine(); 
            //De manera funcional
            numeros.OrderBy(numero => -numero)
                .ToList()
                .ForEach(numero => Console.WriteLine(numero));

            Console.ReadLine();

        }
    }
}
