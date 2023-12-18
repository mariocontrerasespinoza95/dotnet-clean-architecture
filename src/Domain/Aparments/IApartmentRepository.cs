﻿namespace Domain.Aparments;
public interface IApartmentRepository
{
    Task<Apartment?> GetByIdAsync(ApartmentId id, CancellationToken cancellationToken = default);
}
