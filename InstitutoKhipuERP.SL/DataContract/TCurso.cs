using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
    [DataContract]
   public class TCurso
    {
        string codCurso;
        [DataMember]
        public string CodCurso
        {
            get { return codCurso; }
            set { codCurso = value; }
        }
        string nomCurso;
        [DataMember]
        public string NomCurso
        {
            get { return nomCurso; }
            set { nomCurso = value; }
        }
        Nullable<int> horas;
        [DataMember]
        public Nullable<int> Horas
        {
            get { return horas; }
            set { horas = value; }
        }
        Nullable<int> creditos;
        [DataMember]
        public Nullable<int> Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
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
    }
}
