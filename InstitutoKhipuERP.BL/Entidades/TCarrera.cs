using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Entidades
{
   public partial class TCarrera
    {
        public string CodCarrera { get; set; }
        public string NomCarrera { get; set; }
        public string Descripcion { get; set; }
         public TCarrera()
        {
        }


        public TCarrera(TCarrera obj)
        {
            CodCarrera = obj.CodCarrera;
            NomCarrera = obj.NomCarrera;
            Descripcion = obj.Descripcion;
        }

        #region Metodos sobreescritos
        public override bool Equals(object obj)
        {
            return obj is TCarrera
                && ((TCarrera)obj).CodCarrera == CodCarrera
                && ((TCarrera)obj).NomCarrera == NomCarrera
                && ((TCarrera)obj).Descripcion == Descripcion

            ;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + CodCarrera.GetHashCode();
            hash = (hash * 7) + NomCarrera.GetHashCode();
            hash = (hash * 7) + Descripcion.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            var retorno = "[TCarrera ";
            retorno = retorno + "CodCarrera=" + CodCarrera;
            retorno = retorno + "NomCarrera=" + NomCarrera;
            retorno = retorno + "Descripcion=" + Descripcion;
            return retorno + "]";
        }

        public static bool operator ==(TCarrera obj1, TCarrera obj2)
        {
            return true
                && obj1.CodCarrera == obj2.CodCarrera
                && obj1.NomCarrera == obj2.NomCarrera
                && obj1.Descripcion == obj2.Descripcion

            ;
        }

        public static bool operator !=(TCarrera obj1, TCarrera obj2)
        {
            return obj1.CodCarrera != obj2.CodCarrera
                || obj1.NomCarrera != obj2.NomCarrera
                || obj1.Descripcion != obj2.Descripcion

            ;
        }
        #endregion

        #region Metodos CRUD




        public void Insertar()
        {
            var daTCarrera = new InstitutoKhipuERP.DAL.TCarrera();
            var traductor = new Traductores.TCarrera();
            daTCarrera = traductor.HaciaTCarrera(this);
            daTCarrera.Insertar();
            CodCarrera = daTCarrera.CodCarrera;
        }

        public void Actualizar()
        {
            var daTCarrera = new InstitutoKhipuERP.DAL.TCarrera();
            var traductor = new Traductores.TCarrera();
            daTCarrera = traductor.HaciaTCarrera(this);
            daTCarrera.Actualizar();
        }

        public void Eliminar()
        {
               var daTCarrera = new InstitutoKhipuERP.DAL.TCarrera();
            var traductor = new Traductores.TCarrera();
            daTCarrera = traductor.HaciaTCarrera(this);
            daTCarrera.Eliminar();
        }
        #endregion



    }
}
