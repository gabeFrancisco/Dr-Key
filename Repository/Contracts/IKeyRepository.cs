using Domain.Entities;
using System.Collections.Generic;
using System.Data;

namespace Repository.Contracts
{
    public interface IKeyRepository : IBaseRepository<Key>
    {
        DataTable ReturnTable();
        bool IsDuplicated(Key key);
        int KeyNumbers();
        DataTable SearchTable(string search);
        DataTable SearchFilter(string manufactor, string type, string service);
        void AddQuantity(Key key);
        void SubtractQuantity(Key key);
        void UpdateImage(int id);
    }
}
