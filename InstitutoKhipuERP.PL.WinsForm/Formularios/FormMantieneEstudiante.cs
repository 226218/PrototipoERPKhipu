using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoKhipuERP.PL.WinsForm
{
    public partial class FormMantieneEstudiante : Form
    {
        public FormMantieneEstudiante()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTEstudiante(  codEstudianteTextBox.Text,dniTextBox.Text,apePaternoTextBox.Text,apeMaternoTextBox.Text,nombresTextBox.Text, codCarreraTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.actualizarTEstudiante(codEstudianteTextBox.Text, dniTextBox.Text, apePaternoTextBox.Text, apeMaternoTextBox.Text, nombresTextBox.Text, codCarreraTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.eliminarTEstudiante(codEstudianteTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FormMantieneEstudiante_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            tEstudianteBindingSource.DataSource = driver.SeleccionarTEstudiantes();
        }
    }
}
