using Proyecto_NET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_NET.Controlador
{
    class InventarioController{

        public static string Insertar(int fk_producto, int cantidad){

            Inventario Inv = new Inventario();
            Inv.FkProducto = fk_producto;
            Inv.Cantidad = cantidad;

            return Inv.Insertar(Inv);
        }

    }
}
