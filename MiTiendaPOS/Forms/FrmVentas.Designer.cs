namespace MiTiendaPOS.Forms
{
	partial class FrmVentas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			grpEncabezado = new GroupBox();
			lblVenta = new Label();
			cboUsuario = new ComboBox();
			cboCliente = new ComboBox();
			lblUsuario = new Label();
			lblCliente = new Label();
			grpDetalle = new GroupBox();
			lblTotal = new Label();
			btnQuitar = new Button();
			dgvDetalle = new DataGridView();
			btnAgregar = new Button();
			nudCantidad = new NumericUpDown();
			lblCantidad = new Label();
			cboProducto = new ComboBox();
			lblProducto = new Label();
			grpHistorial = new GroupBox();
			dgvVentas = new DataGridView();
			btnNueva = new Button();
			btnGuardar = new Button();
			btnEliminar = new Button();
			grpEncabezado.SuspendLayout();
			grpDetalle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
			grpHistorial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
			SuspendLayout();
			// 
			// grpEncabezado
			// 
			grpEncabezado.Controls.Add(lblVenta);
			grpEncabezado.Controls.Add(cboUsuario);
			grpEncabezado.Controls.Add(cboCliente);
			grpEncabezado.Controls.Add(lblUsuario);
			grpEncabezado.Controls.Add(lblCliente);
			grpEncabezado.Location = new Point(12, 12);
			grpEncabezado.Name = "grpEncabezado";
			grpEncabezado.Size = new Size(532, 124);
			grpEncabezado.TabIndex = 0;
			grpEncabezado.TabStop = false;
			grpEncabezado.Text = "Encabezado de la venta";
			// 
			// lblVenta
			// 
			lblVenta.AutoSize = true;
			lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblVenta.Location = new Point(36, 84);
			lblVenta.Name = "lblVenta";
			lblVenta.Size = new Size(79, 15);
			lblVenta.TabIndex = 4;
			lblVenta.Text = " Venta nueva";
			// 
			// cboUsuario
			// 
			cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
			cboUsuario.FormattingEnabled = true;
			cboUsuario.Location = new Point(335, 35);
			cboUsuario.Name = "cboUsuario";
			cboUsuario.Size = new Size(153, 23);
			cboUsuario.TabIndex = 3;
			// 
			// cboCliente
			// 
			cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
			cboCliente.FormattingEnabled = true;
			cboCliente.Location = new Point(88, 35);
			cboCliente.Name = "cboCliente";
			cboCliente.Size = new Size(159, 23);
			cboCliente.TabIndex = 2;
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsuario.Location = new Point(280, 38);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(49, 15);
			lblUsuario.TabIndex = 1;
			lblUsuario.Text = "Usuario";
			// 
			// lblCliente
			// 
			lblCliente.AutoSize = true;
			lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCliente.Location = new Point(36, 38);
			lblCliente.Name = "lblCliente";
			lblCliente.Size = new Size(46, 15);
			lblCliente.TabIndex = 0;
			lblCliente.Text = "Cliente";
			// 
			// grpDetalle
			// 
			grpDetalle.Controls.Add(lblTotal);
			grpDetalle.Controls.Add(btnQuitar);
			grpDetalle.Controls.Add(dgvDetalle);
			grpDetalle.Controls.Add(btnAgregar);
			grpDetalle.Controls.Add(nudCantidad);
			grpDetalle.Controls.Add(lblCantidad);
			grpDetalle.Controls.Add(cboProducto);
			grpDetalle.Controls.Add(lblProducto);
			grpDetalle.Location = new Point(12, 142);
			grpDetalle.Name = "grpDetalle";
			grpDetalle.Size = new Size(532, 371);
			grpDetalle.TabIndex = 1;
			grpDetalle.TabStop = false;
			grpDetalle.Text = "Detalle de productos";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTotal.Location = new Point(287, 313);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(119, 25);
			lblTotal.TabIndex = 7;
			lblTotal.Text = " Total: $0.00";
			// 
			// btnQuitar
			// 
			btnQuitar.Location = new Point(36, 317);
			btnQuitar.Name = "btnQuitar";
			btnQuitar.Size = new Size(75, 23);
			btnQuitar.TabIndex = 6;
			btnQuitar.Text = "Quitar línea";
			btnQuitar.UseVisualStyleBackColor = true;
			btnQuitar.Click += btnQuitar_Click;
			// 
			// dgvDetalle
			// 
			dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDetalle.Location = new Point(6, 80);
			dgvDetalle.Name = "dgvDetalle";
			dgvDetalle.ReadOnly = true;
			dgvDetalle.RowHeadersVisible = false;
			dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDetalle.Size = new Size(520, 207);
			dgvDetalle.TabIndex = 5;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(437, 36);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(75, 23);
			btnAgregar.TabIndex = 4;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// nudCantidad
			// 
			nudCantidad.Location = new Point(287, 36);
			nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudCantidad.Name = "nudCantidad";
			nudCantidad.Size = new Size(120, 23);
			nudCantidad.TabIndex = 3;
			nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// lblCantidad
			// 
			lblCantidad.AutoSize = true;
			lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCantidad.Location = new Point(246, 39);
			lblCantidad.Name = "lblCantidad";
			lblCantidad.Size = new Size(35, 15);
			lblCantidad.TabIndex = 2;
			lblCantidad.Text = "Cant.";
			// 
			// cboProducto
			// 
			cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
			cboProducto.FormattingEnabled = true;
			cboProducto.Location = new Point(102, 36);
			cboProducto.Name = "cboProducto";
			cboProducto.Size = new Size(121, 23);
			cboProducto.TabIndex = 1;
			// 
			// lblProducto
			// 
			lblProducto.AutoSize = true;
			lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblProducto.Location = new Point(38, 39);
			lblProducto.Name = "lblProducto";
			lblProducto.Size = new Size(58, 15);
			lblProducto.TabIndex = 0;
			lblProducto.Text = "Producto";
			// 
			// grpHistorial
			// 
			grpHistorial.Controls.Add(dgvVentas);
			grpHistorial.Location = new Point(550, 12);
			grpHistorial.Name = "grpHistorial";
			grpHistorial.Size = new Size(442, 597);
			grpHistorial.TabIndex = 1;
			grpHistorial.TabStop = false;
			grpHistorial.Text = " Historial de Ventas";
			// 
			// dgvVentas
			// 
			dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVentas.Location = new Point(6, 22);
			dgvVentas.Name = "dgvVentas";
			dgvVentas.ReadOnly = true;
			dgvVentas.RowHeadersVisible = false;
			dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvVentas.Size = new Size(430, 569);
			dgvVentas.TabIndex = 0;
			dgvVentas.CellContentClick += dgvVentas_CellContentClick;
			// 
			// btnNueva
			// 
			btnNueva.BackColor = Color.SkyBlue;
			btnNueva.Location = new Point(57, 551);
			btnNueva.Name = "btnNueva";
			btnNueva.Size = new Size(134, 23);
			btnNueva.TabIndex = 2;
			btnNueva.Text = " Nueva venta";
			btnNueva.UseVisualStyleBackColor = false;
			btnNueva.Click += btnNueva_Click;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = Color.LightGreen;
			btnGuardar.Location = new Point(197, 551);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(134, 23);
			btnGuardar.TabIndex = 3;
			btnGuardar.Text = "Guardar venta";
			btnGuardar.UseVisualStyleBackColor = false;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.BackColor = Color.Salmon;
			btnEliminar.Location = new Point(337, 551);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(134, 23);
			btnEliminar.TabIndex = 4;
			btnEliminar.Text = "Eliminar venta";
			btnEliminar.UseVisualStyleBackColor = false;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// FrmVentas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1004, 621);
			Controls.Add(btnEliminar);
			Controls.Add(btnGuardar);
			Controls.Add(btnNueva);
			Controls.Add(grpHistorial);
			Controls.Add(grpDetalle);
			Controls.Add(grpEncabezado);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FrmVentas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registro de Ventas";
			Load += FrmVentas_Load;
			grpEncabezado.ResumeLayout(false);
			grpEncabezado.PerformLayout();
			grpDetalle.ResumeLayout(false);
			grpDetalle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
			((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
			grpHistorial.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpEncabezado;
		private ComboBox cboUsuario;
		private ComboBox cboCliente;
		private Label lblUsuario;
		private Label lblCliente;
		private GroupBox grpDetalle;
		private GroupBox grpHistorial;
		private Label lblVenta;
		private NumericUpDown nudCantidad;
		private Label lblCantidad;
		private ComboBox cboProducto;
		private Label lblProducto;
		private Button btnQuitar;
		private DataGridView dgvDetalle;
		private Button btnAgregar;
		private Label lblTotal;
		private DataGridView dgvVentas;
		private Button btnNueva;
		private Button btnGuardar;
		private Button btnEliminar;
	}
}