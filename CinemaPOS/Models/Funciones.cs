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
    
    public partial class Funciones
    {
        public string TituloLocal { get; set; }
        public int RowID_EncabezadoPelicula { get; set; }
        public string Afiche { get; set; }
        public string ClasificacionPelicula { get; set; }
        public int RowID_Detalle { get; set; }
        public string PeliculaIdioma { get; set; }
        public string PeliculaVersion { get; set; }
        public int RowID_Funcion { get; set; }
        public int EncabezadoProgramacionID { get; set; }
        public Nullable<int> DetallePeliculaID { get; set; }
        public int SalaID { get; set; }
        public Nullable<int> EstadoID { get; set; }
        public Nullable<short> TiempoAseo { get; set; }
        public Nullable<short> TiempoCorto { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string CreadoPor { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<bool> Sincronizado { get; set; }
        public Nullable<System.TimeSpan> HoraInicial { get; set; }
        public Nullable<System.TimeSpan> HoraFinal { get; set; }
        public string NombreSala { get; set; }
        public string NombreEstadoSala { get; set; }
        public string FechaFuncion { get; set; }
        public string NombreTeatro { get; set; }
        public int RowIDTeatro { get; set; }
        public string EstadoFuncion { get; set; }
    }
}
