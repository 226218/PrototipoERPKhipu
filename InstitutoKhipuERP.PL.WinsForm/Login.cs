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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FormEstudiante fom = new Formularios.FormEstudiante();
            
            string tipo;
            var driver = new DrvServicioInstitutoKhipuERP();
            tipo=driver.ingresar(textBox1.Text, textBox2.Text);

            
            if (tipo == "Estudiante")
            {
                var FormEstudia = new Formularios.FormEstudiante();
                fom.coduser = textBox1.Text;
                FormEstudia.ShowDialog();
            
            
            }
            if (tipo == "Administrativo")
            {
                var FormAdministrador = new FormAdministrativo();
                FormAdministrador.ShowDialog();

            }
            if (tipo == "Docente")
            {
                var FormDocente = new FormDocente();
                FormDocente.codDocenteTextBox.Text = textBox1.Text;
                FormDocente.ShowDialog();

            }

        
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
