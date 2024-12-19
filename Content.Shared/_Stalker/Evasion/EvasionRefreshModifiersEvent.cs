using Content.Shared.FixedPoint;

namespace Content.Shared._Stalker.Evasion;

[ByRefEvent]
public record struct EvasionRefreshModifiersEvent(
    Entity<EvasionComponent> Entity,
    FixedPoint2 Evasion,
    FixedPoint2 EvasionFriendly
);
