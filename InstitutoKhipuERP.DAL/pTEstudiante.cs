using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
    public partial class TEstudiante
    {
        public TEstudiante(TEstudiante obj)
		{
		 CodEstudiante =obj.CodEstudiante;
         Dni = obj.Dni;
         ApePaterno = obj.ApePaterno;
         ApeMaterno = obj.ApeMaterno;
         Nombres = obj.Nombres;
         CodCarrera = obj.CodCarrera;
		}

		#region Metodos sobreescritos
		public override bool Equals(object obj)
		{
            return obj is TEstudiante
                && ((TEstudiante)obj).CodEstudiante == CodEstudiante
                && ((TEstudiante)obj).Dni == Dni
                && ((TEstudiante)obj).ApePaterno == ApePaterno
              && ((TEstudiante)obj).ApeMaterno == ApeMaterno
               && ((TEstudiante)obj).Nombres == Nombres
               && ((TEstudiante)obj).CodCarrera == CodCarrera
			;
		}

		public override int GetHashCode()
		{
			int hash = 13;
            hash = (hash * 7) + CodEstudiante.GetHashCode();
            hash = (hash * 7) + Dni.GetHashCode();
            hash = (hash * 7) + ApePaterno.GetHashCode();
            hash = (hash * 7) + ApeMaterno.GetHashCode();
            hash = (hash * 7) + Nombres.GetHashCode();
            hash = (hash * 7) + CodCarrera.GetHashCode();
			return hash;
		}

		public override string ToString()
		{
            var retorno = "[TEstudiante ";
            retorno = retorno + "CodEstudiante=" + CodEstudiante;
            retorno = retorno + "Dni=" + Dni;
            retorno = retorno + "ApePaterno=" + ApePaterno;
            retorno = retorno + "ApeMaterno=" + ApeMaterno;
            retorno = retorno + "Nombres=" + Nombres;
            retorno = retorno + "CodCarrera=" + CodCarrera;
			return retorno + "]";
		}

        public static bool operator ==(TEstudiante obj1, TEstudiante obj2)
		{
			return true
                && obj1.CodEstudiante == obj2.CodEstudiante
                && obj1.Dni == obj2.Dni
                && obj1.ApePaterno == obj2.ApePaterno
                && obj1.ApeMaterno == obj2.ApeMaterno
                && obj1.Nombres == obj2.Nombres
                 && obj1.CodCarrera == obj2.CodCarrera
		
			;
		}

        public static bool operator !=(TEstudiante obj1, TEstudiante obj2)
		{
            return obj1.CodEstudiante != obj2.CodEstudiante
                || obj1.Dni != obj2.Dni
                || obj1.ApePaterno != obj2.ApePaterno
                 || obj1.ApeMaterno != obj2.ApeMaterno
                || obj1.Nombres != obj2.Nombres
                 || obj1.CodCarrera != obj2.CodCarrera
			;
		}
		#endregion

		#region Metodos CRUD
		public void Insertar()
		{
			var db = new InstitutoKhipuEntities();
            db.TEstudiante.Add(this);

            Usuario obj = new Usuario(); ;
            obj.CodUsuario = CodEstudiante;
            obj.contraseña = Dni;
            obj.Tipo = "Estudiante";
            obj.Insertar();
          

			db.SaveChanges();

		}

		public void Actualizar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TEstudiante
                       where
                            obj.CodEstudiante == CodEstudiante
			           select obj).First();
           
            reg.CodEstudiante = CodEstudiante;
            reg.Dni = Dni;
            reg.ApePaterno = ApePaterno;
            reg.ApeMaterno = ApeMaterno;
            reg.Nombres = Nombres;
            reg.CodCarrera = CodCarrera;
		
			db.SaveChanges();
		}

		public void Eliminar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.TEstudiante
                       where obj.CodEstudiante == CodEstudiante
			           select obj).First();
            db.TEstudiante.Remove(reg);
			db.SaveChanges();
		}
		#endregion

    }
}
