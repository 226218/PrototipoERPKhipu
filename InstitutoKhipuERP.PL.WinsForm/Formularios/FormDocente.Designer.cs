namespace InstitutoKhipuERP.PL.WinsForm
{
    partial class FormDocente
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
            System.Windows.Forms.Label codCursoLabel;
            System.Windows.Forms.Label codDocenteLabel;
            System.Windows.Forms.Label codEstudianteLabel;
            System.Windows.Forms.Label codMatriculaLabel;
            System.Windows.Forms.Label codMatriculaSemetreLabel;
            System.Windows.Forms.Label nomCursoLabel;
            System.Windows.Forms.Label notaPromedioLabel;
            System.Windows.Forms.Label semestreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocente));
            this.codCursoTextBox = new System.Windows.Forms.TextBox();
            this.codDocenteTextBox = new System.Windows.Forms.TextBox();
            this.codEstudianteTextBox = new System.Windows.Forms.TextBox();
            this.codMatriculaTextBox = new System.Windows.Forms.TextBox();
            this.codMatriculaSemetreTextBox = new System.Windows.Forms.TextBox();
            this.nomCursoTextBox = new System.Windows.Forms.TextBox();
            this.notaPromedioTextBox = new System.Windows.Forms.TextBox();
            this.semestreTextBox = new System.Windows.Forms.TextBox();
            this.tMatriculaSemetreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMatriculaSemetreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tMatriculaSemetreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pegarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            codCursoLabel = new System.Windows.Forms.Label();
            codDocenteLabel = new System.Windows.Forms.Label();
            codEstudianteLabel = new System.Windows.Forms.Label();
            codMatriculaLabel = new System.Windows.Forms.Label();
            codMatriculaSemetreLabel = new System.Windows.Forms.Label();
            nomCursoLabel = new System.Windows.Forms.Label();
            notaPromedioLabel = new System.Windows.Forms.Label();
            semestreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaSemetreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaSemetreBindingNavigator)).BeginInit();
            this.tMatriculaSemetreBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codCursoLabel
            // 
            codCursoLabel.AutoSize = true;
            codCursoLabel.Location = new System.Drawing.Point(53, 77);
            codCursoLabel.Name = "codCursoLabel";
            codCursoLabel.Size = new System.Drawing.Size(59, 13);
            codCursoLabel.TabIndex = 0;
            codCursoLabel.Text = "Cod Curso:";
            // 
            // codDocenteLabel
            // 
            codDocenteLabel.AutoSize = true;
            codDocenteLabel.Location = new System.Drawing.Point(53, 103);
            codDocenteLabel.Name = "codDocenteLabel";
            codDocenteLabel.Size = new System.Drawing.Size(73, 13);
            codDocenteLabel.TabIndex = 2;
            codDocenteLabel.Text = "Cod Docente:";
            // 
            // codEstudianteLabel
            // 
            codEstudianteLabel.AutoSize = true;
            codEstudianteLabel.Location = new System.Drawing.Point(53, 129);
            codEstudianteLabel.Name = "codEstudianteLabel";
            codEstudianteLabel.Size = new System.Drawing.Size(82, 13);
            codEstudianteLabel.TabIndex = 4;
            codEstudianteLabel.Text = "Cod Estudiante:";
            // 
            // codMatriculaLabel
            // 
            codMatriculaLabel.AutoSize = true;
            codMatriculaLabel.Location = new System.Drawing.Point(53, 155);
            codMatriculaLabel.Name = "codMatriculaLabel";
            codMatriculaLabel.Size = new System.Drawing.Size(75, 13);
            codMatriculaLabel.TabIndex = 6;
            codMatriculaLabel.Text = "Cod Matricula:";
            // 
            // codMatriculaSemetreLabel
            // 
            codMatriculaSemetreLabel.AutoSize = true;
            codMatriculaSemetreLabel.Location = new System.Drawing.Point(53, 54);
            codMatriculaSemetreLabel.Name = "codMatriculaSemetreLabel";
            codMatriculaSemetreLabel.Size = new System.Drawing.Size(117, 13);
            codMatriculaSemetreLabel.TabIndex = 8;
            codMatriculaSemetreLabel.Text = "Cod Matricula Semetre:";
            // 
            // nomCursoLabel
            // 
            nomCursoLabel.AutoSize = true;
            nomCursoLabel.Location = new System.Drawing.Point(53, 182);
            nomCursoLabel.Name = "nomCursoLabel";
            nomCursoLabel.Size = new System.Drawing.Size(62, 13);
            nomCursoLabel.TabIndex = 10;
            nomCursoLabel.Text = "Nom Curso:";
            // 
            // notaPromedioLabel
            // 
            notaPromedioLabel.AutoSize = true;
            notaPromedioLabel.Location = new System.Drawing.Point(53, 208);
            notaPromedioLabel.Name = "notaPromedioLabel";
            notaPromedioLabel.Size = new System.Drawing.Size(80, 13);
            notaPromedioLabel.TabIndex = 12;
            notaPromedioLabel.Text = "Nota Promedio:";
            // 
            // semestreLabel
            // 
            semestreLabel.AutoSize = true;
            semestreLabel.Location = new System.Drawing.Point(53, 234);
            semestreLabel.Name = "semestreLabel";
            semestreLabel.Size = new System.Drawing.Size(54, 13);
            semestreLabel.TabIndex = 14;
            semestreLabel.Text = "Semestre:";
            // 
            // codCursoTextBox
            // 
            this.codCursoTextBox.Location = new System.Drawing.Point(176, 74);
            this.codCursoTextBox.Name = "codCursoTextBox";
            this.codCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codCursoTextBox.TabIndex = 1;
            // 
            // codDocenteTextBox
            // 
            this.codDocenteTextBox.Location = new System.Drawing.Point(176, 100);
            this.codDocenteTextBox.Name = "codDocenteTextBox";
            this.codDocenteTextBox.ReadOnly = true;
            this.codDocenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.codDocenteTextBox.TabIndex = 3;
            // 
            // codEstudianteTextBox
            // 
            this.codEstudianteTextBox.Location = new System.Drawing.Point(176, 126);
            this.codEstudianteTextBox.Name = "codEstudianteTextBox";
            this.codEstudianteTextBox.Size = new System.Drawing.Size(100, 20);
            this.codEstudianteTextBox.TabIndex = 5;
            // 
            // codMatriculaTextBox
            // 
            this.codMatriculaTextBox.Location = new System.Drawing.Point(176, 152);
            this.codMatriculaTextBox.Name = "codMatriculaTextBox";
            this.codMatriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.codMatriculaTextBox.TabIndex = 7;
            // 
            // codMatriculaSemetreTextBox
            // 
            this.codMatriculaSemetreTextBox.Location = new System.Drawing.Point(176, 51);
            this.codMatriculaSemetreTextBox.Name = "codMatriculaSemetreTextBox";
            this.codMatriculaSemetreTextBox.Size = new System.Drawing.Size(100, 20);
            this.codMatriculaSemetreTextBox.TabIndex = 9;
            // 
            // nomCursoTextBox
            // 
            this.nomCursoTextBox.Location = new System.Drawing.Point(176, 179);
            this.nomCursoTextBox.Name = "nomCursoTextBox";
            this.nomCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomCursoTextBox.TabIndex = 11;
            // 
            // notaPromedioTextBox
            // 
            this.notaPromedioTextBox.Location = new System.Drawing.Point(176, 205);
            this.notaPromedioTextBox.Name = "notaPromedioTextBox";
            this.notaPromedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.notaPromedioTextBox.TabIndex = 13;
            // 
            // semestreTextBox
            // 
            this.semestreTextBox.Location = new System.Drawing.Point(176, 231);
            this.semestreTextBox.Name = "semestreTextBox";
            this.semestreTextBox.Size = new System.Drawing.Size(100, 20);
            this.semestreTextBox.TabIndex = 15;
            // 
            // tMatriculaSemetreBindingSource
            // 
            this.tMatriculaSemetreBindingSource.DataSource = typeof(InstitutoKhipuERP.PL.WinsForm.ProxyServicioInstitutoKhipuERP.TMatriculaSemetre);
            // 
            // tMatriculaSemetreBindingNavigator
            // 
            this.tMatriculaSemetreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tMatriculaSemetreBindingNavigator.BindingSource = this.tMatriculaSemetreBindingSource;
            this.tMatriculaSemetreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tMatriculaSemetreBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tMatriculaSemetreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tMatriculaSemetreBindingNavigatorSaveItem,
            this.nuevoToolStripButton,
            this.abrirToolStripButton,
            this.guardarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.cortarToolStripButton,
            this.copiarToolStripButton,
            this.pegarToolStripButton,
            this.toolStripSeparator1,
            this.ayudaToolStripButton});
            this.tMatriculaSemetreBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tMatriculaSemetreBindingNavigator.MoveFirstItem = null;
            this.tMatriculaSemetreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tMatriculaSemetreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tMatriculaSemetreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tMatriculaSemetreBindingNavigator.Name = "tMatriculaSemetreBindingNavigator";
            this.tMatriculaSemetreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tMatriculaSemetreBindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.tMatriculaSemetreBindingNavigator.TabIndex = 16;
            this.tMatriculaSemetreBindingNavigator.Text = "bindingNavigator1";
            this.tMatriculaSemetreBindingNavigator.RefreshItems += new System.EventHandler(this.tMatriculaSemetreBindingNavigator_RefreshItems);
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
            // tMatriculaSemetreBindingNavigatorSaveItem
            // 
            this.tMatriculaSemetreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tMatriculaSemetreBindingNavigatorSaveItem.Enabled = false;
            this.tMatriculaSemetreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tMatriculaSemetreBindingNavigatorSaveItem.Image")));
            this.tMatriculaSemetreBindingNavigatorSaveItem.Name = "tMatriculaSemetreBindingNavigatorSaveItem";
            this.tMatriculaSemetreBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tMatriculaSemetreBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // nuevoToolStripButton
            // 
            this.nuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripButton.Image")));
            this.nuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuevoToolStripButton.Text = "&Nuevo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // guardarToolStripButton
            // 
            this.guardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton.Image")));
            this.guardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton.Name = "guardarToolStripButton";
            this.guardarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.guardarToolStripButton.Text = "&Guardar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cortarToolStripButton
            // 
            this.cortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripButton.Image")));
            this.cortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripButton.Name = "cortarToolStripButton";
            this.cortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cortarToolStripButton.Text = "Cort&ar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            this.pegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pegarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripButton.Image")));
            this.pegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripButton.Name = "pegarToolStripButton";
            this.pegarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pegarToolStripButton.Text = "&Pegar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ayudaToolStripButton
            // 
            this.ayudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ayudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripButton.Image")));
            this.ayudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayudaToolStripButton.Name = "ayudaToolStripButton";
            this.ayudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ayudaToolStripButton.Text = "Ay&uda";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(105, 292);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(308, 292);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FormDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 365);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.tMatriculaSemetreBindingNavigator);
            this.Controls.Add(codCursoLabel);
            this.Controls.Add(this.codCursoTextBox);
            this.Controls.Add(codDocenteLabel);
            this.Controls.Add(this.codDocenteTextBox);
            this.Controls.Add(codEstudianteLabel);
            this.Controls.Add(this.codEstudianteTextBox);
            this.Controls.Add(codMatriculaLabel);
            this.Controls.Add(this.codMatriculaTextBox);
            this.Controls.Add(codMatriculaSemetreLabel);
            this.Controls.Add(this.codMatriculaSemetreTextBox);
            this.Controls.Add(nomCursoLabel);
            this.Controls.Add(this.nomCursoTextBox);
            this.Controls.Add(notaPromedioLabel);
            this.Controls.Add(this.notaPromedioTextBox);
            this.Controls.Add(semestreLabel);
            this.Controls.Add(this.semestreTextBox);
            this.Name = "FormDocente";
            this.Text = "FormDocente";
            this.Load += new System.EventHandler(this.FormDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaSemetreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMatriculaSemetreBindingNavigator)).EndInit();
            this.tMatriculaSemetreBindingNavigator.ResumeLayout(false);
            this.tMatriculaSemetreBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codCursoTextBox;
        private System.Windows.Forms.TextBox codEstudianteTextBox;
        private System.Windows.Forms.TextBox codMatriculaTextBox;
        private System.Windows.Forms.TextBox codMatriculaSemetreTextBox;
        private System.Windows.Forms.TextBox nomCursoTextBox;
        private System.Windows.Forms.TextBox notaPromedioTextBox;
        private System.Windows.Forms.TextBox semestreTextBox;
        private System.Windows.Forms.BindingSource tMatriculaSemetreBindingSource;
        private System.Windows.Forms.BindingNavigator tMatriculaSemetreBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tMatriculaSemetreBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton guardarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton pegarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ayudaToolStripButton;
        public System.Windows.Forms.TextBox codDocenteTextBox;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;

    }
}