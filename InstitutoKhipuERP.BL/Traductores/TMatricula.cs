using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
    public class TMatricula
    {
        public InstitutoKhipuERP.DAL.TMatricula HaciaTMatricula(InstitutoKhipuERP.BL.Entidades.TMatricula desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TMatricula();
            hacia.CodMatricula = desde.CodMatricula;
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.CodModulo = desde.CodModulo;
            hacia.Semestre = desde.Semestre;
            hacia.Fecha = desde.Fecha;
            return hacia;
        }

        public InstitutoKhipuERP.BL.Entidades.TMatricula HaciaTMatricula(InstitutoKhipuERP.DAL.TMatricula desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TMatricula();
            hacia.CodMatricula = desde.CodMatricula;
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.CodModulo = desde.CodModulo;
            hacia.Semestre = desde.Semestre;
            hacia.Fecha = desde.Fecha;
            return hacia;
        }

        public List<InstitutoKhipuERP.DAL.TMatricula> HaciaTMatricula(List<InstitutoKhipuERP.BL.Entidades.TMatricula> desde)
        {
            return desde.Select(HaciaTMatricula).ToList();
        }

        public List<InstitutoKhipuERP.BL.Entidades.TMatricula> HaciaTMatricula(List<InstitutoKhipuERP.DAL.TMatricula> desde)
        {
            return desde.Select(HaciaTMatricula).ToList();
        }
    }
}
