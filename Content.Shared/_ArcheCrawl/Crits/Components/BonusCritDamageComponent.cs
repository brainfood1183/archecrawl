﻿namespace Content.Shared._ArcheCrawl.Crits.Components;

[RegisterComponent]
public sealed partial class BonusCritDamageComponent : Component
{
    [DataField("flatModifier")]
    public float FlatModifier;

    [DataField("multiplier")]
    public float Multiplier = 1;
}
