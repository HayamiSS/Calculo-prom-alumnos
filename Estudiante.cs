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
    class Estudiante
    {
        Estudiante estu1 = new Estudiante();
        private string cod, rut,Rut, nom, pater, mater, motivo, valido, asignatura;
        private float nota1, nota2, nota3, nota4;
        private int totalnotas;
        public Estudiante()
        {
            cod = "Sin codigo"; rut = "Sin rut"; nom = "Sin nombre"; pater = "Sin apellido";
            mater = "Sin apellido"; motivo = "sin motivo"; valido = "Sin validación"; asignatura = "Sin asignatura"; nota1 = float.Parse("0");
            nota2 = float.Parse("0"); nota3 = float.Parse("0"); nota4 = float.Parse("0"); totalnotas = int.Parse("0");
        }
        public string CODIGO { get { return cod; } set { cod = value; } }
        public string RUT { get { return rut; } set {
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
            rut = value; } }
        public string NOMBRE { get { return nom; } set { nom = value; } }
        public string APATERNO { get { return pater; } set { pater = value; } }
        public string AMATERNO { get { return mater; } set { mater = value; } }
        public string MOTIVO { get { return motivo; } set { motivo = value; } }
        public string VALIDO { get { return valido; } set { valido = value; } }
        public string ASIGNATURA { get { return asignatura; } set { asignatura = value; } }
        public float NOTA1 { get { return nota1; } set { nota1 = value; } }
        public float NOTA2 { get { return nota2; } set { nota2 = value; } }
        public float NOTA3 { get { return nota3; } set { nota3 = value; } }
        public float NOTA4 { get { return nota4; } set { nota4 = value; } }
        public int TOTALNOTAS { get { return totalnotas; } set { totalnotas = value; } }

    }
}
