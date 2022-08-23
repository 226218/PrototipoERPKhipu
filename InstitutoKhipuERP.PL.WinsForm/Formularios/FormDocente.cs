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
    public partial class FormDocente : Form
    {
        public FormDocente()
        {
            InitializeComponent();
        }

        private void FormDocente_Load(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
        }

        private void tMatriculaSemetreBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTMatriculaSemetre(codMatriculaSemetreTextBox.Text, codMatriculaTextBox.Text, codEstudianteTextBox.Text, codCursoTextBox.Text, codDocenteTextBox.Text, semestreTextBox.Text, nomCursoTextBox.Text,Convert.ToInt32( notaPromedioTextBox.Text));

           
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
