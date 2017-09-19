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

        //Mostar Listado Productos

        private void ListProductos() {
            this.dataProductos.DataSource = ProductoController.Mostrar();
            this.OcularColumnas();

        
        }




		
	}
}
