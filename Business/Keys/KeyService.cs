using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data;

namespace Business.Keys
{
    public class KeyService
    {
        private KeyRepository _context;
        
        public KeyService()
        {
            _context = new KeyRepository();
        }

        public void CreateKey(Key key)
        {
            if (key != null)
            {
                _context.Add(key);
            }
            else
            {
                throw new NullReferenceException("A chave não pode ter um valor nulo");
            }
        }

        public Key ReadKey(int id)
        {
            return _context.GetById(id);
        }

        public void UpdateKey(Key key)
        {
            if (key != null)
            {
                _context.Update(key);
            }
            else
            {
                throw new NullReferenceException("A chave não pode ser nula");
            }
        }

        public void DeleteKey(int id)
        {
            _context.Remove(id);
        }

        public DataTable ReturnTable()
        {
            return _context.ReturnTable();
        }
    }
}
