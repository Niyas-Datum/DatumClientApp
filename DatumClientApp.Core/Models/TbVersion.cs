using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class TbVersion
{
    public long Id { get; set; }

    public long? Version { get; set; }

    public DateTime? Date { get; set; }

    public string? Updates { get; set; }
}
