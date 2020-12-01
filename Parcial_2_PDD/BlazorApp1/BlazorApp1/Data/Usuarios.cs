using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Usuarios
    {

        [Key]
        public int IDUser { get; set; }
        public String User { get; set; }
        public String Clave { get; set; }


        public Usuarios() { }

        public Usuarios(int iDUser, string user, string clave)
        {
            IDUser = iDUser;
            User = user;
            Clave = clave;
        }
    }


}