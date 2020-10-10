using System;
using System.Collections.Generic;
using System.Text;

namespace parcial_1
{
    class Recursos
    {
        public int IdRecursos { get; set; }
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
