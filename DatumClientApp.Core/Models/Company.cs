using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string? ServerName { get; set; }

    public string ServerIp { get; set; } = null!;

    public bool IsRemote { get; set; }

    public bool Active { get; set; }

    public bool? IsDefault { get; set; }
}
