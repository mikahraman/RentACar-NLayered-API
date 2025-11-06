using Entities;

namespace DataAccess
{
    public class EfCarRepository : EfEntityRepositoryBase<Car, RentACarContext>, ICarRepository
    {
        public EfCarRepository(RentACarContext context) : base(context)
        {
        }
    }
}