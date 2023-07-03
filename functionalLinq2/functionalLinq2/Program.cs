using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            //Obtener el cuadrado de los numeros

            //Imperativo
            foreach (var numero in numeros) 
            {
                Console.WriteLine(numero * numero);
            }
            Console.WriteLine();
            //Declarativo
            var result = numeros.Select(numero => numero * numero);
            foreach(var numero in result)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine();

            //Obtener la suma de los elementos
            //Imperativo
            int suma = 0;
            foreach (var numero in numeros)
            {
                suma += numero;
            }
            Console.WriteLine(suma);

            Console.WriteLine();

            //Declarativo
            // Valor Iniciar de Acumulador = 0
            int result2 = numeros.Aggregate( (acumulador, numero) => numero + acumulador );
            Console.WriteLine(result2);

            // Filter -> Where Filtrar Elemeentos de una Coleccion
            // Map -> Select Modificar Elementos de una Coleccion
            //Reduce -> Agregate Reducir Elemnentos de una Coleccion
            //Agregate lo podemos ver como un acumulador

            Console.ReadLine();
        }
    }
}
