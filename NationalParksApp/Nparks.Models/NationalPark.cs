using System;
using System.Collections.Generic;

namespace Nparks.Models;

public class NationalPark
{
    public int NationalParkId { get; set; }

    public string? NationalParkName { get; set; }

    public string? NationalParkState { get; set; }

    public string? NationalParkSummary { get; set; }
}