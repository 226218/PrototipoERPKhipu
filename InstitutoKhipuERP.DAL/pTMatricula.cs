using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
   public partial class TMatricula
    {
       public TMatricula(TMatricula obj)
		{
		    CodMatricula=obj.CodMatricula;
            CodEstudiante = obj.CodEstudiante;
            CodCarrera = obj.CodCarrera;
            CodModulo = obj.CodModulo;
            Semestre = obj.Semestre;
            Fecha = obj.Fecha;
		}

		#region Metodos sobreescritos
		public override bool Equals(object obj)
		{
            return obj is TMatricula
                && ((TMatricula)obj).CodMatricula == CodMatricula
                && ((TMatricula)obj).CodEstudiante == CodEstudiante
                && ((TMatricula)obj).CodCarrera == CodCarrera
              && ((TMatricula)obj).CodModulo == CodModulo
               && ((TMatricula)obj).Semestre == Semestre
              && ((TMatricula)obj).Fecha == Fecha
              
			;
		}

		public override int GetHashCode()
		{
			int hash = 13;
            hash = (hash * 7) + CodMatricula.GetHashCode();
            hash = (hash * 7) + CodEstudiante.GetHashCode();
            hash = (hash * 7) + CodCarrera.GetHashCode();
            hash = (hash * 7) + CodModulo.GetHashCode();
            hash = (hash * 7) + Semestre.GetHashCode();
            hash = (hash * 7) + Fecha.GetHashCode();
          
			return hash;
		}

		public override string ToString()
		{
            var retorno = "[TMatricula ";
            retorno = retorno + "CodMatricula=" + CodMatricula;
            retorno = retorno + "CodEstudiante=" + CodEstudiante;
            retorno = retorno + "CodCarrera=" + CodCarrera;
            retorno = retorno + "CodModulo=" + CodModulo;
            retorno = retorno + "Semestre=" + CodModulo;
            retorno = retorno + "Fecha=" + Fecha;
            
			return retorno + "]";
		}

        public static bool operator ==(TMatricula obj1, TMatricula obj2)
		{
			return true
                && obj1.CodMatricula == obj2.CodMatricula
                && obj1.CodEstudiante == obj2.CodEstudiante
                && obj1.CodCarrera == obj2.CodCarrera
                && obj1.CodModulo == obj2.CodModulo
                   && obj1.Semestre == obj2.Semestre
                && obj1.Fecha == obj2.Fecha
              
		
			;
		}

        public static bool operator !=(TMatricula obj1, TMatricula obj2)
		{
            return obj1.CodMatricula != obj2.CodMatricula
                || obj1.CodEstudiante != obj2.CodEstudiante
                || obj1.CodCarrera != obj2.CodCarrera
                 || obj1.CodModulo != obj2.CodModulo
                   || obj1.Semestre != obj2.Semestre
                || obj1.Fecha != obj2.Fecha
           
			;
		}
		#endregion

		#region Metodos CRUD
		public void Insertar()
		{
			var db = new InstitutoKhipuEntities();
            db.TMatricula.Add(this);
			db.SaveChanges();
		}

		public void Actualizar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TMatricula
                       where
                            obj.CodMatricula == CodMatricula
			           select obj).First();
           
            
            reg.CodMatricula = CodMatricula;
            reg.CodEstudiante = CodEstudiante;
            reg.CodCarrera = CodCarrera;
            reg.CodModulo =CodModulo;
            reg.Semestre = Semestre;
            reg.Fecha = Fecha;
		
			db.SaveChanges();
		}

		public void Eliminar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TMatricula
                       where obj.CodMatricula == CodMatricula
			           select obj).First();
            db.TMatricula.Remove(reg);
			db.SaveChanges();
		}
		#endregion
    }
}
