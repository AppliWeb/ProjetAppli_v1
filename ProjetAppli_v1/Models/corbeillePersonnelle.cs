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
    
    public partial class corbeillePersonnelle
    {
        public int identifiant { get; set; }
        public int fkIdentifiantLog { get; set; }
        public System.DateTime dateCreation { get; set; }
        public string nom { get; set; }
        public string titre { get; set; }
        public string numeroEtape { get; set; }
        public string messageErreur { get; set; }
        public string severite { get; set; }
        public Nullable<System.DateTime> datePriseEnCharge { get; set; }
        public Nullable<System.DateTime> dateTraitement { get; set; }
        public string statut { get; set; }
        public string detailAnomalie { get; set; }
    }
}
