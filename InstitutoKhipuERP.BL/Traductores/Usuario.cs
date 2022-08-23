using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoKhipuERP.BL.Traductores
{
    public class Usuario
    {
        public InstitutoKhipuERP.DAL.Usuario HaciaUsuario(InstitutoKhipuERP.BL.Entidades.Usuario desde)
        {
            var hacia = new InstitutoKhipuERP.DAL.Usuario();
            hacia.CodUsuario = desde.CodUsuario;
            hacia.contraseña = desde.contraseña;
            hacia.Tipo = desde.Tipo;
            return hacia;
        }

        public InstitutoKhipuERP.BL.Entidades.Usuario HaciaUsuario(InstitutoKhipuERP.DAL.Usuario desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.Usuario();
            hacia.CodUsuario = desde.CodUsuario;
            hacia.contraseña = desde.contraseña;
            hacia.Tipo = desde.Tipo;
            return hacia;
        }

        public List<InstitutoKhipuERP.DAL.Usuario> HaciaUsuario(List<InstitutoKhipuERP.BL.Entidades.Usuario> desde)
        {
            return desde.Select(HaciaUsuario).ToList();
        }

        public List<InstitutoKhipuERP.BL.Entidades.Usuario> HaciaUsuario(List<InstitutoKhipuERP.DAL.Usuario> desde)
        {
            return desde.Select(HaciaUsuario).ToList();
        }


      
    }
}
