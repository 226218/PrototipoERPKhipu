using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
  public  class TModuloCarrera
    {
      public InstitutoKhipuERP.DAL.TModuloCarrera HaciaTModuloCarrera(InstitutoKhipuERP.BL.Entidades.TModuloCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TModuloCarrera();
            hacia.CodModulo = desde.CodModulo;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NroModulo = desde.NroModulo;
            hacia.Semestre = desde.Semestre;
            return hacia;
        }

      public InstitutoKhipuERP.BL.Entidades.TModuloCarrera HaciaTModuloCarrera(InstitutoKhipuERP.DAL.TModuloCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TModuloCarrera();
            hacia.CodModulo = desde.CodModulo;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NroModulo = desde.NroModulo;
            hacia.Semestre = desde.Semestre;
            return hacia;
        }

      public List<InstitutoKhipuERP.DAL.TModuloCarrera> HaciaTModuloCarrera(List<InstitutoKhipuERP.BL.Entidades.TModuloCarrera> desde)
        {
            return desde.Select(HaciaTModuloCarrera).ToList();
        }

      public List<InstitutoKhipuERP.BL.Entidades.TModuloCarrera> HaciaTModuloCarrera(List<InstitutoKhipuERP.DAL.TModuloCarrera> desde)
        {
            return desde.Select(HaciaTModuloCarrera).ToList();
        }
    }
}
