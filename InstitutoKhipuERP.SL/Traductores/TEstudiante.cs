using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
   public class TEstudiante
    {
       public static InstitutoKhipuERP.SL.DataContract.TEstudiante HaciaTEstudiante(InstitutoKhipuERP.BL.Entidades.TEstudiante desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TEstudiante();
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            hacia.CodCarrera = desde.CodCarrera;
            return hacia;
        }

       public static InstitutoKhipuERP.BL.Entidades.TEstudiante HaciaTEstudiante(InstitutoKhipuERP.SL.DataContract.TEstudiante desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TEstudiante();
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            hacia.CodCarrera = desde.CodCarrera;
            return hacia;
        }
       public  InstitutoKhipuERP.SL.DataContract.TEstudiante HaciaTEstudiante1(InstitutoKhipuERP.BL.Entidades.TEstudiante desde)
       {
           var hacia = new InstitutoKhipuERP.SL.DataContract.TEstudiante();
           hacia.CodEstudiante = desde.CodEstudiante;
           hacia.Dni = desde.Dni;
           hacia.ApePaterno = desde.ApePaterno;
           hacia.ApeMaterno = desde.ApeMaterno;
           hacia.Nombres = desde.Nombres;
           hacia.CodCarrera = desde.CodCarrera;
           return hacia;
       }

       public  InstitutoKhipuERP.BL.Entidades.TEstudiante HaciaTEstudiante1(InstitutoKhipuERP.SL.DataContract.TEstudiante desde)
       {
           var hacia = new InstitutoKhipuERP.BL.Entidades.TEstudiante();
           hacia.CodEstudiante = desde.CodEstudiante;
           hacia.Dni = desde.Dni;
           hacia.ApePaterno = desde.ApePaterno;
           hacia.ApeMaterno = desde.ApeMaterno;
           hacia.Nombres = desde.Nombres;
           hacia.CodCarrera = desde.CodCarrera;
           return hacia;
       }
       public InstitutoKhipuERP.SL.DataContract.ListaTEstudiante HaciaTEstudiantes(
              List<InstitutoKhipuERP.BL.Entidades.TEstudiante> desde)
       {
           var hacia = new SL.DataContract.ListaTEstudiante();
           hacia.AddRange(desde.Select(HaciaTEstudiante));
           return hacia;
       }

       public List<InstitutoKhipuERP.BL.Entidades.TEstudiante> HaciaTEstudiantes(
           InstitutoKhipuERP.SL.DataContract.ListaTEstudiante desde)
       {
           return desde.Select(HaciaTEstudiante).ToList();
       }
    }
}
