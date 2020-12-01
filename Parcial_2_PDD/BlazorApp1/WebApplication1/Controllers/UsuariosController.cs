using ClassLibrary.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DBCont _context;
        public UsuariosController(DBCont context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuarios> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public Usuarios Get(int id)
        {
            return _context.Usuarios.Where(i => i.IDUser == id).Single();
        }



        [HttpPost]
        public IActionResult Post(Usuarios valor)
        {
            if (valor.IDUser == 0)
            {
                _context.Usuarios.Add(valor);
            }
            else
            {
                //_context.Usuarios.Attach(valor);
                _context.Usuarios.Update(valor);
            }
            _context.SaveChanges();
            return Ok(valor);
        }


    }
}