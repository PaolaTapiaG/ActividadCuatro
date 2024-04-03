using ActividadCuatro.Bss;
using ActividadCuatro.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadCuatro.Vistas.ClientesVistas
{
    public partial class ClientesEditarVistas : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss clientebss = new ClienteBss();
        public ClientesEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.Correo = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;

            clientebss.EditarClienteBss(cliente);
            MessageBox.Show("Los datos del cliente estan actualizados ;)");
        }

        private void ClientesEditarVistas_Load(object sender, EventArgs e)
        {
            cliente = clientebss.ObtenerClienteIdBss(idx);
            textBox1.Text = cliente.Nombre;
            textBox2.Text = cliente.Apellido;
            textBox3.Text = cliente.Correo;
            textBox4.Text = cliente.Telefono;
            textBox5.Text = cliente.Direccion;
        }
    }
}
