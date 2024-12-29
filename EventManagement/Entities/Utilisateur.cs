using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Domain.Entities
{
    public class Utilisateur:IdentityUser
    {
        public DateTime dateInscription { get; set; }
        public int participationFk { get; set; }
        public int eventFK { get; set; }
        public virtual IList<Participation> Participations { get; set; }
        public virtual IList<Evennement> Evennements { get; set; }
    }
}
