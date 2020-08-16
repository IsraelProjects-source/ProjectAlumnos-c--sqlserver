using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargaCmbCarrera();
            cargaCmbMateria();
            cargaGrid();
        }

        private void cargaCmbCarrera()
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
            //adptador.Fill(resultado);

            cmbMateria.DisplayMember = "Nom_Materia";
            cmbMateria.ValueMember = "Id_Materia";
            cmbMateria.DataSource = resultado;
        }

        private void cargaCmbMateria()
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

            cmbCarrera.DisplayMember = "Nom_Carrera";
            cmbCarrera.ValueMember = "Id_Carrera";
            cmbCarrera.DataSource = resultado;
        }


        private void cargaGrid()
        {
            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
              "Catalog=PrograWeb16;user id=;password=";

            System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Alumnos_BRM";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "T"));

            System.Data.SqlClient.SqlDataAdapter adptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adptador.Fill(resultado);
            dgvDatos.DataSource = resultado;
        }


        private void limiaTextos()
        {
            txtNoCon.Text = "";
            txtNom.Text = "";
            txtPatern.Text = "";
            TxtMatern.Text = "";
            cmbCarrera.SelectedIndex = 0;
            cmbMateria.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNoCon.Text = dgvDatos.CurrentRow.Cells["Id_Control"].Value.ToString();
            txtNom.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtPatern.Text = dgvDatos.CurrentRow.Cells["Ape_Paterno"].Value.ToString();
            TxtMatern.Text = dgvDatos.CurrentRow.Cells["Ape_Materno"].Value.ToString();

            cmbCarrera.SelectedValue = Convert.ToInt16(dgvDatos.CurrentRow.Cells["Id_Carrera"].Value.ToString());
            cmbMateria.SelectedValue = Convert.ToInt16(dgvDatos.CurrentRow.Cells["Id_Materia"].Value.ToString());

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtMatern_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatern_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
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
                comandoSQL.CommandText = "[sp_Alumnos_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@operacion", "I"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(txtNoCon.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", txtNom.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", txtPatern.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", TxtMatern.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt16(cmbCarrera.SelectedValue.ToString())));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt16(cmbMateria.SelectedValue.ToString())));

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

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Form1 frm1 = new Form1();
            frm1.Dispose();
            frm1.Close();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Form1 frm1 = new Form1();
            frm1.Dispose();
            frm1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
           "Catalog=PrograWeb16;user id=;password=";

            Int32 pintxtNoCon = Int32.Parse(txtNoCon.Text);
            try

            {

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "[sp_Alumnos_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@operacion", "D"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", pintxtNoCon));

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

        private void l(object sender, EventArgs e)
        {

        }

        private void txtNoCon_Leave(object sender, EventArgs e)
        {

            if (this.txtNoCon.Text == "")
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
                ComandoSQL.CommandText = "sp_Alumnos_BRM";
                ComandoSQL.CommandType = CommandType.StoredProcedure;

                ComandoSQL.Parameters.Add(new SqlParameter("@operacion", "L"));
                ComandoSQL.Parameters.Add(new SqlParameter("Id_Control", Convert.ToInt32(this.txtNoCon.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(ComandoSQL);

                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);

                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNom.Text = resultado.Rows[0]["Nombre"].ToString();
                    this.txtPatern.Text = resultado.Rows[0]["Ape_Paterno"].ToString();
                    this.TxtMatern.Text = resultado.Rows[0]["Ape_Materno"].ToString();
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
                comandoSQL.CommandText = "[sp_Alumnos_BRM]";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "C"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(txtNoCon.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", txtNom.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", txtPatern.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", TxtMatern.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt16(cmbCarrera.SelectedValue.ToString())));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt16(cmbMateria.SelectedValue.ToString())));

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

        private void txtPatern_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtMatern_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbMateria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cargaGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string cadena = "Data Source=tcp:fime-homework-server.database.windows.net;Initial " +
              "Catalog=PrograWeb16;user id= ;password= ";

            System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(cadena);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Alumnos_BRM";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@Operacion", "R"));

            System.Data.SqlClient.SqlDataAdapter adptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adptador.Fill(resultado);
            dgvDatos.DataSource = resultado;

        }
    }
}
