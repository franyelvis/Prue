using System;
using System.Collections.Generic;

namespace ProductCRUDAPI.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
