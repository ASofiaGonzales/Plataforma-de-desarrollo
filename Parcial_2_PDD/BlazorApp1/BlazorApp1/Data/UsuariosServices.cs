using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuariosService
    {

        private DBCont context;

        public UsuariosService(DBCont _context)
        {
            context = _context;
        }

        public async Task<List<Usuarios>> GetAll()
        {
            //return await context.Usuarios.ToListAsync();

            var RemoteService = RestService.For<IRemoteService>("https://localhost:44341/api/");

            return await RemoteService.GetUsuarios();
        }

        public async Task<Usuarios> Save(Usuarios value)
        {
            if (value.IDUser == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<Usuarios> Get(int id)
        {
            return await context.Usuarios.Where(i => i.IDUser == id).SingleAsync();
        }


        public async Task<bool> Borrar(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.IDUser == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

    }



}