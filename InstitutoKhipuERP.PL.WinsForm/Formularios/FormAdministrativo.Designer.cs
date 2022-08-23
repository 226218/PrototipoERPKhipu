namespace InstitutoKhipuERP.PL.WinsForm
{
    partial class FormAdministrativo
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
            this.btn_TDocente = new System.Windows.Forms.Button();
            this.btn_TEstudiante = new System.Windows.Forms.Button();
            this.btn_TMatricula = new System.Windows.Forms.Button();
            this.btn_TCurso = new System.Windows.Forms.Button();
            this.btn_TModuloCarrera = new System.Windows.Forms.Button();
            this.btn_TCarrera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TDocente
            // 
            this.btn_TDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TDocente.Location = new System.Drawing.Point(140, 66);
            this.btn_TDocente.Name = "btn_TDocente";
            this.btn_TDocente.Size = new System.Drawing.Size(92, 23);
            this.btn_TDocente.TabIndex = 16;
            this.btn_TDocente.Text = "Docente";
            this.btn_TDocente.UseVisualStyleBackColor = false;
            this.btn_TDocente.Click += new System.EventHandler(this.btn_TDocente_Click);
            // 
            // btn_TEstudiante
            // 
            this.btn_TEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TEstudiante.Location = new System.Drawing.Point(140, 23);
            this.btn_TEstudiante.Name = "btn_TEstudiante";
            this.btn_TEstudiante.Size = new System.Drawing.Size(92, 23);
            this.btn_TEstudiante.TabIndex = 17;
            this.btn_TEstudiante.Text = "Estudiante";
            this.btn_TEstudiante.UseVisualStyleBackColor = false;
            this.btn_TEstudiante.Click += new System.EventHandler(this.btn_TEstudiante_Click);
            // 
            // btn_TMatricula
            // 
            this.btn_TMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TMatricula.Location = new System.Drawing.Point(26, 110);
            this.btn_TMatricula.Name = "btn_TMatricula";
            this.btn_TMatricula.Size = new System.Drawing.Size(88, 23);
            this.btn_TMatricula.TabIndex = 12;
            this.btn_TMatricula.Text = "Matriculas";
            this.btn_TMatricula.UseVisualStyleBackColor = false;
            this.btn_TMatricula.Click += new System.EventHandler(this.btn_TMatricula_Click);
            // 
            // btn_TCurso
            // 
            this.btn_TCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TCurso.Location = new System.Drawing.Point(26, 66);
            this.btn_TCurso.Name = "btn_TCurso";
            this.btn_TCurso.Size = new System.Drawing.Size(88, 23);
            this.btn_TCurso.TabIndex = 13;
            this.btn_TCurso.Text = "Cursos";
            this.btn_TCurso.UseVisualStyleBackColor = false;
            this.btn_TCurso.Click += new System.EventHandler(this.btn_TCurso_Click);
            // 
            // btn_TModuloCarrera
            // 
            this.btn_TModuloCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TModuloCarrera.Location = new System.Drawing.Point(140, 110);
            this.btn_TModuloCarrera.Name = "btn_TModuloCarrera";
            this.btn_TModuloCarrera.Size = new System.Drawing.Size(92, 23);
            this.btn_TModuloCarrera.TabIndex = 14;
            this.btn_TModuloCarrera.Text = "Modulo Carreras";
            this.btn_TModuloCarrera.UseVisualStyleBackColor = false;
            this.btn_TModuloCarrera.Click += new System.EventHandler(this.btn_TModuloCarrera_Click);
            // 
            // btn_TCarrera
            // 
            this.btn_TCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_TCarrera.Location = new System.Drawing.Point(26, 23);
            this.btn_TCarrera.Name = "btn_TCarrera";
            this.btn_TCarrera.Size = new System.Drawing.Size(88, 23);
            this.btn_TCarrera.TabIndex = 15;
            this.btn_TCarrera.Text = "Carrera";
            this.btn_TCarrera.UseVisualStyleBackColor = false;
            this.btn_TCarrera.Click += new System.EventHandler(this.btn_TCarrera_Click);
            // 
            // FormAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(248, 173);
            this.Controls.Add(this.btn_TDocente);
            this.Controls.Add(this.btn_TEstudiante);
            this.Controls.Add(this.btn_TMatricula);
            this.Controls.Add(this.btn_TCurso);
            this.Controls.Add(this.btn_TModuloCarrera);
            this.Controls.Add(this.btn_TCarrera);
            this.Name = "FormAdministrativo";
            this.Text = "FormAdministrativo";
            this.Load += new System.EventHandler(this.FormAdministrativo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TDocente;
        private System.Windows.Forms.Button btn_TEstudiante;
        private System.Windows.Forms.Button btn_TMatricula;
        private System.Windows.Forms.Button btn_TCurso;
        private System.Windows.Forms.Button btn_TModuloCarrera;
        private System.Windows.Forms.Button btn_TCarrera;
    }
}