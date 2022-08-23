using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Entidades
{
   public partial class Usuario
    {
        public string CodUsuario { get; set; }
        public string contraseña { get; set; }
        public string Tipo { get; set; }
        public Usuario()
        { }
        public Usuario(Usuario obj)
        {

            CodUsuario = obj.CodUsuario;
            contraseña = obj.contraseña;
            Tipo = obj.Tipo;
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
            var daUsuario = new InstitutoKhipuERP.DAL.Usuario();
            var traductor = new Traductores.Usuario();
            daUsuario = traductor.HaciaUsuario(this);
            daUsuario.Insertar();
            CodUsuario = daUsuario.CodUsuario;
        }

        public void Actualizar()
        {
            var daUsuario = new InstitutoKhipuERP.DAL.Usuario();
            var traductor = new Traductores.Usuario();
            daUsuario = traductor.HaciaUsuario(this);
            daUsuario.Actualizar();
        }

        public void Eliminar()
        {
            var daUsuario = new InstitutoKhipuERP.DAL.Usuario();
            var traductor = new Traductores.Usuario();
            daUsuario = traductor.HaciaUsuario(this);
            daUsuario.Eliminar();
        }
        #endregion
    }
}
