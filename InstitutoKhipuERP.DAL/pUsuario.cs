using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.DAL
{
   public partial class Usuario
   {
       public Usuario(Usuario obj)
		{
  
            CodUsuario = obj.CodUsuario;
            contraseña = obj.contraseña;
            Tipo = obj.Tipo;
		}

       public Usuario()
       {
           // TODO: Complete member initialization
       }

		#region Metodos sobreescritos
		public override bool Equals(object obj)
		{
            return obj is Usuario
                && ((Usuario)obj).CodUsuario == CodUsuario
                && ((Usuario)obj).contraseña == contraseña
                && ((Usuario)obj).Tipo == Tipo
			;
		}

		public override int GetHashCode()
		{
			int hash = 13;
            hash = (hash * 7) + CodUsuario.GetHashCode();
            hash = (hash * 7) + contraseña.GetHashCode();
            hash = (hash * 7) + Tipo.GetHashCode();
    
         
          
			return hash;
		}

		public override string ToString()
		{
            var retorno = "[Usuario ";
            retorno = retorno + "CodUsuario=" + CodUsuario;
            retorno = retorno + "contraseña=" + contraseña;
            retorno = retorno + "Tipo=" + Tipo;
           
       
			return retorno + "]";
		}

        public static bool operator ==(Usuario obj1, Usuario obj2)
		{
			return true
                && obj1.CodUsuario == obj2.CodUsuario
                && obj1.contraseña == obj2.contraseña
                && obj1.Tipo == obj2.Tipo
              
			;
		}

        public static bool operator !=(Usuario obj1, Usuario obj2)
		{
            return obj1.CodUsuario != obj2.CodUsuario
                || obj1.contraseña != obj2.contraseña
                || obj1.Tipo != obj2.Tipo
              
			;
		}
		#endregion

		#region Metodos CRUD
		public void Insertar()
		{
			var db = new InstitutoKhipuEntities();
            db.Usuario.Add(this);
			db.SaveChanges();
		}

		public void Actualizar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.Usuario
                       where
                            obj.CodUsuario == CodUsuario
			           select obj).First();
            reg.CodUsuario = CodUsuario;
            reg.contraseña = contraseña;
            reg.Tipo = Tipo;
            
			db.SaveChanges();
		}

		public void Eliminar()
		{
            var db = new InstitutoKhipuEntities();
            var reg = (from obj in db.Usuario
                       where obj.CodUsuario == CodUsuario
			           select obj).First();
            db.Usuario.Remove(reg);
			db.SaveChanges();
		}
		#endregion
    }
}
