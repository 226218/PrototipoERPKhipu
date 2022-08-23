namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    partial class FormMantieneMatriculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantieneMatriculas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tMatriculaDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMatriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.codCarreraTextBox = new System.Windows.Forms.TextBox();
            this.codEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.codMatriculaTextBox = new System.Windows.Forms.TextBox();
            this.codModuloTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.semestreTextBox = new System.Windows.Forms.TextBox();
            this.tMatriculaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tMatriculaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            codCarreraLabel = new System.Windows.Forms.Label();
            codEstudianteLabel = new System.Windows.Forms.Label();
            codMatriculaLabel = new System.Windows.Forms.Label();
            codModuloLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            semestreLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaBindingNavigator)).BeginInit();
            this.tMatriculaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codCarreraLabel
            // 
            codCarreraLabel.AutoSize = true;
            codCarreraLabel.Location = new System.Drawing.Point(23, 51);
            codCarreraLabel.Name = "codCarreraLabel";
            codCarreraLabel.Size = new System.Drawing.Size(66, 13);
            codCarreraLabel.TabIndex = 10;
            codCarreraLabel.Text = "Cod Carrera:";
            // 
            // codEstudianteLabel
            // 
            codEstudianteLabel.AutoSize = true;
            codEstudianteLabel.Location = new System.Drawing.Point(23, 77);
            codEstudianteLabel.Name = "codEstudianteLabel";
            codEstudianteLabel.Size = new System.Drawing.Size(82, 13);
            codEstudianteLabel.TabIndex = 12;
            codEstudianteLabel.Text = "Cod Estudiante:";
            // 
            // codMatriculaLabel
            // 
            codMatriculaLabel.AutoSize = true;
            codMatriculaLabel.Location = new System.Drawing.Point(23, 103);
            codMatriculaLabel.Name = "codMatriculaLabel";
            codMatriculaLabel.Size = new System.Drawing.Size(75, 13);
            codMatriculaLabel.TabIndex = 14;
            codMatriculaLabel.Text = "Cod Matricula:";
            // 
            // codModuloLabel
            // 
            codModuloLabel.AutoSize = true;
            codModuloLabel.Location = new System.Drawing.Point(23, 129);
            codModuloLabel.Name = "codModuloLabel";
            codModuloLabel.Size = new System.Drawing.Size(67, 13);
            codModuloLabel.TabIndex = 16;
            codModuloLabel.Text = "Cod Modulo:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(23, 156);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 18;
            fechaLabel.Text = "Fecha:";
            // 
            // semestreLabel
            // 
            semestreLabel.AutoSize = true;
            semestreLabel.Location = new System.Drawing.Point(23, 181);
            semestreLabel.Name = "semestreLabel";
            semestreLabel.Size = new System.Drawing.Size(54, 13);
            semestreLabel.TabIndex = 20;
            semestreLabel.Text = "Semestre:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 318);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tMatriculaDataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tMatriculaDataGridView1
            // 
            this.tMatriculaDataGridView1.AutoGenerateColumns = false;
            this.tMatriculaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tMatriculaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tMatriculaDataGridView1.DataSource = this.tMatriculaBindingSource;
            this.tMatriculaDataGridView1.Location = new System.Drawing.Point(0, 3);
            this.tMatriculaDataGridView1.Name = "tMatriculaDataGridView1";
            this.tMatriculaDataGridView1.Size = new System.Drawing.Size(445, 267);
            this.tMatriculaDataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodCarrera";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodCarrera";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodEstudiante";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodEstudiante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodMatricula";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodMatricula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodModulo";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodModulo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Semestre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Semestre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tMatriculaBindingSource
            // 
            this.tMatriculaBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TMatricula);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(codCarreraLabel);
            this.tabPage2.Controls.Add(this.codCarreraTextBox);
            this.tabPage2.Controls.Add(codEstudianteLabel);
            this.tabPage2.Controls.Add(this.codEstudianteTextBox);
            this.tabPage2.Controls.Add(codMatriculaLabel);
            this.tabPage2.Controls.Add(this.codMatriculaTextBox);
            this.tabPage2.Controls.Add(codModuloLabel);
            this.tabPage2.Controls.Add(this.codModuloTextBox);
            this.tabPage2.Controls.Add(fechaLabel);
            this.tabPage2.Controls.Add(this.fechaDateTimePicker);
            this.tabPage2.Controls.Add(semestreLabel);
            this.tabPage2.Controls.Add(this.semestreTextBox);
            this.tabPage2.Controls.Add(this.tMatriculaBindingNavigator);
            this.tabPage2.Controls.Add(this.btn_Eliminar);
            this.tabPage2.Controls.Add(this.btn_Actualizar);
            this.tabPage2.Controls.Add(this.btn_Insertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // codCarreraTextBox
            // 
            this.codCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodCarrera", true));
            this.codCarreraTextBox.Location = new System.Drawing.Point(111, 48);
            this.codCarreraTextBox.Name = "codCarreraTextBox";
            this.codCarreraTextBox.Size = new System.Drawing.Size(200, 20);
            this.codCarreraTextBox.TabIndex = 11;
            // 
            // codEstudianteTextBox
            // 
            this.codEstudianteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodEstudiante", true));
            this.codEstudianteTextBox.Location = new System.Drawing.Point(111, 74);
            this.codEstudianteTextBox.Name = "codEstudianteTextBox";
            this.codEstudianteTextBox.Size = new System.Drawing.Size(200, 20);
            this.codEstudianteTextBox.TabIndex = 13;
            // 
            // codMatriculaTextBox
            // 
            this.codMatriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodMatricula", true));
            this.codMatriculaTextBox.Location = new System.Drawing.Point(111, 100);
            this.codMatriculaTextBox.Name = "codMatriculaTextBox";
            this.codMatriculaTextBox.Size = new System.Drawing.Size(200, 20);
            this.codMatriculaTextBox.TabIndex = 15;
            // 
            // codModuloTextBox
            // 
            this.codModuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "CodModulo", true));
            this.codModuloTextBox.Location = new System.Drawing.Point(111, 126);
            this.codModuloTextBox.Name = "codModuloTextBox";
            this.codModuloTextBox.Size = new System.Drawing.Size(200, 20);
            this.codModuloTextBox.TabIndex = 17;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tMatriculaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(111, 152);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 19;
            // 
            // semestreTextBox
            // 
            this.semestreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tMatriculaBindingSource, "Semestre", true));
            this.semestreTextBox.Location = new System.Drawing.Point(111, 178);
            this.semestreTextBox.Name = "semestreTextBox";
            this.semestreTextBox.Size = new System.Drawing.Size(200, 20);
            this.semestreTextBox.TabIndex = 21;
            // 
            // tMatriculaBindingNavigator
            // 
            this.tMatriculaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tMatriculaBindingNavigator.BindingSource = this.tMatriculaBindingSource;
            this.tMatriculaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tMatriculaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tMatriculaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tMatriculaBindingNavigatorSaveItem});
            this.tMatriculaBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tMatriculaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tMatriculaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tMatriculaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tMatriculaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tMatriculaBindingNavigator.Name = "tMatriculaBindingNavigator";
            this.tMatriculaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tMatriculaBindingNavigator.Size = new System.Drawing.Size(435, 25);
            this.tMatriculaBindingNavigator.TabIndex = 10;
            this.tMatriculaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tMatriculaBindingNavigatorSaveItem
            // 
            this.tMatriculaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tMatriculaBindingNavigatorSaveItem.Enabled = false;
            this.tMatriculaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tMatriculaBindingNavigatorSaveItem.Image")));
            this.tMatriculaBindingNavigatorSaveItem.Name = "tMatriculaBindingNavigatorSaveItem";
            this.tMatriculaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tMatriculaBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(223, 222);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(125, 222);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 8;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(23, 222);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 7;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // FormMantieneMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantieneMatriculas";
            this.Text = "FormMantieneMatriculas";
            this.Load += new System.EventHandler(this.FormMantieneMatriculas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaBindingNavigator)).EndInit();
            this.tMatriculaBindingNavigator.ResumeLayout(false);
            this.tMatriculaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tMatriculaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tMatriculaBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox codCarreraTextBox;
        private System.Windows.Forms.TextBox codEstudianteTextBox;
        private System.Windows.Forms.TextBox codMatriculaTextBox;
        private System.Windows.Forms.TextBox codModuloTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox semestreTextBox;
        private System.Windows.Forms.BindingNavigator tMatriculaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tMatriculaBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Insertar;
    }
}