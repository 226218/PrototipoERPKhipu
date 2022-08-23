using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
   public class TDocente
    {
       public static InstitutoKhipuERP.SL.DataContract.TDocente HaciaTDocente(InstitutoKhipuERP.BL.Entidades.TDocente desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TDocente();
            hacia.CodDocente = desde.CodDocente;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            return hacia;
        }

        public static InstitutoKhipuERP.BL.Entidades.TDocente HaciaTDocente(InstitutoKhipuERP.SL.DataContract.TDocente desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TDocente();
            hacia.CodDocente = desde.CodDocente;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            return hacia;
        }
        public  InstitutoKhipuERP.SL.DataContract.TDocente HaciaTDocente1(InstitutoKhipuERP.BL.Entidades.TDocente desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.TDocente();
            hacia.CodDocente = desde.CodDocente;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            return hacia;
        }

        public  InstitutoKhipuERP.BL.Entidades.TDocente HaciaTDocente1(InstitutoKhipuERP.SL.DataContract.TDocente desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.TDocente();
            hacia.CodDocente = desde.CodDocente;
            hacia.Dni = desde.Dni;
            hacia.ApePaterno = desde.ApePaterno;
            hacia.ApeMaterno = desde.ApeMaterno;
            hacia.Nombres = desde.Nombres;
            return hacia;
        }
        public InstitutoKhipuERP.SL.DataContract.ListaTDocente HaciaTDocentes(
             List<InstitutoKhipuERP.BL.Entidades.TDocente> desde)
        {
            var hacia = new SL.DataContract.ListaTDocente();
            hacia.AddRange(desde.Select(HaciaTDocente));
            return hacia;
        }

        public List<InstitutoKhipuERP.BL.Entidades.TDocente> HaciaTDocentes(
            InstitutoKhipuERP.SL.DataContract.ListaTDocente desde)
        {
            return desde.Select(HaciaTDocente).ToList();
        }
    }
}
