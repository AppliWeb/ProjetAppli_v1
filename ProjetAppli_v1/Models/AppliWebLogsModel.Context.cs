﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class appliWebLogsEntities1 : DbContext
    {
        public appliWebLogsEntities1()
            : base("name=appliWebLogsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<anomalie> anomalie { get; set; }
        public virtual DbSet<batch> batch { get; set; }
        public virtual DbSet<corbeille> corbeille { get; set; }
        public virtual DbSet<domaine> domaine { get; set; }
        public virtual DbSet<log> log { get; set; }
        public virtual DbSet<messageErreur> messageErreur { get; set; }
        public virtual DbSet<pole> pole { get; set; }
        public virtual DbSet<serveur> serveur { get; set; }
        public virtual DbSet<severite> severite { get; set; }
        public virtual DbSet<statut> statut { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<type> type { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }
        public virtual DbSet<corbeillePersonnelle> corbeillePersonnelle { get; set; }
        public virtual DbSet<parametrageAnomalie> parametrageAnomalie { get; set; }
        public virtual DbSet<parametrageHabilitations> parametrageHabilitations { get; set; }
        public virtual DbSet<parametrageLogs> parametrageLogs { get; set; }
    
        public virtual int AjouterAnomalie(Nullable<int> fkIdentifiantLog, Nullable<System.DateTime> dateCreation, string severite, string statut, string type, string motsCles, Nullable<int> nombreAnomalies, Nullable<int> nombreMotsCles)
        {
            var fkIdentifiantLogParameter = fkIdentifiantLog.HasValue ?
                new ObjectParameter("fkIdentifiantLog", fkIdentifiantLog) :
                new ObjectParameter("fkIdentifiantLog", typeof(int));
    
            var dateCreationParameter = dateCreation.HasValue ?
                new ObjectParameter("dateCreation", dateCreation) :
                new ObjectParameter("dateCreation", typeof(System.DateTime));
    
            var severiteParameter = severite != null ?
                new ObjectParameter("severite", severite) :
                new ObjectParameter("severite", typeof(string));
    
            var statutParameter = statut != null ?
                new ObjectParameter("statut", statut) :
                new ObjectParameter("statut", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            var motsClesParameter = motsCles != null ?
                new ObjectParameter("motsCles", motsCles) :
                new ObjectParameter("motsCles", typeof(string));
    
            var nombreAnomaliesParameter = nombreAnomalies.HasValue ?
                new ObjectParameter("nombreAnomalies", nombreAnomalies) :
                new ObjectParameter("nombreAnomalies", typeof(int));
    
            var nombreMotsClesParameter = nombreMotsCles.HasValue ?
                new ObjectParameter("nombreMotsCles", nombreMotsCles) :
                new ObjectParameter("nombreMotsCles", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AjouterAnomalie", fkIdentifiantLogParameter, dateCreationParameter, severiteParameter, statutParameter, typeParameter, motsClesParameter, nombreAnomaliesParameter, nombreMotsClesParameter);
        }
    
        public virtual int AjouterLog(string nom, string domaine, string titre, string numeroEtape, string pole, string horodatage, Nullable<System.DateTime> dateCreation, string nomServeur, string adresseServeur, ObjectParameter identifiant)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var domaineParameter = domaine != null ?
                new ObjectParameter("domaine", domaine) :
                new ObjectParameter("domaine", typeof(string));
    
            var titreParameter = titre != null ?
                new ObjectParameter("titre", titre) :
                new ObjectParameter("titre", typeof(string));
    
            var numeroEtapeParameter = numeroEtape != null ?
                new ObjectParameter("numeroEtape", numeroEtape) :
                new ObjectParameter("numeroEtape", typeof(string));
    
            var poleParameter = pole != null ?
                new ObjectParameter("pole", pole) :
                new ObjectParameter("pole", typeof(string));
    
            var horodatageParameter = horodatage != null ?
                new ObjectParameter("horodatage", horodatage) :
                new ObjectParameter("horodatage", typeof(string));
    
            var dateCreationParameter = dateCreation.HasValue ?
                new ObjectParameter("dateCreation", dateCreation) :
                new ObjectParameter("dateCreation", typeof(System.DateTime));
    
            var nomServeurParameter = nomServeur != null ?
                new ObjectParameter("nomServeur", nomServeur) :
                new ObjectParameter("nomServeur", typeof(string));
    
            var adresseServeurParameter = adresseServeur != null ?
                new ObjectParameter("adresseServeur", adresseServeur) :
                new ObjectParameter("adresseServeur", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AjouterLog", nomParameter, domaineParameter, titreParameter, numeroEtapeParameter, poleParameter, horodatageParameter, dateCreationParameter, nomServeurParameter, adresseServeurParameter, identifiant);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
