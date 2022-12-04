using System;
using System.Collections.Generic;

namespace ProductCRUDAPI.Models
{
    public partial class ItemVenta
    {
        public int Id { get; set; }
        public string VentaId { get; set; } = null!;
        public string? ProductoId { get; set; }
        public decimal Precio { get; set; }
    }
}
