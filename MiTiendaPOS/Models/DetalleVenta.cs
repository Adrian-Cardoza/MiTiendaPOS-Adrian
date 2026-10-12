using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MiTiendaPOS.Models
{
	public class DetalleVenta
	{
		public int Id { get; set; }
		public int VentaId { get; set; }
		public Venta Venta { get; set; }
		public int ProductoId { get; set; }
		public Producto Producto { get; set; }
		public int Cantidad { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal PrecioUnitario { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal SubTotal { get; set; }
	}
}
