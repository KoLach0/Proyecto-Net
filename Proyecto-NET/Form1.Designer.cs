namespace Proyecto_NET
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.sidebar = new System.Windows.Forms.MenuStrip();
			this.tsmParametrizacion = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSubProductos = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSubTarjetas = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSubVentas = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxRegistrarProducto = new System.Windows.Forms.GroupBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.labCantidad = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.comboBoxEstado = new System.Windows.Forms.ComboBox();
			this.labNombre = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.labCodigo = new System.Windows.Forms.Label();
			this.labEstado = new System.Windows.Forms.Label();
			this.labPrecio = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelProductos = new System.Windows.Forms.Panel();
			this.panelTarjeta = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxTarjeta = new System.Windows.Forms.ComboBox();
			this.labelEstado = new System.Windows.Forms.Label();
			this.btnRegistrarTarjeta = new System.Windows.Forms.Button();
			this.txtNombreTar = new System.Windows.Forms.TextBox();
			this.labelNombre = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
			this.sidebar.SuspendLayout();
			this.groupBoxRegistrarProducto.SuspendLayout();
			this.panelProductos.SuspendLayout();
			this.panelTarjeta.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
			this.SuspendLayout();
			// 
			// sidebar
			// 
			this.sidebar.BackColor = System.Drawing.SystemColors.MenuBar;
			resources.ApplyResources(this.sidebar, "sidebar");
			this.sidebar.GripMargin = new System.Windows.Forms.Padding(2, 4, 0, 4);
			this.sidebar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmParametrizacion,
            this.tsmVentas,
            this.tsmReportes,
            this.tsmSalir});
			this.sidebar.Name = "sidebar";
			// 
			// tsmParametrizacion
			// 
			this.tsmParametrizacion.BackColor = System.Drawing.Color.Transparent;
			this.tsmParametrizacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSubProductos,
            this.tsmSubTarjetas});
			resources.ApplyResources(this.tsmParametrizacion, "tsmParametrizacion");
			this.tsmParametrizacion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tsmParametrizacion.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.tsmParametrizacion.Name = "tsmParametrizacion";
			this.tsmParametrizacion.Padding = new System.Windows.Forms.Padding(8);
			// 
			// tsmSubProductos
			// 
			this.tsmSubProductos.BackColor = System.Drawing.SystemColors.Control;
			this.tsmSubProductos.Name = "tsmSubProductos";
			this.tsmSubProductos.Padding = new System.Windows.Forms.Padding(0, 10, 2, 0);
			resources.ApplyResources(this.tsmSubProductos, "tsmSubProductos");
			this.tsmSubProductos.Click += new System.EventHandler(this.tsmSubProductos_Click);
			// 
			// tsmSubTarjetas
			// 
			this.tsmSubTarjetas.Name = "tsmSubTarjetas";
			this.tsmSubTarjetas.Padding = new System.Windows.Forms.Padding(0, 10, 0, 1);
			resources.ApplyResources(this.tsmSubTarjetas, "tsmSubTarjetas");
			this.tsmSubTarjetas.Click += new System.EventHandler(this.tsmSubTarjetas_Click);
			// 
			// tsmVentas
			// 
			this.tsmVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSubVentas});
			resources.ApplyResources(this.tsmVentas, "tsmVentas");
			this.tsmVentas.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tsmVentas.Name = "tsmVentas";
			this.tsmVentas.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
			// 
			// tsmSubVentas
			// 
			this.tsmSubVentas.Name = "tsmSubVentas";
			resources.ApplyResources(this.tsmSubVentas, "tsmSubVentas");
			this.tsmSubVentas.Click += new System.EventHandler(this.tsmSubVentas_Click);
			// 
			// tsmReportes
			// 
			this.tsmReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsmReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8});
			resources.ApplyResources(this.tsmReportes, "tsmReportes");
			this.tsmReportes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tsmReportes.Name = "tsmReportes";
			this.tsmReportes.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.tsmReportes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
			// 
			// tsmSalir
			// 
			this.tsmSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			resources.ApplyResources(this.tsmSalir, "tsmSalir");
			this.tsmSalir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tsmSalir.Name = "tsmSalir";
			this.tsmSalir.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
			this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
			// 
			// groupBoxRegistrarProducto
			// 
			this.groupBoxRegistrarProducto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			resources.ApplyResources(this.groupBoxRegistrarProducto, "groupBoxRegistrarProducto");
			this.groupBoxRegistrarProducto.Controls.Add(this.txtCantidad);
			this.groupBoxRegistrarProducto.Controls.Add(this.labCantidad);
			this.groupBoxRegistrarProducto.Controls.Add(this.txtCodigo);
			this.groupBoxRegistrarProducto.Controls.Add(this.txtNombre);
			this.groupBoxRegistrarProducto.Controls.Add(this.comboBoxEstado);
			this.groupBoxRegistrarProducto.Controls.Add(this.labNombre);
			this.groupBoxRegistrarProducto.Controls.Add(this.txtPrecio);
			this.groupBoxRegistrarProducto.Controls.Add(this.btnRegistrar);
			this.groupBoxRegistrarProducto.Controls.Add(this.labCodigo);
			this.groupBoxRegistrarProducto.Controls.Add(this.labEstado);
			this.groupBoxRegistrarProducto.Controls.Add(this.labPrecio);
			this.groupBoxRegistrarProducto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBoxRegistrarProducto.Name = "groupBoxRegistrarProducto";
			this.groupBoxRegistrarProducto.TabStop = false;
			// 
			// txtCantidad
			// 
			resources.ApplyResources(this.txtCantidad, "txtCantidad");
			this.txtCantidad.Name = "txtCantidad";
			// 
			// labCantidad
			// 
			resources.ApplyResources(this.labCantidad, "labCantidad");
			this.labCantidad.ForeColor = System.Drawing.Color.SteelBlue;
			this.labCantidad.Name = "labCantidad";
			// 
			// txtCodigo
			// 
			resources.ApplyResources(this.txtCodigo, "txtCodigo");
			this.txtCodigo.Name = "txtCodigo";
			// 
			// txtNombre
			// 
			resources.ApplyResources(this.txtNombre, "txtNombre");
			this.txtNombre.Name = "txtNombre";
			// 
			// comboBoxEstado
			// 
			resources.ApplyResources(this.comboBoxEstado, "comboBoxEstado");
			this.comboBoxEstado.FormattingEnabled = true;
			this.comboBoxEstado.Items.AddRange(new object[] {
            resources.GetString("comboBoxEstado.Items"),
            resources.GetString("comboBoxEstado.Items1")});
			this.comboBoxEstado.Name = "comboBoxEstado";
			// 
			// labNombre
			// 
			resources.ApplyResources(this.labNombre, "labNombre");
			this.labNombre.ForeColor = System.Drawing.Color.SteelBlue;
			this.labNombre.Name = "labNombre";
			// 
			// txtPrecio
			// 
			resources.ApplyResources(this.txtPrecio, "txtPrecio");
			this.txtPrecio.Name = "txtPrecio";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.btnRegistrar, "btnRegistrar");
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
			// 
			// labCodigo
			// 
			resources.ApplyResources(this.labCodigo, "labCodigo");
			this.labCodigo.ForeColor = System.Drawing.Color.SteelBlue;
			this.labCodigo.Name = "labCodigo";
			// 
			// labEstado
			// 
			resources.ApplyResources(this.labEstado, "labEstado");
			this.labEstado.ForeColor = System.Drawing.Color.SteelBlue;
			this.labEstado.Name = "labEstado";
			// 
			// labPrecio
			// 
			resources.ApplyResources(this.labPrecio, "labPrecio");
			this.labPrecio.ForeColor = System.Drawing.Color.SteelBlue;
			this.labPrecio.Name = "labPrecio";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label3.Name = "label3";
			// 
			// panelProductos
			// 
			this.panelProductos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panelProductos.Controls.Add(this.groupBoxRegistrarProducto);
			this.panelProductos.Controls.Add(this.label3);
			resources.ApplyResources(this.panelProductos, "panelProductos");
			this.panelProductos.Name = "panelProductos";
			// 
			// panelTarjeta
			// 
			this.panelTarjeta.BackColor = System.Drawing.Color.GhostWhite;
			this.panelTarjeta.Controls.Add(this.groupBox1);
			this.panelTarjeta.Controls.Add(this.label5);
			this.panelTarjeta.Controls.Add(this.label6);
			resources.ApplyResources(this.panelTarjeta, "panelTarjeta");
			this.panelTarjeta.Name = "panelTarjeta";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.comboBoxTarjeta);
			this.groupBox1.Controls.Add(this.labelEstado);
			this.groupBox1.Controls.Add(this.btnRegistrarTarjeta);
			this.groupBox1.Controls.Add(this.txtNombreTar);
			this.groupBox1.Controls.Add(this.labelNombre);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// comboBoxTarjeta
			// 
			this.comboBoxTarjeta.FormattingEnabled = true;
			this.comboBoxTarjeta.Items.AddRange(new object[] {
            resources.GetString("comboBoxTarjeta.Items"),
            resources.GetString("comboBoxTarjeta.Items1")});
			resources.ApplyResources(this.comboBoxTarjeta, "comboBoxTarjeta");
			this.comboBoxTarjeta.Name = "comboBoxTarjeta";
			// 
			// labelEstado
			// 
			resources.ApplyResources(this.labelEstado, "labelEstado");
			this.labelEstado.ForeColor = System.Drawing.Color.SteelBlue;
			this.labelEstado.Name = "labelEstado";
			// 
			// btnRegistrarTarjeta
			// 
			this.btnRegistrarTarjeta.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnRegistrarTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.btnRegistrarTarjeta, "btnRegistrarTarjeta");
			this.btnRegistrarTarjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegistrarTarjeta.Name = "btnRegistrarTarjeta";
			this.btnRegistrarTarjeta.UseVisualStyleBackColor = false;
			this.btnRegistrarTarjeta.Click += new System.EventHandler(this.btnRegistrarTarjeta_Click);
			// 
			// txtNombreTar
			// 
			resources.ApplyResources(this.txtNombreTar, "txtNombreTar");
			this.txtNombreTar.Name = "txtNombreTar";
			// 
			// labelNombre
			// 
			resources.ApplyResources(this.labelNombre, "labelNombre");
			this.labelNombre.ForeColor = System.Drawing.Color.SteelBlue;
			this.labelNombre.Name = "labelNombre";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label5.Name = "label5";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// errorIcono
			// 
			this.errorIcono.ContainerControl = this;
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panelTarjeta);
			this.Controls.Add(this.panelProductos);
			this.Controls.Add(this.sidebar);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.MainMenuStrip = this.sidebar;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.sidebar.ResumeLayout(false);
			this.sidebar.PerformLayout();
			this.groupBoxRegistrarProducto.ResumeLayout(false);
			this.groupBoxRegistrarProducto.PerformLayout();
			this.panelProductos.ResumeLayout(false);
			this.panelProductos.PerformLayout();
			this.panelTarjeta.ResumeLayout(false);
			this.panelTarjeta.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem parametrizaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarjetasDeCréditoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox productosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip sidebar;
		private System.Windows.Forms.ToolStripMenuItem tsmParametrizacion;
		private System.Windows.Forms.ToolStripMenuItem tsmSubProductos;
		private System.Windows.Forms.ToolStripMenuItem tsmSubTarjetas;
		private System.Windows.Forms.ToolStripMenuItem tsmVentas;
		private System.Windows.Forms.ToolStripMenuItem tsmReportes;
		private System.Windows.Forms.ToolStripMenuItem tsmSubVentas;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.GroupBox groupBoxRegistrarProducto;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.Label labPrecio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panelProductos;
		private System.Windows.Forms.Panel panelTarjeta;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxTarjeta;
		private System.Windows.Forms.Label labelEstado;
		private System.Windows.Forms.Button btnRegistrarTarjeta;
		private System.Windows.Forms.TextBox txtNombreTar;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
	}
}

