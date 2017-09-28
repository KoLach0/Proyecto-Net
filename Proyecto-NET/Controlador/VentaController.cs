using Proyecto_NET.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Controlador
{
	class VentaController {


		public static string Insertar(int fk_producto, int cantidad, int total, DataTable dtproductos) {

			Ventas ven = new Ventas();
			ven.FkProducto = fk_producto;
			ven.Cantidad = cantidad;
			ven.TotalProducto = total;
			List<Producto> productos = new List<Producto>();

			foreach (DataRow row in dtproductos.Rows){

				Producto pro = new Producto();

				pro.IdProducto = Convert.ToInt32(row["id_producto"].ToString());
				pro.Nombre = row["nombre"].ToString();
				pro.Precio = Convert.ToInt32(row["total_efectivo"].ToString());
				pro.Fk_estado = Convert.ToInt32(row["fk_estado"].ToString());
				

				productos.Add(pro);

			}


			return ven.Insertar(ven, productos);
		}

		public static DataTable MostrarDetalleVenta()
		{

			return new Ventas().MostrarDetalleVenta();
		}

	}

}

