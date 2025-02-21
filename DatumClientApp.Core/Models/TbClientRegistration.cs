using System;
using System.Collections.Generic;

namespace DatumClientApp.Core.Models;

public partial class TbClientRegistration
{
    public long Id { get; set; }

    public string? ClinetName { get; set; }

    public string? Address { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? ExpDate { get; set; }

    public byte? DemoStatus { get; set; }

    public int? Limit { get; set; }

    public string? Description { get; set; }

    public string? Connection { get; set; }

    public string? MacAddress { get; set; }

    public bool? LockSystem { get; set; }

    public string? DisplayMessage { get; set; }

    public string? VatNo { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}
