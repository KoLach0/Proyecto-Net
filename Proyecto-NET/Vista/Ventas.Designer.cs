namespace Proyecto_NET.vistas
{
	partial class Ventas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
			this.tabControlVentas = new System.Windows.Forms.TabControl();
			this.tabPVendidos = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPDisponibles = new System.Windows.Forms.TabPage();
			this.dataProductos = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.labCantidad = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabControlVentas.SuspendLayout();
			this.tabPVendidos.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPDisponibles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlVentas
			// 
			this.tabControlVentas.Controls.Add(this.tabPVendidos);
			this.tabControlVentas.Controls.Add(this.tabPDisponibles);
			this.tabControlVentas.Location = new System.Drawing.Point(12, 12);
			this.tabControlVentas.Name = "tabControlVentas";
			this.tabControlVentas.SelectedIndex = 0;
			this.tabControlVentas.Size = new System.Drawing.Size(781, 335);
			this.tabControlVentas.TabIndex = 14;
			// 
			// tabPVendidos
			// 
			this.tabPVendidos.Controls.Add(this.button3);
			this.tabPVendidos.Controls.Add(this.button2);
			this.tabPVendidos.Controls.Add(this.textBox1);
			this.tabPVendidos.Controls.Add(this.label1);
			this.tabPVendidos.Controls.Add(this.tabControl1);
			this.tabPVendidos.Location = new System.Drawing.Point(4, 22);
			this.tabPVendidos.Name = "tabPVendidos";
			this.tabPVendidos.Padding = new System.Windows.Forms.Padding(3);
			this.tabPVendidos.Size = new System.Drawing.Size(773, 309);
			this.tabPVendidos.TabIndex = 0;
			this.tabPVendidos.Text = "Productos Vendidos";
			this.tabPVendidos.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(412, 201);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(69, 33);
			this.button3.TabIndex = 17;
			this.button3.Text = "Anular";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(248, 201);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 33);
			this.button2.TabIndex = 16;
			this.button2.Text = "Terminar Venta";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(39, 195);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 39);
			this.textBox1.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Venta Total";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(21, 20);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(200, 100);
			this.tabControl1.TabIndex = 13;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Productos vendidos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPDisponibles
			// 
			this.tabPDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPDisponibles.Controls.Add(this.dataProductos);
			this.tabPDisponibles.Controls.Add(this.btnAgregar);
			this.tabPDisponibles.Controls.Add(this.txtCantidad);
			this.tabPDisponibles.Controls.Add(this.labCantidad);
			this.tabPDisponibles.Controls.Add(this.label2);
			this.tabPDisponibles.Location = new System.Drawing.Point(4, 22);
			this.tabPDisponibles.Name = "tabPDisponibles";
			this.tabPDisponibles.Padding = new System.Windows.Forms.Padding(3);
			this.tabPDisponibles.Size = new System.Drawing.Size(773, 309);
			this.tabPDisponibles.TabIndex = 1;
			this.tabPDisponibles.Text = "Productos Disponibles";
			this.tabPDisponibles.UseVisualStyleBackColor = true;
			// 
			// dataProductos
			// 
			this.dataProductos.AllowUserToAddRows = false;
			this.dataProductos.AllowUserToDeleteRows = false;
			this.dataProductos.AllowUserToOrderColumns = true;
			this.dataProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
			this.dataProductos.Location = new System.Drawing.Point(51, 82);
			this.dataProductos.Margin = new System.Windows.Forms.Padding(4);
			this.dataProductos.MultiSelect = false;
			this.dataProductos.Name = "dataProductos";
			this.dataProductos.ReadOnly = true;
			this.dataProductos.RowHeadersWidth = 50;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.dataProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataProductos.RowTemplate.Height = 40;
			this.dataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataProductos.Size = new System.Drawing.Size(353, 182);
			this.dataProductos.TabIndex = 18;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnAgregar.Location = new System.Drawing.Point(545, 194);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(116, 39);
			this.btnAgregar.TabIndex = 17;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(545, 131);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(116, 20);
			this.txtCantidad.TabIndex = 16;
			// 
			// labCantidad
			// 
			this.labCantidad.AutoSize = true;
			this.labCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCantidad.Location = new System.Drawing.Point(562, 92);
			this.labCantidad.Name = "labCantidad";
			this.labCantidad.Size = new System.Drawing.Size(84, 24);
			this.labCantidad.TabIndex = 15;
			this.labCantidad.Text = "Cantidad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(46, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(227, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Productos Disponibles";
			// 
			// Seleccionar
			// 
			this.Seleccionar.HeaderText = "Seleccionar";
			this.Seleccionar.Name = "Seleccionar";
			this.Seleccionar.ReadOnly = true;
			this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Seleccionar.Width = 70;
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 359);
			this.Controls.Add(this.tabControlVentas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Ventas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Ventas_Load);
			this.tabControlVentas.ResumeLayout(false);
			this.tabPVendidos.ResumeLayout(false);
			this.tabPVendidos.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPDisponibles.ResumeLayout(false);
			this.tabPDisponibles.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TabControl tabControlVentas;
        private System.Windows.Forms.TabPage tabPVendidos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPDisponibles;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
	}
}