using System;
using System.Collections.Generic;

namespace ECommerce.Models;

public partial class Smartphonedetail
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? GarantiTipi { get; set; }

    public string? DahiliHafıza { get; set; }

    public string? RamLapasitesi { get; set; }

    public string? EkranBoyutu { get; set; }

    public string? PilGücü { get; set; }

    public string? MobilBaglantiHizi { get; set; }

    public string? KameraCozunurlugu { get; set; }

    public string? AnaKameraCozunurlugu { get; set; }

    public string? Renk { get; set; }

    public string? DokunmatikEkran { get; set; }

    public string? ArkaKameraSayısı { get; set; }

    public string? OnKameraSayısı { get; set; }

    public string? OnKameraCozunurlugu { get; set; }

    public string? IsletimSistemi { get; set; }

    public string? BataryaKapasitesiAraligi { get; set; }

    public string? KulaklıkGirisi { get; set; }

    public string? SarjGirisi { get; set; }

    public string? Nfc { get; set; }

    public string? SuyaTozaDayaniklilik { get; set; }

    public string? CiftHat { get; set; }

    public string? GarantiSuresi { get; set; }

    public virtual Product? Product { get; set; }
}
