using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioprueba4
{
    public partial class Form2 : Form
    { 
        ConexionBD con = new ConexionBD();
        public Form2()
        {
            InitializeComponent();
            con.actualizar(dataGridView2);
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            con.MostrarAlumno(tbcodigo.Text, dataGridView2);
        }

        private void btn_Promcurso_Click(object sender, EventArgs e)
        {
            con.promCodNota(tbcodigo.Text, int.Parse(tbposnota.Text), dataGridView2);
        }

        private void btn_Reprovados_Click(object sender, EventArgs e)
        {
            con.Examen(dataGridView2);
        }

        private void btn_Aprobados_Click(object sender, EventArgs e)
        {
            con.Aprobados(dataGridView2);
        }

        private void btn_Danexamen_Click(object sender, EventArgs e)
        {
            con.Examen(dataGridView2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

