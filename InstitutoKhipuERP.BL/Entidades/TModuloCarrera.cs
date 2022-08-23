using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Entidades
{
  public partial  class TModuloCarrera
    {
        public string CodModulo { get; set; }
        public string CodCarrera { get; set; }
        public Nullable<int> NroModulo { get; set; }
        public string Semestre { get; set; }

      public TModuloCarrera()
      { }
        public TModuloCarrera(TModuloCarrera obj)
        {

            CodModulo = obj.CodModulo;
            CodCarrera = obj.CodCarrera;
            NroModulo = obj.NroModulo;
            Semestre = obj.Semestre;

        }

        #region Metodos sobreescritos
        public override bool Equals(object obj)
        {
            return obj is TModuloCarrera
                && ((TModuloCarrera)obj).CodModulo == CodModulo
                && ((TModuloCarrera)obj).CodCarrera == CodCarrera
                && ((TModuloCarrera)obj).NroModulo == NroModulo
              && ((TModuloCarrera)obj).Semestre == Semestre


            ;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + CodModulo.GetHashCode();
            hash = (hash * 7) + CodCarrera.GetHashCode();
            hash = (hash * 7) + NroModulo.GetHashCode();
            hash = (hash * 7) + Semestre.GetHashCode();


            return hash;
        }

        public override string ToString()
        {
            var retorno = "[TModuloCarrera ";
            retorno = retorno + "CodModulo=" + CodModulo;
            retorno = retorno + "CodCarrera=" + CodCarrera;
            retorno = retorno + "NroModulo=" + NroModulo;
            retorno = retorno + "Semestre=" + Semestre;

            return retorno + "]";
        }

        public static bool operator ==(TModuloCarrera obj1, TModuloCarrera obj2)
        {
            return true
                && obj1.CodModulo == obj2.CodModulo
                && obj1.CodCarrera == obj2.CodCarrera
                && obj1.NroModulo == obj2.NroModulo
                && obj1.Semestre == obj2.Semestre



            ;
        }

        public static bool operator !=(TModuloCarrera obj1, TModuloCarrera obj2)
        {
            return obj1.CodModulo != obj2.CodModulo
                || obj1.CodCarrera != obj2.CodCarrera
                || obj1.NroModulo != obj2.NroModulo
                 || obj1.Semestre != obj2.Semestre


            ;
        }
        #endregion

        #region Metodos CRUD
        public void Insertar()
        {
            var daTModuloCarrera = new InstitutoKhipuERP.DAL.TModuloCarrera();
            var traductor = new Traductores.TModuloCarrera();
            daTModuloCarrera = traductor.HaciaTModuloCarrera(this);
            daTModuloCarrera.Insertar();
            CodModulo = daTModuloCarrera.CodModulo;
        }

        public void Actualizar()
        {
            var daTModuloCarrera = new InstitutoKhipuERP.DAL.TModuloCarrera();
            var traductor = new Traductores.TModuloCarrera();
            daTModuloCarrera = traductor.HaciaTModuloCarrera(this);
            daTModuloCarrera.Actualizar();
        }

        public void Eliminar()
        {
            var daTModuloCarrera = new InstitutoKhipuERP.DAL.TModuloCarrera();
            var traductor = new Traductores.TModuloCarrera();
            daTModuloCarrera = traductor.HaciaTModuloCarrera(this);
            daTModuloCarrera.Eliminar();
        }
        #endregion
    }
}
