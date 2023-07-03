using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalLinq6
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }

        public Task(int id, string title, int userId)
        {
            this.Id = id;
            this.Title = title;
            this.UserId = userId;
        }

        public static List<Task> Tasks()
        {
            return new List<Task>
            {
                  new Task(1, "Terminar Examen", 2),
                  new Task(2, "Ir por el Super", 2),
                  new Task(3, "Completar curso de C#", 5),
                  new Task(4, "Finalizar Presentacion del Curso", 6),
                  new Task(5, "Comprar Boletos de Avion", 7),
                  new Task(6, "Automatizar pago de nomina", 10),
                  new Task(7, "Recoger Ropa de la Tintoreria", 10),
                  new Task(8, "Formatear Computadora", 9),
                  new Task(9, "Estudiar para Examen de Ingles", 9),
                  new Task(10, "Limpiar Casa", 9),
            };
        }
    }
}
