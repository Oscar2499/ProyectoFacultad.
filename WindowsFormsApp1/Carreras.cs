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
    public partial class Carreras : Form
    {
        private string _Servidor = "DESKTOP-MB5FMEK";
        private string _BD = "PrograWeb";
        private string _sCadenaConexion = string.Empty;

        public Carreras()
        {
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            CargaGrid();
        }

        private void Limpiatextos()
        {
            txtNoCarrera.Text = "";
            txtNombreCarrera.Text = "";

        }

        private void CargaGrid()
        {

            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
            System.Data.SqlClient.SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "Sp_Carreras";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "T"));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            dgVDatosCa.DataSource = resultado;
               
        }

        private void txtNoCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNombreCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void txtNoCarrera_Leave(object sender, EventArgs e)
        {
            if (this.txtNoCarrera.Text == "")
            {

            }
            else
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
                System.Data.SqlClient.SqlConnection conexionDB = new
                System.Data.SqlClient.SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionDB;
                comandoSQL.CommandText = "Sp_Carreras";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "L"));
                comandoSQL.Parameters.Add(new SqlParameter("Id_Carrera", Convert.ToInt32(this.txtNoCarrera.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNombreCarrera.Text = resultado.Rows[0]["Nom_Carrera"].ToString();
                }


            }
            
        }

        private void txtNoCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            try
            {

                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Carreras";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'I'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(txtNoCarrera.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Carrera", txtNombreCarrera.Text));

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

        private void btnBajas_Click(object sender, EventArgs e)
        {
            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=" + _BD + ";Integrated Security=True";

            Int32 pinControl = pinControl = Int32.Parse(txtNoCarrera.Text);
            try
            {
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Carreras";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'D'));

                comandoSQL.Parameters.Add(new SqlParameter("Id_Carrera", pinControl));
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

        private void btnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=" + _BD + ";Integrated Security=True";

                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandosql = new SqlCommand();

                comandosql.Connection = conexionBD;
                comandosql.CommandText = "Sp_Carreras";
                comandosql.CommandType = CommandType.StoredProcedure;
                comandosql.Parameters.Add(new SqlParameter("@OPERACION", 'C'));

                comandosql.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(txtNoCarrera.Text)));
                comandosql.Parameters.Add(new SqlParameter("@Nom_Carrera", txtNombreCarrera.Text));

                conexionBD.Open();
                comandosql.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();

                MessageBox.Show("Cambio Efectuado");
                Limpiatextos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("El cambio ya Existe" + ex);
            }

        }

        private void dgVDatosCa_DoubleClick(object sender, EventArgs e)
        {
            txtNoCarrera.Text = dgVDatosCa.CurrentRow.Cells["Id_Carrera"].Value.ToString();
            txtNombreCarrera.Text = dgVDatosCa.CurrentRow.Cells["Nom_Carrera"].Value.ToString();
        }
    }
}
