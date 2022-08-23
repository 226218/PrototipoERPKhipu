using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace InstitutoKhipuERP.SL.DataContract
{
   
        [CollectionDataContract]
        public class ListaTCarrera : System.Collections.Generic.List<TCarrera>
        {
        }

        [CollectionDataContract]
        public class ListaTCurso : System.Collections.Generic.List<TCurso>
        {
        }

        [CollectionDataContract]
        public class ListaTDocente : System.Collections.Generic.List<TDocente>
        {
        }
        [CollectionDataContract]
        public class ListaTEstudiante : System.Collections.Generic.List<TEstudiante>
        {
        }

        [CollectionDataContract]
        public class ListaTMatricula : System.Collections.Generic.List<TMatricula>
        {
        }
        [CollectionDataContract]
        public class ListaTMatriculaSemetre : System.Collections.Generic.List<TMatriculaSemetre>
        {
        }

        [CollectionDataContract]
        public class ListaTModuloCarrera : System.Collections.Generic.List<TModuloCarrera>
        {
        }
    
}
