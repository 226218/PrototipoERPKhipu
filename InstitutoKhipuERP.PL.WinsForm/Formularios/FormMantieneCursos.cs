using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoKhipuERP.PL.WinsForm.Formularios
{
    public partial class FormMantieneCursos : Form
    {
        public FormMantieneCursos()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTCurso(codCursoTextBox.Text, nomCursoTextBox.Text, Convert.ToInt32(horasTextBox.Text), Convert.ToInt32(creditosTextBox.Text), codModuloTextBox.Text, codCarreraTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
        
        }

        private void FormMantieneCursos_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            tCursoBindingSource.DataSource = driver.SeleccionarTCursos();
        
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.actualizarTCurso(codCursoTextBox.Text, nomCursoTextBox.Text, Convert.ToInt32(horasTextBox.Text), Convert.ToInt32(creditosTextBox.Text), codModuloTextBox.Text, codCarreraTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.eliminarTCurso(codCursoTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
            
        }
    }
}
