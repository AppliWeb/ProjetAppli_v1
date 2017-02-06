using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions; // pour RegEx
using System.ComponentModel.DataAnnotations; // pour ValidationAttribute

namespace eLearning.Models
{
    
    #region Entities

    [MetadataType(typeof(ClientMetadata))]
    public partial class Client  {  }

    #endregion 

    #region Metadata
    public partial class ClientMetadata
    {
       
        [Required(ErrorMessage = "La référence du client est requise")]
        [Display(Name = "Référence :")]
        public string Reference { get; set; }

        [Required(ErrorMessage = "La société du client est requise")]
        [Display(Name = "Société :")]
        public string RaisonSociale { get; set; }

        [Email(ErrorMessage = "Mail invalide")]
        public string Email { get; set; }

        [Url(ErrorMessage = "Url invalide")]
        public string UrlSiteWeb { get; set; }

    }

    #endregion

    #region Validations

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class EmailAttribute : ValidationAttribute
    {
        private const string MAIL_PATTERN = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        public override bool IsValid(object value)
        {

            if (value == null) return false;
            string mailValue = value.ToString();
            return Regex.IsMatch(mailValue, MAIL_PATTERN);
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class UrlAttribute : ValidationAttribute
    {
        private const string URL_PATTERN = @"^(http|ftp|https|www)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$";

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            string mailValue = value.ToString();
            return Regex.IsMatch(mailValue, URL_PATTERN,RegexOptions.IgnoreCase);
        }
    }

    #endregion

}
