using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MiTiendaPOS.Models
{
	public class Venta
	{
		public int Id { get; set; }
		public DateTime Fecha { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal Total { get; set; }

		//Relacion con Usuario
		public int UsuarioId { get; set; }
		public Usuario Usuario { get; set; }

		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; }

		public List<DetalleVenta> Detalles { get; set; } = new();
	}
}
