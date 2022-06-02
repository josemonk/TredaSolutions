using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TredaSolutions.Domains.IServices;
using TredaSolutions.Domains.Models;
using TredaSolutions.DTO;
using TredaSolutions.Persitence.Context;

namespace TredaSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly AplicationDbContext _aplicationDbContext;
        public readonly IProductoService _productosService;
        public ProductoController(IProductoService productosService,AplicationDbContext aplicationDbContext)
        {
            _productosService = productosService;
            _aplicationDbContext = aplicationDbContext;
        }
        [HttpPost]
        public async Task<IActionResult>SaveProducto(Producto producto)
        {
            try
            {
                
                var validateSku = await _productosService.ValidateSKU(producto);
                if (validateSku)
                {
                    return Ok(new { message = "el SKU " + producto.SKU + " ya existe!" });
                }

                await _productosService.SaveProducto(producto);
                return Ok(new { message = "Producto registrado correctamente!" });

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("productos-de-tienda/{id}")]
        public async Task<IActionResult> GetAllProductsByStore(int id)
        {
            List<Producto> productos = await _aplicationDbContext.productos.Where(x => x.TiendaId == id).ToListAsync();
            return Ok(productos);
        }
    }
}
