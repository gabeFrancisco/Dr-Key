using Domain.Entities;
using Repository.Contracts;
using Repository.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repository.Repositories
{
    public class ServiceRepository : IBaseRepository<Service>, IServiceRepository
    {
        public readonly ServiceData _db = new ServiceData();
        public void Add(Service entity)
        {
            _db.CreateService(entity);
        }

        public List<Service> GetAll()
        {
            throw new NotImplementedException();
        }

        public Service GetById(int id)
        {
            return _db.ReadService(id);
        }

        public void Remove(int id)
        {
            _db.DeleteService(id);
        }

        public DataTable ReturnTable()
        {
            return _db.ReturnTable();
        }

        public void Update(Service entity)
        {
            _db.UpdateService(entity);
        }

        public DataTable SearchTable(string search)
        {
            return _db.SearchTable(search);
        }
    }
}
