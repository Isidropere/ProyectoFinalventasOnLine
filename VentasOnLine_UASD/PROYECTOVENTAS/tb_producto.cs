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
    
    public partial class tb_producto
    {
        public tb_producto()
        {
            this.DETALLEPAGO = new HashSet<DETALLEPAGO>();
            this.tb_ventaxproducto = new HashSet<tb_ventaxproducto>();
        }
    
        public int idProducto { get; set; }
        public string nomProducto { get; set; }
        public string descProducto { get; set; }
        public decimal precioProducto { get; set; }
        public int stockProducto { get; set; }
        public int idCategoria { get; set; }
        public bool estadoProducto { get; set; }
        public byte[] imagen { get; set; }
        public string ruta_img { get; set; }
    
        public virtual ICollection<DETALLEPAGO> DETALLEPAGO { get; set; }
        public virtual tb_categoria tb_categoria { get; set; }
        public virtual ICollection<tb_ventaxproducto> tb_ventaxproducto { get; set; }
    }
}
