using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
    public class TCurso
    {
        public InstitutoKhipuERP.DAL.TCurso HaciaTCurso(InstitutoKhipuERP.BL.Entidades.TCurso desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TCurso();
            hacia.CodCurso = desde.CodCurso;
            hacia.NomCurso = desde.NomCurso;
            hacia.Horas = desde.Horas;
            hacia.Creditos = desde.Creditos;
            hacia.CodModulo = desde.CodModulo;
            return hacia;
        }

        public InstitutoKhipuERP.BL.Entidades.TCurso HaciaTCurso(InstitutoKhipuERP.DAL.TCurso desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TCurso();
            hacia.CodCurso = desde.CodCurso;
            hacia.NomCurso = desde.NomCurso;
            hacia.Horas = desde.Horas;
            hacia.Creditos = desde.Creditos;
            hacia.CodModulo = desde.CodModulo;
            return hacia;
        }

        public List<InstitutoKhipuERP.DAL.TCurso> HaciaTCurso(List<InstitutoKhipuERP.BL.Entidades.TCurso> desde)
        {
            return desde.Select(HaciaTCurso).ToList();
        }

        public List<InstitutoKhipuERP.BL.Entidades.TCurso> HaciaTCurso(List<InstitutoKhipuERP.DAL.TCurso> desde)
        {
            return desde.Select(HaciaTCurso).ToList();
        }
    }
}
