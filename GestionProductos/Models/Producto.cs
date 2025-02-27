using System;
using System.Collections.Generic;

namespace GestionProductos.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Existencias { get; set; }

    public decimal Precio { get; set; }
}
