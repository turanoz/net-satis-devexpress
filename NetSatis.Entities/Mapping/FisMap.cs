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
    public class FisMap:EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasMaxLength(20).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasMaxLength(20).HasColumnName("FisTuru");
            this.Property(p => p.CariTuru).HasMaxLength(20).HasColumnName("CariTuru");
            this.Property(p => p.CariKodu).HasMaxLength(15).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasMaxLength(50).HasColumnName("CariAdi");
            this.Property(p => p.BelgeNo).HasMaxLength(15).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.PlasiyerKodu).HasMaxLength(15).HasColumnName("PlasiyerKodu");
            this.Property(p => p.PlasiyetAdi).HasMaxLength(30).HasColumnName("PlasiyetAdi");
            this.Property(p => p.IskontoOrani).HasPrecision(5,2).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutar).HasPrecision(12,2).HasColumnName("IskontoTutar");
            this.Property(p => p.ToplamTutar).HasPrecision(12,2).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");
            
            this.ToTable("Fisler");
        }
    }
}
