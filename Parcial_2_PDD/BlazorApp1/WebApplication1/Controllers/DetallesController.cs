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
    public class DetallesController : ControllerBase
    {


        private readonly DBCont _context;
        public DetallesController(DBCont context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalles> Get()
        {
            return _context.Detalles.ToList();
        }

        [HttpGet("{id}")]
        public Detalles Get(int id)
        {
            return _context.Detalles.Where(i => i.IDDetalle == id).Single();
        }

        [HttpGet("{id}")]
        public List<Detalles> GetD(int id)
        {
            return _context.Detalles.Where(i => i.IDTarea == id).ToList();
        }



        [HttpPost]
        public IActionResult Post(Detalles valor)
        {
            if (valor.IDDetalle == 0)
            {
                _context.Detalles.Add(valor);
            }
            else
            {
                _context.Detalles.Attach(valor);
                _context.Detalles.Update(valor);
            }
            _context.SaveChanges();
            return Ok(valor);
        }

    }
}