using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebApplication1.Data;

namespace WebApplication1.Entities
{
    public class OperacionesDB
    {
        public static void Insertar<T>(T elemento) where T : class
        {
            var ctx = new TaskDbContext();
            ctx.Add<T>(elemento);
            ctx.SaveChanges();
        }

        public static void InsertarSinGuardar<T>(T elemento, TaskDbContext ctx) where T : class
        {
            ctx.Add<T>(elemento);
        }

        public static List<T> ObtenerTodo<T>() where T : class
        {
            var ctx = new TaskDbContext();
            return ctx.Set<T>().ToList<T>();
        }

        public static List<T> ObtenerTodoInclude<T, I>(Expression<Func<T, I>> expresion) where T : class where I : class
        {
            var ctx = new TaskDbContext();
            return ctx.Set<T>().Include<T, I>(expresion).ToList();
        }

        public static T ObtenerPorId<T>(int id) where T : class
        {
            var ctx = new TaskDbContext();
            var elemento = ctx.Set<T>().Find(id);
            return elemento ?? (T)Activator.CreateInstance(typeof(T));
        }

        public static void Actualizar<T>(T elemento) where T : class
        {
            var ctx = new TaskDbContext();
            ctx.Set<T>().Attach(elemento);
            ctx.Set<T>().Update(elemento);
            ctx.SaveChanges();
        }

        public static void Borrar<T>(int id) where T : class
        {
            var ctx = new TaskDbContext();
            T elementoABorrar = ObtenerPorId<T>(id);
            if (!elementoABorrar.Equals((T)Activator.CreateInstance(typeof(T))))
            {
                ctx.Set<T>().Remove(elementoABorrar);
                ctx.SaveChanges();
            }
        }

        public static void InsertarDatosIniciales()
        {
        }
    }
}