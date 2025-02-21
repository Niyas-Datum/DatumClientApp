using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class TbClientUpdate
{
    public long Id { get; set; }

    public long? ClientId { get; set; }

    public string? ClientName { get; set; }

    public DateTime? Date { get; set; }

    public string? Updates { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }
}
