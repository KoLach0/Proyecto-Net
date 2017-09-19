using Proyecto_NET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Controlador
{
	class TarjetaCreditoController{

		public static string Insertar(string nombre, int estado) {

			TarjetasCredito Tar = new TarjetasCredito();
			Tar.Nombre = nombre;
			Tar.FkEstado = estado;

			return Tar.Insertar(Tar);
		}
	}
}
