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

namespace Sulpidores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dtgvSuplidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigosupl.Text = dtgvSuplidores.CurrentRow.Cells[0].Value.ToString();
            txtnombrecomp.Text = dtgvSuplidores.CurrentRow.Cells[1].Value.ToString();
            txtnombconta.Text = dtgvSuplidores.CurrentRow.Cells[2].Value.ToString();
            txtcargocont.Text = dtgvSuplidores.CurrentRow.Cells[3].Value.ToString();
            txtprovincia.Text = dtgvSuplidores.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dtgvSuplidores.CurrentRow.Cells[5].Value.ToString();
            txttelefono.Text = dtgvSuplidores.CurrentRow.Cells[6].Value.ToString();
           txtCodigopostal.Text = dtgvSuplidores.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnBuscarSupli_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable dtb = new DataTable();
            string cadena = "Select codSuplidores, NombreCompania, NombreContacto, CargoContacto, Provincia, Dirrecion,Tel, CPostal from Suplidores1 where Nombrecompania like'%" + this.txtNombreBuscSupl.Text + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, cnn);
            adap.Fill(dtb);

            dtgvSuplidores.DataSource = dtb;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string SqlLoad = "Insert into Suplidores1 values ('" + int.Parse(txtcodigosupl.Text) + "','" + txtnombrecomp.Text + "','" + txtnombconta.Text + "','" + txtcargocont.Text + "','" + txtprovincia.Text + "','" + txtDireccion.Text + "','" + txttelefono.Text + "','" + txtCodigopostal.Text + "' )";
            SqlCommand cmd = new SqlCommand(SqlLoad, connection);
            connection.Open();
            cmd.CommandType = CommandType.Text;
            int prb;
            prb = cmd.ExecuteNonQuery();
            if (prb == 1)
            {
                MessageBox.Show("¡Datos Agregados correctamente !", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al Agregar los datos!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string SqlLoad = "Update Suplidores1 set  NombreCompania= '" + txtnombrecomp.Text + "', NombreContacto= '" + txtnombconta.Text + "', CargoContacto= '" + txtcargocont.Text + "', Provincia = '" + txtprovincia.Text + "', Dirrecion= '" + txtDireccion.Text + "', Tel= '" + txttelefono.Text + "', CPostal='" + int.Parse (txtcodigosupl.Text) + "' where  codSuplidores= '" + int.Parse(txtcodigosupl.Text) + "'";
            SqlCommand cmd = new SqlCommand(SqlLoad, connection); 
            connection.Open();
            cmd.CommandType = CommandType.Text;
            int mdf;
            mdf = cmd.ExecuteNonQuery();
            if (mdf == 1)
            {
                MessageBox.Show("¡Los Datos Han sido modificados !", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al  Modificar Revise los datos!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string cad = "Delete from Suplidores1 where codSuplidores = '" + txtcodigosupl.Text + "'";
            SqlCommand com = new SqlCommand(cad, cnn);
            cnn.Open();
            int prub = com.ExecuteNonQuery();
            if (prub == 1)
            {
                MessageBox.Show("¡Datos Eliminados!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al eliminar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnombrecomp.Text = "";
            txtnombconta.Text = "";
            txtcargocont.Text = "";
            txtprovincia.Text = "";
            txtDireccion.Text = "";
            txttelefono.Text = "";
            txtCodigopostal.Text = "";
            txtNombreBuscSupl.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable dtb = new DataTable();
            string cadena = "Select codSuplidores, NombreCompania, NombreContacto, CargoContacto, Provincia, Dirrecion,Tel, CPostal from Suplidores1";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, cnn);
            adap.Fill(dtb);

            dtgvSuplidores.DataSource = dtb;
        }
    }
}
