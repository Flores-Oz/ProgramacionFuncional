using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lambda = Funcion anonima
            //(parametros) =< El Cuerpo de la Funcion
            //return no es necesaria
            //(paranetros) => {El Cuerpo de La Fucnion}
            //Func para cuando retorne valor Action para cuando no retorne valor

            Func<int,bool> par = numero => numero % 2 == 0;
            Console.WriteLine("El Numero es Par " + par(10));

            Func<int,int,int> sum = (num1, num2) => num1 + num2;
            Console.WriteLine("La Suma es " + sum(10,20));

            Func<string, bool> validador = correo =>
            {
                if (!correo.EndsWith("@gmail.com", StringComparison.CurrentCulture))
                {
                    Console.WriteLine("El Correo es Invalido!");
                    return false;
                }
                return true;
            };
            Console.WriteLine("El Correo es Valido: " + validador("oscar@adfs.com"));

            Action<string> saludar = mensaje => Console.WriteLine(mensaje);
            saludar("Hola Mundo con Lambda");

            Action<string, int> saludo = (mensaje, numero) =>
            {
                Console.WriteLine(mensaje);
                Console.WriteLine(numero);
            };
            saludo("Hola Mundo con Lambda", 2);


            Console.ReadLine();
        }
    }
}
