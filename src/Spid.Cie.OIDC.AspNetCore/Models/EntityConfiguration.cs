﻿using System.Text.Json.Serialization;

namespace Spid.Cie.OIDC.AspNetCore.Models;

internal class EntityConfiguration : FederationEntityConfiguration
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    [JsonPropertyName("trust_marks")]
    public TrustMarkDefinition[] TrustMarks { get; set; }

    [JsonPropertyName("authority_hints")]
    public string[] AuthorityHints { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}