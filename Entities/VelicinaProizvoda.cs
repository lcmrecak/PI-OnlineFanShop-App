
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
    
public partial class VelicinaProizvoda
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public VelicinaProizvoda()
    {

        this.Proizvod = new HashSet<Proizvod>();

    }


    public int ID_velicina { get; set; }

    public string nazivVelicine { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Proizvod> Proizvod { get; set; }

}

}
