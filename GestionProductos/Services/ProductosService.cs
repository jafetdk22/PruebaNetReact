using GestionProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionProductos.Services
{
    public class ProductosService : IProductosService
    {
        private readonly ProductosDbContext _productosDbContext;
        public ProductosService(ProductosDbContext productosDbContext)
        {
            _productosDbContext = productosDbContext;

        }
        public Task<bool> ActualizarProducto(int idProducto, Producto request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CrearProducto(Producto request)
        {
            try
            {
                _productosDbContext.Productos.Add(request);
                _productosDbContext.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }

        public async Task<List<Producto>> GetProductos()
        {
            return await _productosDbContext.Productos.ToListAsync();
        }
    }
}
