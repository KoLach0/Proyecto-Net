namespace Proyecto_NET.vistas
{
	partial class Parametrizacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametrizacion));
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.labPrecio = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.labNombre = new System.Windows.Forms.Label();
			this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
			this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.labEstado = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label3.Location = new System.Drawing.Point(45, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 31);
			this.label3.TabIndex = 6;
			this.label3.Text = "Productos";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEstado);
			this.groupBox1.Controls.Add(this.labEstado);
			this.groupBox1.Controls.Add(this.btnRegistrar);
			this.groupBox1.Controls.Add(this.txtPrecio);
			this.groupBox1.Controls.Add(this.labPrecio);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.labNombre);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(52, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 225);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registrar Producto";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegistrar.Location = new System.Drawing.Point(117, 162);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(157, 33);
			this.btnRegistrar.TabIndex = 10;
			this.btnRegistrar.Text = "Agregar Producto";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(139, 78);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(159, 20);
			this.txtPrecio.TabIndex = 9;
			// 
			// labPrecio
			// 
			this.labPrecio.AutoSize = true;
			this.labPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPrecio.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labPrecio.Location = new System.Drawing.Point(73, 81);
			this.labPrecio.Name = "labPrecio";
			this.labPrecio.Size = new System.Drawing.Size(56, 15);
			this.labPrecio.TabIndex = 8;
			this.labPrecio.Text = "Precio: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(139, 32);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(159, 20);
			this.txtNombre.TabIndex = 7;
			// 
			// labNombre
			// 
			this.labNombre.AutoSize = true;
			this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labNombre.Location = new System.Drawing.Point(73, 35);
			this.labNombre.Name = "labNombre";
			this.labNombre.Size = new System.Drawing.Size(66, 15);
			this.labNombre.TabIndex = 6;
			this.labNombre.Text = "Nombre: ";
			// 
			// errorIcono
			// 
			this.errorIcono.ContainerControl = this;
			// 
			// ttMensaje
			// 
			this.ttMensaje.IsBalloon = true;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(139, 121);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(159, 20);
			this.txtEstado.TabIndex = 12;
			this.txtEstado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// labEstado
			// 
			this.labEstado.AutoSize = true;
			this.labEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labEstado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labEstado.Location = new System.Drawing.Point(73, 124);
			this.labEstado.Name = "labEstado";
			this.labEstado.Size = new System.Drawing.Size(55, 15);
			this.labEstado.TabIndex = 11;
			this.labEstado.Text = "Estado:";
			this.labEstado.Click += new System.EventHandler(this.label1_Click);
			// 
			// Parametrizacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(509, 286);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Parametrizacion";
			this.Text = ".:. Registrar Producto .:.";
			this.Load += new System.EventHandler(this.Parametrizacion_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label labPrecio;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label labNombre;
		private System.Windows.Forms.ErrorProvider errorIcono;
		private System.Windows.Forms.ToolTip ttMensaje;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label labEstado;
	}
}