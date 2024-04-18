using System;
using System.Collections.Generic;

namespace Nparks.Models;

public class UserTable
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserPassword { get; set; }

    public string? AdminPrivilege { get; set; }
}
