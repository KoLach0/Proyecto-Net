using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_NET.Modelo
{
	class TarjetasCredito{

		private int idTarjeta;
        private string nombre;
        private int fkEstado;

        public int FkEstado
        {
            get { return fkEstado; }
            set { fkEstado = value; }
        }

        public int IdTarjeta1
        {
            get { return idTarjeta; }
            set { idTarjeta = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
		public TarjetasCredito() { }

		public TarjetasCredito(int id_tarjeta, string nombre, int estado)
		{
			this.idTarjeta = id_tarjeta;
			this.Nombre = nombre;
			this.FkEstado = estado;
		}

		//public int IdTarjeta {get => idTarjeta;set => idTarjeta = value;}
		//public string Nombre {get => nombre;set => nombre = value;}
		//public int FkEstado {get => fkEstado;set => fkEstado = value;}

		// Metodo Insertar
		public string Insertar(TarjetasCredito Tarjeta)
		{

			string rta = "";

			SqlConnection SqlCon = new SqlConnection();

			try
			{

				SqlCon.ConnectionString = Conexion.Cn;
				SqlCon.Open();

				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = SqlCon;
				SqlCmd.CommandText = "pa_insertar_tarjeta";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParIdTarjeta = new SqlParameter();
				ParIdTarjeta.ParameterName = "@idtarjeta";
				ParIdTarjeta.SqlDbType = SqlDbType.Int;
				ParIdTarjeta.Direction = ParameterDirection.Output;
				SqlCmd.Parameters.Add(ParIdTarjeta);

				SqlParameter ParNombre = new SqlParameter();
				ParNombre.ParameterName = "@nombre";
				ParNombre.SqlDbType = SqlDbType.VarChar;
				ParNombre.Size = 20;
				ParNombre.SqlValue = Tarjeta.Nombre;
				SqlCmd.Parameters.Add(ParNombre);

				
				SqlParameter ParEstado = new SqlParameter();
				ParEstado.ParameterName = "@estado";
				ParEstado.SqlDbType = SqlDbType.Int;
				ParEstado.SqlValue = Tarjeta.FkEstado;
				SqlCmd.Parameters.Add(ParEstado);

				//Ejecutar el procedimiento

				rta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";


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
        public DataTable Mostrar()
        {

            DataTable DtResultado = new DataTable("tarjetas_credito");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_mostrar_tarjetas";
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
