using System;
using System.Collections.Generic;

namespace ProductCRUDAPI.Models
{
    public partial class Venta
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public int IdItemVenta { get; set; }
        public string? ProductoId { get; set; }
        public decimal Precio { get; set; }
    }
}
