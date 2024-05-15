using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    internal class TacheConfig : IEntityTypeConfiguration<Tache>
    {

        public void Configure(EntityTypeBuilder<Tache> builder)
        {
            builder.HasOne(t => t.Member).WithMany(p => p.Taches).HasForeignKey(t => t.MemberKey);
            builder.HasOne(t => t.Sprint).WithMany(p => p.Taches).HasForeignKey(t => t.SprintKey);


            builder.HasKey(r => new
            {
                r.MemberKey,
                r.SprintKey,
                r.Titre


            });

        }
    }
}
