using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
     [DataContract]
    public class TMatricula
    {

        string codMatricula;
         [DataMember]
        public string CodMatricula
        {
            get { return codMatricula; }
            set { codMatricula = value; }
        }
        string codEstudiante;
            [DataMember]
        public string CodEstudiante
        {
            get { return codEstudiante; }
            set { codEstudiante = value; }
        }
        string codCarrera;
            [DataMember]
        public string CodCarrera
        {
            get { return codCarrera; }
            set { codCarrera = value; }
        }
        string codModulo;
            [DataMember]
        public string CodModulo
        {
            get { return codModulo; }
            set { codModulo = value; }
        }
        string semestre;
            [DataMember]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        Nullable<System.DateTime> fecha;
            [DataMember]
        public Nullable<System.DateTime> Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
