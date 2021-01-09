using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;
using System;
using System.Data;

namespace Business.Services
{
    public class KeyService
    {
        private readonly IKeyRepository _context;
        
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

        public void UpdateImage(int id)
        {
            _context.UpdateImage(id);
        }

        public int GetTotalKeyNumbers()
        {
            return _context.KeyNumbers();
        }

        public DataTable SearchTable(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return _context.SearchTable(search);
            }
            else { return null; }
        }

        public DataTable SearchFilter(string manufactor, string type, string service)
        {
            return _context.SearchFilter(manufactor, type, service);
        }

        public void AddQuantity(Key key)
        {
            key.AddQuantity();
            _context.AddQuantity(key);
        }

        public void SubtractQuantity(Key key)
        {
            key.AddQuantity();
            _context.SubtractQuantity(key);
        }

        public bool IsDuplicated(Key key)
        {
            return _context.IsDuplicated(key);
        }
    }
}
