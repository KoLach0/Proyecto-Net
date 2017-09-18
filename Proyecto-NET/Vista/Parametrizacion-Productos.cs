using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proyecto_NET.Controlador;

namespace Proyecto_NET.vistas
{
	public partial class Parametrizacion : Form{

		private bool IsNuevo = false;
		private bool IsEditar = false;



		public Parametrizacion()
		{
			InitializeComponent();
			this.ttMensaje.SetToolTip(this.txtNombre,"Ingrese el nombre del producto");
			this.ttMensaje.SetToolTip(this.txtPrecio, "Ingrese el precio del producto");
		}

		//Mostrar Mensaje de Confirmacion
		private void MensajeOK(string mensaje) {
			MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//Mostrar Mensaje de Error
		private void MensajeError(string mensaje){
			MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//Limpiar todos los controles del formulario
		private void Limpiar() {
			this.txtNombre.Text = string.Empty;
			this.txtPrecio.Text = string.Empty;
			this.txtEstado.Text = string.Empty;

		}

		//Mostrar Productos

		private void Mostrar() {
			
		}

		private void Parametrizacion_Load(object sender, EventArgs e)
		{

		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			try{
				string rta = "";
				if (this.txtNombre.Text == string.Empty)
				{
					MensajeError("Falta ingresar algunos datos");
					errorIcono.SetError(txtNombre, "El campo Nombre es obligatorio");
				}
				
			
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);
			}
			

			

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
