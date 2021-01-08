using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        DataTable ReturnTable();
        DataTable SearchTable(string search);
    }
}
