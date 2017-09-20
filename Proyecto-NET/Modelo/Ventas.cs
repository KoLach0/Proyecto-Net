using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Modelo
{
	class Ventas{

		private int idVenta;
		private int fkProducto;
		private int cantidad;
		private int totalProducto;

		public Ventas() { }

		public Ventas(int id_venta, int fk_producto, int cantidad, int total) {

			this.idVenta = IdVenta;
			this.fkProducto = FkProducto;
			this.cantidad = Cantidad;
			this.totalProducto = TotalProducto;

		}

		public int IdVenta { get => idVenta; set => idVenta = value; }
		public int FkProducto { get => fkProducto; set => fkProducto = value; }
		public int Cantidad { get => cantidad; set => cantidad = value; }
		public int TotalProducto { get => totalProducto; set => totalProducto = value; }

		
	}
}
