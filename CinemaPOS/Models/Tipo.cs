//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaPOS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo
    {
        public Tipo()
        {
            this.Opcion = new HashSet<Opcion>();
            this.Menu = new HashSet<Menu>();
            this.Menu1 = new HashSet<Menu>();
        }
    
        public int RowID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Opcion> Opcion { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<Menu> Menu1 { get; set; }
    }
}
