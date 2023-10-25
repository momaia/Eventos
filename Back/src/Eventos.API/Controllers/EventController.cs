using System.Collections;
using System.Data.SqlTypes;
using System.Linq;
using Eventos.API.Data;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;
        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public System.Collections.Generic.IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public System.Collections.Generic.IEnumerable<Evento> Get(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id);
        }
    }
}
