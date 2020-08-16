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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cargaGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.Show();
            //Form3 frm1 = new Form3();
            //frm1.Dispose();
            //frm1.Close();
            this.Dispose();
        }

        private void cargaGrid()
        {
            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
              "Catalog=PrograWeb16;user id=;password=";

            System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Carreras_BRM";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "T"));

            System.Data.SqlClient.SqlDataAdapter adptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adptador.Fill(resultado);
            dgvDatos.DataSource = resultado;
        }

        private void limiaTextos()
        {
            txtIdCarr.Text = "";
            txtNom.Text = "";

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtNoCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dgvDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            txtIdCarr.Text = dgvDatos.CurrentRow.Cells["Id_Carrera"].Value.ToString();
            txtNom.Text = dgvDatos.CurrentRow.Cells["Nom_Carrera"].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
              "Catalog=PrograWeb16;user id=;password=";

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "[sp_Carreras_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "I"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(txtIdCarr.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Carrera", txtNom.Text));                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();

                MessageBox.Show("Alta efectuada");
                cargaGrid();
                limiaTextos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Alta ya existente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
           "Catalog=PrograWeb16;user id=;password=";

            Int32 pintxtIdCarr = Int32.Parse(txtIdCarr.Text);
            try

            {

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "[sp_Carreras_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "D"));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", pintxtIdCarr));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();

                cargaGrid();
                limiaTextos();

                MessageBox.Show("Baja efectuada");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al dar de baja");
            }

        }

        private void txtIdCarr_Leave(object sender, EventArgs e)
        {


            if (this.txtIdCarr.Text == "")
            {

            }
            else
            {
                string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
               "Catalog=PrograWeb16;user id=;password=";

                System.Data.SqlClient.SqlConnection conexionBD = new
                System.Data.SqlClient.SqlConnection(cadena);
                System.Data.SqlClient.SqlCommand ComandoSQL = new SqlCommand();

                ComandoSQL.Connection = conexionBD;
                ComandoSQL.CommandText = "sp_Carreras_BRM";
                ComandoSQL.CommandType = CommandType.StoredProcedure;

                ComandoSQL.Parameters.Add(new SqlParameter("@Operacion", "L"));
                ComandoSQL.Parameters.Add(new SqlParameter("Id_Carrera", Convert.ToInt32(this.txtIdCarr.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(ComandoSQL);

                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);

                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNom.Text = resultado.Rows[0]["Nom_Carrera"].ToString();
                    
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
               "Catalog=PrograWeb16;user id=;password=";

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "[sp_Carreras_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "C"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(txtIdCarr.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Carrera", txtNom.Text));
                
                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();

                MessageBox.Show("Cambio Efectuado");
                cargaGrid();
                limiaTextos();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar datos");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
