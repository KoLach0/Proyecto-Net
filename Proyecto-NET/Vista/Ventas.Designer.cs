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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(29, 26);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(200, 100);
			this.tabControl1.TabIndex = 3;
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
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Venta Total";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(33, 180);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 39);
			this.textBox1.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Location = new System.Drawing.Point(338, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 194);
			this.panel1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(335, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Productos Disponibles";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(607, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cantidad";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(610, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(85, 20);
			this.textBox2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(610, 103);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(46, 276);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 33);
			this.button2.TabIndex = 11;
			this.button2.Text = "Terminar Venta";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(210, 276);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(69, 33);
			this.button3.TabIndex = 12;
			this.button3.Text = "Anular";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 321);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}