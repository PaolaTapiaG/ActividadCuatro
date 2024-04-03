using ActividadCuatro.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadCuatro.Modelos;

namespace ActividadCuatro.Dal
{
    public class ClienteDal
    {
        Cliente cliente = new Cliente();
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from CLIENTES";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into CLIENTES values('" + cliente.Nombre + "'," +
                                                         "'" + cliente.Apellido + "'," +
                                                         "'" + cliente.Correo + "'," +
                                                         "'" + cliente.Telefono + "'," +
                                                         "'" + cliente.Direccion + "')";
            conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from CLIENTES where IDCLIENTE=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "cliente");
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                cliente.Apellido = tabla.Rows[0]["apellido"].ToString();
                cliente.Correo = tabla.Rows[0]["correo"].ToString();
                cliente.Telefono = tabla.Rows[0]["telefono"].ToString();
                cliente.Direccion = tabla.Rows[0]["direccion"].ToString();
            }
            return cliente;
        }
        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "update CLIENTES set nombre='" + cliente.Nombre + "'," +
                                                        "apellido='" + cliente.Apellido + "'," +
                                                        "correo='" + cliente.Correo + "'," +
                                                        "telefono='" + cliente.Telefono + "'," +
                                                        "direccion='" + cliente.Direccion + "'" +
                                                "where idcliente=" + cliente.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from CLIENTES where IDCLIENTE=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable ClienteDatosTDal(int id)
        {
            string consulta = " SELECT COUNT(*) AS TotalPedidos FROM PEDIDO WHERE IDCLIENTE = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
        public DataTable ClienteDatosLDal(int id)
        {
            string consulta = " SELECT * FROM PEDIDO WHERE IDCLIENTE = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
