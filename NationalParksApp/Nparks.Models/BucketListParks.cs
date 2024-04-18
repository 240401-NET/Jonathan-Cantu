using System;
using System.Collections.Generic;

namespace Nparks.Models;

public class BucketListParks
{   
    public int bucket_id { get; set; }

    public int? user_id { get; set; }

    public int? nationalPark_id { get; set; }

    public string? special_notes { get; set; }

    public string? bucket_list_item { get; set; }
}
