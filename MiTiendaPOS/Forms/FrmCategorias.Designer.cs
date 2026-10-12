namespace MiTiendaPOS.Forms
{
	partial class FrmCategorias
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
			txtBuscar = new TextBox();
			lblBuscar = new Label();
			dgvCategoria = new DataGridView();
			groupBox1 = new GroupBox();
			txtNombre = new TextBox();
			lblNombre = new Label();
			btnNuevo = new Button();
			btnGuardar = new Button();
			btnEliminar = new Button();
			((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// txtBuscar
			// 
			txtBuscar.Location = new Point(76, 27);
			txtBuscar.Name = "txtBuscar";
			txtBuscar.Size = new Size(272, 23);
			txtBuscar.TabIndex = 0;
			txtBuscar.TextChanged += txtBuscar_TextChanged;
			// 
			// lblBuscar
			// 
			lblBuscar.AutoSize = true;
			lblBuscar.Location = new Point(22, 30);
			lblBuscar.Name = "lblBuscar";
			lblBuscar.Size = new Size(42, 15);
			lblBuscar.TabIndex = 1;
			lblBuscar.Text = "Buscar";
			// 
			// dgvCategoria
			// 
			dgvCategoria.AllowUserToAddRows = false;
			dgvCategoria.AllowUserToDeleteRows = false;
			dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategoria.Location = new Point(12, 64);
			dgvCategoria.Name = "dgvCategoria";
			dgvCategoria.ReadOnly = true;
			dgvCategoria.RowHeadersVisible = false;
			dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvCategoria.Size = new Size(348, 278);
			dgvCategoria.TabIndex = 2;
			dgvCategoria.CellClick += dgvCategoria_CellClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtNombre);
			groupBox1.Controls.Add(lblNombre);
			groupBox1.Location = new Point(376, 64);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(269, 115);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Datos de la Categoria";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(6, 66);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(257, 23);
			txtNombre.TabIndex = 1;
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(6, 37);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(54, 15);
			lblNombre.TabIndex = 0;
			lblNombre.Text = "Nombre:";
			// 
			// btnNuevo
			// 
			btnNuevo.Location = new Point(446, 199);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(138, 23);
			btnNuevo.TabIndex = 4;
			btnNuevo.Text = "Nuevo";
			btnNuevo.UseVisualStyleBackColor = true;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(446, 239);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(138, 23);
			btnGuardar.TabIndex = 5;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnEliminar
			// 
			btnEliminar.Location = new Point(446, 280);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(138, 23);
			btnEliminar.TabIndex = 6;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = true;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// FrmCategorias
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(657, 354);
			Controls.Add(btnEliminar);
			Controls.Add(btnGuardar);
			Controls.Add(btnNuevo);
			Controls.Add(groupBox1);
			Controls.Add(dgvCategoria);
			Controls.Add(lblBuscar);
			Controls.Add(txtBuscar);
			Name = "FrmCategorias";
			Text = "Mantenimiento Categorias";
			Load += FrmCategorias_Load;
			((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtBuscar;
		private Label lblBuscar;
		private DataGridView dgvCategoria;
		private GroupBox groupBox1;
		private TextBox txtNombre;
		private Label lblNombre;
		private Button btnNuevo;
		private Button btnGuardar;
		private Button btnEliminar;
	}
}