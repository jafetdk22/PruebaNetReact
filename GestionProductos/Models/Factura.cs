using System;
using System.Collections.Generic;

namespace GestionProductos.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public string NumeroFactura { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public decimal Total { get; set; }

    public int ProductosAdquiridos { get; set; }
}
