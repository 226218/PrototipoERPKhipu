﻿namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    partial class FormMantieneModulo
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
            System.Windows.Forms.Label codModuloLabel;
            System.Windows.Forms.Label nroModuloLabel;
            System.Windows.Forms.Label semestreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantieneModulo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tModuloCarreraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tModuloCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.codCarreraTextBox = new System.Windows.Forms.TextBox();
            this.codModuloTextBox = new System.Windows.Forms.TextBox();
            this.nroModuloTextBox = new System.Windows.Forms.TextBox();
            this.semestreTextBox = new System.Windows.Forms.TextBox();
            this.tModuloCarreraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tModuloCarreraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            codCarreraLabel = new System.Windows.Forms.Label();
            codModuloLabel = new System.Windows.Forms.Label();
            nroModuloLabel = new System.Windows.Forms.Label();
            semestreLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tModuloCarreraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tModuloCarreraBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tModuloCarreraBindingNavigator)).BeginInit();
            this.tModuloCarreraBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codCarreraLabel
            // 
            codCarreraLabel.AutoSize = true;
            codCarreraLabel.Location = new System.Drawing.Point(26, 62);
            codCarreraLabel.Name = "codCarreraLabel";
            codCarreraLabel.Size = new System.Drawing.Size(66, 13);
            codCarreraLabel.TabIndex = 10;
            codCarreraLabel.Text = "Cod Carrera:";
            // 
            // codModuloLabel
            // 
            codModuloLabel.AutoSize = true;
            codModuloLabel.Location = new System.Drawing.Point(26, 88);
            codModuloLabel.Name = "codModuloLabel";
            codModuloLabel.Size = new System.Drawing.Size(67, 13);
            codModuloLabel.TabIndex = 12;
            codModuloLabel.Text = "Cod Modulo:";
            // 
            // nroModuloLabel
            // 
            nroModuloLabel.AutoSize = true;
            nroModuloLabel.Location = new System.Drawing.Point(26, 114);
            nroModuloLabel.Name = "nroModuloLabel";
            nroModuloLabel.Size = new System.Drawing.Size(65, 13);
            nroModuloLabel.TabIndex = 14;
            nroModuloLabel.Text = "Nro Modulo:";
            // 
            // semestreLabel
            // 
            semestreLabel.AutoSize = true;
            semestreLabel.Location = new System.Drawing.Point(26, 140);
            semestreLabel.Name = "semestreLabel";
            semestreLabel.Size = new System.Drawing.Size(54, 13);
            semestreLabel.TabIndex = 16;
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
            this.tabControl1.Size = new System.Drawing.Size(463, 320);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.tModuloCarreraDataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(455, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tModuloCarreraDataGridView
            // 
            this.tModuloCarreraDataGridView.AutoGenerateColumns = false;
            this.tModuloCarreraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tModuloCarreraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tModuloCarreraDataGridView.DataSource = this.tModuloCarreraBindingSource;
            this.tModuloCarreraDataGridView.Location = new System.Drawing.Point(8, 72);
            this.tModuloCarreraDataGridView.Name = "tModuloCarreraDataGridView";
            this.tModuloCarreraDataGridView.Size = new System.Drawing.Size(443, 220);
            this.tModuloCarreraDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodCarrera";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodCarrera";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodModulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodModulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NroModulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "NroModulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Semestre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Semestre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tModuloCarreraBindingSource
            // 
            this.tModuloCarreraBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TModuloCarrera);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Traer Carreras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(codCarreraLabel);
            this.tabPage2.Controls.Add(this.codCarreraTextBox);
            this.tabPage2.Controls.Add(codModuloLabel);
            this.tabPage2.Controls.Add(this.codModuloTextBox);
            this.tabPage2.Controls.Add(nroModuloLabel);
            this.tabPage2.Controls.Add(this.nroModuloTextBox);
            this.tabPage2.Controls.Add(semestreLabel);
            this.tabPage2.Controls.Add(this.semestreTextBox);
            this.tabPage2.Controls.Add(this.tModuloCarreraBindingNavigator);
            this.tabPage2.Controls.Add(this.btn_Eliminar);
            this.tabPage2.Controls.Add(this.btn_Actualizar);
            this.tabPage2.Controls.Add(this.btn_Insertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(455, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // codCarreraTextBox
            // 
            this.codCarreraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tModuloCarreraBindingSource, "CodCarrera", true));
            this.codCarreraTextBox.Location = new System.Drawing.Point(99, 59);
            this.codCarreraTextBox.Name = "codCarreraTextBox";
            this.codCarreraTextBox.Size = new System.Drawing.Size(100, 20);
            this.codCarreraTextBox.TabIndex = 11;
            // 
            // codModuloTextBox
            // 
            this.codModuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tModuloCarreraBindingSource, "CodModulo", true));
            this.codModuloTextBox.Location = new System.Drawing.Point(99, 85);
            this.codModuloTextBox.Name = "codModuloTextBox";
            this.codModuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.codModuloTextBox.TabIndex = 13;
            // 
            // nroModuloTextBox
            // 
            this.nroModuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tModuloCarreraBindingSource, "NroModulo", true));
            this.nroModuloTextBox.Location = new System.Drawing.Point(99, 111);
            this.nroModuloTextBox.Name = "nroModuloTextBox";
            this.nroModuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.nroModuloTextBox.TabIndex = 15;
            // 
            // semestreTextBox
            // 
            this.semestreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tModuloCarreraBindingSource, "Semestre", true));
            this.semestreTextBox.Location = new System.Drawing.Point(99, 137);
            this.semestreTextBox.Name = "semestreTextBox";
            this.semestreTextBox.Size = new System.Drawing.Size(100, 20);
            this.semestreTextBox.TabIndex = 17;
            // 
            // tModuloCarreraBindingNavigator
            // 
            this.tModuloCarreraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tModuloCarreraBindingNavigator.BindingSource = this.tModuloCarreraBindingSource;
            this.tModuloCarreraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tModuloCarreraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tModuloCarreraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tModuloCarreraBindingNavigatorSaveItem});
            this.tModuloCarreraBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.tModuloCarreraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tModuloCarreraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tModuloCarreraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tModuloCarreraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tModuloCarreraBindingNavigator.Name = "tModuloCarreraBindingNavigator";
            this.tModuloCarreraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tModuloCarreraBindingNavigator.Size = new System.Drawing.Size(449, 25);
            this.tModuloCarreraBindingNavigator.TabIndex = 10;
            this.tModuloCarreraBindingNavigator.Text = "bindingNavigator1";
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
            // tModuloCarreraBindingNavigatorSaveItem
            // 
            this.tModuloCarreraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tModuloCarreraBindingNavigatorSaveItem.Enabled = false;
            this.tModuloCarreraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tModuloCarreraBindingNavigatorSaveItem.Image")));
            this.tModuloCarreraBindingNavigatorSaveItem.Name = "tModuloCarreraBindingNavigatorSaveItem";
            this.tModuloCarreraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tModuloCarreraBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(279, 222);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(181, 222);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 8;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.Location = new System.Drawing.Point(87, 222);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 7;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // FormMantieneModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 320);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantieneModulo";
            this.Text = "FormMantieneModulo";
            this.Load += new System.EventHandler(this.FormMantieneModulo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tModuloCarreraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tModuloCarreraBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tModuloCarreraBindingNavigator)).EndInit();
            this.tModuloCarreraBindingNavigator.ResumeLayout(false);
            this.tModuloCarreraBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tModuloCarreraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tModuloCarreraBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox codCarreraTextBox;
        private System.Windows.Forms.TextBox codModuloTextBox;
        private System.Windows.Forms.TextBox nroModuloTextBox;
        private System.Windows.Forms.TextBox semestreTextBox;
        private System.Windows.Forms.BindingNavigator tModuloCarreraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tModuloCarreraBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Insertar;
    }
}