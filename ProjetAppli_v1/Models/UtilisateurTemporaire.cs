using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetAppli_v1.Models
{
    public class UtilisateurTemporaire
    {
        public string email { get; set; }
        public string motDePasseTemporaire { get; set; }
        public string nouveauMotDePasse { get; set; }
        public string confirmMotDePasse { get; set; }
    }
}