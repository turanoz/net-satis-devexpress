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
    public class DepoMap:EntityTypeConfiguration<Depo>
    {
        public DepoMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.DepoKodu).HasMaxLength(20).HasColumnName("DepoKodu");
            this.Property(p => p.DepoAdi).HasMaxLength(30).HasColumnName("DepoAdi");
            this.Property(p => p.YetkiliKodu).HasMaxLength(20).HasColumnName("YetkiliKodu");
            this.Property(p => p.YetkiliAdi).HasMaxLength(50).HasColumnName("YetkiliAdi");
            this.Property(p => p.Il).HasMaxLength(30).HasColumnName("Il");
            this.Property(p => p.Ilce).HasMaxLength(30).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasMaxLength(30).HasColumnName("Semt");
            this.Property(p => p.Adres).HasMaxLength(200).HasColumnName("Adres");
            this.Property(p => p.Telefon).HasMaxLength(20).HasColumnName("Telefon");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");
            this.ToTable("Depolar");
        }
    }
}
