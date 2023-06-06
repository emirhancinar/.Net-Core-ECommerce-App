using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models;

public partial class EcommerceContext : DbContext
{
    public EcommerceContext()
    {
    }

    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Smartphonedetail> Smartphonedetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ecommerce;User Id=postgres;Password=12345;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("images_pkey");

            entity.ToTable("images");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("image_url");
            entity.Property(e => e.ProductId).HasColumnName("product_id");

            entity.HasOne(d => d.Product).WithMany(p => p.Images)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(4096)
                .HasColumnName("aciklama");
            entity.Property(e => e.Baslik)
                .HasMaxLength(255)
                .HasColumnName("baslik");
            entity.Property(e => e.BegeniSayisi)
                .HasMaxLength(255)
                .HasColumnName("begeni_sayisi");
            entity.Property(e => e.Degerlendirme)
                .HasMaxLength(255)
                .HasColumnName("degerlendirme");
            entity.Property(e => e.Fiyat)
                .HasMaxLength(255)
                .HasColumnName("fiyat");
            entity.Property(e => e.Kategori)
                .HasMaxLength(255)
                .HasColumnName("kategori");
            entity.Property(e => e.Marka)
                .HasMaxLength(255)
                .HasColumnName("marka");
            entity.Property(e => e.Satıcı)
                .HasMaxLength(255)
                .HasColumnName("satıcı");
        });

        modelBuilder.Entity<Smartphonedetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("smartphonedetails_pkey");

            entity.ToTable("smartphonedetails");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnaKameraCozunurlugu)
                .HasMaxLength(100)
                .HasColumnName("ana_kamera_cozunurlugu");
            entity.Property(e => e.ArkaKameraSayısı)
                .HasMaxLength(100)
                .HasColumnName("arka_kamera_sayısı");
            entity.Property(e => e.BataryaKapasitesiAraligi)
                .HasMaxLength(100)
                .HasColumnName("batarya_kapasitesi_araligi");
            entity.Property(e => e.CiftHat)
                .HasMaxLength(100)
                .HasColumnName("cift_hat");
            entity.Property(e => e.DahiliHafıza)
                .HasMaxLength(100)
                .HasColumnName("dahili_hafıza");
            entity.Property(e => e.DokunmatikEkran)
                .HasMaxLength(100)
                .HasColumnName("dokunmatik_ekran");
            entity.Property(e => e.EkranBoyutu)
                .HasMaxLength(100)
                .HasColumnName("ekran_boyutu");
            entity.Property(e => e.GarantiSuresi)
                .HasMaxLength(100)
                .HasColumnName("garanti_suresi");
            entity.Property(e => e.GarantiTipi)
                .HasMaxLength(100)
                .HasColumnName("garanti_tipi");
            entity.Property(e => e.IsletimSistemi)
                .HasMaxLength(100)
                .HasColumnName("isletim_sistemi");
            entity.Property(e => e.KameraCozunurlugu)
                .HasMaxLength(100)
                .HasColumnName("kamera_cozunurlugu");
            entity.Property(e => e.KulaklıkGirisi)
                .HasMaxLength(100)
                .HasColumnName("kulaklık_girisi");
            entity.Property(e => e.MobilBaglantiHizi)
                .HasMaxLength(100)
                .HasColumnName("mobil_baglanti_hizi");
            entity.Property(e => e.Nfc)
                .HasMaxLength(100)
                .HasColumnName("nfc");
            entity.Property(e => e.OnKameraCozunurlugu)
                .HasMaxLength(100)
                .HasColumnName("on_kamera_cozunurlugu");
            entity.Property(e => e.OnKameraSayısı)
                .HasMaxLength(100)
                .HasColumnName("on_kamera_sayısı");
            entity.Property(e => e.PilGücü)
                .HasMaxLength(100)
                .HasColumnName("pil_gücü");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.RamLapasitesi)
                .HasMaxLength(100)
                .HasColumnName("ram_lapasitesi");
            entity.Property(e => e.Renk)
                .HasMaxLength(100)
                .HasColumnName("renk");
            entity.Property(e => e.SarjGirisi)
                .HasMaxLength(100)
                .HasColumnName("sarj_girisi");
            entity.Property(e => e.SuyaTozaDayaniklilik)
                .HasMaxLength(100)
                .HasColumnName("suya_toza_dayaniklilik");

            entity.HasOne(d => d.Product).WithMany(p => p.Smartphonedetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk_products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
