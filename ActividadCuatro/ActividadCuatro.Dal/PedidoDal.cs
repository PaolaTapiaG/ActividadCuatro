using ActividadCuatro.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCuatro.Dal
{
    public class PedidoDal
    {
        public DataTable ListarPedidoDal()
        {
            string consulta = " select * from pedido";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPedidoDal(Pedido pedido)
        {
            string consulta = "insert into pedido values(" + pedido.IdCliente + " ," +
                                                           "'" + pedido.Fecha + "'," +
                                                           "" + pedido.Total + "," +
                                                           "'" + pedido.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        public Pedido ObtenerPedidoId(int id)
        {
            string consulta = "select * from pedido where idpedido=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Pedido p = new Pedido();
            if (tabla.Rows.Count > 0)
            {
                p.IdPedido = Convert.ToInt32(tabla.Rows[0]["idpedido"]);
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                p.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                p.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }
        public void EditarPedidoDal(Pedido p)
        {
            string consulta = "update pedido set idcliente=" + p.IdCliente + "," +
                                                 "fecha='" + p.Fecha + "'," +
                                                 "total=" + p.Total + "," +
                                                 "estado='" + p.Estado + "'" +
                               "where idpedido=" + p.IdPedido;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPedidoDal(int id)
        {
            string consulta = "delete from pedido where idpedido=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
