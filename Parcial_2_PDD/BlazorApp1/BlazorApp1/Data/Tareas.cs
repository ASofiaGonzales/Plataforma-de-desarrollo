using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public class Tareas
    {
        [Key]
        public int IDTarea { get; set; }
        public String Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int IdRecursos { get; set; }
        public Recursos Responsable { get; set; }

        public bool Estado { get; set; }

        public Tareas() { }

        public Tareas(int iDTarea, string titulo, DateTime vencimiento, int estimacion, int idRecursos, Recursos responsable, bool estado)
        {
            IDTarea = iDTarea;
            Titulo = titulo;
            Vencimiento = vencimiento;
            Estimacion = estimacion;
            IdRecursos = idRecursos;
            Responsable = responsable;
            Estado = estado;
        }
    }
}