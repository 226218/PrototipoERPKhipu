//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstitutoKhipuERP.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TDocente
    {
        public TDocente()
        {
            this.TMatriculaSemetre = new HashSet<TMatriculaSemetre>();
        }
    
        public string CodDocente { get; set; }
        public string Dni { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombres { get; set; }
    
        public virtual ICollection<TMatriculaSemetre> TMatriculaSemetre { get; set; }
    }
}
