using GestionProductos.Models;
using GestionProductos.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IVentasServices _ventaService;
        public VentasController(IVentasServices ventaService)
        {
            _ventaService = ventaService;
        }

        // GET: api/<VentasController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var productos = await _ventaService.GetVentas();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<VentasController>
        [HttpPost]
        public void Post([FromBody] Factura request)
        {
            try
            {
                _ventaService.CrearVenta(request);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }
        // PUT api/<VentasController>/5
        [HttpPut("{id}")]
        public void Put(int idFactura, [FromBody] Factura request)
        {
            try
            {
                _ventaService.ActualizarVenta(idFactura, request);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }

        //// DELETE api/<VentasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
