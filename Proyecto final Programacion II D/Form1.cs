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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable dtb = new DataTable();
            string cadena = "Select Codigo, Nombre, [Tipo de Producto], Ubicacion, Precio, Existencia, Estatus from Consulta1";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, cnn);
            adap.Fill(dtb);

            dtgvProductos.DataSource = dtb;

        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtnombreProd.Text = dtgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtTipoProd.Text = dtgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtubicacion.Text = dtgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtprecio.Text = dtgvProductos.CurrentRow.Cells[4].Value.ToString();
            txtexistenca.Text = dtgvProductos.CurrentRow.Cells[5].Value.ToString();
            cmbEstatus.Text = dtgvProductos.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string cdn = "insert into Productos values ('"+ int.Parse(txtcodigo.Text) +"', '" + txtnombreProd.Text + "' , '"+ int.Parse(txtTipoProd.Text)+ 
                "', '" + cmbEstatus.Text +"')";
            SqlCommand cmd = new SqlCommand(cdn, cnn);
            cnn.Open();
            cmd.CommandType = CommandType.Text;
            int prueb;
            prueb= cmd.ExecuteNonQuery();

            string cadn = "insert into TablaRelaciones values ('"+ int.Parse(txtcodigo.Text) + "' , '" + int.Parse(txtubicacion.Text) + "' , '" + int.Parse(txtprecio.Text) + 
                "' , '" + int.Parse(txtexistenca.Text) + "')";
            SqlCommand com = new SqlCommand(cadn, cnn);
            com.CommandType = CommandType.Text;
            int prb;
            prb = com.ExecuteNonQuery();
            if (prueb== 1 || prb== 1) 
            {
                MessageBox.Show("¡Datos Registrados!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al registrar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string cadn = "insert into TablaRelaciones values ('" + int.Parse(txtcodigo.Text) + "' , '" + int.Parse(txtubicacion.Text) + 
                "' , '" + int.Parse(txtprecio.Text) + "' , '" + int.Parse(txtexistenca.Text) + "')";
            SqlCommand com = new SqlCommand(cadn, cnn);
            cnn.Open();
            com.CommandType = CommandType.Text;
            int prb;
            prb = com.ExecuteNonQuery();
            if (prb== 1)
            {
                MessageBox.Show("¡Datos Registrados!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al registrar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string cd = "Update Productos set nombProd= '" + txtnombreProd.Text + "', tipProd= '"+ int.Parse(txtTipoProd.Text)+"', estatusProd= '"+cmbEstatus.Text +
                "' where codProd= '" + int.Parse(txtcodigo.Text)+ "'";
            SqlCommand com = new SqlCommand(cd,cnn);
            cnn.Open();
            com.CommandType = CommandType.Text;
            int verf = com.ExecuteNonQuery();

            string cad = "Update TablaRelaciones set precioProd= '"+ int.Parse(txtprecio.Text) + "' , existenciaProd= '"+ int.Parse(txtexistenca.Text)+ 
                "' where prodCod= '" + int.Parse(txtcodigo.Text)+ "' and prodUbicacion= '" + int.Parse(txtubicacion.Text)+ "'";
            SqlCommand cmd = new SqlCommand(cad, cnn);
            cmd.CommandType = CommandType.Text;
            int rev = cmd.ExecuteNonQuery();

            if (verf==1 || rev==1)
            {
                MessageBox.Show("¡Datos modificados!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            string cad = "Delete from TablaRelaciones where prodCod = '" + txtcodigo.Text+"' and prodUbicacion= '" + txtubicacion.Text+"'";
            SqlCommand com = new SqlCommand(cad, cnn);
            cnn.Open();
            int prub = com.ExecuteNonQuery();
            if (prub==1)
            {
                MessageBox.Show("¡Datos Eliminados!","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Error al eliminar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Proyecto programacion II D; Integrated Security= True");
            DataTable dtb = new DataTable();
            string cadena = "Select Codigo, Nombre, [Tipo de Producto], Ubicacion, Precio, Existencia, Estatus from Consulta1 where Nombre like'%"+ 
                this.txtNombreBusc.Text + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(cadena, cnn);
            adap.Fill(dtb);

            dtgvProductos.DataSource = dtb;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtnombreProd.Text = "";
            txtTipoProd.Text = "";
            txtubicacion.Text = "";
            txtprecio.Text = "";
            txtexistenca.Text = "";
            cmbEstatus.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
