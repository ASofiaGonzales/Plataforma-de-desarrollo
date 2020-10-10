using System;
using System.Collections.Generic;
using System.Text;

namespace parcial_1
{
    class Detalles
    {
        public int IdDetalles { get; set; }
        public DateTime Fecha { get; set; }
        public int Tiempo { get; set; }
        public int IdRecursos { get; set; }
        public Recursos Recurso { get; set; }
        public int IdTareas { get; set; }
        public Tareas Tarea { get; set; }
    }
}
