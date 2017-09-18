namespace Proyecto_NET.vistas
{
	partial class Reportes
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total_efectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total_tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Fecha inicial";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(224, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fecha final";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(84, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(132, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(289, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(148, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(455, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Producto";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(511, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(684, 28);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(92, 21);
			this.comboBox2.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(638, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tarjeta";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Fecha,
            this.Total_efectivo,
            this.Total_tarjeta,
            this.Cliente});
			this.dataGridView1.Location = new System.Drawing.Point(15, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(685, 127);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Factura
			// 
			this.Factura.HeaderText = "Factura";
			this.Factura.Name = "Factura";
			this.Factura.Width = 120;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.Width = 150;
			// 
			// Total_efectivo
			// 
			this.Total_efectivo.HeaderText = "Total efectivo";
			this.Total_efectivo.Name = "Total_efectivo";
			this.Total_efectivo.Width = 120;
			// 
			// Total_tarjeta
			// 
			this.Total_tarjeta.HeaderText = "Total Tarjeta";
			this.Total_tarjeta.Name = "Total_tarjeta";
			this.Total_tarjeta.Width = 120;
			// 
			// Cliente
			// 
			this.Cliente.HeaderText = "Cliente";
			this.Cliente.Name = "Cliente";
			this.Cliente.Width = 130;
			// 
			// Reportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 261);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Reportes";
			this.Text = "Reportes";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total_efectivo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total_tarjeta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
	}
}