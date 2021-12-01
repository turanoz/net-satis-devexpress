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
    public class KasaMap:EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.KasaKodu).HasMaxLength(20).HasColumnName("KasaKodu");
            this.Property(p => p.KasaAdi).HasMaxLength(30).HasColumnName("KasaAdi");
            this.Property(p => p.YetkiliKodu).HasMaxLength(15).HasColumnName("YetkiliKodu");
            this.Property(p => p.YetkiliAdi).HasMaxLength(30).HasColumnName("YetkiliAdi");
            this.Property(p => p.Aciklama).HasMaxLength(200 ).HasColumnName("Aciklama");
            this.ToTable("Kasalar");
        }
    }
}
