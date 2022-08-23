using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Entidades
{
   public partial class TMatriculaSemetre
    {
        public string CodMatriculaSemetre { get; set; }
        public string CodMatricula { get; set; }
        public string CodEstudiante { get; set; }
        public string CodCurso { get; set; }
        public string CodDocente { get; set; }
        public string Semestre { get; set; }
        public string NomCurso { get; set; }
        public Nullable<int> NotaPromedio { get; set; }

       public TMatriculaSemetre()
       {}
        public TMatriculaSemetre(TMatriculaSemetre obj)
		{

            CodMatriculaSemetre = obj.CodMatriculaSemetre;
            CodMatricula = obj.CodMatricula;
            CodEstudiante = obj.CodEstudiante;
            CodCurso = obj.CodCurso;
            CodDocente = obj.CodDocente;
               Semestre = obj.Semestre;
               NomCurso = obj.NomCurso;
               NotaPromedio = obj.NotaPromedio;
		}

		#region Metodos sobreescritos
		public override bool Equals(object obj)
		{
            return obj is TMatriculaSemetre
                && ((TMatriculaSemetre)obj).CodMatriculaSemetre == CodMatriculaSemetre
                && ((TMatriculaSemetre)obj).CodMatricula == CodMatricula
                && ((TMatriculaSemetre)obj).CodEstudiante == CodEstudiante
              && ((TMatriculaSemetre)obj).CodCurso == CodCurso
                    && ((TMatriculaSemetre)obj).CodDocente == CodDocente
                           && ((TMatriculaSemetre)obj).Semestre == Semestre
                                  && ((TMatriculaSemetre)obj).NomCurso == NomCurso
                                         && ((TMatriculaSemetre)obj).NotaPromedio == NotaPromedio
              
			;
		}

		public override int GetHashCode()
		{
			int hash = 13;
            hash = (hash * 7) + CodMatriculaSemetre.GetHashCode();
            hash = (hash * 7) + CodMatricula.GetHashCode();
            hash = (hash * 7) + CodEstudiante.GetHashCode();
            hash = (hash * 7) + CodCurso.GetHashCode();
            hash = (hash * 7) + CodDocente.GetHashCode();
            hash = (hash * 7) + Semestre.GetHashCode();
            hash = (hash * 7) + NomCurso.GetHashCode();
            hash = (hash * 7) + NotaPromedio.GetHashCode();
         
          
			return hash;
		}

		public override string ToString()
		{
            var retorno = "[TMatriculaSemetre ";
            retorno = retorno + "CodMatriculaSemetre=" + CodMatriculaSemetre;
            retorno = retorno + "CodMatricula=" + CodMatricula;
            retorno = retorno + "CodEstudiante=" + CodEstudiante;
            retorno = retorno + "CodCurso=" + CodCurso;
            retorno = retorno + "CodDocente=" + CodDocente;
            retorno = retorno + "Semestre=" + Semestre;
            retorno = retorno + "NomCurso=" + NomCurso;
            retorno = retorno + "NotaPromedio=" + NotaPromedio;
			return retorno + "]";
		}

        public static bool operator ==(TMatriculaSemetre obj1, TMatriculaSemetre obj2)
		{
			return true
                && obj1.CodMatriculaSemetre == obj2.CodMatriculaSemetre
                && obj1.CodMatricula == obj2.CodMatricula
                && obj1.CodEstudiante == obj2.CodEstudiante
                && obj1.CodCurso == obj2.CodCurso
                && obj1.CodDocente == obj2.CodDocente
                && obj1.Semestre == obj2.Semestre
                && obj1.NomCurso == obj2.NomCurso
                && obj1.NotaPromedio == obj2.NotaPromedio
              
		
			;
		}

        public static bool operator !=(TMatriculaSemetre obj1, TMatriculaSemetre obj2)
		{
            return obj1.CodMatriculaSemetre != obj2.CodMatriculaSemetre
                || obj1.CodMatricula != obj2.CodMatricula
                || obj1.CodEstudiante != obj2.CodEstudiante
                 || obj1.CodCurso != obj2.CodCurso
              || obj1.CodDocente != obj2.CodDocente
                 || obj1.Semestre != obj2.Semestre
                  || obj1.NomCurso != obj2.NomCurso
                 || obj1.NotaPromedio != obj2.NotaPromedio
           
			;
		}
		#endregion

		#region Metodos CRUD
        public void Insertar()
        {
            var daTMatriculaSemetre = new InstitutoKhipuERP.DAL.TMatriculaSemetre();
            var traductor = new Traductores.TMatriculaSemetre();
            daTMatriculaSemetre = traductor.HaciaTMatriculaSemetre(this);
            daTMatriculaSemetre.Insertar();
            CodMatriculaSemetre = daTMatriculaSemetre.CodMatriculaSemetre;
        }

        public void Actualizar()
        {
            var daTMatriculaSemetre = new InstitutoKhipuERP.DAL.TMatriculaSemetre();
            var traductor = new Traductores.TMatriculaSemetre();
            daTMatriculaSemetre = traductor.HaciaTMatriculaSemetre(this);
            daTMatriculaSemetre.Actualizar();
        }

        public void Eliminar()
        {
            var daTMatriculaSemetre = new InstitutoKhipuERP.DAL.TMatriculaSemetre();
            var traductor = new Traductores.TMatriculaSemetre();
            daTMatriculaSemetre = traductor.HaciaTMatriculaSemetre(this);
            daTMatriculaSemetre.Eliminar();
        }
		#endregion
    }
}
