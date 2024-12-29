using EventManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;


namespace EventManagement.Domain.Entities
{
    public class Evennement
    {
        [Key]
        public int IdEvenement { get; set; }
        public string Nom { get; set; }
        public string description { get; set; }
        public DateTime dateEvent { get; set; }
        public Categories categorie { get; set; }
        public int MaxParticipants { get; set; }
        public string organisateurFK { get; set; }
        public virtual IList<Participation> Participations { get; set; }
        public virtual Utilisateur Organisateur { get; set; }
    }
}
