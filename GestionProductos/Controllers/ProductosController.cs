using GestionProductos.Models;
using GestionProductos.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosService _productosService;
        public ProductosController(IProductosService productosService)
        {
            _productosService = productosService;
        }
        // GET: api/<ProductosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var productos = await _productosService.GetProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<ProductosController>
        [HttpPost]
        public void Post([FromBody] Producto request)
        {
            try
            {
                _productosService.CrearProducto(request);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }

        //// PUT api/<ProductosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
