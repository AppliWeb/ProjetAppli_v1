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
    
    public partial class utilisateur
    {
        public int identifiant { get; set; }
        public string role { get; set; }
        public string email { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public System.DateTime debutValidite { get; set; }
        public string domaines { get; set; }
        public string motDePasse { get; set; }
        public System.DateTime finValidite { get; set; }
    
        public virtual corbeille corbeille { get; set; }
    }
}
