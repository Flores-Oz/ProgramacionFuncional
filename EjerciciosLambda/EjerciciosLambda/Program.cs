using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    Crear una función anónima que nos permita conocer si un número es primo o no*/
            Func<int, bool> primo = num => {
                if((num % 2) != 0)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(primo(10));
            /*
            
            /*Crear una función anónima que calcule el factorial dado un número entero.*/
            Func<int, int> factorial = num => 
                {
                  int c = num;
                  for(int i = 1; i < c; i++) 
                    {
                        num *=  i;
                    }
                  return num;
                };
            Console.WriteLine(factorial(9));

            /*Dado una lista de números enteros, crear una función anónima que nos permita conocer el promedio de dicha lista.*/
            var list = new List<int> { 10,2,3,4,5,6,11,12,13,41,32 };
            int promedio = list.Aggregate((num, prom) => num + prom) / list.Count;
            Console.WriteLine(promedio);

            /*Dado una lista de números enteros, crear una función anónima que nos permita conocer si el número 79 se encuentra dentro de la lista.*/
            var list2 = new List<int> { 10, 2, 3, 4, 5, 6, 11, 12, 13, 41, 32, 79 };
            bool numF = list2.Contains(79);
            Console.WriteLine(numF);

            /*Crear una función anónima que recibe 3 parámetros de tipo entero. La función debe retornar verdadero si los parámetros son números primos, en caso contrario retorna falso.*/
            /*Crear una función anónima que nos permita conocer si un string es palindromo o no.*/
            /*Dado una lista de strings, crear una función anónima que nos permita conocer si todos los elementos de la lista son o no palíndromos (para este problema puedes hacer uso de la función del ejercicio anterior).*/
            /*Crear una función llamada calculadora, la cual permita, sumar, restar, multiplicar y dividir dos números enteros. La función calculadora debe ser capaz de recibir cualquier tipo de operación (suma, resta, multiplicación y división).*/



            Console.ReadLine();
        }
    }
}
