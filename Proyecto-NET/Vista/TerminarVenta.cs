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

namespace Proyecto_NET.Vista
{
	public partial class TerminarVenta : Form
	{
		public TerminarVenta()
		{
			InitializeComponent();
		}

		private void TerminarVenta_Load(object sender, EventArgs e)
		{
            LlenarComboBox();
            

            labTarjetaCredito.Visible = false;
            comboBoxTarjeta.Visible = false;

            labEfectivo.Visible = false;
            txtEfectivo.Visible = false;

            labTotalTarjeta.Visible = false;
            txtTotalTarjeta.Visible = false;
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
			this.txtEfectivo.Text = string.Empty;
			this.txtTotalTarjeta.Text = string.Empty;
			this.txtCedula.Text = string.Empty;
			this.txtNombre.Text = string.Empty;
			this.txtVueltas.Text = string.Empty;
		}



        private void rbEfectivo_CheckedChanged(object sender, EventArgs e){
            if (rbEfectivo.Checked){
                labTarjetaCredito.Visible = false;
                comboBoxTarjeta.Visible = false;

                labEfectivo.Visible = true;
                txtEfectivo.Visible = true;

                labTotalTarjeta.Visible = false;
                txtTotalTarjeta.Visible = false;
            }

        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e){
            if (rbTarjeta.Checked)
            {
                labTarjetaCredito.Visible = true;
                comboBoxTarjeta.Visible = true;

                labEfectivo.Visible = false;
                txtEfectivo.Visible = false;

                labTotalTarjeta.Visible = true;
                txtTotalTarjeta.Visible = true;

            }

        }


		private void LlenarComboBox()
		{
			try
			{
				comboBoxTarjeta.DataSource = TarjetaCreditoController.Mostrar();
				comboBoxTarjeta.DisplayMember = "nombre";
				comboBoxTarjeta.ValueMember = "id_tarjeta";
                

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + ex.StackTrace);

			}
		}
			


		private void btnGuardar_Click(object sender, EventArgs e){

            string rta = "";
            string tarjetaSeleccionada = comboBoxTarjeta.SelectedValue.ToString();
			frmVentas form = frmVentas.getInstancia();




			try
			{
				

				if (this.txtCedula.Text == string.Empty || this.txtNombre.Text == string.Empty)
				{
					MensajeError("Falta ingresar algunos datos");
					errorIcono.SetError(txtCedula, "El campo identificaion es obligatorio");
					errorIcono.SetError(txtNombre, "El campo nombres es obligatorio");

				}else {


					if (rbEfectivo.Checked){

						//rta = VentaController.Insertar(Convert.ToInt32(tarjetaSeleccionada),);

						if (rbTarjeta.Checked)
						{

							//rta = DetalleVentaController.Insertar();
						}

					}


				}



            }
            catch (Exception ex)
            {
				MessageBox.Show(ex.Message + ex.StackTrace);
			}

       }

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Limpiar();
		}

	}
}
