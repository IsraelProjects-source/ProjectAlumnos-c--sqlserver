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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cargaGrid();
        }

        private void cargaGrid()
        {
            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
              "Catalog=PrograWeb16;user id=;password=";

            System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Materias_BRM";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "T"));

            System.Data.SqlClient.SqlDataAdapter adptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adptador.Fill(resultado);
            dgvDatos.DataSource = resultado;
        }

        private void limiaTextos()
        {
            txtIdMat.Text = "";
            txtNom.Text = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            //frm.Show();
            //Form2 frm1 = new Form2();
            //frm1.Dispose();
            this.Dispose();
            //frm1.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {

            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
          "Catalog=PrograWeb16;user id=;password=";

            Int32 pintxtIdMat = Int32.Parse(txtIdMat.Text);
            try

            {

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "[sp_Materias_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "D"));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", pintxtIdMat));

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

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIdMat.Text = dgvDatos.CurrentRow.Cells["Id_Materia"].Value.ToString();
            txtNom.Text = dgvDatos.CurrentRow.Cells["Nom_Materia"].Value.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
                comandoSQL.CommandText = "[sp_Materias_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "I"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(txtIdMat.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Materia", txtNom.Text));
                conexionBD.Open();
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

        private void txtIdMat_Leave(object sender, EventArgs e)
        {
            if (this.txtIdMat.Text == "")
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
                ComandoSQL.CommandText = "sp_Materias_BRM";
                ComandoSQL.CommandType = CommandType.StoredProcedure;

                ComandoSQL.Parameters.Add(new SqlParameter("@Operacion", "L"));
                ComandoSQL.Parameters.Add(new SqlParameter("Id_Materia", Convert.ToInt32(this.txtIdMat.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(ComandoSQL);

                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);

                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNom.Text = resultado.Rows[0]["Nom_Materia"].ToString();
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
                comandoSQL.CommandText = "[sp_Materias_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "C"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(txtIdMat.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Materia", txtNom.Text));

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
    }
}
