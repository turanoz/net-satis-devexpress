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
    public class CariMap:EntityTypeConfiguration<Cari>
    {
        public CariMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.CariTuru).HasMaxLength(15).HasColumnName("CariTuru");
            this.Property(p => p.CariKodu).HasMaxLength(15).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasMaxLength(50).HasColumnName("CariAdi");
            this.Property(p => p.YetkiliKisi).HasMaxLength(30).HasColumnName("YetkiliKisi");
            this.Property(p => p.FaturaUnvani).HasMaxLength(50).HasColumnName("FaturaUnvani");
            this.Property(p => p.CepTelefonu).HasMaxLength(11).HasColumnName("CepTelefonu");
            this.Property(p => p.Telefon).HasMaxLength(11).HasColumnName("Telefon");
            this.Property(p => p.Fax).HasMaxLength(11).HasColumnName("Fax");
            this.Property(p => p.EMail).HasMaxLength(50).HasColumnName("EMail");
            this.Property(p => p.Web).HasMaxLength(31).HasColumnName("Web");
            this.Property(p => p.Il).HasMaxLength(20).HasColumnName("Il");
            this.Property(p => p.Ilce).HasMaxLength(20).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasMaxLength(20).HasColumnName("Semt");
            this.Property(p => p.Adres).HasMaxLength(150).HasColumnName("Adres");
            this.Property(p => p.CariGrubu).HasMaxLength(30).HasColumnName("CariGrubu");
            this.Property(p => p.CariAltGrubu).HasMaxLength(30).HasColumnName("CariAltGrubu");
            this.Property(p => p.OzelKod1).HasMaxLength(30).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasMaxLength(30).HasColumnName("OzelKod2");
            this.Property(p => p.OzelKod3).HasMaxLength(30).HasColumnName("OzelKod3");
            this.Property(p => p.OzelKod4).HasMaxLength(30).HasColumnName("OzelKod4");
            this.Property(p => p.VergiDairesi).HasMaxLength(20).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasMaxLength(20).HasColumnName("VergiNo");
            this.Property(p => p.IskontoOrani).HasPrecision(5,2).HasColumnName("IskontoOrani");
            this.Property(p => p.RiskLimiti).HasPrecision(12,2).HasColumnName("RiskLimiti");
            this.Property(p => p.AlisOzelFiyati).HasMaxLength(30).HasColumnName("AlisOzelFiyati");
            this.Property(p => p.SatisOzelFiyati).HasMaxLength(30).HasColumnName("SatisOzelFiyati");
            this.Property(p => p.Aciklama).HasMaxLength(200).HasColumnName("Aciklama");
            this.ToTable("Cariler");


        }
    }
}
