using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProAgil.WebAPI.Data;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class WeatherForecastController : ControllerBase
    {
        public ApplicationDbContext _context { get; }

        public WeatherForecastController(ApplicationDbContext Context)
        {
            _context = Context;
        }

        //GET api/value
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _context.Eventos.ToListAsync();
                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }

        }

        //GET api/value/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {

            try
            {
                var result = await _context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id);
                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
            }

        }




    }
}
