namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    partial class FormMantieneCarrera
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
            System.Windows.Forms.Label nomCarreraLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label codCarreraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantieneCarrera));
            this.tCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.codCarreraTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nomCarreraTextBox = new System.Windows.Forms.TextBox();
            this.tCarreraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tCarreraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tCarreraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            nomCarreraLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            codCarreraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tCarreraBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCarreraBindingNavigator)).BeginInit();
            this.tCarreraBindingNavigator.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCarreraDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomCarreraLabel
            // 
            nomCarreraLabel.AutoSize = true;
            nomCarreraLabel.Location = new System.Drawing.Point(29, 123);
            nomCarreraLabel.Name = "nomCarreraLabel";
            nomCarreraLabel.Size = new System.Drawing.Size(69, 13);
            nomCarreraLabel.TabIndex = 5;
            nomCarreraLabel.Text = "Nom Carrera:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(29, 97);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // codCarreraLabel
            // 
            codCarreraLabel.AutoSize = true;
            codCarreraLabel.Location = new System.Drawing.Point(29, 71);
            codCarreraLabel.Name = "codCarreraLabel";
            codCarreraLabel.Size = new System.Drawing.Size(66, 13);
            codCarreraLabel.TabIndex = 1;
            codCarreraLabel.Text = "Cod Carrera:";
            // 
            // tCarreraBindingSource
            // 
            this.tCarreraBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TCarrera);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Eliminar);
            this.tabPage2.Controls.Add(this.btn_Actualizar);
            this.tabPage2.Controls.Add(this.btn_Insertar);
            this.tabPage2.Controls.Add(codCarreraLabel);
            this.tabPage2.Controls.Add(this.codCarreraTextBox);
            this.tabPage2.Controls.Add(this.descripcionTextBox);
            this.tabPage2.Controls.Add(this.nomCarreraTextBox);
            this.tabPage2.Controls.Add(descripcionLabel);
            this.tabPage2.Controls.Add(nomCarreraLabel);
            this.tabPage2.Controls.Add(this.tCarreraBindingNavigator);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(225, 159);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(127, 159);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 8;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(32, 159);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 7;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // codCarreraTextBox
            // 
            this.codCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarreraBindingSource, "CodCarrera", true));
            this.codCarreraTextBox.Location = new System.Drawing.Point(104, 68);
            this.codCarreraTextBox.Name = "codCarreraTextBox";
            this.codCarreraTextBox.Size = new System.Drawing.Size(214, 20);
            this.codCarreraTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarreraBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(104, 94);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(214, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // nomCarreraTextBox
            // 
            this.nomCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tCarreraBindingSource, "NomCarrera", true));
            this.nomCarreraTextBox.Location = new System.Drawing.Point(104, 120);
            this.nomCarreraTextBox.Name = "nomCarreraTextBox";
            this.nomCarreraTextBox.Size = new System.Drawing.Size(214, 20);
            this.nomCarreraTextBox.TabIndex = 6;
            // 
            // tCarreraBindingNavigator
            // 
            this.tCarreraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tCarreraBindingNavigator.BindingSource = this.tCarreraBindingSource;
            this.tCarreraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tCarreraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tCarreraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tCarreraBindingNavigatorSaveItem});
            this.tCarreraBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tCarreraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tCarreraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tCarreraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tCarreraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tCarreraBindingNavigator.Name = "tCarreraBindingNavigator";
            this.tCarreraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tCarreraBindingNavigator.Size = new System.Drawing.Size(356, 25);
            this.tCarreraBindingNavigator.TabIndex = 1;
            this.tCarreraBindingNavigator.Text = "bindingNavigator1";
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
            // tCarreraBindingNavigatorSaveItem
            // 
            this.tCarreraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tCarreraBindingNavigatorSaveItem.Enabled = false;
            this.tCarreraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tCarreraBindingNavigatorSaveItem.Image")));
            this.tCarreraBindingNavigatorSaveItem.Name = "tCarreraBindingNavigatorSaveItem";
            this.tCarreraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tCarreraBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tCarreraDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tCarreraDataGridView
            // 
            this.tCarreraDataGridView.AutoGenerateColumns = false;
            this.tCarreraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tCarreraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tCarreraDataGridView.DataSource = this.tCarreraBindingSource;
            this.tCarreraDataGridView.Location = new System.Drawing.Point(3, 6);
            this.tCarreraDataGridView.Name = "tCarreraDataGridView";
            this.tCarreraDataGridView.Size = new System.Drawing.Size(351, 220);
            this.tCarreraDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodCarrera";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodCarrera";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomCarrera";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomCarrera";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 239);
            this.tabControl1.TabIndex = 0;
            // 
            // FormMantieneCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 239);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantieneCarrera";
            this.Text = "FormMantieneCarrera";
            this.Load += new System.EventHandler(this.FormMantieneCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCarreraBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCarreraBindingNavigator)).EndInit();
            this.tCarreraBindingNavigator.ResumeLayout(false);
            this.tCarreraBindingNavigator.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tCarreraDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tCarreraBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.TextBox codCarreraTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nomCarreraTextBox;
        private System.Windows.Forms.BindingNavigator tCarreraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tCarreraBindingNavigatorSaveItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tCarreraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabControl tabControl1;

    }
}