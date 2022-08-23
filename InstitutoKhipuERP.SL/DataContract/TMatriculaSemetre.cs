using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
     [DataContract]
    public class TMatriculaSemetre
    {
        string codMatriculaSemetre;
         [DataMember]
        public string CodMatriculaSemetre
        {
            get { return codMatriculaSemetre; }
            set { codMatriculaSemetre = value; }
        }
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
        string codCurso;
             [DataMember]
        public string CodCurso
        {
            get { return codCurso; }
            set { codCurso = value; }
        }
        string codDocente;
             [DataMember]
        public string CodDocente
        {
            get { return codDocente; }
            set { codDocente = value; }
        }
        string semestre;
             [DataMember]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        string nomCurso;
             [DataMember]
        public string NomCurso
        {
            get { return nomCurso; }
            set { nomCurso = value; }
        }
        Nullable<int> notaPromedio;
             [DataMember]
        public Nullable<int> NotaPromedio
        {
            get { return notaPromedio; }
            set { notaPromedio = value; }
        }
    }
}
