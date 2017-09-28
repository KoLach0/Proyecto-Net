using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public int FkProducto
        {
            get { return fkProducto; }
            set { fkProducto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int TotalProducto
        {
            get { return totalProducto; }
            set { totalProducto = value; }
        }

		//public int IdVenta { get => idVenta; set => idVenta = value; }
		//public int FkProducto { get => fkProducto; set => fkProducto = value; }
		//public int Cantidad { get => cantidad; set => cantidad = value; }
		//public int TotalProducto { get => totalProducto; set => totalProducto = value; }


		// Metodo Insertar
		public string Insertar(Ventas Venta, List<Producto> productos)
		{

			string rta = "";

			SqlConnection SqlCon = new SqlConnection();

			try
			{

				SqlCon.ConnectionString = Conexion.Cn;
				SqlCon.Open();
				SqlTransaction SqlTra = SqlCon.BeginTransaction();

				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.Transaction = SqlTra;
				SqlCmd.CommandText = "pa_insertar_venta";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParIdVenta = new SqlParameter();
				ParIdVenta.ParameterName = "@idventa";
                ParIdVenta.SqlDbType = SqlDbType.Int;
				ParIdVenta.Direction = ParameterDirection.Output;
				SqlCmd.Parameters.Add(ParIdVenta);

				SqlParameter ParFkProducto = new SqlParameter();
				ParFkProducto.ParameterName = "@fkproducto";
				ParFkProducto.SqlDbType = SqlDbType.Int;
				ParFkProducto.SqlValue = Venta.FkProducto;
				SqlCmd.Parameters.Add(ParFkProducto);

				SqlParameter ParCantidad = new SqlParameter();
				ParCantidad.ParameterName = "@cantidad";
				ParCantidad.SqlDbType = SqlDbType.Int;
				ParCantidad.SqlValue = Venta.Cantidad;
				SqlCmd.Parameters.Add(ParCantidad);

				SqlParameter ParTotal = new SqlParameter();
				ParTotal.ParameterName = "@total";
				ParTotal.SqlDbType = SqlDbType.Int;
				ParTotal.SqlValue = Venta.TotalProducto;
				SqlCmd.Parameters.Add(ParTotal);

				//Ejecutar el procedimiento

				rta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";

				if (rta.Equals("OK")){
					// Obtener el ID de "Ventas" generado
					this.idVenta = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
					DetalleVenta det = new DetalleVenta();

						det.FkVenta = this.idVenta;
						rta = det.Insertar(det, ref SqlCon, ref SqlTra);
					SqlTra.Commit();

				}else {
					SqlTra.Rollback();
				}

			}
			catch (Exception e)
			{

				rta = e.Message + e.StackTrace;
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
		public DataTable MostrarDetalleVenta()
		{

			DataTable DtResultado = new DataTable("detalle_venta");
			SqlConnection SqlCon = new SqlConnection();

			try
			{
				SqlCon.ConnectionString = Conexion.Cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.CommandText = "pa_mostrar_detalle_venta";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);

			}
			catch (Exception e)
			{
				DtResultado = null;
			}

			return DtResultado;


		}
	}
}
