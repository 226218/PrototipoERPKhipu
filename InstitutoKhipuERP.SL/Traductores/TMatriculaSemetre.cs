using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
   public class TMatriculaSemetre
    {
       public static InstitutoKhipuERP.SL.DataContract.TMatriculaSemetre HaciaTMatriculaSemetre(InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TMatriculaSemetre();

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

       public static InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre HaciaTMatriculaSemetre(InstitutoKhipuERP.SL.DataContract.TMatriculaSemetre desde)
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
       public  InstitutoKhipuERP.SL.DataContract.TMatriculaSemetre HaciaTMatriculaSemetre1(InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre desde)
       {
           var hacia = new InstitutoKhipuERP.SL.DataContract.TMatriculaSemetre();

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

       public  InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre HaciaTMatriculaSemetre1(InstitutoKhipuERP.SL.DataContract.TMatriculaSemetre desde)
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
       public InstitutoKhipuERP.SL.DataContract.ListaTMatriculaSemetre HaciaTMatriculaSemetres(
             List<InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre> desde)
       {
           var hacia = new SL.DataContract.ListaTMatriculaSemetre();
           hacia.AddRange(desde.Select(HaciaTMatriculaSemetre));
           return hacia;
       }

       public List<InstitutoKhipuERP.BL.Entidades.TMatriculaSemetre> HaciaTMatriculaSemetres(
           InstitutoKhipuERP.SL.DataContract.ListaTMatriculaSemetre desde)
       {
           return desde.Select(HaciaTMatriculaSemetre).ToList();
       }
    }
}
