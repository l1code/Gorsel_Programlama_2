//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ders1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maas
    {
        public int MaasID { get; set; }
        public int KisiId { get; set; }
        public Nullable<int> DonemId { get; set; }
        public decimal MaasTutar { get; set; }
    
        public virtual Donem Donem { get; set; }
        public virtual Kisi Kisi { get; set; }
    }
}
