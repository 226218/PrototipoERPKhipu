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
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var driver = new DrvServicioInstitutoKhipuERP();
            driver.insertarTMatricula(codMatriculaTextBox.Text, codEstudianteTextBox.Text, codCarreraTextBox.Text, codModuloTextBox.Text, semestreTextBox.Text, Convert.ToDateTime(fechaDateTimePicker.Text));
            MessageBox.Show("Se realizo la Matricula exitosamente");
           
        }

        private void Matricula_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
