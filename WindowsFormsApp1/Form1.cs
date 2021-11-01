using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

        
    {
        int I = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNoControl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNomAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No. Control         " + textBox1.Text);
            MessageBox.Show("Nombre              " + txtNomAlumno.Text);
            MessageBox.Show("Apellido Paterno    " + textBox2.Text);
            MessageBox.Show("Apellido Materno    " + txtApeMaterno.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                dgvAgregar.Rows.Add(I, textBox1.Text, txtNomAlumno.Text, textBox2.Text,
                    txtApePaterno.Text, dtpFechaIngreso.Value.ToString());

                I = I + 1;
                textBox1.Text = "";
                txtNomAlumno.Text = "";
                textBox2.Text = "";
                txtApeMaterno.Text = "";
                dtpFechaIngreso.Value = System.DateTime.Today;
                textBox1.Focus();
            }
        }

        private void dgvAgregar_DoubleClick(object sender, EventArgs e)
        {
            String CON = dgvAgregar.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dgvAgregar.CurrentRow.Cells[1].Value.ToString();
            txtNomAlumno.Text = dgvAgregar.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgvAgregar.CurrentRow.Cells[3].Value.ToString();
            txtApeMaterno.Text = dgvAgregar.CurrentRow.Cells[4].Value.ToString();

            String Fecha = dgvAgregar.CurrentRow.Cells[5].Value.ToString();

            dtpFechaIngreso.Value = DateTime.Parse(Fecha);
        }
    }
}
