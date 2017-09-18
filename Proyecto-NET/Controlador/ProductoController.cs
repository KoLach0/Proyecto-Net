using Proyecto_NET.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Proyecto_NET.Controlador
{
	public class ProductoController{

		public static string Insertar(String nombre, int precio, int estado) {

			Producto Obj = new Producto();
			Obj.Nombre = nombre;
			Obj.Precio = precio;
			Obj.Fk_estado = estado;

			return Obj.Insertar(Obj);
		}

		public static string Editar(int idproducto, String nombre, int precio, int estado){

			Producto Obj = new Producto();
			Obj.IdProducto = idproducto;
			Obj.Nombre = nombre;
			Obj.Precio = precio;
			Obj.Fk_estado = estado;

			return Obj.Editar(Obj);
		}

		public static DataTable Mostrar()
		{

			return new Producto().Mostrar();
		}




	}
}
