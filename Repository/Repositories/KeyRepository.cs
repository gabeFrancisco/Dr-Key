using Domain.Entities;
using Repository.Contracts;
using Repository.DataAcess;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System;

namespace Repository.Repositories
{
    public class KeyRepository : IBaseRepository<Key>, IKeyRepository
    {
        private readonly KeyData _db = new KeyData();
        private List<Key> _keys;
        public KeyRepository() { }
        public void Add(Key entity)
        {
            _db.CreateKey(entity);
        }

        public List<Key> GetAll()
        {
            throw new NotImplementedException();
        }

        public Key GetById(int id)
        {

            return _db.ReadKey(id);
        }

        public void Remove(int id)
        {
            _db.DeleteKey(id);
        }

        public void Update(Key entity)
        {
            _db.UpdateKey(entity);
        }

        public DataTable ReturnTable()
        {
            return _db.ReturnTable();
        }

        public bool IsDuplicated(Key key)
        {
            return _db.IsDuplicated(key);
        }

        public int KeyNumbers()
        {
            return _db.KeyNumbers();
        }

        public DataTable SearchTable(string search)
        {
            return _db.SearchTable(search);
        }

        public DataTable SearchFilter(string manufactor, string type, string service)
        {
            return _db.Search(manufactor, type, service);

        }

        public void AddQuantity(Key key)
        {
            _db.AddQuantity(key);
        }

        public void SubtractQuantity(Key key)
        {
            _db.SubtractQuantity(key);
        }
        public void UpdateImage(int id)
        {
            _db.UpdateImage(id);
        }
    }
}
