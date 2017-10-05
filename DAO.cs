using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bandasCrud.Models
{
	public class DAO
	{
		private Conexion c;
		

		public DAO() {

			c = new Conexion();
		}

		private void Ejecutar(string sql) {
			string rta;
			try{
				c.sqlCon.Open();

				c.sqlCmd = new SqlCommand(sql, c.sqlCon);
				c.sqlCmd.ExecuteNonQuery();


			}
			catch (Exception ex)
			{

				rta = ex.Message;
			}
			finally {
				c.sqlCon.Close();
			}
		}

		public void Insertar(Banda banda) {

			string sql = "INSERT INTO banda VALUES ('"+banda.Codigo+"','"+banda.Nombre+"','"+banda.Estilo+"')";
			Ejecutar(sql);
		}

		public void Actualizar(Banda banda) {

			string sql = "UPDATE banda SET	nombre ='"+banda.Nombre+"', estilo='"+banda.Estilo+"' where codigo = '"+banda.Codigo+"' ";
			Ejecutar(sql);
		}

		public void Eliminar(int codigo) {

			string sql = "DELETE FROM banda WHERE = '" + codigo + "' ";
			Ejecutar(sql);
		}

		public Banda BuscarId(int codigo) {
			string rta;
			Banda banda = null;

			try{
				c.sqlCon.Open();
				string sql = "SELECT * FROM	banda WHERE codigo = '" + codigo + "' ";
				c.sqlCmd = new SqlCommand(sql, c.sqlCon);
				c.sqlDr = c.sqlCmd.ExecuteReader();

				/*Si son varios registros "While" si no  "if" */

				if (c.sqlDr.Read()){
					banda = new Banda();
					banda.Codigo = Convert.ToInt32(c.sqlDr[0]);
					banda.Nombre = c.sqlDr[1].ToString();
					banda.Estilo = c.sqlDr[2].ToString();

				}
				return banda;

			}
			catch (Exception ex)
			{
				rta = ex.Message;
				return null;
			}
			finally {
				c.sqlCon.Close();
			}

		}

	}
}