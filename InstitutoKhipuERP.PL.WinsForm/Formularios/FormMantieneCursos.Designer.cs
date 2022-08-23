namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    partial class FormMantieneCursos
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
            System.Windows.Forms.Label codCursoLabel;
            System.Windows.Forms.Label codModuloLabel;
            System.Windows.Forms.Label creditosLabel;
            System.Windows.Forms.Label horasLabel;
            System.Windows.Forms.Label nomCursoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantieneCursos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tCursoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.codCarreraTextBox = new System.Windows.Forms.TextBox();
            this.codCursoTextBox = new System.Windows.Forms.TextBox();
            this.codModuloTextBox = new System.Windows.Forms.TextBox();
            this.creditosTextBox = new System.Windows.Forms.TextBox();
            this.horasTextBox = new System.Windows.Forms.TextBox();
            this.nomCursoTextBox = new System.Windows.Forms.TextBox();
            this.tCursoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tCursoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            codCarreraLabel = new System.Windows.Forms.Label();
            codCursoLabel = new System.Windows.Forms.Label();
            codModuloLabel = new System.Windows.Forms.Label();
            creditosLabel = new System.Windows.Forms.Label();
            horasLabel = new System.Windows.Forms.Label();
            nomCursoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCursoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCursoBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCursoBindingNavigator)).BeginInit();
            this.tCursoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codCarreraLabel
            // 
            codCarreraLabel.AutoSize = true;
            codCarreraLabel.Location = new System.Drawing.Point(17, 73);
            codCarreraLabel.Name = "codCarreraLabel";
            codCarreraLabel.Size = new System.Drawing.Size(66, 13);
            codCarreraLabel.TabIndex = 10;
            codCarreraLabel.Text = "Cod Carrera:";
            // 
            // codCursoLabel
            // 
            codCursoLabel.AutoSize = true;
            codCursoLabel.Location = new System.Drawing.Point(17, 47);
            codCursoLabel.Name = "codCursoLabel";
            codCursoLabel.Size = new System.Drawing.Size(59, 13);
            codCursoLabel.TabIndex = 12;
            codCursoLabel.Text = "Cod Curso:";
            // 
            // codModuloLabel
            // 
            codModuloLabel.AutoSize = true;
            codModuloLabel.Location = new System.Drawing.Point(16, 99);
            codModuloLabel.Name = "codModuloLabel";
            codModuloLabel.Size = new System.Drawing.Size(67, 13);
            codModuloLabel.TabIndex = 14;
            codModuloLabel.Text = "Cod Modulo:";
            // 
            // creditosLabel
            // 
            creditosLabel.AutoSize = true;
            creditosLabel.Location = new System.Drawing.Point(16, 125);
            creditosLabel.Name = "creditosLabel";
            creditosLabel.Size = new System.Drawing.Size(48, 13);
            creditosLabel.TabIndex = 16;
            creditosLabel.Text = "Creditos:";
            // 
            // horasLabel
            // 
            horasLabel.AutoSize = true;
            horasLabel.Location = new System.Drawing.Point(16, 151);
            horasLabel.Name = "horasLabel";
            horasLabel.Size = new System.Drawing.Size(38, 13);
            horasLabel.TabIndex = 18;
            horasLabel.Text = "Horas:";
            // 
            // nomCursoLabel
            // 
            nomCursoLabel.AutoSize = true;
            nomCursoLabel.Location = new System.Drawing.Point(16, 177);
            nomCursoLabel.Name = "nomCursoLabel";
            nomCursoLabel.Size = new System.Drawing.Size(62, 13);
            nomCursoLabel.TabIndex = 20;
            nomCursoLabel.Text = "Nom Curso:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(423, 302);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tCursoDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(415, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tCursoDataGridView
            // 
            this.tCursoDataGridView.AutoGenerateColumns = false;
            this.tCursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tCursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tCursoDataGridView.DataSource = this.tCursoBindingSource;
            this.tCursoDataGridView.Location = new System.Drawing.Point(8, 3);
            this.tCursoDataGridView.Name = "tCursoDataGridView";
            this.tCursoDataGridView.Size = new System.Drawing.Size(399, 252);
            this.tCursoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodCurso";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodCurso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NomCurso";
            this.dataGridViewTextBoxColumn6.HeaderText = "NomCurso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodCarrera";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodCarrera";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodModulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodModulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Creditos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Creditos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Horas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Horas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tCursoBindingSource
            // 
            this.tCursoBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TCurso);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(codCarreraLabel);
            this.tabPage2.Controls.Add(this.codCarreraTextBox);
            this.tabPage2.Controls.Add(codCursoLabel);
            this.tabPage2.Controls.Add(this.codCursoTextBox);
            this.tabPage2.Controls.Add(codModuloLabel);
            this.tabPage2.Controls.Add(this.codModuloTextBox);
            this.tabPage2.Controls.Add(creditosLabel);
            this.tabPage2.Controls.Add(this.creditosTextBox);
            this.tabPage2.Controls.Add(horasLabel);
            this.tabPage2.Controls.Add(this.horasTextBox);
            this.tabPage2.Controls.Add(nomCursoLabel);
            this.tabPage2.Controls.Add(this.nomCursoTextBox);
            this.tabPage2.Controls.Add(this.tCursoBindingNavigator);
            this.tabPage2.Controls.Add(this.btn_Eliminar);
            this.tabPage2.Controls.Add(this.btn_Actualizar);
            this.tabPage2.Controls.Add(this.btn_Insertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(415, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // codCarreraTextBox
            // 
            this.codCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCursoBindingSource, "CodCarrera", true));
            this.codCarreraTextBox.Location = new System.Drawing.Point(90, 70);
            this.codCarreraTextBox.Name = "codCarreraTextBox";
            this.codCarreraTextBox.Size = new System.Drawing.Size(100, 20);
            this.codCarreraTextBox.TabIndex = 11;
            // 
            // codCursoTextBox
            // 
            this.codCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCursoBindingSource, "CodCurso", true));
            this.codCursoTextBox.Location = new System.Drawing.Point(90, 44);
            this.codCursoTextBox.Name = "codCursoTextBox";
            this.codCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codCursoTextBox.TabIndex = 13;
            // 
            // codModuloTextBox
            // 
            this.codModuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCursoBindingSource, "CodModulo", true));
            this.codModuloTextBox.Location = new System.Drawing.Point(89, 96);
            this.codModuloTextBox.Name = "codModuloTextBox";
            this.codModuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.codModuloTextBox.TabIndex = 15;
            // 
            // creditosTextBox
            // 
            this.creditosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCursoBindingSource, "Creditos", true));
            this.creditosTextBox.Location = new System.Drawing.Point(89, 122);
            this.creditosTextBox.Name = "creditosTextBox";
            this.creditosTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditosTextBox.TabIndex = 17;
            // 
            // horasTextBox
            // 
            this.horasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCursoBindingSource, "Horas", true));
            this.horasTextBox.Location = new System.Drawing.Point(89, 148);
            this.horasTextBox.Name = "horasTextBox";
            this.horasTextBox.Size = new System.Drawing.Size(100, 20);
            this.horasTextBox.TabIndex = 19;
            // 
            // nomCursoTextBox
            // 
            this.nomCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCursoBindingSource, "NomCurso", true));
            this.nomCursoTextBox.Location = new System.Drawing.Point(89, 174);
            this.nomCursoTextBox.Name = "nomCursoTextBox";
            this.nomCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomCursoTextBox.TabIndex = 21;
            // 
            // tCursoBindingNavigator
            // 
            this.tCursoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tCursoBindingNavigator.BindingSource = this.tCursoBindingSource;
            this.tCursoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tCursoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tCursoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tCursoBindingNavigatorSaveItem});
            this.tCursoBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tCursoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tCursoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tCursoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tCursoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tCursoBindingNavigator.Name = "tCursoBindingNavigator";
            this.tCursoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tCursoBindingNavigator.Size = new System.Drawing.Size(409, 25);
            this.tCursoBindingNavigator.TabIndex = 10;
            this.tCursoBindingNavigator.Text = "bindingNavigator1";
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
            // tCursoBindingNavigatorSaveItem
            // 
            this.tCursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tCursoBindingNavigatorSaveItem.Enabled = false;
            this.tCursoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tCursoBindingNavigatorSaveItem.Image")));
            this.tCursoBindingNavigatorSaveItem.Name = "tCursoBindingNavigatorSaveItem";
            this.tCursoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tCursoBindingNavigatorSaveItem.Text = "Guardar datos";
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
            // FormMantieneCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 302);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantieneCursos";
            this.Text = "FormMantieneCursos";
            this.Load += new System.EventHandler(this.FormMantieneCursos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tCursoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCursoBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCursoBindingNavigator)).EndInit();
            this.tCursoBindingNavigator.ResumeLayout(false);
            this.tCursoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tCursoDataGridView;
        private System.Windows.Forms.BindingSource tCursoBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox codCarreraTextBox;
        private System.Windows.Forms.TextBox codCursoTextBox;
        private System.Windows.Forms.TextBox codModuloTextBox;
        private System.Windows.Forms.TextBox creditosTextBox;
        private System.Windows.Forms.TextBox horasTextBox;
        private System.Windows.Forms.TextBox nomCursoTextBox;
        private System.Windows.Forms.BindingNavigator tCursoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tCursoBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}