using EventManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Infrastructure.Configurations
{
    public class UtilisateursConfiguration : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.HasMany(u => u.Participations)
                .WithOne(p => p.Particpant)
                .HasForeignKey(p => p.participantFK)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.Evennements)
                .WithOne(e => e.Organisateur)
                .HasForeignKey(e => e.organisateurFK)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
