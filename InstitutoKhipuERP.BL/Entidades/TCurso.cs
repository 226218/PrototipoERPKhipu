using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Entidades
{
   public partial class TCurso
    {
        public string CodCurso { get; set; }
        public string NomCurso { get; set; }
        public Nullable<int> Horas { get; set; }
        public Nullable<int> Creditos { get; set; }
        public string CodModulo { get; set; }
        public string CodCarrera { get; set; }
        public TCurso()
        { }

        public TCurso(TCurso obj)
        {
            CodCurso = obj.CodCurso;
            NomCurso = obj.NomCurso;
            Horas = obj.Horas;
            Creditos = obj.Creditos;
            CodModulo = obj.CodModulo;
        }

        #region Metodos sobreescritos
        public override bool Equals(object obj)
        {
            return obj is TCurso
                && ((TCurso)obj).CodCurso == CodCurso
                && ((TCurso)obj).NomCurso == NomCurso
                && ((TCurso)obj).Horas == Horas
              && ((TCurso)obj).Creditos == Creditos
               && ((TCurso)obj).CodModulo == CodModulo
            ;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + CodCurso.GetHashCode();
            hash = (hash * 7) + NomCurso.GetHashCode();
            hash = (hash * 7) + Horas.GetHashCode();
            hash = (hash * 7) + Creditos.GetHashCode();
            hash = (hash * 7) + CodModulo.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            var retorno = "[TCurso ";
            retorno = retorno + "CodCurso=" + CodCurso;
            retorno = retorno + "NomCurso=" + NomCurso;
            retorno = retorno + "Horas=" + Horas;
            retorno = retorno + "Creditos=" + Creditos;
            retorno = retorno + "CodModulo=" + CodModulo;
            return retorno + "]";
        }

        public static bool operator ==(TCurso obj1, TCurso obj2)
        {
            return true
                && obj1.CodCurso == obj2.CodCurso
                && obj1.NomCurso == obj2.NomCurso
                && obj1.Horas == obj2.Horas
                && obj1.Creditos == obj2.Creditos
                && obj1.CodModulo == obj2.CodModulo

            ;
        }

        public static bool operator !=(TCurso obj1, TCurso obj2)
        {
            return obj1.CodCurso != obj2.CodCurso
                || obj1.NomCurso != obj2.NomCurso
                || obj1.Horas != obj2.Horas
                 || obj1.Creditos != obj2.Creditos
                || obj1.CodModulo != obj2.CodModulo
            ;
        }
        #endregion


        #region Metodos CRUD
        public void Insertar()
        {
            var daTCurso = new InstitutoKhipuERP.DAL.TCurso();
            var traductor = new Traductores.TCurso();
            daTCurso = traductor.HaciaTCurso(this);
            daTCurso.Insertar();
            CodCurso = daTCurso.CodCurso;
        }

        public void Actualizar()
        {
            var daTCurso = new InstitutoKhipuERP.DAL.TCurso();
            var traductor = new Traductores.TCurso();
            daTCurso = traductor.HaciaTCurso(this);
            daTCurso.Actualizar();
        }

        public void Eliminar()
        {
            var daTCurso = new InstitutoKhipuERP.DAL.TCurso();
            var traductor = new Traductores.TCurso();
            daTCurso = traductor.HaciaTCurso(this);
            daTCurso.Eliminar();
        }
        #endregion


    }
}
