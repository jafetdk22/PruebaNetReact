using GestionProductos.Models;

namespace GestionProductos.Services
{
    public class VentasServices:IVentasServices
    {
        private readonly ProductosDbContext _productosDbContext;
        public VentasServices(ProductosDbContext productosDbContext) {

            _productosDbContext = productosDbContext;

        }

        public Task<bool> ActualizarVenta(int idFactura, Factura request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CrearVenta(Factura request)
        {
            try
            {
                _productosDbContext.Facturas.Add(request);
                _productosDbContext.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
        public Task<List<Factura>> GetVentas()
        {
            try
            {
                return Task.FromResult(_productosDbContext.Facturas.ToList());
            }
            catch (Exception ex)
            {
                return Task.FromResult(new List<Factura>());
            }
        }
    }
}
