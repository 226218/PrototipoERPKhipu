using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
    public class TModuloCarrera
    {
        public static InstitutoKhipuERP.SL.DataContract.TModuloCarrera HaciaTModuloCarrera(InstitutoKhipuERP.BL.Entidades.TModuloCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TModuloCarrera();
            hacia.CodModulo = desde.CodModulo;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NroModulo = desde.NroModulo;
            hacia.Semestre = desde.Semestre;
            return hacia;
        }

        public static InstitutoKhipuERP.BL.Entidades.TModuloCarrera HaciaTModuloCarrera(InstitutoKhipuERP.SL.DataContract.TModuloCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TModuloCarrera();
            hacia.CodModulo = desde.CodModulo;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NroModulo = desde.NroModulo;
            hacia.Semestre = desde.Semestre;
            return hacia;
        }
        public  InstitutoKhipuERP.SL.DataContract.TModuloCarrera HaciaTModuloCarrera1(InstitutoKhipuERP.BL.Entidades.TModuloCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TModuloCarrera();
            hacia.CodModulo = desde.CodModulo;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NroModulo = desde.NroModulo;
            hacia.Semestre = desde.Semestre;
            return hacia;
        }

        public  InstitutoKhipuERP.BL.Entidades.TModuloCarrera HaciaTModuloCarrera1(InstitutoKhipuERP.SL.DataContract.TModuloCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TModuloCarrera();
            hacia.CodModulo = desde.CodModulo;
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NroModulo = desde.NroModulo;
            hacia.Semestre = desde.Semestre;
            return hacia;
        }
        public InstitutoKhipuERP.SL.DataContract.ListaTModuloCarrera HaciaTModuloCarreras(
              List<InstitutoKhipuERP.BL.Entidades.TModuloCarrera> desde)
        {
            var hacia = new SL.DataContract.ListaTModuloCarrera();
            hacia.AddRange(desde.Select(HaciaTModuloCarrera));
            return hacia;
        }

        public List<InstitutoKhipuERP.BL.Entidades.TModuloCarrera> HaciaTModuloCarreras(
            InstitutoKhipuERP.SL.DataContract.ListaTModuloCarrera desde)
        {
            return desde.Select(HaciaTModuloCarrera).ToList();
        }
    }
}
