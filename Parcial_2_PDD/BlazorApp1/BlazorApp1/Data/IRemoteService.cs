using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    interface IRemoteService
    {

        [Get("/Usuarios")]
        Task<List<Usuarios>> GetUsuarios();

        [Get("/Recursos")]
        Task<List<Recursos>> GetRecursos();

        [Get("/Tareas")]
        Task<List<Tareas>> GetTareas();

        [Get("/Detalles")]
        Task<List<Detalles>> GetDetalles();


        [Post("/Usuarios")]
        Task<List<Usuarios>> AddUsuarios();

        [Post("/Recursos")]
        Task<List<Usuarios>> AddRecursos();

        [Post("/Tareas")]
        Task<List<Usuarios>> AddTareas();

        [Post("/Detalles")]
        Task<List<Usuarios>> AddDetalles();

    }
}
