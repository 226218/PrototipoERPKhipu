namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    partial class FormMantieneDocente
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
            System.Windows.Forms.Label codDocenteLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantieneDocente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tDocenteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDocenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.apeMaternoTextBox = new System.Windows.Forms.TextBox();
            this.apePaternoTextBox = new System.Windows.Forms.TextBox();
            this.codDocenteTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.tDocenteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tDocenteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            apeMaternoLabel = new System.Windows.Forms.Label();
            apePaternoLabel = new System.Windows.Forms.Label();
            codDocenteLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDocenteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDocenteBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDocenteBindingNavigator)).BeginInit();
            this.tDocenteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // apeMaternoLabel
            // 
            apeMaternoLabel.AutoSize = true;
            apeMaternoLabel.Location = new System.Drawing.Point(58, 108);
            apeMaternoLabel.Name = "apeMaternoLabel";
            apeMaternoLabel.Size = new System.Drawing.Size(71, 13);
            apeMaternoLabel.TabIndex = 21;
            apeMaternoLabel.Text = "Ape Materno:";
            // 
            // apePaternoLabel
            // 
            apePaternoLabel.AutoSize = true;
            apePaternoLabel.Location = new System.Drawing.Point(58, 134);
            apePaternoLabel.Name = "apePaternoLabel";
            apePaternoLabel.Size = new System.Drawing.Size(69, 13);
            apePaternoLabel.TabIndex = 23;
            apePaternoLabel.Text = "Ape Paterno:";
            // 
            // codDocenteLabel
            // 
            codDocenteLabel.AutoSize = true;
            codDocenteLabel.Location = new System.Drawing.Point(58, 78);
            codDocenteLabel.Name = "codDocenteLabel";
            codDocenteLabel.Size = new System.Drawing.Size(73, 13);
            codDocenteLabel.TabIndex = 25;
            codDocenteLabel.Text = "Cod Docente:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(58, 163);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 27;
            dniLabel.Text = "Dni:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(58, 189);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 29;
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
            this.tabControl1.Size = new System.Drawing.Size(490, 336);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tDocenteDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tDocenteDataGridView
            // 
            this.tDocenteDataGridView.AutoGenerateColumns = false;
            this.tDocenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tDocenteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tDocenteDataGridView.DataSource = this.tDocenteBindingSource;
            this.tDocenteDataGridView.Location = new System.Drawing.Point(6, 0);
            this.tDocenteDataGridView.Name = "tDocenteDataGridView";
            this.tDocenteDataGridView.Size = new System.Drawing.Size(473, 255);
            this.tDocenteDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodDocente";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodDocente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dni";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tDocenteBindingSource
            // 
            this.tDocenteBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TDocente);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(apeMaternoLabel);
            this.tabPage2.Controls.Add(this.apeMaternoTextBox);
            this.tabPage2.Controls.Add(apePaternoLabel);
            this.tabPage2.Controls.Add(this.apePaternoTextBox);
            this.tabPage2.Controls.Add(codDocenteLabel);
            this.tabPage2.Controls.Add(this.codDocenteTextBox);
            this.tabPage2.Controls.Add(dniLabel);
            this.tabPage2.Controls.Add(this.dniTextBox);
            this.tabPage2.Controls.Add(nombresLabel);
            this.tabPage2.Controls.Add(this.nombresTextBox);
            this.tabPage2.Controls.Add(this.tDocenteBindingNavigator);
            this.tabPage2.Controls.Add(this.btn_Eliminar);
            this.tabPage2.Controls.Add(this.btn_Actualizar);
            this.tabPage2.Controls.Add(this.btn_Insertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // apeMaternoTextBox
            // 
            this.apeMaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDocenteBindingSource, "ApeMaterno", true));
            this.apeMaternoTextBox.Location = new System.Drawing.Point(137, 105);
            this.apeMaternoTextBox.Name = "apeMaternoTextBox";
            this.apeMaternoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apeMaternoTextBox.TabIndex = 22;
            // 
            // apePaternoTextBox
            // 
            this.apePaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDocenteBindingSource, "ApePaterno", true));
            this.apePaternoTextBox.Location = new System.Drawing.Point(137, 131);
            this.apePaternoTextBox.Name = "apePaternoTextBox";
            this.apePaternoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apePaternoTextBox.TabIndex = 24;
            // 
            // codDocenteTextBox
            // 
            this.codDocenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDocenteBindingSource, "CodDocente", true));
            this.codDocenteTextBox.Location = new System.Drawing.Point(137, 75);
            this.codDocenteTextBox.Name = "codDocenteTextBox";
            this.codDocenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.codDocenteTextBox.TabIndex = 26;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDocenteBindingSource, "Dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(137, 160);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 28;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tDocenteBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(137, 186);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 30;
            // 
            // tDocenteBindingNavigator
            // 
            this.tDocenteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tDocenteBindingNavigator.BindingSource = this.tDocenteBindingSource;
            this.tDocenteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tDocenteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tDocenteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tDocenteBindingNavigatorSaveItem});
            this.tDocenteBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tDocenteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tDocenteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tDocenteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tDocenteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tDocenteBindingNavigator.Name = "tDocenteBindingNavigator";
            this.tDocenteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tDocenteBindingNavigator.Size = new System.Drawing.Size(476, 25);
            this.tDocenteBindingNavigator.TabIndex = 21;
            this.tDocenteBindingNavigator.Text = "bindingNavigator1";
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
            // tDocenteBindingNavigatorSaveItem
            // 
            this.tDocenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tDocenteBindingNavigatorSaveItem.Enabled = false;
            this.tDocenteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tDocenteBindingNavigatorSaveItem.Image")));
            this.tDocenteBindingNavigatorSaveItem.Name = "tDocenteBindingNavigatorSaveItem";
            this.tDocenteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tDocenteBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(280, 228);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(182, 228);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 8;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(87, 228);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 7;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // FormMantieneDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantieneDocente";
            this.Text = "FormMantieneDocente";
            this.Load += new System.EventHandler(this.FormMantieneDocente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tDocenteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDocenteBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tDocenteBindingNavigator)).EndInit();
            this.tDocenteBindingNavigator.ResumeLayout(false);
            this.tDocenteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.DataGridView tDocenteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource tDocenteBindingSource;
        private System.Windows.Forms.TextBox apeMaternoTextBox;
        private System.Windows.Forms.TextBox apePaternoTextBox;
        private System.Windows.Forms.TextBox codDocenteTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.BindingNavigator tDocenteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tDocenteBindingNavigatorSaveItem;
    }
}