using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.API.models;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] { 
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular",
                    Local = "JP",
                    Lote = "1° Lote",
                    QtdPessoas = 500,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                },

                new Evento() {
                    EventoId = 2,
                    Tema = "react",
                    Local = "JP",
                    Lote = "1° Lote",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                },
            };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        { 
            return "pegou";
            /*  return new Evento[] { 
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular",
                    Local = "JP",
                    Lote = "1° Lote",
                    QtdPessoas = 500,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "react",
                    Local = "JP",
                    Lote = "1° Lote",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                }
            };*/
        }

       /* [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/
    }
}
