namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    partial class Matricula
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codCarreraLabel;
            System.Windows.Forms.Label codEstudianteLabel;
            System.Windows.Forms.Label codMatriculaLabel;
            System.Windows.Forms.Label codModuloLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label semestreLabel;
            this.tMatriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codCarreraTextBox = new System.Windows.Forms.TextBox();
            this.codEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.codMatriculaTextBox = new System.Windows.Forms.TextBox();
            this.codModuloTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.semestreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            codCarreraLabel = new System.Windows.Forms.Label();
            codEstudianteLabel = new System.Windows.Forms.Label();
            codMatriculaLabel = new System.Windows.Forms.Label();
            codModuloLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            semestreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tMatriculaBindingSource
            // 
            this.tMatriculaBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TMatricula);
            // 
            // codCarreraLabel
            // 
            codCarreraLabel.AutoSize = true;
            codCarreraLabel.Location = new System.Drawing.Point(56, 29);
            codCarreraLabel.Name = "codCarreraLabel";
            codCarreraLabel.Size = new System.Drawing.Size(66, 13);
            codCarreraLabel.TabIndex = 1;
            codCarreraLabel.Text = "Cod Carrera:";
            // 
            // codCarreraTextBox
            // 
            this.codCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodCarrera", true));
            this.codCarreraTextBox.Location = new System.Drawing.Point(144, 26);
            this.codCarreraTextBox.Name = "codCarreraTextBox";
            this.codCarreraTextBox.Size = new System.Drawing.Size(200, 20);
            this.codCarreraTextBox.TabIndex = 2;
            // 
            // codEstudianteLabel
            // 
            codEstudianteLabel.AutoSize = true;
            codEstudianteLabel.Location = new System.Drawing.Point(56, 55);
            codEstudianteLabel.Name = "codEstudianteLabel";
            codEstudianteLabel.Size = new System.Drawing.Size(82, 13);
            codEstudianteLabel.TabIndex = 3;
            codEstudianteLabel.Text = "Cod Estudiante:";
            // 
            // codEstudianteTextBox
            // 
            this.codEstudianteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodEstudiante", true));
            this.codEstudianteTextBox.Location = new System.Drawing.Point(144, 52);
            this.codEstudianteTextBox.Name = "codEstudianteTextBox";
            this.codEstudianteTextBox.Size = new System.Drawing.Size(200, 20);
            this.codEstudianteTextBox.TabIndex = 4;
            // 
            // codMatriculaLabel
            // 
            codMatriculaLabel.AutoSize = true;
            codMatriculaLabel.Location = new System.Drawing.Point(56, 81);
            codMatriculaLabel.Name = "codMatriculaLabel";
            codMatriculaLabel.Size = new System.Drawing.Size(75, 13);
            codMatriculaLabel.TabIndex = 5;
            codMatriculaLabel.Text = "Cod Matricula:";
            // 
            // codMatriculaTextBox
            // 
            this.codMatriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodMatricula", true));
            this.codMatriculaTextBox.Location = new System.Drawing.Point(144, 78);
            this.codMatriculaTextBox.Name = "codMatriculaTextBox";
            this.codMatriculaTextBox.Size = new System.Drawing.Size(200, 20);
            this.codMatriculaTextBox.TabIndex = 6;
            // 
            // codModuloLabel
            // 
            codModuloLabel.AutoSize = true;
            codModuloLabel.Location = new System.Drawing.Point(56, 107);
            codModuloLabel.Name = "codModuloLabel";
            codModuloLabel.Size = new System.Drawing.Size(67, 13);
            codModuloLabel.TabIndex = 7;
            codModuloLabel.Text = "Cod Modulo:";
            // 
            // codModuloTextBox
            // 
            this.codModuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodModulo", true));
            this.codModuloTextBox.Location = new System.Drawing.Point(144, 104);
            this.codModuloTextBox.Name = "codModuloTextBox";
            this.codModuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.codModuloTextBox.TabIndex = 8;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(56, 134);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tMatriculaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(144, 130);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 10;
            // 
            // semestreLabel
            // 
            semestreLabel.AutoSize = true;
            semestreLabel.Location = new System.Drawing.Point(56, 159);
            semestreLabel.Name = "semestreLabel";
            semestreLabel.Size = new System.Drawing.Size(54, 13);
            semestreLabel.TabIndex = 11;
            semestreLabel.Text = "Semestre:";
            // 
            // semestreTextBox
            // 
            this.semestreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "Semestre", true));
            this.semestreTextBox.Location = new System.Drawing.Point(144, 156);
            this.semestreTextBox.Name = "semestreTextBox";
            this.semestreTextBox.Size = new System.Drawing.Size(200, 20);
            this.semestreTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Matricularse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 231);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codCarreraLabel);
            this.Controls.Add(this.codCarreraTextBox);
            this.Controls.Add(codEstudianteLabel);
            this.Controls.Add(this.codEstudianteTextBox);
            this.Controls.Add(codMatriculaLabel);
            this.Controls.Add(this.codMatriculaTextBox);
            this.Controls.Add(codModuloLabel);
            this.Controls.Add(this.codModuloTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(semestreLabel);
            this.Controls.Add(this.semestreTextBox);
            this.Name = "Matricula";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tMatriculaBindingSource;
        private System.Windows.Forms.TextBox codCarreraTextBox;
        private System.Windows.Forms.TextBox codEstudianteTextBox;
        private System.Windows.Forms.TextBox codMatriculaTextBox;
        private System.Windows.Forms.TextBox codModuloTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox semestreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}