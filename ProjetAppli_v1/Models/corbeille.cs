//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetAppli_v1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class corbeille
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public corbeille()
        {
            this.anomalie = new HashSet<anomalie>();
        }
    
        public int identifiant { get; set; }
        public Nullable<int> taille { get; set; }
    
        public virtual utilisateur utilisateur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<anomalie> anomalie { get; set; }
    }
}