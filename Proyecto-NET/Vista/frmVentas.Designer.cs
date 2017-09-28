namespace Proyecto_NET.Vista
{
	partial class frmVentas
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.datadetallesVenta = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataProductos = new System.Windows.Forms.DataGridView();
			this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tpProductosVen = new System.Windows.Forms.TabPage();
			this.txtVentaTotal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataDetalles = new System.Windows.Forms.DataGridView();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.labCantidad = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAnular = new System.Windows.Forms.Button();
			this.btnTerminarVenta = new System.Windows.Forms.Button();
			this.tpProductosDis = new System.Windows.Forms.TabPage();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
			this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.datadetallesVenta)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
			this.tpProductosVen.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataDetalles)).BeginInit();
			this.tpProductosDis.SuspendLayout();
			this.tabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label4.Location = new System.Drawing.Point(41, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(205, 25);
			this.label4.TabIndex = 43;
			this.label4.Text = "Productos Vendidos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(51, 274);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 34;
			this.label1.Text = "Venta Total";
			// 
			// datadetallesVenta
			// 
			this.datadetallesVenta.AllowUserToAddRows = false;
			this.datadetallesVenta.AllowUserToDeleteRows = false;
			this.datadetallesVenta.AllowUserToOrderColumns = true;
			this.datadetallesVenta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.datadetallesVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.datadetallesVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.datadetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datadetallesVenta.Location = new System.Drawing.Point(7, 13);
			this.datadetallesVenta.Margin = new System.Windows.Forms.Padding(4);
			this.datadetallesVenta.MultiSelect = false;
			this.datadetallesVenta.Name = "datadetallesVenta";
			this.datadetallesVenta.ReadOnly = true;
			this.datadetallesVenta.RowHeadersWidth = 50;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.datadetallesVenta.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datadetallesVenta.RowTemplate.Height = 40;
			this.datadetallesVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.datadetallesVenta.Size = new System.Drawing.Size(700, 131);
			this.datadetallesVenta.TabIndex = 29;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox3.Controls.Add(this.datadetallesVenta);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox3.Location = new System.Drawing.Point(39, 58);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(714, 153);
			this.groupBox3.TabIndex = 44;
			this.groupBox3.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox2.Controls.Add(this.dataProductos);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox2.Location = new System.Drawing.Point(26, 41);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(574, 153);
			this.groupBox2.TabIndex = 42;
			this.groupBox2.TabStop = false;
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
			this.dataProductos.Location = new System.Drawing.Point(7, 13);
			this.dataProductos.Margin = new System.Windows.Forms.Padding(4);
			this.dataProductos.MultiSelect = false;
			this.dataProductos.Name = "dataProductos";
			this.dataProductos.ReadOnly = true;
			this.dataProductos.RowHeadersWidth = 50;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.dataProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataProductos.RowTemplate.Height = 40;
			this.dataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataProductos.Size = new System.Drawing.Size(560, 131);
			this.dataProductos.TabIndex = 29;
			this.dataProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductos_CellContentClick_1);
			// 
			// Seleccionar
			// 
			this.Seleccionar.HeaderText = "Seleccionar";
			this.Seleccionar.Name = "Seleccionar";
			this.Seleccionar.ReadOnly = true;
			this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Seleccionar.Width = 70;
			// 
			// tpProductosVen
			// 
			this.tpProductosVen.BackColor = System.Drawing.Color.White;
			this.tpProductosVen.Controls.Add(this.groupBox3);
			this.tpProductosVen.Controls.Add(this.label4);
			this.tpProductosVen.Controls.Add(this.txtVentaTotal);
			this.tpProductosVen.Controls.Add(this.label1);
			this.tpProductosVen.Location = new System.Drawing.Point(4, 22);
			this.tpProductosVen.Name = "tpProductosVen";
			this.tpProductosVen.Padding = new System.Windows.Forms.Padding(3);
			this.tpProductosVen.Size = new System.Drawing.Size(791, 435);
			this.tpProductosVen.TabIndex = 1;
			this.tpProductosVen.Text = "Productos Vendidos";
			// 
			// txtVentaTotal
			// 
			this.txtVentaTotal.Enabled = false;
			this.txtVentaTotal.Location = new System.Drawing.Point(55, 298);
			this.txtVentaTotal.Multiline = true;
			this.txtVentaTotal.Name = "txtVentaTotal";
			this.txtVentaTotal.Size = new System.Drawing.Size(152, 39);
			this.txtVentaTotal.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label3.Location = new System.Drawing.Point(22, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(217, 25);
			this.label3.TabIndex = 41;
			this.label3.Text = "Productos agregados";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox1.Controls.Add(this.dataDetalles);
			this.groupBox1.Location = new System.Drawing.Point(26, 230);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(589, 140);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			// 
			// dataDetalles
			// 
			this.dataDetalles.AllowUserToAddRows = false;
			this.dataDetalles.AllowUserToDeleteRows = false;
			this.dataDetalles.AllowUserToOrderColumns = true;
			this.dataDetalles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataDetalles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.dataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataDetalles.Location = new System.Drawing.Point(7, 11);
			this.dataDetalles.Margin = new System.Windows.Forms.Padding(4);
			this.dataDetalles.MultiSelect = false;
			this.dataDetalles.Name = "dataDetalles";
			this.dataDetalles.ReadOnly = true;
			this.dataDetalles.RowHeadersWidth = 50;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.dataDetalles.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataDetalles.RowTemplate.Height = 40;
			this.dataDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataDetalles.Size = new System.Drawing.Size(560, 118);
			this.dataDetalles.TabIndex = 30;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(645, 64);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(116, 20);
			this.txtCantidad.TabIndex = 38;
			// 
			// labCantidad
			// 
			this.labCantidad.AutoSize = true;
			this.labCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCantidad.Location = new System.Drawing.Point(641, 41);
			this.labCantidad.Name = "labCantidad";
			this.labCantidad.Size = new System.Drawing.Size(73, 20);
			this.labCantidad.TabIndex = 37;
			this.labCantidad.Text = "Cantidad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(28, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(227, 25);
			this.label2.TabIndex = 36;
			this.label2.Text = "Productos Disponibles";
			// 
			// btnAnular
			// 
			this.btnAnular.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAnular.Location = new System.Drawing.Point(683, 376);
			this.btnAnular.Name = "btnAnular";
			this.btnAnular.Size = new System.Drawing.Size(78, 39);
			this.btnAnular.TabIndex = 35;
			this.btnAnular.Text = "Anular";
			this.btnAnular.UseVisualStyleBackColor = false;
			// 
			// btnTerminarVenta
			// 
			this.btnTerminarVenta.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnTerminarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnTerminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTerminarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTerminarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTerminarVenta.Location = new System.Drawing.Point(523, 376);
			this.btnTerminarVenta.Name = "btnTerminarVenta";
			this.btnTerminarVenta.Size = new System.Drawing.Size(138, 39);
			this.btnTerminarVenta.TabIndex = 34;
			this.btnTerminarVenta.Text = "Terminar Venta";
			this.btnTerminarVenta.UseVisualStyleBackColor = false;
			this.btnTerminarVenta.Click += new System.EventHandler(this.btnTerminarVenta_Click);
			// 
			// tpProductosDis
			// 
			this.tpProductosDis.Controls.Add(this.btnQuitar);
			this.tpProductosDis.Controls.Add(this.groupBox2);
			this.tpProductosDis.Controls.Add(this.label3);
			this.tpProductosDis.Controls.Add(this.groupBox1);
			this.tpProductosDis.Controls.Add(this.btnAgregar);
			this.tpProductosDis.Controls.Add(this.txtCantidad);
			this.tpProductosDis.Controls.Add(this.labCantidad);
			this.tpProductosDis.Controls.Add(this.label2);
			this.tpProductosDis.Controls.Add(this.btnAnular);
			this.tpProductosDis.Controls.Add(this.btnTerminarVenta);
			this.tpProductosDis.Location = new System.Drawing.Point(4, 22);
			this.tpProductosDis.Name = "tpProductosDis";
			this.tpProductosDis.Padding = new System.Windows.Forms.Padding(3);
			this.tpProductosDis.Size = new System.Drawing.Size(791, 435);
			this.tpProductosDis.TabIndex = 0;
			this.tpProductosDis.Text = "Productos Disponibles";
			this.tpProductosDis.UseVisualStyleBackColor = true;
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
			this.btnQuitar.BackgroundImage = global::Proyecto_NET.Properties.Resources.IconoQuitar;
			this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnQuitar.ImageKey = "(ninguno)";
			this.btnQuitar.Location = new System.Drawing.Point(683, 279);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnQuitar.Size = new System.Drawing.Size(44, 44);
			this.btnQuitar.TabIndex = 43;
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.UseWaitCursor = true;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.BackgroundImage = global::Proyecto_NET.Properties.Resources.IconoAgregar;
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAgregar.ImageKey = "(ninguno)";
			this.btnAgregar.Location = new System.Drawing.Point(683, 102);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnAgregar.Size = new System.Drawing.Size(44, 44);
			this.btnAgregar.TabIndex = 39;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.UseWaitCursor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpProductosDis);
			this.tabControl1.Controls.Add(this.tpProductosVen);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(799, 461);
			this.tabControl1.TabIndex = 1;
			// 
			// errorIcono
			// 
			this.errorIcono.ContainerControl = this;
			// 
			// frmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 479);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVentas";
			this.Text = ".: Ventas :.";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentas_FormClosing);
			this.Load += new System.EventHandler(this.frmVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.datadetallesVenta)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
			this.tpProductosVen.ResumeLayout(false);
			this.tpProductosVen.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataDetalles)).EndInit();
			this.tpProductosDis.ResumeLayout(false);
			this.tpProductosDis.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView datadetallesVenta;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataProductos;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
		private System.Windows.Forms.TabPage tpProductosVen;
		private System.Windows.Forms.TextBox txtVentaTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataDetalles;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label labCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAnular;
		private System.Windows.Forms.Button btnTerminarVenta;
		private System.Windows.Forms.TabPage tpProductosDis;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolTip ttMensaje;
		private System.Windows.Forms.ErrorProvider errorIcono;
		private System.Windows.Forms.Button btnQuitar;
	}
}