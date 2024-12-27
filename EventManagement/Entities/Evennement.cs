using EventManagement.Domain.Enums;


namespace EventManagement.Domain.Entities
{
    public class Evennement
    {
        public int IdEvenement { get; set; }
        public string Nom { get; set; }
        public string description { get; set; }
        public DateTime dateEvent { get; set; }
        public Categories categorie { get; set; }
        public int MaxParticipants { get; set; }
    }
}
