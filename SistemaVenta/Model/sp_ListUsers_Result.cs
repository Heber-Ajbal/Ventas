//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaVenta.Model
{
    using System;
    
    public partial class sp_ListUsers_Result
    {
        public int UserId { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> RolId { get; set; }
        public Nullable<bool> State { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    }
}