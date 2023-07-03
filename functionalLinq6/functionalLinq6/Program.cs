using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = User.Users();
            var tasks = Task.Tasks();
            //Obtener las tareas de los Usuarios
            //Join
            //Creacion de la Query
            (
            from user in users
            join task in tasks on user.id equals task.UserId //* Con esto indicamos que queremos obtener todos los usuarios con el id de el id de la tarea//
            select new
            {
                Task = task.Title,
                User = user.username
            }
            ).ToList().ForEach(userTask =>
            {
                Console.WriteLine("Usuario: " + userTask.User + " Tarea: " + userTask.Task);
            });

            Console.WriteLine();
            //Obtener el username de los usuarios que tenga tareas
            (
            from user in users
            join task in tasks on user.id equals task.UserId
            select user.username
            )
            .Distinct() //Es retornar elementos sin duplicar
            .ToList()
            .ForEach(username => Console.WriteLine(username));

            Console.WriteLine();
            //Obtener el username de los usuarios que tengan tareas
            (
                from user in users
                join task in tasks on user.id equals task.UserId
                group user by user.username into groupUser //6
                select groupUser
            ).ToList()
            .ForEach(username => Console.WriteLine( username.Key ));

            Console.WriteLine();
            //Obtener la cantidad de tareas por cada usuario
            //El Resultado debe estar ordenando por la cantidad de tareas des.
            (
               from user in users
               join task in tasks on user.id equals task.UserId
               group user by user.username into groupUser //6
               orderby groupUser.Count() descending
               select new
               {
                   Message = "Username: " + groupUser.Key + " Cantidad de Tareas: " + groupUser.Count()
               }
            ).ToList()
            .ForEach(user => Console.WriteLine(user.Message));

            Console.WriteLine();
            //Dada una lista de numeros enteros, mostrar en consola el cuadrado
            //de cada uno de los elementos, si y solo si, dicho cuadrado es mayor a 50
            var numeros = new List<int> {10,8,7,6,4,5,2,1,10 };
            //let
            (
                from numero in numeros
                let cuadrado = numero * numero
                where cuadrado > 50
                select cuadrado
            ).ToList()
            .ForEach(cuadrado => Console.WriteLine(cuadrado));

            Console.WriteLine();
            //Obtener el username de los usuarios que NO tengan tareas
            //Left Join
            (
              from user in users
              join task in tasks on user.id equals task.UserId into relacion
              from a in relacion.DefaultIfEmpty()
              where a == null //Where is Null (Si se anula tendriamos a los usuarios que tienen y no tienen tareas
              select user.username 
            ).ToList()
            .ForEach(username => Console.WriteLine(username));

            Console.ReadLine();
        }
    }
}
