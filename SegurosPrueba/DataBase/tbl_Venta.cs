//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SegurosPrueba.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Venta
    {
        public int id_venta { get; set; }
        public int id_asesor { get; set; }
        public int id_cliente { get; set; }
        public int id_producto { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual tbl_Asesor tbl_Asesor { get; set; }
        public virtual tbl_Cliente tbl_Cliente { get; set; }
        public virtual tbl_Producto tbl_Producto { get; set; }
    }
}
