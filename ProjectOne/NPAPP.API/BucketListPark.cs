using System;
using System.Collections.Generic;

namespace NPAPP.API;

public partial class BucketListPark
{
    public int BucketId { get; set; }

    public int? UserId { get; set; }

    public int? NationalParkId { get; set; }

    public string? SpecialNotes { get; set; }

    public string? BucketListItem { get; set; }
}
