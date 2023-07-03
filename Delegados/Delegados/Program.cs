using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Delegados.Program;

namespace Delegados
{
    internal class Program
    {
        //Estructura delegado
        public delegate float DelegateOperacion(float val1, float val2);


        //Pequeño Cajero Automatico
        //Una operacion = a una funcion
        //Dpeositos
        //Retiros
        //
        public static float Deposito(float cantidad, float monto)
        {
            return cantidad + monto;
        }

        public static float Retiro(float cantidad, float monto)
        {
            if(cantidad > monto)
            {
                Console.WriteLine("No es posible realizar el retiro");
                return 0.0f;
            }
            return monto - cantidad;
        }

        public static float EjecutarOperacion(DelegateOperacion operacion, float cantidad, float monto)
        {
            Console.WriteLine("Estamos por Ejecutar una Operación");
            float result = operacion(cantidad, monto);
            Console.WriteLine(result);
            Console.WriteLine("La Operacion se ha Ejecutado");
            return result;
        }
        static void Main(string[] args)
        {
            //Delegate
            DelegateOperacion retiro = Retiro;
            DelegateOperacion deposito = Deposito;

            EjecutarOperacion(retiro, 10, 100);

            EjecutarOperacion(deposito, 50, 200);

            //Para darle interes al deposito 
            //DELEGADOS JUNTO CON LAMBDA
            //Manera 1 de Hacerlo 
            /*
           DelegateOperacion depositoInteres = (cantidad, monto) =>
           {
               if(cantidad > 100)
               {
                   return cantidad + monto + (cantidad * 0.02f);
               }
               return cantidad + monto;
            };
            */

            //Manera 2 de Hacerlo coon el Operador Ternario
            //Es incorrecto el return pero es la unica forma en que me funciona
            DelegateOperacion depositoInteres = (cantidad, monto) =>
            {
                return cantidad > 100 ? cantidad + monto + (cantidad * 0.02f) : cantidad + monto;
            };



            EjecutarOperacion(depositoInteres, 101, 100);

            Console.ReadLine();
        }
    }
}
