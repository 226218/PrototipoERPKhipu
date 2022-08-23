using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
    public class TCarrera
    {
        public InstitutoKhipuERP.DAL.TCarrera HaciaTCarrera(InstitutoKhipuERP.BL.Entidades.TCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.TCarrera();
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NomCarrera = desde.NomCarrera;
            hacia.Descripcion = desde.Descripcion;
            return hacia;
        }

        public InstitutoKhipuERP.BL.Entidades.TCarrera HaciaTCarrera(InstitutoKhipuERP.DAL.TCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TCarrera();
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NomCarrera = desde.NomCarrera;
            hacia.Descripcion = desde.Descripcion;
            return hacia;
        }

        public List<InstitutoKhipuERP.DAL.TCarrera> HaciaTCarrera(List<InstitutoKhipuERP.BL.Entidades.TCarrera> desde)
        {
            return desde.Select(HaciaTCarrera).ToList();
        }

        public List<InstitutoKhipuERP.BL.Entidades.TCarrera> HaciaTCarrera(List<InstitutoKhipuERP.DAL.TCarrera> desde)
        {
            return desde.Select(HaciaTCarrera).ToList();
        }
    }
}
