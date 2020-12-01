using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalles
    {

        [Key]
        public int IDDetalle { get; set; }
        public DateTime Fecha { get; set; }
        public String Tiempo { get; set; }
        public int IdRecursos { get; set; }
        public Recursos Recurso { get; set; }
        public int IDTarea { get; set; }

        public Detalles()
        {
        }

        public Detalles(int iDDetalle, DateTime fecha, string tiempo, int idRecursos, Recursos recurso, int iDTarea)
        {
            IDDetalle = iDDetalle;
            Fecha = fecha;
            Tiempo = tiempo;
            IdRecursos = idRecursos;
            Recurso = recurso;
            IDTarea = iDTarea;
        }
    }
}