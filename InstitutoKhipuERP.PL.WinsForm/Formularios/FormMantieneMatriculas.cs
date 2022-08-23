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
    public partial class FormMantieneMatriculas : Form
    {
        public FormMantieneMatriculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTMatricula(codMatriculaTextBox.Text,codEstudianteTextBox.Text,codCarreraTextBox.Text,codModuloTextBox.Text,semestreTextBox.Text,Convert.ToDateTime(fechaDateTimePicker.Text));
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void FormMantieneMatriculas_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            tMatriculaBindingSource.DataSource = driver.SeleccionarTMatriculas();
        
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.actualizarTMatricula(codMatriculaTextBox.Text, codEstudianteTextBox.Text, codCarreraTextBox.Text, codModuloTextBox.Text, semestreTextBox.Text, Convert.ToDateTime(fechaDateTimePicker.Text));
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.eliminarTMatricula(codMatriculaTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }
    }
}
