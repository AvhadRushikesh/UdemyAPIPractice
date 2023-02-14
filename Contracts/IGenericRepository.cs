using Microsoft.AspNetCore.Mvc.RazorPages;
using UdemyAPIPractice.Model;

namespace UdemyAPIPractice.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);      //  Get Single Record.
        Task<List<T>> GetAllAsync();    //  Get ALl Record.
        Task<PageResult<TResult>> GetAllAsync<TResult>(QueryParameters queryParameters);    //  Implementing Pagging
        Task<T> AddAsync(T entity);     //  Add New Record.
        Task DeleteAsync(int id);       //  Delete Existing Record.
        Task UpdateAsync(T entity);     //  Update Existing Record.
        Task<bool> Exists(int id);      //  Boolean Method / Last Method from Controller.
    }
}
