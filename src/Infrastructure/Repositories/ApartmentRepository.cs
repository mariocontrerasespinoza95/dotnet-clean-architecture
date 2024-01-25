﻿using Domain.Apartments;

namespace Infrastructure.Repositories;
internal class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
