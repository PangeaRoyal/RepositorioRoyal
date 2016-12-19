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
    
    public partial class Seguimiento
    {
        public Seguimiento()
        {
            this.SeguientoEvidencia = new HashSet<SeguientoEvidencia>();
        }
    
        public int RowID { get; set; }
        public Nullable<int> AreaAnteriorID { get; set; }
        public Nullable<int> AreaActualID { get; set; }
        public Nullable<int> EstadoID { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> CreadoPor { get; set; }
        public Nullable<int> PQRS_ID { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Opcion Opcion { get; set; }
        public virtual Opcion Opcion1 { get; set; }
        public virtual Pqrs Pqrs { get; set; }
        public virtual ICollection<SeguientoEvidencia> SeguientoEvidencia { get; set; }
    }
}
