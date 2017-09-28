using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Modelo
{
	class DetalleVenta{

        private int idDetalleVenta;
        private int fkTarjeta;
        private int fkVenta;
        private int cedulaCliente;
        private string nomCliente;
        private int totalEfectivo;
        private int totalTarjeta;
        private int vueltas;
        private DateTime fecha;


		public DetalleVenta() { }

		public DetalleVenta(int idDetalleVenta, int fkTarjeta, int fkVenta, int cedulaCliente, string nomCliente, int totalEfectivo, int totalTarjeta, int vueltas, DateTime fecha)
		{
			this.idDetalleVenta = idDetalleVenta;
			this.fkTarjeta = fkTarjeta;
			this.fkVenta = fkVenta;
			this.cedulaCliente = cedulaCliente;
			this.nomCliente = nomCliente;
			this.totalEfectivo = totalEfectivo;
			this.totalTarjeta = totalTarjeta;
			this.vueltas = vueltas;
			this.fecha = fecha;
		}

        public int IdDetalleVenta
        {
            get { return idDetalleVenta; }
            set { idDetalleVenta = value; }
        }

        public int FkTarjeta
        {
            get { return fkTarjeta; }
            set { fkTarjeta = value; }
        }
        public int FkVenta
        {
            get { return fkVenta; }
            set { fkVenta = value; }
        }

        public int CedulaCliente
        {
            get { return cedulaCliente; }
            set { cedulaCliente = value; }
        }

        public string NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }

        public int TotalEfectivo
        {
            get { return totalEfectivo; }
            set { totalEfectivo = value; }
        }

        public int TotalTarjeta
        {
            get { return totalTarjeta; }
            set { totalTarjeta = value; }
        }

        public int Vueltas
        {
            get { return vueltas; }
            set { vueltas = value; }
        }


        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        
		// Metodo Insertar
		public string Insertar(DetalleVenta DVenta, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
		{

			string rta = "";

			try
			{

				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.Transaction = SqlTra;
				SqlCmd.CommandText = "pa_insertar_detalle_venta";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParIdDetalleVenta = new SqlParameter();
				ParIdDetalleVenta.ParameterName = "@iddetalleventa";
				ParIdDetalleVenta.SqlDbType = SqlDbType.Int;
				ParIdDetalleVenta.Direction = ParameterDirection.Output;
				SqlCmd.Parameters.Add(ParIdDetalleVenta);

				SqlParameter ParFkTarjeta = new SqlParameter();
				ParFkTarjeta.ParameterName = "@fktarjeta";
				ParFkTarjeta.SqlDbType = SqlDbType.Int;
				ParFkTarjeta.SqlValue = DVenta.FkTarjeta;
				SqlCmd.Parameters.Add(ParFkTarjeta);

				SqlParameter ParFkVenta = new SqlParameter();
				ParFkVenta.ParameterName = "@fkventa";
				ParFkVenta.SqlDbType = SqlDbType.Int;
				ParFkVenta.SqlValue = DVenta.FkVenta;
				SqlCmd.Parameters.Add(ParFkVenta);

				SqlParameter ParCedulaCliente = new SqlParameter();
				ParCedulaCliente.ParameterName = "@cedula";
				ParCedulaCliente.SqlDbType = SqlDbType.Int;
				ParCedulaCliente.SqlValue = DVenta.CedulaCliente;
				SqlCmd.Parameters.Add(ParCedulaCliente);

				SqlParameter ParNomCliente = new SqlParameter();
				ParNomCliente.ParameterName = "@nombre";
				ParNomCliente.SqlDbType = SqlDbType.VarChar;
				ParNomCliente.Size = 30;
				ParNomCliente.SqlValue = DVenta.NomCliente;
				SqlCmd.Parameters.Add(ParNomCliente);

				SqlParameter ParTotalEfectivo = new SqlParameter();
				ParTotalEfectivo.ParameterName = "@totalefectivo";
				ParTotalEfectivo.SqlDbType = SqlDbType.Int;
				ParTotalEfectivo.SqlValue = DVenta.totalEfectivo;
				SqlCmd.Parameters.Add(ParTotalEfectivo);

				SqlParameter ParTotalTarjeta = new SqlParameter();
				ParTotalTarjeta.ParameterName = "@totaltarjeta";
				ParTotalTarjeta.SqlDbType = SqlDbType.Int;
				ParTotalTarjeta.SqlValue = DVenta.TotalTarjeta;
				SqlCmd.Parameters.Add(ParTotalTarjeta);

				SqlParameter ParVueltas = new SqlParameter();
				ParVueltas.ParameterName = "@vueltas";
				ParVueltas.SqlDbType = SqlDbType.Int;
				ParVueltas.SqlValue = DVenta.Vueltas;
				SqlCmd.Parameters.Add(ParVueltas);

				SqlParameter ParFecha = new SqlParameter();
				ParFecha.ParameterName = "@fecha";
				ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Direction = ParameterDirection.Output;
				SqlCmd.Parameters.Add(ParFecha);

				//Ejecutar el procedimiento

				rta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";


			}
			catch (Exception e)
			{

				rta = e.Message + e.StackTrace;
			}
			

			return rta;

		}

		//Metodo Mostrar
		public DataTable Mostrar()
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
