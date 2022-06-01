using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.IServices;
using TredaSolutions.Domains.Models;

namespace TredaSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        public readonly ITiendaService _tiendaService;
        public TiendaController(ITiendaService tiendaService)
        {
            _tiendaService = tiendaService;
        }

        [HttpPost]
        public async Task<IActionResult>SaveTienda(Tienda tienda)
        {
            try
            {
                var validatienda = await _tiendaService.ValidateName(tienda);
                if (validatienda)
                {
                    return BadRequest(new { message = "la tienda " + tienda.Nombre + " ya existe" });
                }
                tienda.FechaApertura = DateTime.Now;
                await _tiendaService.SaveTienda(tienda);
                return Ok(new { message = "La tienda se registro con exito!" });

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
