using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_Programacion_II_D
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable Dt = new DataTable();
            string SqlLoad = "Select IdCli, Nombre_Cli, Apellido_Cli, Sexo_Cli, Estatus, Documento_Cli, Telefono_Cli, Email_Cli, Direcion_Cli from Cliente";
            SqlDataAdapter Dat = new SqlDataAdapter(SqlLoad, connection);
            Dat.Fill(Dt);

            DgvClientes.DataSource = Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdCli.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text = DgvClientes.CurrentRow.Cells[1].Value.ToString();
            TxtApellido.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
            cmbSexo.Text = DgvClientes.CurrentRow.Cells[3].Value.ToString();
            cmbEstatus.Text = DgvClientes.CurrentRow.Cells[4].Value.ToString();
            TxtDocumento.Text = DgvClientes.CurrentRow.Cells[5].Value.ToString();
            TxtTelefono.Text = DgvClientes.CurrentRow.Cells[6].Value.ToString();
            TxtEmail.Text = DgvClientes.CurrentRow.Cells[7].Value.ToString();
            TxtDireccion.Text = DgvClientes.CurrentRow.Cells[8].Value.ToString();
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string SqlLoad = "Insert into Cliente values ('" + int.Parse(TxtIdCli.Text) + "','" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + cmbSexo.Text + "','" + cmbEstatus.Text + "','" + TxtDocumento.Text + "','" + TxtTelefono.Text + "','" + TxtEmail.Text + "','" + TxtDireccion.Text + "' )";
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
       
        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void bntModificar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string SqlLoad = "Update Cliente set  Nombre_Cli= '"+ TxtNombre.Text+ "', Apellido_Cli= '"+ TxtApellido.Text +"', Sexo_Cli= '"+ cmbSexo.Text + "', Estatus= '" + cmbEstatus.Text + "', Documento_Cli= '" +TxtDocumento.Text + "', Telefono_Cli= '" + TxtTelefono.Text + "', Email_Cli='" + TxtEmail.Text + "' , Direcion_Cli='" + TxtDireccion.Text + "' where  IdCli= '" + int.Parse(TxtIdCli.Text) + "'";
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

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtIdCli.Text = "";
            TxtApellido.Text = "";
            cmbSexo.Text = "";
            cmbEstatus.Text = "";
            TxtDocumento.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            TxtBuscar.Text = "";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable Dt = new DataTable();
            string SqlLoad = "Select IdCli, Nombre_Cli, Apellido_Cli, Sexo_Cli, Estatus, Documento_Cli, Telefono_Cli, Email_Cli, Direcion_Cli from Cliente where Nombre_Cli like'%" + this.TxtBuscar.Text + "%'";
            SqlDataAdapter Dat4 = new SqlDataAdapter(SqlLoad, connection);
            Dat4.Fill(Dt);

            DgvClientes.DataSource = Dt; 
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string SqlLoad = "Delete from Cliente where  IdCli = '" + TxtIdCli.Text + "'";
            SqlCommand cmd = new SqlCommand(SqlLoad, connection);
            connection.Open();
            cmd.CommandType = CommandType.Text;
            int elm;
            elm = cmd.ExecuteNonQuery();
            if (elm == 1)
            {
                MessageBox.Show("¡los Datos se han Eliminado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al Eliminar los datos!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
