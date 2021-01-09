using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ServicesService
    {
        private readonly IServiceRepository _context;

        public ServicesService()
        {
            _context = new ServiceRepository();
        }

        public void CreateService(Service service)
        {
            if (service != null)
            {
                _context.Add(service);
            }
            else
            {
                throw new NullReferenceException("O serviço não pode ter um valor nulo");
            }
        }

        public Service ReadService(int id)
        {
            return _context.GetById(id);
        }

        public void UpdateService(Service service)
        {
            if (service != null)
            {
                _context.Update(service);
            }
            else
            {
                throw new NullReferenceException("O cliente não pode ser nulo");
            }
        }

        public void DeleteService(int id)
        {
            _context.Remove(id);
        }

        public DataTable ReturnTable()
        {
            return _context.ReturnTable();
        }

        public DataTable SearchTable(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return _context.SearchTable(search);
            }
            else { return null; }
        }
    }
}
