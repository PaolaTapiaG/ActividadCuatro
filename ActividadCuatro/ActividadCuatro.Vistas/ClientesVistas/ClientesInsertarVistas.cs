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
    public partial class ClientesInsertarVistas : Form
    {
        public ClientesInsertarVistas()
        {
            InitializeComponent();
        }
        ClienteBss clientebss = new ClienteBss();
        private void ClientesInsertarVistas_Load(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.Correo = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;
            clientebss.InsertarClienteBss(cliente);
            MessageBox.Show("Se guardó exitosamente al cliente :)");




        }
    }
}
