using Proyecto_NET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Controlador
{
	class DetalleVentaController{

		public static string Insertar(int fk_tarjeta, int fk_venta, int cedula, string nombre, int tota_efectivo, int total_tarjeta, int vueltas, DateTime fecha) {

			DetalleVenta DVenta = new DetalleVenta();
			DVenta.FkTarjeta = fk_tarjeta;
			DVenta.FkVenta = fk_venta;
			DVenta.CedulaCliente = cedula;
			DVenta.NomCliente = nombre;
			DVenta.TotalEfectivo = tota_efectivo;
			DVenta.TotalTarjeta = total_tarjeta;
			DVenta.Vueltas = vueltas;
			DVenta.Fecha = fecha;

			return DVenta.Insertar(DVenta);
		}
	}
}
