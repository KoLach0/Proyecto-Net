using Proyecto_NET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Controlador
{
	class VentaController {


		public static string Insertar(int fk_producto, int cantidad, int total) {

			Ventas ven = new Ventas();
			ven.FkProducto = fk_producto;
			ven.Cantidad = cantidad;
			ven.TotalProducto = total;

			return ven.Insertar(ven);
		}

	}
}
