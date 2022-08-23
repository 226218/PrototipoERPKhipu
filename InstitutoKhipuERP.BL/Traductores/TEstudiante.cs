using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
   public class TEstudiante
    {
       public InstitutoKhipuERP.DAL.TEstudiante HaciaTEstudiante(InstitutoKhipuERP.BL.Entidades.TEstudiante desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TEstudiante();
            hacia.CodEstudiante = desde.CodEstudiante;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            hacia.CodCarrera = desde.CodCarrera;
            return hacia;
        }

       public InstitutoKhipuERP.BL.Entidades.TEstudiante HaciaTEstudiante(InstitutoKhipuERP.DAL.TEstudiante desde)
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

       public List<InstitutoKhipuERP.DAL.TEstudiante> HaciaTEstudiante(List<InstitutoKhipuERP.BL.Entidades.TEstudiante> desde)
        {
            return desde.Select(HaciaTEstudiante).ToList();
        }

       public List<InstitutoKhipuERP.BL.Entidades.TEstudiante> HaciaTEstudiante(List<InstitutoKhipuERP.DAL.TEstudiante> desde)
        {
            return desde.Select(HaciaTEstudiante).ToList();
        }
    }
}
