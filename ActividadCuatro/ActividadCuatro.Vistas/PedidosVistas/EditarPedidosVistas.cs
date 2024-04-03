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

namespace ActividadCuatro.Vistas.PedidosVistas
{

    public partial class EditarPedidosVistas : Form
    {
        int idx = 0;
        Pedido p = new Pedido();
        PedidoBss bss = new PedidoBss();
        public EditarPedidosVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarPedidosVistas_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerPIdBss(idx);
            dateTimePicker1.Value = p.Fecha;
            textBox2.Text = p.Total.ToString();
            textBox1.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            p.Estado = textBox1.Text;
            bss.EditarPedidoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
