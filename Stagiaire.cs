//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliothèque
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stagiaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stagiaire()
        {
            this.Emprinte = new HashSet<Emprinte>();
        }
    
        public int IdStagiaire { get; set; }
        public string NomStagiaire { get; set; }
        public string PrenomStagiaire { get; set; }
        public string EmailStagiaire { get; set; }
        public string PasswordStagiaire { get; set; }
        public Nullable<int> IdFGroupe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprinte> Emprinte { get; set; }
        public virtual Groupe Groupe { get; set; }
    }
}
