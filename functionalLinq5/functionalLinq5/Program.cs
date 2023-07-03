using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = User.Users();
            //Obtener el nombre de los usuarios y edad de los  ususarios mayores de eda
            //Cuyo sexo sea Femenino
            //Ordenar el resultado de forma desc con respecto a su nombre

            //Utilizacion de una Query
            (
             from user in users
             where user.age > 18
             where user.gender == "female"
             orderby user.username descending //default ascendente
             select user.username
                ).ToList().ForEach(username => Console.WriteLine(username));

            //Generar nuevos Objetos
            (
             from user in users
             where user.age > 18
             where user.gender == "female"
             orderby user.username descending //default ascendente
             select new //Generacion del Nuevo Objeto
             {
                 Nombre = user.username,
                 Edad = user.age,
             }
                ).ToList().ForEach(user =>
                { 
                    Console.WriteLine("Username: " + user.Nombre + " Edad: " + user.Edad);
                });


            Console.ReadLine();

        }
    }
}
