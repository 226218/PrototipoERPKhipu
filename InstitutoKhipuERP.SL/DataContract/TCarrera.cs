using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
    [DataContract]
  public  class TCarrera
    {
        string codCarrera;
        [DataMember]
        public string CodCarrera
        {
            get { return codCarrera; }
            set { codCarrera = value; }
        }
        string nomCarrera;
           [DataMember]
        public string NomCarrera
        {
            get { return nomCarrera; }
            set { nomCarrera = value; }
        }
        string descripcion;
           [DataMember]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
