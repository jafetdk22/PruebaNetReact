using GestionProductos.Models;

namespace GestionProductos.Services
{
    public interface IProductosService
    {
        public Task<bool> CrearProducto(Producto request);
        public Task<bool> ActualizarProducto(int idProducto ,Producto request);
        public Task<List<Producto>> GetProductos();
    }
}
