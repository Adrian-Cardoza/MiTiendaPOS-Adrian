using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Models;

namespace MiTiendaPOS.Services
{
	public class CategoriaService
	{
		//Traer todas las categorias
		public List<Categoria> Listar(string filtro = "")
		{
			using var ctx = new MiTiendaPOSContext();
			IQueryable<Categoria> consulta = ctx.Categorias.AsNoTracking();

			if (!string.IsNullOrWhiteSpace(filtro))
				consulta = consulta.Where(c => c.Nombre.Contains(filtro.Trim()));
			return consulta.OrderBy(c => c.Nombre).ToList();
		}

		//Read
		public Categoria? ObtenerPorId(int id)
		{
			using var ctx = new MiTiendaPOSContext();
			return ctx.Categorias.Find(id);
		}

		//Create
		public void Crear(Categoria categoria)
		{
			using var ctx = new MiTiendaPOSContext();
			Validar(ctx, categoria);
			ctx.Categorias.Add(categoria);
			ctx.SaveChanges();
		}

		//Update
		public void Actualizar(Categoria categoria)
		{
			using var ctx = new MiTiendaPOSContext();
			Categoria existente = ctx.Categorias.Find(categoria.Id) ?? throw new InvalidOperationException("La categoría no existe.");
			Validar(ctx, categoria);
			existente.Nombre = categoria.Nombre;
			ctx.SaveChanges();
		}

		//Delete
		public void Eliminar(int id)
		{
			using var ctx = new MiTiendaPOSContext();
			Categoria categoria = ctx.Categorias.Find(id) ?? throw new InvalidOperationException("La categoría no existe.");
			if (ctx.Productos.Any(p => p.CategoriaId == id))
				throw new InvalidOperationException("No se puede eliminar la categoría porque tiene productos asociados.");
			ctx.Categorias.Remove(categoria);
			ctx.SaveChanges();
		}

		//Validar
		private void Validar(MiTiendaPOSContext ctx, Categoria categoria)
		{
			if (string.IsNullOrWhiteSpace(categoria.Nombre))
				throw new ArgumentException("El nombre de la categoría es obligatorio.");
			categoria.Nombre = categoria.Nombre.Trim();

			bool duplicado = ctx.Categorias.Any(c => c.Nombre == categoria.Nombre && c.Id == categoria.Id);
			if (duplicado)
				throw new InvalidOperationException("Ya existe una categoría con el mismo nombre.");
		}
	}
}
