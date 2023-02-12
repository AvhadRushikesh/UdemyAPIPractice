using UdemyAPIPractice.Data;

namespace UdemyAPIPractice.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
