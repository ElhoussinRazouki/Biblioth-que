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
    
    public partial class Emprinte
    {
        public int IdEmprinte { get; set; }
        public Nullable<int> IdSagiaire { get; set; }
        public Nullable<int> IdLivre { get; set; }
        public Nullable<System.DateTime> DateEmprinte { get; set; }
        public Nullable<System.DateTime> DateRoteur { get; set; }
    
        public virtual Livre Livre { get; set; }
        public virtual Stagiaire Stagiaire { get; set; }
    }
}
