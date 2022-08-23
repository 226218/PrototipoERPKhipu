using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
   public partial class TDocente
    {
       public TDocente(TDocente obj)
		{
		    CodDocente=obj.CodDocente;
            Dni = obj.Dni;
            ApePaterno = obj.ApePaterno;
            ApeMaterno = obj.ApeMaterno;
            Nombres = obj.Nombres;
		}

		#region Metodos sobreescritos
		public override bool Equals(object obj)
		{
            return obj is TDocente
                && ((TDocente)obj).CodDocente == CodDocente
                && ((TDocente)obj).Dni == Dni
                && ((TDocente)obj).ApePaterno == ApePaterno
              && ((TDocente)obj).ApeMaterno == ApeMaterno
               && ((TDocente)obj).Nombres == Nombres
			;
		}

		public override int GetHashCode()
		{
			int hash = 13;
            hash = (hash * 7) + CodDocente.GetHashCode();
            hash = (hash * 7) + Dni.GetHashCode();
            hash = (hash * 7) + ApePaterno.GetHashCode();
            hash = (hash * 7) + ApeMaterno.GetHashCode();
            hash = (hash * 7) + Nombres.GetHashCode();
			return hash;
		}

		public override string ToString()
		{
            var retorno = "[TDocente ";
            retorno = retorno + "CodDocente=" + CodDocente;
            retorno = retorno + "Dni=" + Dni;
            retorno = retorno + "ApePaterno=" + ApePaterno;
            retorno = retorno + "ApeMaterno=" + ApeMaterno;
            retorno = retorno + "Nombres=" + Nombres;
			return retorno + "]";
		}

        public static bool operator ==(TDocente obj1, TDocente obj2)
		{
			return true
                && obj1.CodDocente == obj2.CodDocente
                && obj1.Dni == obj2.Dni
                && obj1.ApePaterno == obj2.ApePaterno
                && obj1.ApeMaterno == obj2.ApeMaterno
                && obj1.Nombres == obj2.Nombres
		
			;
		}

        public static bool operator !=(TDocente obj1, TDocente obj2)
		{
            return obj1.CodDocente != obj2.CodDocente
                || obj1.Dni != obj2.Dni
                || obj1.ApePaterno != obj2.ApePaterno
                 || obj1.ApeMaterno != obj2.ApeMaterno
                || obj1.Nombres != obj2.Nombres
			;
		}
		#endregion

		#region Metodos CRUD
		public void Insertar()
		{
			var db = new InstitutoKhipuEntities();
            db.TDocente.Add(this);
            Usuario obj = new Usuario(); ;
            obj.CodUsuario = CodDocente;
            obj.contraseña = Dni;
            obj.Tipo = "Docente";
            obj.Insertar();
          
            db.SaveChanges();

		}

		public void Actualizar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TDocente
                       where
                            obj.CodDocente == CodDocente
			           select obj).First();
           reg.CodDocente = CodDocente;
           reg.Dni = Dni;
           reg.ApePaterno =ApePaterno;
           reg.ApeMaterno = ApeMaterno;
           reg.Nombres = Nombres;
		
			db.SaveChanges();
		}

		public void Eliminar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TDocente
                       where obj.CodDocente == CodDocente
			           select obj).First();
            db.TDocente.Remove(reg);
			db.SaveChanges();
		}
		#endregion

    }
}
