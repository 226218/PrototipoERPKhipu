namespace InstitutoKhipuERP.PL.WinsForm
{
    partial class FormMantieneEstudiante
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
            System.Windows.Forms.Label apeMaternoLabel;
            System.Windows.Forms.Label apePaternoLabel;
            System.Windows.Forms.Label codCarreraLabel;
            System.Windows.Forms.Label codEstudianteLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantieneEstudiante));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tEstudianteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tEstudianteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tEstudianteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.apeMaternoTextBox = new System.Windows.Forms.TextBox();
            this.apePaternoTextBox = new System.Windows.Forms.TextBox();
            this.codCarreraTextBox = new System.Windows.Forms.TextBox();
            this.codEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            apeMaternoLabel = new System.Windows.Forms.Label();
            apePaternoLabel = new System.Windows.Forms.Label();
            codCarreraLabel = new System.Windows.Forms.Label();
            codEstudianteLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteBindingNavigator)).BeginInit();
            this.tEstudianteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // apeMaternoLabel
            // 
            apeMaternoLabel.AutoSize = true;
            apeMaternoLabel.Location = new System.Drawing.Point(23, 92);
            apeMaternoLabel.Name = "apeMaternoLabel";
            apeMaternoLabel.Size = new System.Drawing.Size(71, 13);
            apeMaternoLabel.TabIndex = 9;
            apeMaternoLabel.Text = "Ape Materno:";
            // 
            // apePaternoLabel
            // 
            apePaternoLabel.AutoSize = true;
            apePaternoLabel.Location = new System.Drawing.Point(23, 118);
            apePaternoLabel.Name = "apePaternoLabel";
            apePaternoLabel.Size = new System.Drawing.Size(69, 13);
            apePaternoLabel.TabIndex = 11;
            apePaternoLabel.Text = "Ape Paterno:";
            // 
            // codCarreraLabel
            // 
            codCarreraLabel.AutoSize = true;
            codCarreraLabel.Location = new System.Drawing.Point(26, 173);
            codCarreraLabel.Name = "codCarreraLabel";
            codCarreraLabel.Size = new System.Drawing.Size(66, 13);
            codCarreraLabel.TabIndex = 13;
            codCarreraLabel.Text = "Cod Carrera:";
            // 
            // codEstudianteLabel
            // 
            codEstudianteLabel.AutoSize = true;
            codEstudianteLabel.Location = new System.Drawing.Point(23, 68);
            codEstudianteLabel.Name = "codEstudianteLabel";
            codEstudianteLabel.Size = new System.Drawing.Size(82, 13);
            codEstudianteLabel.TabIndex = 15;
            codEstudianteLabel.Text = "Cod Estudiante:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(23, 196);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 17;
            dniLabel.Text = "Dni:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(26, 144);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 19;
            nombresLabel.Text = "Nombres:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 314);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tEstudianteDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(467, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tEstudianteDataGridView
            // 
            this.tEstudianteDataGridView.AutoGenerateColumns = false;
            this.tEstudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tEstudianteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tEstudianteDataGridView.DataSource = this.tEstudianteBindingSource;
            this.tEstudianteDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tEstudianteDataGridView.Location = new System.Drawing.Point(3, 6);
            this.tEstudianteDataGridView.Name = "tEstudianteDataGridView";
            this.tEstudianteDataGridView.Size = new System.Drawing.Size(461, 279);
            this.tEstudianteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ApeMaterno";
            this.dataGridViewTextBoxColumn1.HeaderText = "ApeMaterno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ApePaterno";
            this.dataGridViewTextBoxColumn2.HeaderText = "ApePaterno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodCarrera";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodCarrera";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CodEstudiante";
            this.dataGridViewTextBoxColumn4.HeaderText = "CodEstudiante";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dni";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tEstudianteBindingSource
            // 
            this.tEstudianteBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TEstudiante);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.tEstudianteBindingNavigator);
            this.tabPage2.Controls.Add(apeMaternoLabel);
            this.tabPage2.Controls.Add(this.apeMaternoTextBox);
            this.tabPage2.Controls.Add(apePaternoLabel);
            this.tabPage2.Controls.Add(this.apePaternoTextBox);
            this.tabPage2.Controls.Add(codCarreraLabel);
            this.tabPage2.Controls.Add(this.codCarreraTextBox);
            this.tabPage2.Controls.Add(codEstudianteLabel);
            this.tabPage2.Controls.Add(this.codEstudianteTextBox);
            this.tabPage2.Controls.Add(dniLabel);
            this.tabPage2.Controls.Add(this.dniTextBox);
            this.tabPage2.Controls.Add(nombresLabel);
            this.tabPage2.Controls.Add(this.nombresTextBox);
            this.tabPage2.Controls.Add(this.btn_Eliminar);
            this.tabPage2.Controls.Add(this.btn_Actualizar);
            this.tabPage2.Controls.Add(this.btn_Insertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tEstudianteBindingNavigator
            // 
            this.tEstudianteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tEstudianteBindingNavigator.BindingSource = this.tEstudianteBindingSource;
            this.tEstudianteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tEstudianteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tEstudianteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tEstudianteBindingNavigatorSaveItem});
            this.tEstudianteBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tEstudianteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tEstudianteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tEstudianteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tEstudianteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tEstudianteBindingNavigator.Name = "tEstudianteBindingNavigator";
            this.tEstudianteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tEstudianteBindingNavigator.Size = new System.Drawing.Size(461, 25);
            this.tEstudianteBindingNavigator.TabIndex = 21;
            this.tEstudianteBindingNavigator.Text = "bindingNavigator1";
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
            // tEstudianteBindingNavigatorSaveItem
            // 
            this.tEstudianteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tEstudianteBindingNavigatorSaveItem.Enabled = false;
            this.tEstudianteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tEstudianteBindingNavigatorSaveItem.Image")));
            this.tEstudianteBindingNavigatorSaveItem.Name = "tEstudianteBindingNavigatorSaveItem";
            this.tEstudianteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tEstudianteBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // apeMaternoTextBox
            // 
            this.apeMaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEstudianteBindingSource, "ApeMaterno", true));
            this.apeMaternoTextBox.Location = new System.Drawing.Point(111, 89);
            this.apeMaternoTextBox.Name = "apeMaternoTextBox";
            this.apeMaternoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apeMaternoTextBox.TabIndex = 10;
            // 
            // apePaternoTextBox
            // 
            this.apePaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEstudianteBindingSource, "ApePaterno", true));
            this.apePaternoTextBox.Location = new System.Drawing.Point(111, 115);
            this.apePaternoTextBox.Name = "apePaternoTextBox";
            this.apePaternoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apePaternoTextBox.TabIndex = 12;
            // 
            // codCarreraTextBox
            // 
            this.codCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEstudianteBindingSource, "CodCarrera", true));
            this.codCarreraTextBox.Location = new System.Drawing.Point(111, 167);
            this.codCarreraTextBox.Name = "codCarreraTextBox";
            this.codCarreraTextBox.Size = new System.Drawing.Size(100, 20);
            this.codCarreraTextBox.TabIndex = 14;
            // 
            // codEstudianteTextBox
            // 
            this.codEstudianteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEstudianteBindingSource, "CodEstudiante", true));
            this.codEstudianteTextBox.Location = new System.Drawing.Point(111, 63);
            this.codEstudianteTextBox.Name = "codEstudianteTextBox";
            this.codEstudianteTextBox.Size = new System.Drawing.Size(100, 20);
            this.codEstudianteTextBox.TabIndex = 16;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEstudianteBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(111, 193);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 18;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEstudianteBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(111, 141);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 20;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(266, 225);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(168, 225);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 8;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(73, 225);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 7;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // FormMantieneEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 314);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantieneEstudiante";
            this.Text = "FormEstudiante";
            this.Load += new System.EventHandler(this.FormMantieneEstudiante_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEstudianteBindingNavigator)).EndInit();
            this.tEstudianteBindingNavigator.ResumeLayout(false);
            this.tEstudianteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tEstudianteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tEstudianteBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox apeMaternoTextBox;
        private System.Windows.Forms.TextBox apePaternoTextBox;
        private System.Windows.Forms.TextBox codCarreraTextBox;
        private System.Windows.Forms.TextBox codEstudianteTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.BindingNavigator tEstudianteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tEstudianteBindingNavigatorSaveItem;

    }
}