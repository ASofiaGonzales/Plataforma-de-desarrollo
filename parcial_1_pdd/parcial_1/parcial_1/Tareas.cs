using System;
using System.Collections.Generic;
using System.Text;

namespace parcial_1
{
    class Tareas
    {
        public int IdTareas { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int IdRecursos { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }

    }
}
