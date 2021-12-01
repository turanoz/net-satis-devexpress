using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class TanimMap:EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.Turu).HasMaxLength(50).HasColumnName("Turu");
            this.Property(p => p.Tanimi).HasMaxLength(30).HasColumnName("Tanimi");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");
            this.ToTable("Tanimlar");
        }
    }
}
