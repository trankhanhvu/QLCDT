//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCDT1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTSD
    {
        public string IDSIM { get; set; }
        public System.DateTime TGBD { get; set; }
        public System.DateTime TGKT { get; set; }
        public Nullable<double> THANHTIEN { get; set; }
    
        public virtual SIM SIM { get; set; }
    }
}