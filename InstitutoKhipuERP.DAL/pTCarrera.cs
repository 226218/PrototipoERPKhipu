using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
   public partial class TCarrera
    {
        public TCarrera (TCarrera obj)
		{
		  CodCarrera =obj.CodCarrera;
       NomCarrera=obj.NomCarrera;
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
			var db = new InstitutoKhipuEntities();
			db.TCarrera.Add(this);
			db.SaveChanges();
		}

		public void Actualizar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TCarrera
                       where
                            obj.CodCarrera == CodCarrera
			           select obj).First();
            reg.CodCarrera = CodCarrera;
            reg.NomCarrera = NomCarrera;
            reg.Descripcion = Descripcion;
		
			db.SaveChanges();
		}

		public void Eliminar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TCarrera
                       where obj.CodCarrera == CodCarrera
			           select obj).First();
            db.TCarrera.Remove(reg);
			db.SaveChanges();
		}
		#endregion
    }
}
