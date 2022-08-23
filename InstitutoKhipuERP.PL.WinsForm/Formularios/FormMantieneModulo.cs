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
    public partial class FormMantieneModulo : Form
    {
        public FormMantieneModulo()
        {
            InitializeComponent();
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTModuloCarrera(codModuloTextBox.Text,codCarreraTextBox.Text,Convert.ToInt32( nroModuloTextBox.Text),semestreTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void FormMantieneModulo_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            tModuloCarreraBindingSource.DataSource = driver.SeleccionarTModuloCarreras();
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.actualizarTModuloCarrera(codModuloTextBox.Text, codCarreraTextBox.Text, Convert.ToInt32(nroModuloTextBox.Text), semestreTextBox.Text);
            MessageBox.Show("Se realizo la inserccion exitosamente");
           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.eliminarTModuloCarrera(codModuloTextBox.Text);
     
        }
    }
}
