using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class Licence
{
    public int Id { get; set; }

    public string LicenceKey { get; set; } = null!;

    public string? ActivatedKey { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ActivatedOn { get; set; }

    public string? ComputerName { get; set; }

    public int? Status { get; set; }
}
