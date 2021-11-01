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
    public partial class Alumnos : Form
    {
        private int pEstadocivil;
        private int pCveSexo;
        private string _Servidor = "DESKTOP-MB5FMEK";
        private string _BD = "PrograWeb";
        private string _sCadenaConexion = string.Empty;

        public Alumnos()
        {
            InitializeComponent();
        }

        private void txtNoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Limpiatextos()
        {
            txtNoControl.Text = "";
            txtNombre.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            dtpFecha.Value = DateTime.Today;
            this.optSoltero.Checked = false;
            this.optCasado.Checked = false;
            this.optDivorciado.Checked = false;
            this.optUnionLibre.Checked = false;
            this.optMasculino.Checked = false;
            this.optFemenino.Checked = false;

            CargaComboCarreras();
            CargaComboMaterias();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApePaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApeMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void optSoltero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void optCasado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void optDivorciado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void optUnionLibre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void optMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void optFemenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void CobCarreras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Cobmaterias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnAltas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnBajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnCambios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSalir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            CargaGrid();
            CargaComboCarreras();
            CargaComboMaterias();
        }

        private void CargaGrid()
        {
            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
            System.Data.SqlClient.SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "Sp_Alumnos";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "T"));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            dgvAlumnos.DataSource = resultado;
        }
        private void CargaComboCarreras()
        {
            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
            System.Data.SqlClient.SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Carreras";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            CobCarreras.DisplayMember = "Nom_Carrera";
            CobCarreras.ValueMember = "Id_Carrera";
            CobCarreras.DataSource = resultado;
        }

        private void CargaComboMaterias()
        {
            _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
            System.Data.SqlClient.SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Materias";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            Cobmaterias.DisplayMember = "Nom_Materia";
            Cobmaterias.ValueMember = "Id_Materia";
            Cobmaterias.DataSource = resultado;
        }

        private void txtNoControl_Leave(object sender, EventArgs e)
        {
            if(this.txtNoControl.Text == "")
            {

            }
            else
            {
                _sCadenaConexion = "Data Source =" + _Servidor + ";Initial Catalog=" + _BD + ";Integrated Security=True";


                System.Data.SqlClient.SqlConnection conexionBD = new 
                System.Data.SqlClient.SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "L"));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt32(this.txtNoControl.Text)));
                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNombre.Text = resultado.Rows[0]["Nombre"].ToString();
                    this.txtApePaterno.Text = resultado.Rows[0]["Ape_Paterno"].ToString();
                    this.txtApeMaterno.Text = resultado.Rows[0]["Ape_Materno"].ToString();
                    this.dtpFecha.Value = Convert.ToDateTime(resultado.Rows[0]["Fecha_ing"].ToString());
                    pEstadocivil = 0;
                    pEstadocivil = Convert.ToInt32(resultado.Rows[0]["Estado_Civil"].ToString());
                    if(pEstadocivil ==1)
                    {
                        this.optSoltero.Checked = true;
                    }
                    if (pEstadocivil == 2)
                    {
                        this.optCasado.Checked = true;
                    }
                    if (pEstadocivil == 3)
                    {
                        this.optDivorciado.Checked = true;
                    }
                    if (pEstadocivil == 4)
                    {
                        this.optUnionLibre.Checked = true;
                    }
                    pCveSexo = 0;
                    pCveSexo = Convert.ToInt32(resultado.Rows[0]["Sexo_Alu"].ToString());
                    if (pCveSexo ==1)
                    {
                        this.optMasculino.Checked = true;
                    }
                    if (pCveSexo == 2)
                    {
                        this.optFemenino.Checked = true;
                    }

                    CobCarreras.SelectedValue = Convert.ToInt32(resultado.Rows[0]["Id_Carrera"].ToString());
                    Cobmaterias.SelectedValue = Convert.ToInt32(resultado.Rows[0]["Id_Materia"].ToString());

                }
            }
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            try
            {

                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                pEstadocivil = 0;
                if(this.optSoltero.Checked == true)
                {
                    pEstadocivil = 1;
                }
                if(this.optCasado.Checked == true)
                {
                    pEstadocivil = 2;
                }
                if(this.optDivorciado.Checked == true)
                {
                    pEstadocivil = 3;
                }
                if (this.optUnionLibre.Checked == true)
                {
                    pEstadocivil = 4;
                }

                pCveSexo = 0;

                if (this.optMasculino.Checked == true)
                {
                    pCveSexo = 1;
                }
                if (this.optFemenino.Checked == true)
                {
                    pCveSexo = 2;
                }
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'I'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(this.txtNoControl.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", this.txtNombre.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", this.txtApePaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", this.txtApeMaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Fecha_ing", Convert.ToDateTime(dtpFecha.Value)));

                comandoSQL.Parameters.Add(new SqlParameter("@Estado_Civil", pEstadocivil));
                comandoSQL.Parameters.Add(new SqlParameter("@Sexo_Alu", pCveSexo));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(CobCarreras.SelectedValue)));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(Cobmaterias.SelectedValue)));

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
            try
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'D'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(this.txtNoControl.Text)));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                MessageBox.Show("Baja Efectuada");

                Limpiatextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baja ya existe");
            }
        }

        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            this.txtNoControl.Text = dgvAlumnos.CurrentRow.Cells["Id_Control"].Value.ToString();
            this.txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtApePaterno.Text = dgvAlumnos.CurrentRow.Cells["Ape_Paterno"].Value.ToString();
            this.txtApeMaterno.Text = dgvAlumnos.CurrentRow.Cells["Ape_Materno"].Value.ToString();
            this.dtpFecha.Value = Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells["Fecha_ing"].Value.ToString());
            pEstadocivil = 0;
            pEstadocivil = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Estado_Civil"].Value.ToString());
            if (pEstadocivil ==1)
            {
                this.optSoltero.Checked = true;
            }
            if (pEstadocivil == 2)
            {
                this.optCasado.Checked = true;
            }
            if (pEstadocivil == 3)
            {
                this.optDivorciado.Checked = true;
            }
            if (pEstadocivil == 4)
            {
                this.optUnionLibre.Checked = true;
            }

            pCveSexo = 0;
            pCveSexo = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Sexo_Alu"].Value.ToString());
            if (pCveSexo == 1)
            {
                this.optMasculino.Checked = true;
            }
            if (pCveSexo == 2)
            {
                this.optFemenino.Checked = true;
            }
            CobCarreras.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Id_Carrera"].Value.ToString());
            Cobmaterias.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Id_Materia"].Value.ToString());
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source = " + _Servidor + ";Initial Catalog=PrograWeb;user id=PrograWeb20;password=PrograWeb20";
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                pEstadocivil = 0;
                if (this.optSoltero.Checked == true)
                {
                    pEstadocivil = 1;
                }
                if (this.optCasado.Checked == true)
                {
                    pEstadocivil = 2;
                }
                if (this.optDivorciado.Checked == true)
                {
                    pEstadocivil = 3;
                }
                if (this.optUnionLibre.Checked == true)
                {
                    pEstadocivil = 4;
                }

                pCveSexo = 0;
                if (this.optMasculino.Checked == true)
                {
                    pCveSexo = 1;
                }
                if (this.optFemenino.Checked == true)
                {
                    pCveSexo = 2;
                }
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'C'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(this.txtNoControl.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", this.txtNombre.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", this.txtApePaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", this.txtApeMaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Fecha_ing", Convert.ToDateTime(dtpFecha.Value)));

                comandoSQL.Parameters.Add(new SqlParameter("@Estado_Civil", pEstadocivil));
                comandoSQL.Parameters.Add(new SqlParameter("@Sexo_Alu", pCveSexo));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(CobCarreras.SelectedValue)));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(Cobmaterias.SelectedValue)));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                MessageBox.Show("Cambio Efectuado");
                Limpiatextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cambio ya existe");
            }
        }
    }
}
