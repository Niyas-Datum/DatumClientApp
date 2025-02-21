using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class LicenceKey
{
    public int Id { get; set; }

    public string LicenceKey1 { get; set; } = null!;

    public int? Status { get; set; }
}
