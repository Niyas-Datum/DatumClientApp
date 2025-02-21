using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class UserCredential
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? Status { get; set; }

    public int? Type { get; set; }
}
