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
    public class OdemeTuruMap:EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(30).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(50).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");
            this.ToTable("OdemeTurleri");
        }
    }
}
