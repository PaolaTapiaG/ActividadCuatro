using ActividadCuatro.Bss;
using ActividadCuatro.Modelos;
using ActividadCuatro.Vistas.ClientesVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadCuatro.Vistas.PedidosVistas
{
    public partial class InsertarPedidosVista : Form
    {
        public InsertarPedidosVista()
        {
            InitializeComponent();
        }
        PedidoBss bssp = new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = IdClienteSeleccionada;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bssp.InsertarPedidoBss(pedido);
            MessageBox.Show("Usuario registrado");
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bss = new ClienteBss();
        

        private void button3_Click_1(object sender, EventArgs e)
        {

            ClientesListarVistas fr = new ClientesListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerClienteIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }
    }
}
