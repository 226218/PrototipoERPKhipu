using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
    public class TMatriculaSemetre
    {
        public InstitutoKhipuERP.DAL.TMatriculaSemetre HaciaTMatriculaSemetre(InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TMatriculaSemetre();

            hacia.CodMatriculaSemetre = desde.CodMatriculaSemetre;
            hacia.CodMatricula = desde.CodMatricula;
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.CodCurso = desde.CodCurso;
            hacia.CodDocente = desde.CodDocente;
            hacia.Semestre = desde.Semestre;
            hacia.NomCurso = desde.NomCurso;
            hacia.NotaPromedio = desde.NotaPromedio;
            return hacia;
        }

        public InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre HaciaTMatriculaSemetre(InstitutoKhipuERP.DAL.TMatriculaSemetre desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre();
            hacia.CodMatriculaSemetre = desde.CodMatriculaSemetre;
            hacia.CodMatricula = desde.CodMatricula;
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.CodCurso = desde.CodCurso;
            hacia.CodDocente = desde.CodDocente;
            hacia.Semestre = desde.Semestre;
            hacia.NomCurso = desde.NomCurso;
            hacia.NotaPromedio = desde.NotaPromedio;
            return hacia;
        }

        public List<InstitutoKhipuERP.DAL.TMatriculaSemetre> HaciaTMatriculaSemetre(List<InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre> desde)
        {
            return desde.Select(HaciaTMatriculaSemetre).ToList();
        }

        public List<InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre> HaciaTMatriculaSemetre(List<InstitutoKhipuERP.DAL.TMatriculaSemetre> desde)
        {
            return desde.Select(HaciaTMatriculaSemetre).ToList();
        }
    }
}
