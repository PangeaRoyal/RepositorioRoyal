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
    
    public partial class TarjetaMembresiaClienteRoyal
    {
        public int RowID { get; set; }
        public Nullable<int> TarjetaMembresiaID { get; set; }
        public Nullable<int> ClienteRoyalID { get; set; }
        public Nullable<System.DateTime> FechaActivacion { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<int> EstadoID { get; set; }
        public Nullable<short> NoRedencionesAprob { get; set; }
    
        public virtual ClienteRoyal ClienteRoyal { get; set; }
        public virtual TarjetaMembresia TarjetaMembresia { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
