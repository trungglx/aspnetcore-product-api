using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class account
{
    public uint guid { get; set; }

    public byte? blocked { get; set; }

    public string? security_code { get; set; }

    public long? golden_channel { get; set; }

    public byte? facebook_status { get; set; }

    public byte? secured { get; set; }

    public string? account1 { get; set; }

    public string? password { get; set; }

    public string? email { get; set; }

    public long? register { get; set; }

    public DateTime? updated_at { get; set; }

    public DateTime? created_at { get; set; }

    public DateTime? email_verified_at { get; set; }

    public int? web_admin { get; set; }

    public string deletion_token { get; set; } = null!;

    public string passlost_token { get; set; } = null!;

    public string email_token { get; set; } = null!;

    public string new_email { get; set; } = null!;

    public string social_id { get; set; } = null!;

    public int? activated { get; set; }

    public int? DiscordDiscriminator { get; set; }

    public string? DiscordAvatar { get; set; }

    public int? DiscordId { get; set; }

    public string? DiscordUsername { get; set; }

    public string? DiscordEmail { get; set; }

    public int? DiscordLogin { get; set; }

    public string? token { get; set; }

    public DateTime? create_date { get; set; }

    public string? ip { get; set; }

    public string? registration_token { get; set; }

    public string? lock_token { get; set; }

    public DateTime? ban_time { get; set; }
}
