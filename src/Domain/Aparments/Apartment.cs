﻿using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Apartments;
public sealed class Apartment : Entity<ApartmentId>
{
    public Apartment(
        ApartmentId id,
        Name name,
        Description description,
        Address address,
        Money price,
        Money cleaningFee,
        DateTime? lastBookedOnUtc,
        List<Amenity> amenities)
        : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        LastBookedOnUtc = lastBookedOnUtc;
        Amenities = amenities;
    }

    private Apartment()
    {

    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Address Address { get; private set; }
    public Money Price { get; private set; }
    public Money CleaningFee { get; private set; }
    public DateTime? LastBookedOnUtc { get; internal set; }
    public List<Amenity> Amenities { get; private set; } = new();
}
