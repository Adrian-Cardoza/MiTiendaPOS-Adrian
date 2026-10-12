using MiTiendaPOS.Models;
using MiTiendaPOS.Services;

namespace MiTiendaPOS.Forms
{
	public partial class FrmCategorias : Form
	{
		private readonly CategoriaService _servicio = new();
		private int _idSeleccionado = 0;
		public FrmCategorias()
		{
			InitializeComponent();
		}

		private void FrmCategorias_Load(object sender, EventArgs e)
		{
			CargarCategorias();
			LimpiarFormulario();
		}

		private void CargarCategorias()
		{
			dgvCategoria.DataSource = _servicio.Listar(txtBuscar.Text)
				.Select(c => new { c.Id, c.Nombre })
				.ToList();
		}

		private void LimpiarFormulario()
		{
			txtNombre.Clear();
			_idSeleccionado = 0;
			btnEliminar.Enabled = false;
			dgvCategoria.ClearSelection();
			txtNombre.Focus();
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			CargarCategorias();
		}

		private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;
			var fila = dgvCategoria.Rows[e.RowIndex];
			int id = Convert.ToInt32(fila.Cells["Id"].Value);
			Categoria? categoria = _servicio.ObtenerPorId(id);

			if (categoria == null) return;
			txtNombre.Text = categoria.Nombre;
			btnEliminar.Enabled = true;
			_idSeleccionado = categoria.Id;
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			LimpiarFormulario();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				var categoria = new Categoria
				{
					Id = _idSeleccionado,
					Nombre = txtNombre.Text.Trim()
				};
				if (_idSeleccionado == 0)
				{
					_servicio.Crear(categoria);
					MessageBox.Show("Categoría agregada correctamente.");
				}
				else
				{
					_servicio.Actualizar(categoria);
					MessageBox.Show("Categoría actualizada correctamente.");
					CargarCategorias();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar la categoría: " + ex.Message);
				CargarCategorias();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (_idSeleccionado == 0) return;
			var respuestas = MessageBox.Show($"¿Está seguro de eliminar la categoría '{txtNombre.Text}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (respuestas != DialogResult.Yes) return;

			try
			{
				_servicio.Eliminar(_idSeleccionado);
				MessageBox.Show("Categoría eliminada correctamente.");
				LimpiarFormulario();
				CargarCategorias();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
				CargarCategorias();
			}
		}
	}
}
