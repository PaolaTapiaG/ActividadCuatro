using ActividadCuatro.Dal;
using ActividadCuatro.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCuatro.Bss
{
    public class PedidoBss
    {
        PedidoDal dal = new PedidoDal();
        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidoDal();
        }
        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public Pedido ObtenerPIdBss(int id)
        {
            return dal.ObtenerPedidoId(id);
        }
        public void EditarPedidoBss(Pedido p)
        {
            dal.EditarPedidoDal(p);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}
