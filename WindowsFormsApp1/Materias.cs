using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Materias : Form
    {
        private string _Servidor = "DESKTOP-MB5FMEK";
        private string _BD = "PrograWeb";
        private string _sCadenaConexion = string.Empty;
        public Materias()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomDMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnAltas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnBajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnCambios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void TxtNoMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void BtnSalir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            CargaGrid();
        }

        private void Limpiatextos()
        {
            TxtNoMateria.Text = "";
            TxtNomDMateria.Text = "";

        }
        private void CargaGrid()
        {

            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
            System.Data.SqlClient.SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "Sp_Materias";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "T"));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            DgvMaterias.DataSource = resultado;

        }

        private void TxtNoMateria_Leave(object sender, EventArgs e)
        {
            if(this.TxtNoMateria.Text == "")
            {

            }
            else
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=" + _BD + ";Integrated Security=True";
                System.Data.SqlClient.SqlConnection conexionBD = new
                System.Data.SqlClient.SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Materias";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "L"));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt32(this.TxtNoMateria.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if(resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.TxtNomDMateria.Text = resultado.Rows[0]["Nom_Materia"].ToString();
                }
            }
        }

        private void BtnAltas_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Materias";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "I"));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(this.TxtNoMateria.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Materia", this.TxtNomDMateria.Text));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                MessageBox.Show("Alta Efectuada");
                Limpiatextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alta ya existe");
            }
        }

        private void BtnBajas_Click(object sender, EventArgs e)
        {
            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";

            Int32 pinControl = pinControl = Int32.Parse(TxtNoMateria.Text);
            try
            {
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Materias";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "D"));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", pinControl));
                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                Limpiatextos();
                MessageBox.Show("Baja Efectuada");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de Baja los datos" + ex);
            }
        }

        private void DgvMaterias_DoubleClick(object sender, EventArgs e)
        {
            TxtNoMateria.Text = DgvMaterias.CurrentRow.Cells["Id_Materia"].Value.ToString();
            TxtNomDMateria.Text = DgvMaterias.CurrentRow.Cells["Nom_Materia"].Value.ToString();
        }

        private void BtnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=" + _BD + ";Integrated Security=True";

                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandosql = new SqlCommand();

                comandosql.Connection = conexionBD;
                comandosql.CommandText = "Sp_Materias";
                comandosql.CommandType = CommandType.StoredProcedure;
                comandosql.Parameters.Add(new SqlParameter("@OPERACION", 'C'));

                comandosql.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(TxtNoMateria.Text)));
                comandosql.Parameters.Add(new SqlParameter("@Nom_Materia", TxtNomDMateria.Text));

                conexionBD.Open();
                comandosql.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();

                MessageBox.Show("Cambio Efectuado");
                Limpiatextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Cambio Ya existe" + ex);
            }
        }
    }
}
