//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfBibliotecaComunitaria
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestador()
        {
            this.Prestamo = new HashSet<Prestamo>();
        }
    
        public string NroDocumento { get; set; }
        public int TipoDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public int CiudadID { get; set; }
        public System.DateTime FechaInscripcion { get; set; }
        public bool Estado { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual TipoDocumento TipoDocumento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}
