using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ejercicioprueba4
{
    public partial class Form1 : Form
    {
        ConexionBD con = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
            con.actualizar(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.ValidarRut(tbrut.Text + "-" + tbDV.Text) == 1)
            {
                MessageBox.Show(con.insertar(tbcode.Text, tbrut.Text + "-" + tbDV.Text, tbName.Text, tbpaterno.Text, tbmaterno.Text, float.Parse(tbnota1.Text), float.Parse(tbnota2.Text), float.Parse(tbnota3.Text), float.Parse(tbnota4.Text), int.Parse(tbtotalNotas.Text)));
                con.actualizar(dataGridView1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (con.ValidarRut(tbrut.Text + "-" + tbDV.Text) == 1)
            {
                MessageBox.Show(con.modificar(tbcode.Text, tbrut.Text + "-" + tbDV.Text, tbName.Text, tbpaterno.Text, tbmaterno.Text, float.Parse(tbnota1.Text), float.Parse(tbnota2.Text), float.Parse(tbnota3.Text), float.Parse(tbnota4.Text), int.Parse(tbtotalNotas.Text)));
                con.actualizar(dataGridView1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.eliminar(tbcode.Text));
            con.actualizar(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 buscaalumno = new Form2();
            buscaalumno.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}