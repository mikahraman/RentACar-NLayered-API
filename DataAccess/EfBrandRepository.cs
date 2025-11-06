using Entities;

namespace DataAccess
{

    public class EfBrandRepository : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandRepository
    {

        public EfBrandRepository(RentACarContext context) : base(context)
        {
        }
    }
}