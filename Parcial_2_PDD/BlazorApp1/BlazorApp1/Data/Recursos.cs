using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Recursos
    {

        [Key]
        public int IDRecurso { get; set; }
        public String Nombre { get; set; }
        public Usuarios Usuario { get; set; }
        public int IdUsuario { get; set; }
        public Recursos() { }

        public Recursos(int iDRecurso, string nombre, Usuarios usuario, int idUsuario)
        {
            IDRecurso = iDRecurso;
            Nombre = nombre;
            Usuario = usuario;
            IdUsuario = idUsuario;
        }
    }
}