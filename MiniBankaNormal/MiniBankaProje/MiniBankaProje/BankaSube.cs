//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniBankaProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankaSube
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankaSube()
        {
            this.BankaMusteri = new HashSet<BankaMusteri>();
            this.Kullanici = new HashSet<Kullanici>();
        }
    
        public int BankaSubeID { get; set; }
        public Nullable<int> BankaId { get; set; }
        public string BankaSubeAd { get; set; }
        public string BankaSubeKodu { get; set; }
        public string Faks { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
    
        public virtual Banka Banka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankaMusteri> BankaMusteri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
