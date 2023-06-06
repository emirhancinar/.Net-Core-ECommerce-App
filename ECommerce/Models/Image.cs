using System;
using System.Collections.Generic;

namespace ECommerce.Models;

public partial class Image
{
    public int Id { get; set; }

    public string? ImageUrl { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
