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
    
    public partial class PAGO
    {
        public PAGO()
        {
            this.DETALLEPAGO = new HashSet<DETALLEPAGO>();
        }
    
        public int in_id_pago { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idCliente { get; set; }
        public bool in_id_tipopaVisa { get; set; }
        public bool in_id_tipopaMastercard { get; set; }
        public Nullable<int> documentopaga { get; set; }
        public string vc_dsc_numerotar { get; set; }
        public Nullable<System.DateTime> dt_fechaEmision { get; set; }
        public string cvc { get; set; }
        public Nullable<int> in_id_estado { get; set; }
        public Nullable<System.DateTime> fechaven { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual ICollection<DETALLEPAGO> DETALLEPAGO { get; set; }
        public virtual DocPaga DocPaga { get; set; }
        public virtual tb_usuario tb_usuario { get; set; }
        public virtual tb_usuario tb_usuario1 { get; set; }
    }
}
