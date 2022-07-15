namespace ejercicioprueba4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Promcurso = new System.Windows.Forms.Button();
            this.btn_Aprobados = new System.Windows.Forms.Button();
            this.btn_Danexamen = new System.Windows.Forms.Button();
            this.btn_Reprovados = new System.Windows.Forms.Button();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbposnota = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(12, 24);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Promcurso
            // 
            this.btn_Promcurso.Location = new System.Drawing.Point(12, 53);
            this.btn_Promcurso.Name = "btn_Promcurso";
            this.btn_Promcurso.Size = new System.Drawing.Size(75, 43);
            this.btn_Promcurso.TabIndex = 2;
            this.btn_Promcurso.Text = "Promedio del curdo";
            this.btn_Promcurso.UseVisualStyleBackColor = true;
            this.btn_Promcurso.Click += new System.EventHandler(this.btn_Promcurso_Click);
            // 
            // btn_Aprobados
            // 
            this.btn_Aprobados.Location = new System.Drawing.Point(12, 102);
            this.btn_Aprobados.Name = "btn_Aprobados";
            this.btn_Aprobados.Size = new System.Drawing.Size(75, 23);
            this.btn_Aprobados.TabIndex = 3;
            this.btn_Aprobados.Text = "Aprobados";
            this.btn_Aprobados.UseVisualStyleBackColor = true;
            this.btn_Aprobados.Click += new System.EventHandler(this.btn_Aprobados_Click);
            // 
            // btn_Danexamen
            // 
            this.btn_Danexamen.Location = new System.Drawing.Point(174, 102);
            this.btn_Danexamen.Name = "btn_Danexamen";
            this.btn_Danexamen.Size = new System.Drawing.Size(75, 23);
            this.btn_Danexamen.TabIndex = 4;
            this.btn_Danexamen.Text = "Examen";
            this.btn_Danexamen.UseVisualStyleBackColor = true;
            this.btn_Danexamen.Click += new System.EventHandler(this.btn_Danexamen_Click);
            // 
            // btn_Reprovados
            // 
            this.btn_Reprovados.Location = new System.Drawing.Point(93, 102);
            this.btn_Reprovados.Name = "btn_Reprovados";
            this.btn_Reprovados.Size = new System.Drawing.Size(75, 23);
            this.btn_Reprovados.TabIndex = 5;
            this.btn_Reprovados.Text = "Reprobados";
            this.btn_Reprovados.UseVisualStyleBackColor = true;
            this.btn_Reprovados.Click += new System.EventHandler(this.btn_Reprovados_Click);
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(93, 26);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(100, 20);
            this.tbcodigo.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nota";
            // 
            // tbposnota
            // 
            this.tbposnota.Location = new System.Drawing.Point(269, 65);
            this.tbposnota.Name = "tbposnota";
            this.tbposnota.Size = new System.Drawing.Size(34, 20);
            this.tbposnota.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 164);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 345);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tbposnota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.btn_Reprovados);
            this.Controls.Add(this.btn_Danexamen);
            this.Controls.Add(this.btn_Aprobados);
            this.Controls.Add(this.btn_Promcurso);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "busca_alumno";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Promcurso;
        private System.Windows.Forms.Button btn_Aprobados;
        private System.Windows.Forms.Button btn_Danexamen;
        private System.Windows.Forms.Button btn_Reprovados;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbposnota;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}