using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuplidoresPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-NERHMGU\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable dtb = new DataTable();
            string cadena = "Select codSuplidores, NombreCompania, NombreContacto, CargoContacto, Provincia, Dirrecion,Tel, CPostal from Suplidores1";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, cnn);
            adap.Fill(dtb);

            dataGridView1.DataSource = dtb;
        }
    }
}
