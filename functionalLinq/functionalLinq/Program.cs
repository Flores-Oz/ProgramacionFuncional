using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calificaciones = new List<int> { 10, 10, 5, 7, 7, 10, 8, 9, 9, 10, 9, 9 };
            //Obtener las Calificaciones mayores a 8
            
            //Enfoque Imperativo
            foreach(var calificacion in calificaciones)
            {
                if(calificacion > 8)
                {
                    Console.WriteLine(calificacion);
                }
            }
            Console.WriteLine("");
            //Enfoque Declarativo
            var result = calificaciones.Where(calificacion => calificacion > 8);
            foreach(var calificacion in result)
            {
                Console.WriteLine(calificacion);
            }

            Console.WriteLine("");
            //Obtener la cantidad de Calificaciones mayores a 8
            //Imperativo
            int contador = 0;
            foreach (var calificacion in calificaciones)
            {
                if (calificacion > 8)
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);
            Console.WriteLine("");

            //Declarativo
            var result2 = calificaciones.Where(calificacion => calificacion > 8);
            Console.WriteLine(result2.Count());

            Console.ReadLine();
        }
    }
}
