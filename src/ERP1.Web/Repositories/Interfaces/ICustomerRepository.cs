using ERP1.Models;

namespace ERP1.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);

    }
}
