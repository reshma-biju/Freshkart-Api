using System;
using System.Collections.Generic;

namespace FreshKart.Api.Models;

public partial class Login
{
    public int Id { get; set; }

    public string Uname { get; set; } = null!;

    public string Pword { get; set; } = null!;
}
