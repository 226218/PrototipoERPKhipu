using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;

namespace InstitutoKhipuERP.SL.Traductores
{
   public class TCarrera
    {
        public static InstitutoKhipuERP.SL.DataContract.TCarrera HaciaTCarrera(InstitutoKhipuERP.BL.Entidades.TCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TCarrera();
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NomCarrera = desde.NomCarrera;
            hacia.Descripcion = desde.Descripcion;
            return hacia;
        }

        public static InstitutoKhipuERP.BL.Entidades.TCarrera HaciaTCarrera(InstitutoKhipuERP.SL.DataContract.TCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TCarrera();
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NomCarrera = desde.NomCarrera;
            hacia.Descripcion = desde.Descripcion;
            return hacia;
        }
        public  InstitutoKhipuERP.SL.DataContract.TCarrera HaciaTCarrera1(InstitutoKhipuERP.BL.Entidades.TCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TCarrera();
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NomCarrera = desde.NomCarrera;
            hacia.Descripcion = desde.Descripcion;
            return hacia;
        }

        public  InstitutoKhipuERP.BL.Entidades.TCarrera HaciaTCarrera1(InstitutoKhipuERP.SL.DataContract.TCarrera desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TCarrera();
            hacia.CodCarrera = desde.CodCarrera;
            hacia.NomCarrera = desde.NomCarrera;
            hacia.Descripcion = desde.Descripcion;
            return hacia;
        }

        public InstitutoKhipuERP.SL.DataContract.ListaTCarrera HaciaTCarreras(
              List<InstitutoKhipuERP.BL.Entidades.TCarrera> desde)
        {
            var hacia = new SL.DataContract.ListaTCarrera();
            hacia.AddRange(desde.Select(HaciaTCarrera));
            return hacia;
        }

        public List<InstitutoKhipuERP.BL.Entidades.TCarrera> HaciaTCarreras(
            InstitutoKhipuERP.SL.DataContract.ListaTCarrera desde)
        {
            return desde.Select(HaciaTCarrera).ToList();
        }

    }
}
