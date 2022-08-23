using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
     [DataContract]
    public class TEstudiante
    {
        string codEstudiante;
        [DataMember]
        public string CodEstudiante
        {
            get { return codEstudiante; }
            set { codEstudiante = value; }
        }
        string dni;
           [DataMember]
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        string apePaterno;
           [DataMember]
        public string ApePaterno
        {
            get { return apePaterno; }
            set { apePaterno = value; }
        }
        string apeMaterno;
           [DataMember]
        public string ApeMaterno
        {
            get { return apeMaterno; }
            set { apeMaterno = value; }
        }
        string nombres;
           [DataMember]
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        string codCarrera;
           [DataMember]
        public string CodCarrera
        {
            get { return codCarrera; }
            set { codCarrera = value; }
        }
    }
}
