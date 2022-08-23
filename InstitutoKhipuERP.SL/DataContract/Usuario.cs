using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
     [DataContract]
  public  class Usuario
    {
        string codUsuario;
         [DataMember]
        public string CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }
        string contraseña1;
         [DataMember]
        public string contraseña
        {
            get { return contraseña1; }
            set { contraseña1 = value; }
        }
        string tipo;
         [DataMember]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
