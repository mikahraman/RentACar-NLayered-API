using Business;
using DataAccess;
using Entities;

namespace Business
{

    public class BrandManager : IBrandService
    {

        private readonly IBrandRepository _brandRepository;

   
        public BrandManager(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public void Add(Brand brand)
        {
 
            if (brand.Name.Length < 2)
            {

                Console.WriteLine("Marka ismi 2 karakterden kısa olamaz.");

            }
            _brandRepository.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandRepository.Delete(brand);
        }

        public List<Brand> GetAll()
        {

            return _brandRepository.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandRepository.Get(b => b.Id == id);
        }

        public void Update(Brand brand)
        {
            _brandRepository.Update(brand);
        }
    }
}