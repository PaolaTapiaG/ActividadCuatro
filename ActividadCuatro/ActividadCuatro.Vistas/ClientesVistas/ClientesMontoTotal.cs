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
    public partial class ClientesMontoTotal : Form
    {
        public ClientesMontoTotal(int id)
        {
            idx = id;
            InitializeComponent();
        }
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();

        private void ClientesMontoTotal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosTBss(idx);
        }
    }
}
