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
    public class KasaHareketMap:EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasMaxLength(20).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasMaxLength(20).HasColumnName("Hareket");
            this.Property(p => p.KasaKodu).HasMaxLength(20).HasColumnName("KasaKodu");
            this.Property(p => p.KasaAdi).HasMaxLength(50).HasColumnName("KasaAdi");
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(20).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(50).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.CariKodu).HasMaxLength(20).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasMaxLength(50).HasColumnName("CariAdi");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Tutar).HasPrecision(12,2).HasColumnName("Tutar");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");
            this.ToTable("KasaHareketleri");
        }
    }
}
