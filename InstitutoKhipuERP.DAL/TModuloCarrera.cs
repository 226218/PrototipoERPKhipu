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
    
    public partial class TModuloCarrera
    {
        public TModuloCarrera()
        {
            this.TCurso = new HashSet<TCurso>();
            this.TMatricula = new HashSet<TMatricula>();
        }
    
        public string CodModulo { get; set; }
        public string CodCarrera { get; set; }
        public Nullable<int> NroModulo { get; set; }
        public string Semestre { get; set; }
    
        public virtual TCarrera TCarrera { get; set; }
        public virtual ICollection<TCurso> TCurso { get; set; }
        public virtual ICollection<TMatricula> TMatricula { get; set; }
    }
}
