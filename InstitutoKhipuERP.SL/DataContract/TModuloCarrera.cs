using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
     [DataContract]
    public class TModuloCarrera
    {
        string codModulo;
         [DataMember]
        public string CodModulo
        {
            get { return codModulo; }
            set { codModulo = value; }
        }
        string codCarrera;
         [DataMember]
        public string CodCarrera
        {
            get { return codCarrera; }
            set { codCarrera = value; }
        }
        Nullable<int> nroModulo;
         [DataMember]
        public Nullable<int> NroModulo
        {
            get { return nroModulo; }
            set { nroModulo = value; }
        }
        string semestre;
         [DataMember]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

    }
}
