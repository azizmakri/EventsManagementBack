using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Domain.Entities
{
    public class Participation
    {
        [Key]
        public int IdParticipation { get; set; }
        public DateTime DateInscri { get; set; }
        public int eventFK { get; set; }
        public string participantFK { get; set; }
        public virtual Evennement evennement { get; set; }
        public virtual Utilisateur Particpant { get; set; }
    }
}
