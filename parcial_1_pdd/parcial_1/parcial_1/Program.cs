using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

/*Armar un proyecto de consola con con el modelo de entity framework de la imagen adjunta
el modelo debe tener al menos 5 configuraciones por data annotation o fluent api
la aplicacion debe incluir metodos que inserten, actualicen, borren y consulten datos */
namespace parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CrearUsuario("Lorena", "123456");
            CrearUsuario("Pedro", "123456");
            CrearUsuario("Paco", "123456");
            CrearUsuario("Elena", "123456");
            ListaUsuario();
            EliminarUsuario(3);*/

            /* CrearRecurso("Taladro", 3);
             CrearRecurso("Pinza", 2);
             CrearRecurso("Martillo", 4);
             ListaRecursos();*/


            //Métodos usuario
            static void ListaUsuario()
            {
                var bd = new TareasDbContext();
                var lista = bd.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"Usuario: {item.Usuario} ({item.IdUsuario})");
                }

            }
            static void CrearUsuario(string usuario, string contraseña)
            {

                var bd = new TareasDbContext();

                bd.Set<Usuarios>().Add(new Usuarios
                {
                    Usuario = usuario,
                    Clave = contraseña,

                });

                bd.SaveChanges();
            }
            static void EliminarUsuario(int idUsuario)
            {
                var bd = new TareasDbContext();
                var usuario = bd.Usuarios.Where(i => i.IdUsuario == idUsuario).Single();
                bd.Usuarios.Remove(usuario);
                bd.SaveChanges();
            }

            //Metodo Recurso
            static void CrearRecurso(string nombre, int idUsuario)
            {
                var bd = new TareasDbContext();
                bd.Recursos.Add(new Recursos
                {
                    Nombre = nombre,
                    IdUsuario = idUsuario,

                });

                bd.SaveChanges();
                ;
            }
            static void ListaRecursos()
            {
                var bd = new TareasDbContext();
                var lista = bd.Recursos.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"Nombre: {item.Nombre} ({item.IdRecursos}) Usuario: {item.IdUsuario}");
                }
            }

            //Metodo Tarea
            static void CrearDetalle(DateTime fecha, int tiempo, int idrecurso, int idtarea)
            {
                var bd = new TareasDbContext();
                bd.Detalles.Add(new Detalles
                {

                    Fecha = fecha,
                    Tiempo = tiempo,
                    IdRecursos = idrecurso,
                    IdTareas = idtarea,

                });

                bd.SaveChanges();
            }
            static void CambiarDetalle(int id, int nuevoTiempo)
            {
                var bd = new TareasDbContext();
                var detalle = bd.Detalles.Where(a => a.IdDetalles == id).FirstOrDefault();

                if (detalle != null)
                {
                    detalle.Tiempo = nuevoTiempo;
                };

                bd.SaveChanges();
            }
        }
    }
}
