using Proyecto_NET.Controlador;
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
	public partial class frmVentas : Form{

		private static frmVentas _instancia;

		private DataTable dtDetalles;
		private int ventaTotal = 0;
		private bool agregar = true;

		public frmVentas()
		{
			InitializeComponent();
			this.ttMensaje.SetToolTip(this.txtCantidad, "Seleccione la cantidad de productos a llevar");

			this.txtVentaTotal.ReadOnly = true;
		}

		private void frmVentas_Load(object sender, EventArgs e)
		{
			this.ListProductos();
			this.crearTabla();
		}


		public static frmVentas getInstancia()
		{
			if (_instancia == null)
			{

				_instancia = new frmVentas();

			}
			return _instancia;
		}

		private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
		{
			_instancia = null;
		}

		
		public void getProductos(DataTable dtproductos) {
			this.dtDetalles = dtproductos;
		}

		private void btnTerminarVenta_Click(object sender, EventArgs e)
		{

			TerminarVenta form = new TerminarVenta();
			form.Show();
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

		// Ocular columnas Productos
		private void OcularColumnasProducto()
		{

			this.dataProductos.Columns[4].Visible = false;
		}

		// Ocular columnas DetalleVenta
		private void OcularColumnasDVentas()
		{
			//this.dataProductoVendidos.Columns[0].Visible = false;
			//this.dataProductoVendidos.Columns[1].Visible = false;
			//this.dataProductoVendidos.Columns[3].Visible = false;
			//this.dataProductoVendidos.Columns[4].Visible = false;
			//this.dataProductoVendidos.Columns[7].Visible = false;
			//this.dataProductoVendidos.Columns[8].Visible = false;
		}

		private void Limpiar()
		{
			this.txtCantidad.Text = string.Empty;
			this.crearTabla();


		}

		//Mostar Listado Productos
		private void ListProductos()
		{
			this.dataProductos.DataSource = ProductoController.Mostrar();
			this.OcularColumnasProducto();
		}
		//Mostar Listado DetalleVenta
		private void ListDetalleVenta()
		{
			this.datadetallesVenta.DataSource = VentaController.MostrarDetalleVenta();
			this.OcularColumnasDVentas();
		}

		private void dataProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e){
			if (e.ColumnIndex == dataProductos.Columns["Seleccionar"].Index)
			{
				DataGridViewCheckBoxCell chkSeleccionar = (DataGridViewCheckBoxCell)dataProductos.Rows[e.RowIndex].Cells["Seleccionar"];
				chkSeleccionar.Value = !Convert.ToBoolean(chkSeleccionar.Value);
			}
		}
		
		private void crearTabla()
		{
			this.dtDetalles = new DataTable("Detalle");
			this.dtDetalles.Columns.Add("Codigo", System.Type.GetType("System.Int32"));
			this.dtDetalles.Columns.Add("Nombre", System.Type.GetType("System.String"));
			this.dtDetalles.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
			this.dtDetalles.Columns.Add("Total", System.Type.GetType("System.Int32"));
			
			//Relacionar DataGridView con el DataTable
			this.dataDetalles.DataSource = this.dtDetalles;

		}

		private void btnAgregar_Click_1(object sender, EventArgs e){

			string rta = "";


			try
			{

				if (this.txtCantidad.Text == string.Empty)
				{
					MensajeError("Falta ingresar algunos datos");
					errorIcono.SetError(txtCantidad, "El campo Cantidad es obligatorio");

				}
				else
				{
					bool registrar = true;
					string CodigoP, nombre;
					int cantidad, total;



					foreach (DataGridViewRow row in dataProductos.Rows)
					{

						if (Convert.ToBoolean(row.Cells[0].Value))
						{

							CodigoP = Convert.ToString(row.Cells[1].Value);
							nombre = Convert.ToString(row.Cells[2].Value);
							cantidad = Convert.ToInt32(row.Cells[3].Value);
							


							total = cantidad * Convert.ToInt32(txtCantidad.Text);

							foreach (DataRow row2 in dtDetalles.Rows)
							{
								if (Convert.ToInt32(row2["Codigo"]) == Convert.ToInt32(CodigoP))
								{
									registrar = false;
									this.MensajeError("Ya se encuentra este producto en producto agregados");
									break;
								}
							}
							if (registrar)
							{
								DataRow row3 = this.dtDetalles.NewRow();
								row3["Codigo"] = Convert.ToInt32(CodigoP);
								row3["Nombre"] = Convert.ToString(nombre);
								row3["Cantidad"] = Convert.ToInt32(cantidad);
								row3["Total"] = Convert.ToInt32(total);
								this.dtDetalles.Rows.Add(row3);
								

							}//rta = VentaController.Insertar(Convert.ToInt32(CodigoP), Convert.ToInt32(txtCantidad.Text), total, dtDetalles);

							else
							{
								this.MensajeError("Error al agregar un producto");
								break;
							}
						}
					}
				}	
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);
			}
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			try{
				int indiceFila = this.dataDetalles.CurrentCell.RowIndex;
				DataRow row = this.dtDetalles.Rows[indiceFila];

				//remover
				this.dtDetalles.Rows.Remove(row);
			}
			catch (Exception)
			{

				MensajeError("No hay fila para remover");
			}
		}

		
	}
}
