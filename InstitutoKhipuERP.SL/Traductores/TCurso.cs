using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
    public class TCurso
    {
        public static InstitutoKhipuERP.SL.DataContract.TCurso HaciaTCurso(InstitutoKhipuERP.BL.Entidades.TCurso desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TCurso();
            hacia.CodCurso = desde.CodCurso;
            hacia.NomCurso = desde.NomCurso;
            hacia.Horas = desde.Horas;
            hacia.Creditos = desde.Creditos;
            hacia.CodModulo = desde.CodModulo;
            return hacia;
        }

        public static InstitutoKhipuERP.BL.Entidades.TCurso HaciaTCurso(InstitutoKhipuERP.SL.DataContract.TCurso desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TCurso();
            hacia.CodCurso = desde.CodCurso;
            hacia.NomCurso = desde.NomCurso;
            hacia.Horas = desde.Horas;
            hacia.Creditos = desde.Creditos;
            hacia.CodModulo = desde.CodModulo;
            return hacia;
        }
        public  InstitutoKhipuERP.SL.DataContract.TCurso HaciaTCurso1(InstitutoKhipuERP.BL.Entidades.TCurso desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TCurso();
            hacia.CodCurso = desde.CodCurso;
            hacia.NomCurso = desde.NomCurso;
            hacia.Horas = desde.Horas;
            hacia.Creditos = desde.Creditos;
            hacia.CodModulo = desde.CodModulo;
            return hacia;
        }

        public  InstitutoKhipuERP.BL.Entidades.TCurso HaciaTCurso1(InstitutoKhipuERP.SL.DataContract.TCurso desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TCurso();
            hacia.CodCurso = desde.CodCurso;
            hacia.NomCurso = desde.NomCurso;
            hacia.Horas = desde.Horas;
            hacia.Creditos = desde.Creditos;
            hacia.CodModulo = desde.CodModulo;
            return hacia;
        }

        public InstitutoKhipuERP.SL.DataContract.ListaTCurso HaciaTCursos(
              List<InstitutoKhipuERP.BL.Entidades.TCurso> desde)
        {
            var hacia = new SL.DataContract.ListaTCurso();
            hacia.AddRange(desde.Select(HaciaTCurso));
            return hacia;
        }

        public List<InstitutoKhipuERP.BL.Entidades.TCurso> HaciaTCursos(
            InstitutoKhipuERP.SL.DataContract.ListaTCurso desde)
        {
            return desde.Select(HaciaTCurso).ToList();
        }

    }
}
