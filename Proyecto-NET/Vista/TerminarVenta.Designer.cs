namespace Proyecto_NET.Vista
{
	partial class TerminarVenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminarVenta));
			this.labTarjetaCredito = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.labCedula = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.labNombre = new System.Windows.Forms.Label();
			this.txtVueltas = new System.Windows.Forms.TextBox();
			this.labVueltas = new System.Windows.Forms.Label();
			this.comboBoxTarjeta = new System.Windows.Forms.ComboBox();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.labEfectivo = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTotalTarjeta = new System.Windows.Forms.TextBox();
			this.labTotalTarjeta = new System.Windows.Forms.Label();
			this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.rbTarjeta = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
			this.SuspendLayout();
			// 
			// labTarjetaCredito
			// 
			this.labTarjetaCredito.AutoSize = true;
			this.labTarjetaCredito.Location = new System.Drawing.Point(42, 146);
			this.labTarjetaCredito.Name = "labTarjetaCredito";
			this.labTarjetaCredito.Size = new System.Drawing.Size(76, 13);
			this.labTarjetaCredito.TabIndex = 0;
			this.labTarjetaCredito.Text = "Tarjeta Credito";
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(131, 23);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(130, 20);
			this.txtCedula.TabIndex = 3;
			// 
			// labCedula
			// 
			this.labCedula.AutoSize = true;
			this.labCedula.Location = new System.Drawing.Point(34, 26);
			this.labCedula.Name = "labCedula";
			this.labCedula.Size = new System.Drawing.Size(93, 13);
			this.labCedula.TabIndex = 2;
			this.labCedula.Text = "No. Identificacion:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(132, 47);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(130, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// labNombre
			// 
			this.labNombre.AutoSize = true;
			this.labNombre.Location = new System.Drawing.Point(38, 50);
			this.labNombre.Name = "labNombre";
			this.labNombre.Size = new System.Drawing.Size(81, 13);
			this.labNombre.TabIndex = 4;
			this.labNombre.Text = "Nombre cliente:";
			// 
			// txtVueltas
			// 
			this.txtVueltas.Location = new System.Drawing.Point(130, 218);
			this.txtVueltas.Multiline = true;
			this.txtVueltas.Name = "txtVueltas";
			this.txtVueltas.Size = new System.Drawing.Size(130, 32);
			this.txtVueltas.TabIndex = 7;
			// 
			// labVueltas
			// 
			this.labVueltas.AutoSize = true;
			this.labVueltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labVueltas.Location = new System.Drawing.Point(43, 225);
			this.labVueltas.Name = "labVueltas";
			this.labVueltas.Size = new System.Drawing.Size(75, 20);
			this.labVueltas.TabIndex = 6;
			this.labVueltas.Text = "Vueltas:";
			// 
			// comboBoxTarjeta
			// 
			this.comboBoxTarjeta.FormattingEnabled = true;
			this.comboBoxTarjeta.Items.AddRange(new object[] {
            "Efectivo"});
			this.comboBoxTarjeta.Location = new System.Drawing.Point(131, 143);
			this.comboBoxTarjeta.Name = "comboBoxTarjeta";
			this.comboBoxTarjeta.Size = new System.Drawing.Size(130, 21);
			this.comboBoxTarjeta.TabIndex = 8;
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.Location = new System.Drawing.Point(131, 170);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(130, 20);
			this.txtEfectivo.TabIndex = 10;
			// 
			// labEfectivo
			// 
			this.labEfectivo.AutoSize = true;
			this.labEfectivo.Location = new System.Drawing.Point(54, 174);
			this.labEfectivo.Name = "labEfectivo";
			this.labEfectivo.Size = new System.Drawing.Size(46, 13);
			this.labEfectivo.TabIndex = 9;
			this.labEfectivo.Text = "Efectivo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(226, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "-------------------------------------------------------------------------";
			// 
			// txtTotalTarjeta
			// 
			this.txtTotalTarjeta.Location = new System.Drawing.Point(131, 172);
			this.txtTotalTarjeta.Name = "txtTotalTarjeta";
			this.txtTotalTarjeta.Size = new System.Drawing.Size(130, 20);
			this.txtTotalTarjeta.TabIndex = 13;
			// 
			// labTotalTarjeta
			// 
			this.labTotalTarjeta.AutoSize = true;
			this.labTotalTarjeta.Location = new System.Drawing.Point(42, 177);
			this.labTotalTarjeta.Name = "labTotalTarjeta";
			this.labTotalTarjeta.Size = new System.Drawing.Size(78, 13);
			this.labTotalTarjeta.TabIndex = 12;
			this.labTotalTarjeta.Text = "Total en tarjeta";
			// 
			// errorIcono
			// 
			this.errorIcono.ContainerControl = this;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnGuardar.Location = new System.Drawing.Point(26, 276);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(109, 34);
			this.btnGuardar.TabIndex = 14;
			this.btnGuardar.Text = "Guardar Venta";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancelar.Location = new System.Drawing.Point(180, 276);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(109, 34);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.AutoSize = true;
			this.rbEfectivo.Location = new System.Drawing.Point(74, 114);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
			this.rbEfectivo.TabIndex = 16;
			this.rbEfectivo.TabStop = true;
			this.rbEfectivo.Text = "Efectivo";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
			// 
			// rbTarjeta
			// 
			this.rbTarjeta.AutoSize = true;
			this.rbTarjeta.Location = new System.Drawing.Point(149, 114);
			this.rbTarjeta.Name = "rbTarjeta";
			this.rbTarjeta.Size = new System.Drawing.Size(94, 17);
			this.rbTarjeta.TabIndex = 17;
			this.rbTarjeta.TabStop = true;
			this.rbTarjeta.Text = "Tarjeta Credito";
			this.rbTarjeta.UseVisualStyleBackColor = true;
			this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Metodo de pago";
			// 
			// TerminarVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 332);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rbTarjeta);
			this.Controls.Add(this.rbEfectivo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtTotalTarjeta);
			this.Controls.Add(this.labTotalTarjeta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEfectivo);
			this.Controls.Add(this.labEfectivo);
			this.Controls.Add(this.comboBoxTarjeta);
			this.Controls.Add(this.txtVueltas);
			this.Controls.Add(this.labVueltas);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.labNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.labCedula);
			this.Controls.Add(this.labTarjetaCredito);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TerminarVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Terminar Venta";
			this.Load += new System.EventHandler(this.TerminarVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labTarjetaCredito;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.Label labCedula;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label labNombre;
		private System.Windows.Forms.TextBox txtVueltas;
		private System.Windows.Forms.Label labVueltas;
		private System.Windows.Forms.ComboBox comboBoxTarjeta;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label labEfectivo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTotalTarjeta;
		private System.Windows.Forms.Label labTotalTarjeta;
		private System.Windows.Forms.ErrorProvider errorIcono;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
	}
}