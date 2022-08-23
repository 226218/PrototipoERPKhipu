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
    public partial class FormAdministrativo : Form
    {
        public FormAdministrativo()
        {
            InitializeComponent();
        }

        private void FormAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void btn_TCarrera_Click(object sender, EventArgs e)
        {
            Formularios.FormMantieneCarrera carr = new Formularios.FormMantieneCarrera();
            carr.ShowDialog();
        }

        private void btn_TDocente_Click(object sender, EventArgs e)
        {
            Formularios.FormMantieneDocente doce = new Formularios.FormMantieneDocente();
            doce.ShowDialog();
        }

        private void btn_TEstudiante_Click(object sender, EventArgs e)
        {
            FormMantieneEstudiante estd = new FormMantieneEstudiante();
            estd.ShowDialog();
        }

        private void btn_TCurso_Click(object sender, EventArgs e)
        {

            Formularios.FormMantieneDocente doce = new Formularios.FormMantieneDocente();
            doce.ShowDialog();
        }

        private void btn_TMatricula_Click(object sender, EventArgs e)
        {
            Formularios.FormMantieneMatriculas matri = new Formularios.FormMantieneMatriculas();
            matri.ShowDialog();
        }

        private void btn_TModuloCarrera_Click(object sender, EventArgs e)
        {
            Formularios.FormMantieneModulo modu = new Formularios.FormMantieneModulo();
            modu.ShowDialog();
        }
    }
}
