//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTOVENTAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ventaxproducto
    {
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal subtotal { get; set; }
        public bool estadoVentaxProd { get; set; }
    
        public virtual tb_producto tb_producto { get; set; }
        public virtual tb_venta tb_venta { get; set; }
    }
}