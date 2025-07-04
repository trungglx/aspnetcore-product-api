using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_mail
{
    public uint id { get; set; }

    public uint? char_id { get; set; }

    public string? from_id { get; set; }

    public string? subject { get; set; }

    public string? message { get; set; }

    public byte? direction { get; set; }

    public byte? action { get; set; }

    public string? photo { get; set; }

    public uint? window_guid { get; set; }

    public long? date { get; set; }

    public byte? opened { get; set; }
}
