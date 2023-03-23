using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEnumerable<Evento> eventos;

        public EventoController()
        {
            eventos = new List<Evento>
            {
                new Evento
                {
                    EventoId = 1,
                    Tema = "Angular e .net5",
                    Local = "Belo Horizonte",
                    Lote = "primeiro Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto.png"
                },
                new Evento
                {
                    EventoId = 2,
                    Tema = "React e .net5",
                    Local = "São Paulo",
                    Lote = "segundo Lote",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto2.png"
                }
            };
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return eventos;
        }
    }
}
