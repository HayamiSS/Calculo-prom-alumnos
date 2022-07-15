using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace ejercicioprueba4
{
    class ConexionBD
    {
        SqlConnection con;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        DataTable tabla;
        DataGridView dgw;

        public ConexionBD()
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\BDD61\\INSTITUTOSECCION61.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                MessageBox.Show("Conectado!!!");

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se conecto con la base de datos !" + EX.ToString());
            }
        }
        public void actualizar(DataGridView dgw)
        {

            tabla = new DataTable();
            adaptador = new SqlDataAdapter("select *  from Registrosecc61", con);
            tabla.Clear();
            adaptador.Fill(tabla);
            dgw.DataSource = tabla;

        }
        public string insertar(string cod, string rut, string nom, string pater, string mater, float nota1, float nota2, float nota3, float nota4, int totalnotas)
        {
            string Salida = " se guardo exitosamente!";
            try
            {

                tabla = new DataTable();
                adaptador = new SqlDataAdapter("insert into Registrosecc61 (Codigo, Rut, Nombre, Ap paterno, Ap materno, Nota1, Nota2, nota3, Nota4, Totalnotas) values ('" + cod + "','" + rut + "','" + nom + "','" + pater + "','" + mater + "'," + nota1 + "," + nota2 + "," + nota3 + "," + nota4 + "," + totalnotas + ")", con);
                tabla.Clear();
                adaptador.Fill(tabla);

            }
            catch (Exception ex)
            {
                Salida = "error al ingresar " + ex.ToString();
            }
            return Salida;
        }
        public string eliminar(string cod)
        {
            string salida = "Eliminado Exitosamente";
            try
            {

                comando = new SqlCommand("delete from Registrosecc61 where Codigo ='" + cod + "'", con);
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el registro : " + ex.ToString();
            }
            return salida;
        }
        public string modificar(string cod, string rut, string nom, string pater, string mater, double nota1, double nota2, double nota3, double nota4, int totalnotas)
        {
            string salida = "cambios realizados";
            try
            {
                comando = new SqlCommand("update Registrosecc61 set RUT ='" + rut +
                    "', NOMBRE ='" + nom + "', APPATERNO ='" + pater + "', APMATERNO ='" + mater +
                    "', NOTA1 =" + nota1 + ",NOTA2 = " + nota2 + ",NOTA3 =" + nota3 + ",NOTA4=" + nota4 +
                    ", TOTALNOTAS =" + totalnotas + " where CODIGO ='" + cod + "'", con);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "no se pudo realizar los cambios :" + ex.ToString();

            }
            return salida;
        }
        public int ValidarRut(string Rut)
        {

            int salida = 0;
            if (salida == 0)
            {

                string rut = Rut;
                if (rut.Length > 10)
                {
                    rut = "0" + rut;
                }
                string[] arreRutString = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    arreRutString[i] = rut[i].ToString();
                }
                int[] arreRutInt = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    arreRutInt[i] = Int32.Parse(arreRutString[i]);
                }
                double suma = 0;
                double divicionDecimal = 0;
                suma = 3 * arreRutInt[0] + 2 * arreRutInt[1] + 7 * arreRutInt[2] + 6 * arreRutInt[3] +
                       5 * arreRutInt[4] + 4 * arreRutInt[5] + 3 * arreRutInt[6] + 2 * arreRutInt[7];
                int divicionEnteros = 0;
                divicionDecimal = suma / 11;
                divicionEnteros = (int)divicionDecimal;

                double valorDecimal = 0;
                valorDecimal = divicionEnteros - divicionDecimal;
                double resta11 = 0;
                resta11 = (11 - (11 * (valorDecimal)));
                int digito = 0;
                digito = (int)resta11;

                if (arreRutString[9] == "K" && digito == 10)
                {
                    MessageBox.Show("Rut Verificado Correctamente");
                    salida = 1;

                }
                else if (arreRutString[9] == "0" && digito == 11)
                {
                    MessageBox.Show("Rut Verificado Correctamente" + digito.ToString());
                    salida = 1;

                }
                else if (arreRutString[9] == digito.ToString())
                {
                    MessageBox.Show("Rut Verificado Correctamente");
                    salida = 1;

                }
                else
                {
                    MessageBox.Show("El Rut Esta incorrecto");
                    salida = 0;

                }
            }

            return salida;
        }
        public void MostrarAlumno(string cod, DataGridView dgw)
        {
            float total = 0;

            dgw.DataSource = tabla;
            int CANTFILAS = dgw.RowCount;


            for (int n = 0; n < CANTFILAS - 1; n++)
            {
                string CODIGITO = dgw.Rows[n].Cells[0].Value.ToString().Trim();

                if (cod == CODIGITO)

                {

                    total += float.Parse(dgw.Rows[n].Cells[5].Value.ToString().Trim());
                    total += float.Parse(dgw.Rows[n].Cells[6].Value.ToString().Trim());
                    total += float.Parse(dgw.Rows[n].Cells[7].Value.ToString().Trim());
                    total += float.Parse(dgw.Rows[n].Cells[8].Value.ToString().Trim());
                    total = total / float.Parse(dgw.Rows[n].Cells[9].Value.ToString().Trim());

                    if (total <= 4.9 && total >= 4.0)
                    {
                        MessageBox.Show("examen: " + total.ToString());
                        break;
                    }
                    else if (total > 4.9)
                    {
                        MessageBox.Show("Aprueba: " + total.ToString());
                        break;
                    }
                    else
                    {
                        MessageBox.Show("reprueba: " + total.ToString());

                    }
                }


            }
            total = 0;

        }
        public void promCodNota(string cod, int not, DataGridView dgw)
        {




            dgw.DataSource = tabla;

            string asign = "";
            float lNota = 0;
            int cont = 0;
            int CANTFILAS = dgw.RowCount;
            for (int n = 0; n < CANTFILAS - 1; n++)
            {
                asign = "";
                asign = dgw.Rows[n].Cells[0].Value.ToString().Trim();
                asign = asign[0].ToString() + asign[1].ToString() + asign[2].ToString() + asign[3].ToString();
                if (asign == cod)
                {
                    lNota += float.Parse(dgw.Rows[n].Cells[not + 4].Value.ToString());
                    cont++;
                }

            }
            lNota = lNota / cont;
            MessageBox.Show(lNota.ToString());
        }
        public void Reprobados(DataGridView dgw)
        {
            dgw.DataSource = tabla;
            string resultado = "";
            string asign;
            int cont = 0;
            float total = 0;
            for (int n = 0; n < dgw.RowCount - 1; n++)
            {
                total += float.Parse(dgw.Rows[n].Cells[5].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[6].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[7].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[8].Value.ToString().Trim());
                total = total / float.Parse(dgw.Rows[n].Cells[9].Value.ToString().Trim());

                asign = dgw.Rows[n].Cells[0].Value.ToString().Trim();
                asign = asign[0].ToString() + asign[1].ToString() + asign[2].ToString() + asign[3].ToString();

                if (total < 4.0)
                {
                    cont = cont + 1;
                    resultado = resultado + "Promedio: " + total.ToString() + " Rut: " + dgw.Rows[n].Cells[1].Value.ToString() + " nombre: " + dgw.Rows[n].Cells[2].Value.ToString() + "\n Asignatura:" + asign + "\n";
                }
                total = 0;

            }
            resultado = resultado + "\ntotal de reprobados: " + cont;
            MessageBox.Show(resultado);
        }
        public void Examen(DataGridView dgw)

        {
            dgw.DataSource = tabla;
            string resultado = "";
            string asign;
            int cont = 0;
            float total = 0;
            for (int n = 0; n < dgw.RowCount - 1; n++)
            {
                total += float.Parse(dgw.Rows[n].Cells[5].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[6].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[7].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[8].Value.ToString().Trim());
                total = total / float.Parse(dgw.Rows[n].Cells[9].Value.ToString().Trim());

                asign = dgw.Rows[n].Cells[0].Value.ToString().Trim();
                asign = asign[0].ToString() + asign[1].ToString() + asign[2].ToString() + asign[3].ToString();

                if (total >= 4.0 && total <= 4.9)
                {
                    cont = cont + 1;
                    resultado = resultado + "Promedio: " + total.ToString() + " Rut: " + dgw.Rows[n].Cells[1].Value.ToString() + " nombre: " + dgw.Rows[n].Cells[2].Value.ToString() + "\n Asignatura:" + asign + "\n";
                }
                total = 0;
            }
            resultado = resultado + "\ntotal de Examen: " + cont;
            MessageBox.Show(resultado);

        }
        public void Aprobados(DataGridView dgw)
        {
            string resultado = "";
            string asign;
            int cont = 0;
            float total = 0;
            for (int n = 0; n < dgw.RowCount - 1; n++)
            {
                total += float.Parse(dgw.Rows[n].Cells[5].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[6].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[7].Value.ToString().Trim());
                total += float.Parse(dgw.Rows[n].Cells[8].Value.ToString().Trim());
                total = total / float.Parse(dgw.Rows[n].Cells[9].Value.ToString().Trim());

                asign = dgw.Rows[n].Cells[0].Value.ToString().Trim();
                asign = asign[0].ToString() + asign[1].ToString() + asign[2].ToString() + asign[3].ToString();

                if (total >= 5.0)
                {
                    cont = cont + 1;
                    resultado = resultado + "Promedio: " + total.ToString() + " Rut: " + dgw.Rows[n].Cells[1].Value.ToString() + " nombre: " + dgw.Rows[n].Cells[2].Value.ToString() + "\n Asignatura:" + asign + "\n";
                }
                total = 0;
            }
            resultado = resultado + "\ntotal de Aprobado: " + cont;
            MessageBox.Show(resultado);
        }
    }
}
