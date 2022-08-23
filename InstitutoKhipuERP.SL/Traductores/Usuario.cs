using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstitutoKhipuERP.BL;
namespace InstitutoKhipuERP.SL.Traductores
{
    public class Usuario
    {
        public static InstitutoKhipuERP.SL.DataContract.Usuario HaciaUsuario(InstitutoKhipuERP.BL.Entidades.Usuario desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.Usuario();
            hacia.CodUsuario = desde.CodUsuario;
            hacia.contraseña = desde.contraseña;
            hacia.Tipo = desde.Tipo;
            return hacia;
        }

        public static InstitutoKhipuERP.BL.Entidades.Usuario HaciaUsuario(InstitutoKhipuERP.SL.DataContract.Usuario desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.Usuario();
            hacia.CodUsuario = desde.CodUsuario;
            hacia.contraseña = desde.contraseña;
            hacia.Tipo = desde.Tipo;
            return hacia;
        }
        public  InstitutoKhipuERP.SL.DataContract.Usuario HaciaUsuario1(InstitutoKhipuERP.BL.Entidades.Usuario desde)
        {
            var hacia = new InstitutoKhipuERP.SL.DataContract.Usuario();
            hacia.CodUsuario = desde.CodUsuario;
            hacia.contraseña = desde.contraseña;
            hacia.Tipo = desde.Tipo;
            return hacia;
        }

        public  InstitutoKhipuERP.BL.Entidades.Usuario HaciaUsuario1(InstitutoKhipuERP.SL.DataContract.Usuario desde)
        {
            var hacia = new InstitutoKhipuERP.BL.Entidades.Usuario();
            hacia.CodUsuario = desde.CodUsuario;
            hacia.contraseña = desde.contraseña;
            hacia.Tipo = desde.Tipo;
            return hacia;
        }
        public List<InstitutoKhipuERP.SL.DataContract.Usuario> HaciaUsuario(List<InstitutoKhipuERP.BL.Entidades.Usuario> desde)
        {
            return desde.Select(HaciaUsuario).ToList();
        }

        public List<InstitutoKhipuERP.BL.Entidades.Usuario> HaciaUsuario(List<InstitutoKhipuERP.SL.DataContract.Usuario> desde)
        {
            return desde.Select(HaciaUsuario).ToList();
        }
    }
}
