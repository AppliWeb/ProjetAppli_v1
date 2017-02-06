using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // pour les annotations (au dessus de la classe ou des propriétés)

namespace ProjetAppli_v1.Models
{
    [MetadataType(typeof(utilisateurMetaData))]
    public partial class utilisateur
    {

    }

    public class utilisateurMetaData
    {
        [Required(ErrorMessage = "L'adresse email est requise")]
        [Display(Name = "Email :")]
        public string email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        [Display(Name = "Mot de passe :")]
        public string motDePasse { get; set; }

    }
}