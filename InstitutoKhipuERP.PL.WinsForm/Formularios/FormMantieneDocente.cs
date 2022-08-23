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
    public partial class FormMantieneDocente : Form
    {
        public FormMantieneDocente()
        {
            InitializeComponent();
        }

        private void FormMantieneDocente_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            tDocenteBindingSource.DataSource = driver.SeleccionarTDocentes();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTDocente(codDocenteTextBox.Text,dniTextBox.Text,apePaternoTextBox.Text,apeMaternoTextBox.Text,nombresTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.actualizarTDocente(codDocenteTextBox.Text, dniTextBox.Text, apePaternoTextBox.Text, apeMaternoTextBox.Text, nombresTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.eliminarTDocente(codDocenteTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
            
        }
    }
}
