using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetAppli_v1.Models;
using System.Net.Mail;

namespace ProjetAppli_v1.Controllers
{
    public class utilisateursController : Controller
    {
        private appliWebLogsEntities1 db = new appliWebLogsEntities1();

        // GET: utilisateurs
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        // GET: utilisateurs
        public ActionResult ReinitMdp(string email)
        {
            var util = (from row in db.utilisateur where row.email.ToLower() == email select row).FirstOrDefault();
            if (util == null)
            {
                ViewBag.Message = "L'email ne correspond pas à une adresse connue. Veuillez renouveler cette opération.";
                return View("Index");
            }
            // Envoyer un mail 
            string passe = generatePassword();
            string message = "Votre mot de passe temporaire est " + passe;
            bool success = sendEmail(email, "Réinitialisation du mot de passe", message);
            if (success)
            {
                // Modifier le compte utilisateur
                util.motDePasse = passe;
                db.SaveChanges();
                // Aller à la vue de réinitialisation du mot de passe
                UtilisateurTemporaire utilTemp = new UtilisateurTemporaire();
                utilTemp.email = email;
                return View(utilTemp);
            }
            else
            {
                ViewBag.Message = "Le serveur n'a pas pu vous envoyer un email. Veuillez contacter votre administrateur.";
                return View("Index");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPassword([Bind(Include = "email, motDePasseTemporaire, nouveauMotDePasse, confirmMotDePasse")] UtilisateurTemporaire utilTemp)
        {
            if (ModelState.IsValid)
            {
                string motDePasse = utilTemp.motDePasseTemporaire;
                string email = utilTemp.email.ToLower();
                var util = (from row in db.utilisateur where row.email.ToLower() == email && row.motDePasse == motDePasse select row).FirstOrDefault();
                if (util == null)
                {
                    ViewBag.Message = "Le mot de passe saisie ne correspond pas à celui qui vous a été envoyé. Veuillez consulter votre messagerie.";
                    return View();
                }
                Session["utilisateur"] = util.prenom.Substring(0,1).ToUpper() + util.prenom.Substring(1).ToLower() + " " + util.nom.ToUpper();
                Session["idUtilisateur"] = util.identifiant;
                util.motDePasse = utilTemp.nouveauMotDePasse;
                db.SaveChanges();              
                return RedirectToAction("Index", "corbeillePersonnelles");
            }
            
            ViewBag.Message = "Votre saisie est invalide.";
            return View();
        }

        // POST: utilisateurs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "email,motDePasse")] utilisateur utilisateur)
        {
            if (ModelState.IsValid)
            {
                string motDePasse = utilisateur.motDePasse;
                string email = utilisateur.email.ToLower();
                var util = (from row in db.utilisateur where row.email.ToLower() == email && row.motDePasse == motDePasse select row).FirstOrDefault();
                if (util == null)
                {
                    ViewBag.Message = "L'email et/ou le mot de passe utilisé est invalide. Veuillez renouveler cette opération.";
                    return View();
                }
                Session["utilisateur"] = util.prenom.Substring(0, 1).ToUpper() + util.prenom.Substring(1).ToLower() + " " + util.nom.ToUpper();
                Session["idUtilisateur"] = util.identifiant;
                return RedirectToAction("Index", "corbeillePersonnelles");
            }
            ViewBag.Message = "Votre saisie est invalide.";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        protected string generatePassword()
        {
            Random rnd = new Random();
            string[] passe = new string[8];
            for (int i = 0; i < passe.Length; i++)
            {
                passe[i] = rnd.Next(0, 10).ToString();
            }

            return string.Join("", passe);
        }

        protected bool sendEmail(string _to, string subject, string body)
        {
            string _from = "appliweb@outlook.com"; // compte email générique
            MailMessage mail = new MailMessage(_from, _to);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(_from, "humanis45");
            client.EnableSsl = true;
            client.Host = "smtp-mail.outlook.com";
            mail.Subject = subject;
            mail.Body = body;
            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

    }
}
