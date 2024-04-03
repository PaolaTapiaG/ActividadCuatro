using ActividadCuatro.Bss;
using ActividadCuatro.Modelos;
using ActividadCuatro.Vistas.ClientesVistas;
using ActividadCuatro.Vistas.PedidosVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadCuatro.Vistas.PedidosVistas
{
    public partial class ListarPedidosVista : Form
    {
        public ListarPedidosVista()
        {
            InitializeComponent();
        }
        PedidoBss pedidobss = new PedidoBss();
        private void ListarPedidosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pedidobss.ListarPedidoBss();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            InsertarPedidosVista fr = new InsertarPedidosVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidobss.ListarPedidoBss();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarPedidosVistas fr = new EditarPedidosVistas(IdPedidoSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = pedidobss.ListarPedidoBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este pedido", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                pedidobss.EliminarPedidoBss(IdPedidoSeleccionada);
                dataGridView1.DataSource = pedidobss.ListarPedidoBss();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
   
        }
    }
}
