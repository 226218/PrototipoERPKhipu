using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
   public class TMatricula
    {
       public static InstitutoKhipuERP.SL.DataContract.TMatricula HaciaTMatricula(InstitutoKhipuERP.BL.Entidades.TMatricula desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TMatricula();
            hacia.CodMatricula = desde.CodMatricula;
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.CodModulo = desde.CodModulo;
            hacia.Semestre = desde.Semestre;
            hacia.Fecha = desde.Fecha;
            return hacia;
        }

       public static InstitutoKhipuERP.BL.Entidades.TMatricula HaciaTMatricula(InstitutoKhipuERP.SL.DataContract.TMatricula desde)
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
       public  InstitutoKhipuERP.SL.DataContract.TMatricula HaciaTMatricula1(InstitutoKhipuERP.BL.Entidades.TMatricula desde)
       {
           var hacia = new InstitutoKhipuERP.SL.DataContract.TMatricula();
           hacia.CodMatricula = desde.CodMatricula;
           hacia.CodEstudiante = desde.CodEstudiante;
           hacia.CodCarrera = desde.CodCarrera;
           hacia.CodModulo = desde.CodModulo;
           hacia.Semestre = desde.Semestre;
           hacia.Fecha = desde.Fecha;
           return hacia;
       }

       public  InstitutoKhipuERP.BL.Entidades.TMatricula HaciaTMatricula1(InstitutoKhipuERP.SL.DataContract.TMatricula desde)
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
       public InstitutoKhipuERP.SL.DataContract.ListaTMatricula HaciaTMatriculas(
             List<InstitutoKhipuERP.BL.Entidades.TMatricula> desde)
       {
           var hacia = new SL.DataContract.ListaTMatricula();
           hacia.AddRange(desde.Select(HaciaTMatricula));
           return hacia;
       }

       public List<InstitutoKhipuERP.BL.Entidades.TMatricula> HaciaTMatriculas(
           InstitutoKhipuERP.SL.DataContract.ListaTMatricula desde)
       {
           return desde.Select(HaciaTMatricula).ToList();
       }
    }
}
