using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
   public partial class TModuloCarrera
    {
       public TModuloCarrera(TModuloCarrera obj)
		{

            CodModulo=obj.CodModulo;
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
			var db = new InstitutoKhipuEntities();
            db.TModuloCarrera.Add(this);
			db.SaveChanges();
		}

		public void Actualizar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TModuloCarrera
                       where
                            obj.CodModulo == CodModulo
			           select obj).First();
           
            
        
            reg.CodModulo =CodModulo;
            reg.CodCarrera = CodCarrera;
            reg.NroModulo = NroModulo;
            reg.Semestre = Semestre;
           
			db.SaveChanges();
		}

		public void Eliminar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TModuloCarrera
                       where obj.CodModulo == CodModulo
			           select obj).First();
            db.TModuloCarrera.Remove(reg);
			db.SaveChanges();
		}
		#endregion
    }
}
