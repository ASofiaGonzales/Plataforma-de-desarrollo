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

    public class TareasController : ControllerBase
    {


        private readonly DBCont _context;
        public TareasController(DBCont context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Tareas> Get()
        {
            return _context.Tareas.ToList();
        }

        [HttpGet("{id}")]
        public Tareas Get(int id)
        {
            return _context.Tareas.Where(i => i.IDTarea == id).Single();
        }





        [HttpPost]
        public IActionResult Post(Tareas valor)
        {
            if (valor.IDTarea == 0)
            {
                _context.Tareas.Add(valor);
            }
            else
            {
                _context.Tareas.Attach(valor);
                _context.Tareas.Update(valor);
            }
            _context.SaveChanges();
            return Ok(valor);
        }
    }
}