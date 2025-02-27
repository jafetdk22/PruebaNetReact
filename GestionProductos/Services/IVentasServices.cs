using GestionProductos.Models;

namespace GestionProductos.Services
{
    public interface IVentasServices
    {
        public Task<bool> CrearVenta(Factura request);
        public Task<bool> ActualizarVenta(int idFactura, Factura request);
        public Task<List<Factura>> GetVentas();
    }
}
