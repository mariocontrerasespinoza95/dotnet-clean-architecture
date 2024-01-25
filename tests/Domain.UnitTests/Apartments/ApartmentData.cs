﻿using Domain.Apartments;
using Domain.Shared;

namespace Domain.UnitTests.Apartments;

internal static class ApartmentData
{
    public static Apartment Create(Money price, Money? cleaningFee = null) => new(
        Guid.NewGuid(),
        new Name("Test apartment"),
        new Description("Test description"),
        new Address("Country", "State", "ZipCode", "City", "Street"),
        price,
        cleaningFee ?? Money.Zero(),
        []);
}
