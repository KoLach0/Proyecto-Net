using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Modelo
{
    class Inventario{

        private int idInventario;
        private int fkProducto;
        private int cantidad;


        public Inventario() { }

        public Inventario(int id_inventario, int fk_producto, int cantidad) {
            this.idInventario = id_inventario;
            this.fkProducto = fk_producto;
            this.cantidad = cantidad;
        }

        public int IdInventario
        {
            get { return idInventario; }
            set { idInventario = value; }
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


        // Metodo Insertar
        public string Insertar(Inventario Inventario)
        {

            string rta = "";

            SqlConnection SqlCon = new SqlConnection();

            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_insertar_inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdInventario = new SqlParameter();
                ParIdInventario.ParameterName = "@idinventario";
                ParIdInventario.SqlDbType = SqlDbType.Int;
                ParIdInventario.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdInventario);

                SqlParameter ParFkProducto = new SqlParameter();
                ParFkProducto.ParameterName = "@fkproducto";
                ParFkProducto.SqlDbType = SqlDbType.Int;
                ParFkProducto.SqlValue = Inventario.FkProducto;
                SqlCmd.Parameters.Add(ParFkProducto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.SqlValue = Inventario.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

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
    }
}
