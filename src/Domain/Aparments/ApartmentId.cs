﻿namespace Domain.Apartments;

public sealed record ApartmentId(Guid Value)
{
    public static ApartmentId New() => new(Guid.NewGuid());
}
