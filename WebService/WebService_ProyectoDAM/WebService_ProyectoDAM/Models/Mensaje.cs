//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService_ProyectoDAM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mensaje
    {
        public int id_Mensaje { get; set; }
        public string usuarioEmisor { get; set; }
        public string usuarioReceptor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string asunto { get; set; }
        public string contenido { get; set; }
    
        public virtual Jugador Jugador { get; set; }
        public virtual Jugador Jugador1 { get; set; }
    }
}
