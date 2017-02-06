using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetAppli_v1.Models
{
    [MetadataType(typeof(corbeillePersonnelleMetaData))]
    public partial class corbeillePersonnelle
    {

    }
    public class corbeillePersonnelleMetaData
    {

        [Display(Name = "Clé")]
        public int identifiant { get; set; }

        [Display(Name = "Clé Log")]
        public int fkIdentifiantLog { get; set; }

        [Display(Name = "Date Création", ShortName = "Création")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime dateCreation { get; set; }

        [Display(Name = "Nom", ShortName = "Nom")]
        public string nom { get; set; }

        [Display(Name = "Chaîne Batch", ShortName = "Chaîne")]
        public string titre { get; set; }

        [Display(Name = "N° Etape", ShortName = "Etape")]
        public string numeroEtape { get; set; }

        [Display(Name = "Message Erreur", ShortName = "Erreur")]
        public string messageErreur { get; set; }

        [Display(Name = "Sévérité")]
        public string severite { get; set; }

        [Display(Name = "Date Prise en Charge", ShortName = "Prise en Charge")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> datePriseEnCharge { get; set; }

        [Display(Name = "Date Traitement", ShortName = "Traitement")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> dateTraitement { get; set; }

        [Display(Name = "Statut")]
        public string statut { get; set; }

        [Display(Name = "Détail Anomalie", ShortName = "Détail")]
        public string detailAnomalie { get; set; }
    }
}