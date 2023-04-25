
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
    
public partial class Proizvod
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Proizvod()
    {

        this.Ponuda = new HashSet<Ponuda>();

        this.Skladiste = new HashSet<Skladiste>();

    }


    public int ID_proizvod { get; set; }

    public string nazivProizvoda { get; set; }

    public int ID_vrsta_FK { get; set; }

    public int ID_fransiza_FK { get; set; }

    public int ID_velicina_FK { get; set; }



    public virtual FransizaProizvoda FransizaProizvoda { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Ponuda> Ponuda { get; set; }

    public virtual VelicinaProizvoda VelicinaProizvoda { get; set; }

    public virtual VrstaProizvoda VrstaProizvoda { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Skladiste> Skladiste { get; set; }

}

}
