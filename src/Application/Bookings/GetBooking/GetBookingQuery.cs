﻿using Application.Abstractions.Caching;

namespace Application.Bookings.GetBooking;
public sealed record GetBookingQuery(Guid BookingId) : ICachedQuery<BookingResponse>
{
    public string CacheKey => $"bookings-{BookingId}";

    public TimeSpan? Expiration => null;
}
