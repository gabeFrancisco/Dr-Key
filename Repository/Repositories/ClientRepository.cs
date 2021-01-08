using Domain.Entities;
using Repository.Contracts;
using Repository.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClientRepository : IBaseRepository<Client>, IClientRepository
    {
        private readonly ClientData _db = new ClientData();
        public void Add(Client entity)
        {
            _db.CreateClient(entity);
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
            return _db.ReadClient(id);
        }

        public void Remove(int id)
        {
            _db.DeleteClient(id);
        }

        public DataTable ReturnTable()
        {
            return _db.ReturnTable();
        }

        public void Update(Client entity)
        {
            _db.UpdateClient(entity);
        }

        public DataTable SearchTable(string search)
        {
            return _db.SearchTable(search);
        }
    }
}
