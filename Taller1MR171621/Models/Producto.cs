using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Taller1MR171621.Models
{
    public class Producto
    {
        public int ID { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        public string Categoria { get; set; }
        public decimal Costo { get; set; }
        [Display(Name = "Precio de Venta")]
        public decimal PrecioVenta { get; set; }
        public int Existencia { get; set; }
        [Display(Name = "Número de Pedidos")]
        public int NumeroPedidos { get; set; }
    }

    public class ProductoDBContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
    }
}