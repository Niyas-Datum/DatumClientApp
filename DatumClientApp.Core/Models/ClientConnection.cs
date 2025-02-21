using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class ClientConnection
{
    public int Id { get; set; }

    public string? Client { get; set; }

    public string? ConnectionString { get; set; }

    public string? Pin { get; set; }
}
