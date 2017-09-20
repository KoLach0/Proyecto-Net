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
	public partial class Ventas : Form
	{



		public Ventas()
		{
			InitializeComponent();
		}

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ListProductos();
                
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

        // Ocular columnas
        private void OcularColumnas() {
            this.dataProductos.Columns[1].Visible = false;
            this.dataProductos.Columns[4].Visible = false;
            
		}

		private void Limpiar()
		{
            this.txtCantidad.Text = string.Empty;
			

		}

        //Mostar Listado Productos

        private void ListProductos() {
            this.dataProductos.DataSource = ProductoController.Mostrar();
            this.OcularColumnas();

        
        }

		private void dataProductos_CellContentClick(object sender, DataGridViewCellEventArgs e){

			if (e.ColumnIndex == dataProductos.Columns["Seleccionar"].Index){
				DataGridViewCheckBoxCell chkSeleccionar = (DataGridViewCheckBoxCell)dataProductos.Rows[e.RowIndex].Cells["Seleccionar"];
				chkSeleccionar.Value = !Convert.ToBoolean(chkSeleccionar.Value);
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string rta = "";
			

			try
			{

				if (this.txtCantidad.Text == string.Empty){
					MensajeError("Falta ingresar algunos datos");
					errorIcono.SetError(txtCantidad, "El campo Cantidad es obligatorio");

				}

				else
				{
					string CodigoP;
					int cantidad;

					foreach (DataGridViewRow row in dataProductos.Rows){

						if (Convert.ToBoolean(row.Cells[0].Value)){

							CodigoP = Convert.ToString(row.Cells[1].Value);
							cantidad = Convert.ToInt32(row.Cells[3].Value);
							cantidad = cantidad * Convert.ToInt32(txtCantidad.Text);

							rta = VentaController.Insertar(Convert.ToInt32(CodigoP),Convert.ToInt32(txtCantidad.Text),cantidad);

							if (rta.Equals("OK")){
								this.MensajeOK("Se ha agregado el producto");
								tabPDisponibles.Hide() ;
								tabPVendidos.Show();

							}else {
								this.MensajeError(rta);
							}
						}

					}

				}

			

				this.Limpiar();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);
			}

		}

		
	}
}
