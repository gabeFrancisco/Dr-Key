using Domain.Entities;
using System.Data;

namespace Repository.Contracts
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        DataTable ReturnTable();
        DataTable SearchTable(string search);
    }
}
