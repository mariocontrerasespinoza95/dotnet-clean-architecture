using Domain.Aparments;

namespace Infrastructure.Repositories;
internal class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
