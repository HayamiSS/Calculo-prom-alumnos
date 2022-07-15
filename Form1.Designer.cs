namespace ejercicioprueba4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbmaterno = new System.Windows.Forms.TextBox();
            this.tbrut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcode = new System.Windows.Forms.TextBox();
            this.tbDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbnota1 = new System.Windows.Forms.TextBox();
            this.tbnota2 = new System.Windows.Forms.TextBox();
            this.tbnota4 = new System.Windows.Forms.TextBox();
            this.tbnota3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbtotalNotas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ap Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(125, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbmaterno
            // 
            this.tbmaterno.Location = new System.Drawing.Point(121, 144);
            this.tbmaterno.Name = "tbmaterno";
            this.tbmaterno.Size = new System.Drawing.Size(100, 20);
            this.tbmaterno.TabIndex = 4;
            // 
            // tbrut
            // 
            this.tbrut.Location = new System.Drawing.Point(125, 82);
            this.tbrut.Name = "tbrut";
            this.tbrut.Size = new System.Drawing.Size(80, 20);
            this.tbrut.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "actualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 252);
            this.dataGridView1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Codigo";
            // 
            // tbcode
            // 
            this.tbcode.Location = new System.Drawing.Point(125, 32);
            this.tbcode.Name = "tbcode";
            this.tbcode.Size = new System.Drawing.Size(100, 20);
            this.tbcode.TabIndex = 12;
            // 
            // tbDV
            // 
            this.tbDV.Location = new System.Drawing.Point(227, 82);
            this.tbDV.Name = "tbDV";
            this.tbDV.Size = new System.Drawing.Size(19, 20);
            this.tbDV.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ap Paterno";
            // 
            // tbpaterno
            // 
            this.tbpaterno.Location = new System.Drawing.Point(121, 108);
            this.tbpaterno.Name = "tbpaterno";
            this.tbpaterno.Size = new System.Drawing.Size(100, 20);
            this.tbpaterno.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nota 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nota 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nota 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nota 3";
            // 
            // tbnota1
            // 
            this.tbnota1.Location = new System.Drawing.Point(63, 196);
            this.tbnota1.Name = "tbnota1";
            this.tbnota1.Size = new System.Drawing.Size(29, 20);
            this.tbnota1.TabIndex = 21;
            // 
            // tbnota2
            // 
            this.tbnota2.Location = new System.Drawing.Point(108, 196);
            this.tbnota2.Name = "tbnota2";
            this.tbnota2.Size = new System.Drawing.Size(27, 20);
            this.tbnota2.TabIndex = 22;
            // 
            // tbnota4
            // 
            this.tbnota4.Location = new System.Drawing.Point(198, 196);
            this.tbnota4.Name = "tbnota4";
            this.tbnota4.Size = new System.Drawing.Size(30, 20);
            this.tbnota4.TabIndex = 23;
            // 
            // tbnota3
            // 
            this.tbnota3.Location = new System.Drawing.Point(153, 196);
            this.tbnota3.Name = "tbnota3";
            this.tbnota3.Size = new System.Drawing.Size(36, 20);
            this.tbnota3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total notas";
            // 
            // tbtotalNotas
            // 
            this.tbtotalNotas.Location = new System.Drawing.Point(270, 196);
            this.tbtotalNotas.Name = "tbtotalNotas";
            this.tbtotalNotas.Size = new System.Drawing.Size(30, 20);
            this.tbtotalNotas.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 303);
            this.Controls.Add(this.tbtotalNotas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbnota3);
            this.Controls.Add(this.tbnota4);
            this.Controls.Add(this.tbnota2);
            this.Controls.Add(this.tbnota1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbpaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDV);
            this.Controls.Add(this.tbcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbrut);
            this.Controls.Add(this.tbmaterno);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbmaterno;
        private System.Windows.Forms.TextBox tbrut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcode;
        private System.Windows.Forms.TextBox tbDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbpaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbnota1;
        private System.Windows.Forms.TextBox tbnota2;
        private System.Windows.Forms.TextBox tbnota4;
        private System.Windows.Forms.TextBox tbnota3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbtotalNotas;
    }
}

