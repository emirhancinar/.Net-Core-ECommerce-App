using System;
using System.Collections.Generic;

namespace ECommerce.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Marka { get; set; }

    public string? Baslik { get; set; }

    public string? Aciklama { get; set; }

    public string? Kategori { get; set; }

    public string? Fiyat { get; set; }

    public string? Satıcı { get; set; }

    public string? Degerlendirme { get; set; }

    public string? BegeniSayisi { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Smartphonedetail> Smartphonedetails { get; set; } = new List<Smartphonedetail>();
}
