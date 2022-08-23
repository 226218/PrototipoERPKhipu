using Microsoft.Reporting.WinForms;
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
    public partial class FormEstudiante : Form
    {
        public FormEstudiante()
        {
            InitializeComponent();
        }
        public string coduser;
       
        public string codMatricula;
        private void button1_Click(object sender, EventArgs e)
        {

            var nota = new Formularios.Notas();
            nota.reportViewer1.RefreshReport();

            var driver = new DrvServicioInstitutoKhipuERP();
            var lista = driver.SeleccionarTMatriculaSemetre(coduser);
            var reportData = new ReportDataSource("DataSet1", lista);//driver.seleccionarx();
            //((BindingSource)reportData.Value).DataMember = "dsCategorias";
            nota.reportViewer1.LocalReport.ReportPath = @"C:\Users\user\Desktop\InstitutoKhipuERP\InstitutoKhipuERP.PL.WinsForm\Formularios\ReporteNota.rdlc";
            nota.reportViewer1.LocalReport.DataSources.Add(reportData);
            nota.reportViewer1.ProcessingMode = ProcessingMode.Local;
            nota.reportViewer1.RefreshReport();
            nota.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.Matricula matri = new Formularios.Matricula();
            matri.ShowDialog();
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}
