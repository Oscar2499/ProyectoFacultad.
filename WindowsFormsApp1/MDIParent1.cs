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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void eJEMPLOPRUEBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carreras xcarreras = new Carreras();
            xcarreras.MdiParent = this;
            xcarreras.Show();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ProgPrueba = new Form1();
            ProgPrueba.MdiParent = this;
            ProgPrueba.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias XMATERIAS = new Materias();
            XMATERIAS.MdiParent = this;
            XMATERIAS.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos xAlumnos = new Alumnos();
            xAlumnos.MdiParent = this;
            xAlumnos.Show();
        }
    }
}
