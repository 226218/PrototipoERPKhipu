using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
   public class TDocente
    {
       public InstitutoKhipuERP.DAL.TDocente HaciaTDocente(InstitutoKhipuERP.BL.Entidades.TDocente desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TDocente();
          hacia.CodDocente = desde.CodDocente;
          hacia.Dni = desde.Dni;
          hacia.ApePaterno = desde.ApePaterno;
          hacia.ApeMaterno = desde.ApeMaterno;
          hacia.Nombres = desde.Nombres;
            return hacia;
        }

       public InstitutoKhipuERP.BL.Entidades.TDocente HaciaTDocente(InstitutoKhipuERP.DAL.TDocente desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TDocente();
            hacia.CodDocente = desde.CodDocente;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            return hacia;
        }

       public List<InstitutoKhipuERP.DAL.TDocente> HaciaTDocente(List<InstitutoKhipuERP.BL.Entidades.TDocente> desde)
        {
            return desde.Select(HaciaTDocente).ToList();
        }

       public List<InstitutoKhipuERP.BL.Entidades.TDocente> HaciaTDocente(List<InstitutoKhipuERP.DAL.TDocente> desde)
        {
            return desde.Select(HaciaTDocente).ToList();
        }
    }
}
