
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace OnlineFanShop.Entities
{

using System;
    using System.Collections.Generic;
    
public partial class FransizaProizvoda
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public FransizaProizvoda()
    {

        this.FanKviz = new HashSet<FanKviz>();

        this.Proizvod = new HashSet<Proizvod>();

    }


    public int ID_fransiza { get; set; }

    public string nazivFransize { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FanKviz> FanKviz { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Proizvod> Proizvod { get; set; }

}

}
