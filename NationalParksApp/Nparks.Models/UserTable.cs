using System;
using System.Collections.Generic;

namespace Nparks.Models;

public class UserTable
{   
    public int user_id { get; set; }

    public string? user_name { get; set; }

    public string? user_password { get; set; }

    public string? admin_privilege { get; set; }
}
