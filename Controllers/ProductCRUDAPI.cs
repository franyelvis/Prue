using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VentaCRUDAPI.Models;

namespace VentaCRUDAPI.Controllers
{   
    [ApiController]
    [Route("Venta")]
    public class VentaController : ControllerBase
    {
        private readonly ProductDBContext _context;

        [HttpGet]
        [Route("Venta/Productos")]
        public async Task<IEnumerable<Producto>> GetProductos()
        {
            return await _context.producto.ToListAsync();
        }

        [HttpGet]
        [Route("Venta/Ventas")]
        public async Task<IEnumerable<Venta>> GetVentas()
        {
            return await _context.Venta.ToListAsync();
        }

        [HttpGet]
        [Route("Venta/ItemVenta")]
        public async Task<IEnumerable<ItemVenta>> GetItemVentas()
        {
            return await _context.objVendidos.ToListAsync();
        }

        [HttpPost]
        [Route("Venta/GuardarProducto")]
        public async Task<IActionResult> Post(Producto pro)
        {
            _context.Add(pro);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Route("Venta/GuardarVenta")]
        public async Task<IActionResult> Post(Venta venta)
        {
            _context.Add(venta);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        [Route("Venta/ActualizarProducto")]
        public async Task<IActionResult> Put(Producto proData)
        {
            if (proData == null || proData.Id == 0)
                return BadRequest();

            var product = await _context.producto.FindAsync(proData.Id);
            if (product == null)
                return NotFound();
            product.Nombre = proData.Nombre;
            product.Id = proData.Id;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //falta de tiempo
            return Ok();

        }
    }
}
