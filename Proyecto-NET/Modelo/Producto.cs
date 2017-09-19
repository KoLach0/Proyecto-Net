using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto_NET.Modelo
{
	public class Producto{

        private int idProducto;
        private string nombre;
        private int precio;
        private int fk_estado;

        public int Fk_estado
        {
            get { return fk_estado; }
            set { fk_estado = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

		//Constructor

		public Producto() {
		}

		//Constructor con Parametros

		public Producto(int idProducto, string nombre, int precio, int fk_estado ){
			this.idProducto = idProducto;
			this.nombre = nombre;
			this.precio = precio;
			this.fk_estado = fk_estado;
		}

		// Setters and Getters

		//public int IdProducto {get => idProducto;set => idProducto = value;}
		//public string Nombre {get => nombre;set => nombre = value;}
		//public int Precio {get => precio;set => precio = value;}
		//public int Fk_estado {get => fk_estado;set => fk_estado = value;}

		// Metodo Insertar
		public string Insertar(Producto Producto) {

			string rta = "";

			SqlConnection SqlCon = new SqlConnection();

			try
			{

				SqlCon.ConnectionString = Conexion.Cn;
				SqlCon.Open();

				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.CommandText = "pa_insertar_producto";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParIdProducto = new SqlParameter();
				ParIdProducto.ParameterName = "@idproducto";
				ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.SqlValue = Producto.idProducto;
				SqlCmd.Parameters.Add(ParIdProducto);

				SqlParameter ParNombre = new SqlParameter();
				ParNombre.ParameterName = "@nombre";
				ParNombre.SqlDbType = SqlDbType.VarChar;
				ParNombre.Size = 50;
				ParNombre.SqlValue = Producto.Nombre;
				SqlCmd.Parameters.Add(ParNombre);

				SqlParameter ParPrecio = new SqlParameter();
				ParPrecio.ParameterName = "@precio";
				ParPrecio.SqlDbType = SqlDbType.Int;
				ParPrecio.SqlValue = Producto.Precio;
				SqlCmd.Parameters.Add(ParPrecio);

				SqlParameter ParEstado = new SqlParameter();
				ParEstado.ParameterName = "@estado";
				ParEstado.SqlDbType = SqlDbType.Int;
				ParEstado.SqlValue = Producto.Fk_estado;
				SqlCmd.Parameters.Add(ParEstado);

				//Ejecutar el procedimiento

				rta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";


			}
			catch (Exception e)
			{

				rta = e.Message + e.StackTrace;
			}
			finally {
				if (SqlCon.State== ConnectionState.Open){
					SqlCon.Close();
				}
			}

			return rta;

		}

		//Metodo Editar
		public string Editar(Producto Producto) {

			string rta = "";

			SqlConnection SqlCon = new SqlConnection();

			try
			{

				SqlCon.ConnectionString = Conexion.Cn;
				SqlCon.Open();

				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.CommandText = "pa_editar_producto";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParIdProducto = new SqlParameter();
				ParIdProducto.ParameterName = "@idproducto";
				ParIdProducto.SqlDbType = SqlDbType.Int;
				ParIdProducto.Value = Producto.IdProducto;
				SqlCmd.Parameters.Add(ParIdProducto);

				SqlParameter ParNombre = new SqlParameter();
				ParNombre.ParameterName = "@nombre";
				ParNombre.SqlDbType = SqlDbType.VarChar;
				ParNombre.Size = 50;
				ParNombre.SqlValue = Producto.Nombre;
				SqlCmd.Parameters.Add(ParNombre);

				SqlParameter ParPrecio = new SqlParameter();
				ParPrecio.ParameterName = "@precio";
				ParPrecio.SqlDbType = SqlDbType.Int;
				ParPrecio.SqlValue = Producto.Precio;
				SqlCmd.Parameters.Add(ParPrecio);

				SqlParameter ParEstado = new SqlParameter();
				ParEstado.ParameterName = "@estado";
				ParEstado.SqlDbType = SqlDbType.Int;
				ParEstado.SqlValue = Producto.Fk_estado;
				SqlCmd.Parameters.Add(ParEstado);

				//Ejecutar el procedimiento

				rta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";


			}
			catch (Exception e)
			{

				rta = e.Message;
			}
			finally
			{
				if (SqlCon.State == ConnectionState.Open)
				{
					SqlCon.Close();
				}
			}

			return rta;

		}

		//Metodo Mostrar
		public DataTable Mostrar() {

			DataTable DtResultado = new DataTable("productos");
			SqlConnection SqlCon = new SqlConnection();

			try{
				SqlCon.ConnectionString = Conexion.Cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.CommandText = "pa_mostrar_productos";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);

			}
			catch (Exception e){
				DtResultado = null;
			}

			return DtResultado;


		}

	}
}
