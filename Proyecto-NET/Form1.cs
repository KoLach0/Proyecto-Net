using Proyecto_NET.Controlador;
using Proyecto_NET.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_NET
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			panelProductos.Visible = false;
			panelTarjeta.Visible = false;
		}
		//Productos
		private void tsmSubProductos_Click(object sender, EventArgs e)
		{
			
			panelTarjeta.Visible = false;
			panelProductos.Visible = true;
			
		}
		//Tarjetas
		private void tsmSubTarjetas_Click(object sender, EventArgs e)
		{
			panelProductos.Visible = false;
			panelTarjeta.Visible = true;
		}

        private void tsmSubVentas_Click(object sender, EventArgs e)
        {
            Ventas formVentas = new Ventas();
            formVentas.Show();
            formVentas.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Minimized;

        }
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }



		//Mostrar Mensaje de Confirmacion
		private void MensajeOK(string mensaje)
		{
			MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//Mostrar Mensaje de Error
		private void MensajeError(string mensaje)
		{
			MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//Limpiar todos los controles del formulario
		private void Limpiar()
		{
            this.txtCodigo.Text = string.Empty;
			this.txtNombre.Text = string.Empty;
			this.txtPrecio.Text = string.Empty;
			this.txtNombreTar.Text = string.Empty;

		}

      

		//  -----START  FUNCIONALIDAD PARA PRODUCTOS-----

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string rta = "";
            int estado = 0;

            try
            {

                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorIcono.SetError(txtNombre, "El campo Nombre es obligatorio");

                    if (this.txtPrecio.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar datos");
                        errorIcono.SetError(txtPrecio, "El campo Precio es obligatorio");
                    }

                    if (this.txtCodigo.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar datos");
                        errorIcono.SetError(txtPrecio, "El campo Codigo es obligatorio");
                    }

                    if (this.txtCantidad.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar datos");
                        errorIcono.SetError(txtPrecio, "El campo Cantidad es obligatorio");
                    }
                }

                else
                {

                    if (comboBoxEstado.Text == "Disponible")
                    {
                        estado = 1;
                    }
                    else
                    {
                        estado = 2;
                    }
                    rta = ProductoController.Insertar(Convert.ToInt32(this.txtCodigo.Text), this.txtNombre.Text, Convert.ToInt32(this.txtPrecio.Text), estado);
                    rta = InventarioController.Insertar(Convert.ToInt32(this.txtCodigo.Text), Convert.ToInt32(this.txtCantidad.Text));
                }

                if (rta.Equals("OK"))
                {
                    this.MensajeOK("Producto Registrado Correctamente");
                }
                else
                {
                    this.MensajeError("Error al registrar el producto ");
                }

                this.Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }


		//  END  ----FUNCIONALIDAD PARA PRODUCTOS--


		//  -----START  FUNCIONALIDAD PARA TARJETAS-----


		private void btnRegistrarTarjeta_Click(object sender, EventArgs e){

			string rta = "";
			int estado = 0;

			try
			{

				if (this.txtNombreTar.Text == string.Empty)
				{
					MensajeError("Falta ingresar algunos datos");
					errorIcono.SetError(txtNombreTar, "El campo Nombre es obligatorio");

				}

				else
				{

					if (comboBoxTarjeta.Text == "Activa")
					{
						estado = 1;
					}
					else
					{
						estado = 2;
					}
					rta = TarjetaCreditoController.Insertar(this.txtNombreTar.Text, estado);
				}

				if (rta.Equals("OK"))
				{
					this.MensajeOK("Tarjeta Registrado Correctamente");
				}
				else
				{
					this.MensajeError("Error al registrar la tarjeta ");
				}

				this.Limpiar();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);
			}
		}

      
        
        


		//  END  ----FUNCIONALIDAD PARA TARJETAS--




	}
}
