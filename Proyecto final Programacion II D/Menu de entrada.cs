using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_Programacion_II_D
{
    public partial class Menu_de_entrada : Form
    {
        public Menu_de_entrada()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cli = new FrmCliente();
            cli.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 prod = new Form1();
            prod.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sulpidores.Form1 supli = new Sulpidores.Form1();
            supli.Show();
        }

        private void Menu_de_entrada_Load(object sender, EventArgs e)
        {

        }
    }
}
