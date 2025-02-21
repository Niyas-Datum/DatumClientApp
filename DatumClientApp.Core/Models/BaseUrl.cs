using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class BaseUrl
{
    public int Id { get; set; }

    public string? Pin { get; set; }

    public string? Url { get; set; }

    public string? ReportPath { get; set; }

    public string? ReturnUrl { get; set; }
}
