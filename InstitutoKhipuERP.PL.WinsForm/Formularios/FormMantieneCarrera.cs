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
    public partial class FormMantieneCarrera : Form
    {
        public FormMantieneCarrera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTCarrera(codCarreraTextBox.Text, nomCarreraTextBox.Text, descripcionTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.actualizarTCarrera(codCarreraTextBox.Text, nomCarreraTextBox.Text, descripcionTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
        
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.eliminarTCarrera(codCarreraTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
        
        }

        private void FormMantieneCarrera_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            tCarreraBindingSource.DataSource = driver.SeleccionarTCarreras();
        }

    }
}
