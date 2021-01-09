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
    public class ClientService
    {
        private readonly IClientRepository _context;

        public ClientService()
        { 
            _context = new ClientRepository(); 
        }

        public void CreateClient(Client client)
        {
            if (client != null)
            {
                _context.Add(client);
            }
            else
            {
                throw new NullReferenceException("O cliente não pode ter um valor nulo");
            }
        }

        public Client ReadClient(int id)
        {
            return _context.GetById(id);
        }

        public void UpdateClient(Client client)
        {
            if (client != null)
            {
                _context.Update(client);
            }
            else
            {
                throw new NullReferenceException("O cliente não pode ser nulo");
            }
        }

        public void DeleteClient(int id)
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
