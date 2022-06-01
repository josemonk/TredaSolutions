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
    public class ProductoController : ControllerBase
    {
        public readonly IProductoService _productosService;
        public ProductoController(IProductoService productosService)
        {
            _productosService = productosService;
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
    }
}
